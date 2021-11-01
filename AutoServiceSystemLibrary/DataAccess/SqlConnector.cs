using AutoServiceSystemLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// @CreatedDate date,
// @Description nvarchar(150),
// @Price money,
// @id int = 0 output

namespace AutoServiceSystemLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "AutoServiceSystemPro";

        public void CreateClient(ClientModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@Address", model.Address);
                p.Add("@Email", model.Email);
                p.Add("@NationalCardNumber", model.NationalCardNumber);
                p.Add("@PersonalIdentificationNumber", model.PersonalIdentificationNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spClient_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (VehicleModel v in model.VehicleAcquisition)
                {
                    p = new DynamicParameters();
                    p.Add("@ClientID", model.Id);
                    p.Add("@VehicleID", v.Id);

                    connection.Execute("dbo.spAgreements_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        /// <summary>
        /// Saves a new repair to the database
        /// </summary>
        /// <param name="model">The repair information</param>
        /// <returns>The repair information, including the unique identifier</returns>
        public void CreateRepair(RepairModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@CreatedDate", model.CreatedDate);
                p.Add("@Description", model.Description);
                p.Add("@Price", model.Price);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spRepair_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void CreateService(ServiceModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveService(connection, model);

                SaveServiceRepairs(connection, model);

                SaveServiceEntries(connection, model);
            }
        }

        private void SaveService(IDbConnection connection, ServiceModel model)
        {
            var p = new DynamicParameters();
            p.Add("@Description", model.Description);

            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spService_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
        }

        private void SaveServiceRepairs(IDbConnection connection, ServiceModel model)
        {
            foreach (RepairModel r in model.CreatedRepairs)
            {
                var p = new DynamicParameters();
                p.Add("@ServiceID", model.Id);
                p.Add("@RepairID", r.Id);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spServiceRepairs_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveServiceEntries(IDbConnection connection, ServiceModel model)
        {
            foreach (ClientModel c in model.ServicedClients)
            {
                var p = new DynamicParameters();
                p.Add("@ServiceID", model.Id);
                p.Add("@ClientID", c.Id);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spServiceEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateVehicle(VehicleModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@VehicleIdentificationNumber", model.VehicleIdentificationNumber);
                p.Add("@Plate", model.Plate);
                p.Add("@Make", model.Make);
                p.Add("@Model", model.Model);
                p.Add("@Color", model.Color);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spVehicle_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public List<ClientModel> GetClient_All()
        {
            List<ClientModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClientModel>("dbo.spClient_GetAll").ToList();

                foreach (ClientModel client in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@ClientID", client.Id);

                    client.VehicleAcquisition = connection.Query<VehicleModel>("dbo.spAgreements_GetByClient", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<VehicleModel> GetVehicle_All()
        {
            List<VehicleModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<VehicleModel>("dbo.spVehicle_GetAll").ToList();
            }

            return output;
        }

        public List<ServiceModel> GetService_All()
        {
            List<ServiceModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ServiceModel>("dbo.spServices_GetAll").ToList();
                var p = new DynamicParameters();

                foreach (ServiceModel s in output)
                {
                    // Populate Repairs
                    p = new DynamicParameters();
                    p.Add("@ServiceID", s.Id);

                    s.CreatedRepairs = connection.Query<RepairModel>("dbo.spRepairs_GetByService", p, commandType: CommandType.StoredProcedure).ToList();

                    // Populate Clients
                    p = new DynamicParameters();
                    p.Add("@ServiceID", s.Id);

                    s.ServicedClients = connection.Query<ClientModel>("dbo.spClient_GetByService", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ClientModel client in s.ServicedClients)
                    {
                        p = new DynamicParameters();
                        p.Add("@ClientID", client.Id);

                        client.VehicleAcquisition = connection.Query<VehicleModel>("dbo.spAgreements_GetByClient", p, commandType: CommandType.StoredProcedure).ToList();
                    }


                }
            }

            return output;
        }
    }
}
