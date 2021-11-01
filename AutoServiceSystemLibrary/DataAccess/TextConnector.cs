using AutoServiceSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceSystemLibrary.DataAccess.TextHelpers;

namespace AutoServiceSystemLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreateClient(ClientModel model)
        {
            List<ClientModel> clients = GlobalConfig.ClientsFile.FullFilePath().LoadFile().ConvertToClientModels();

            // Find the max ID
            int currentId = 1;

            if (clients.Count > 0)
            {
                currentId = clients.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            clients.Add(model);

            clients.SaveToClientFile();
        }

        /// <summary>
        /// Saves a new repair to the text file
        /// </summary>
        /// <param name="model">The repair information</param>
        /// <returns>The repair information, including the unique identifier</returns>
        public void CreateRepair(RepairModel model)
        {
            // Load the text file and convert the text to List<RepairModel>
            List<RepairModel> repairs = GlobalConfig.RepairsFile.FullFilePath().LoadFile().ConvertToRepairModels();

            // Find the max ID
            int currentId = 1;

            if (repairs.Count > 0)
            {
                currentId = repairs.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            repairs.Add(model);

            // Convert the Repairs to list<string>
            // Save the list<string> to the text file
            repairs.SaveToRepairFile();
        }

        public void CreateService(ServiceModel model)
        {
            List<ServiceModel> services = GlobalConfig.ServicesFile.FullFilePath().LoadFile().ConvertToServiceModels();

            int currentId = 1;

            if (services.Count > 0)
            {
                currentId = services.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            services.Add(model);

            services.SaveToServiceFile();
        }

        public void CreateVehicle(VehicleModel model)
        {
            List<VehicleModel> vehicles = GlobalConfig.VehiclesFile.FullFilePath().LoadFile().ConvertToVehicleModels();

            int currentId = 1;

            if (vehicles.Count > 0)
            {
                currentId = vehicles.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            vehicles.Add(model);

            vehicles.SaveToVehicleFile();
        }

        public List<ClientModel> GetClient_All()
        {
            return GlobalConfig.ClientsFile.FullFilePath().LoadFile().ConvertToClientModels();
        }

        public List<ServiceModel> GetService_All()
        {
            return GlobalConfig.ServicesFile.FullFilePath().LoadFile().ConvertToServiceModels();
        }

        public List<VehicleModel> GetVehicle_All()
        {
            return GlobalConfig.VehiclesFile.FullFilePath().LoadFile().ConvertToVehicleModels();
        }
    }
}
