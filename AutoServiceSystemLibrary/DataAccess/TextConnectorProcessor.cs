using AutoServiceSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<RepairModel> ConvertToRepairModels(this List<string> lines)
        {
            List<RepairModel> output = new List<RepairModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                RepairModel r = new RepairModel();
                r.Id = int.Parse(cols[0]);
                r.CreatedDate = Convert.ToDateTime(cols[1]);
                r.Description = cols[2];
                r.Price = decimal.Parse(cols[3]);
                output.Add(r);
            }

            return output;
        }

        public static List<VehicleModel> ConvertToVehicleModels(this List<string> lines)
        {
            List<VehicleModel> output = new List<VehicleModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                VehicleModel v = new VehicleModel();
                v.Id = int.Parse(cols[0]);
                v.VehicleIdentificationNumber = cols[1];
                v.Plate = cols[2];
                v.Make = cols[3];
                v.Model = cols[4];
                v.Color = cols[5];
                output.Add(v);
            }

            return output;
        }

        public static List<ClientModel> ConvertToClientModels(this List<string> lines)
        {
            List<ClientModel> output = new List<ClientModel>();
            List<VehicleModel> vehicles = GlobalConfig.VehiclesFile.FullFilePath().LoadFile().ConvertToVehicleModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ClientModel c = new ClientModel();
                c.Id = int.Parse(cols[0]);
                c.FirstName = cols[1];
                c.LastName = cols[2];
                c.CellphoneNumber = cols[3];
                c.Address = cols[4];
                c.Email = cols[5];
                c.NationalCardNumber = cols[6];
                c.PersonalIdentificationNumber = cols[7];

                string[] vehicleIds = cols[8].Split('|');

                foreach (string id in vehicleIds)
                {
                    c.VehicleAcquisition.Add(vehicles.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(c);
            }

            return output;
        }

        public static List<ServiceModel> ConvertToServiceModels(this List<string> lines)
        {
            // id = 0
            // Description = 1
            // ServicedClients = 2
            // CreatedRepairs = 3
            List<ServiceModel> output = new List<ServiceModel>();
            List<ClientModel> clients = GlobalConfig.ClientsFile.FullFilePath().LoadFile().ConvertToClientModels();
            List<RepairModel> repairs = GlobalConfig.RepairsFile.FullFilePath().LoadFile().ConvertToRepairModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ServiceModel s = new ServiceModel();
                s.Id = int.Parse(cols[0]);
                s.Description = cols[1];

                string[] clientIds = cols[2].Split('|');

                foreach (string id in clientIds)
                {
                    s.ServicedClients.Add(clients.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[3].Length > 0)
                {
                    string[] repairIds = cols[3].Split('|');

                    foreach (string id in repairIds)
                    {
                        s.CreatedRepairs.Add(repairs.Where(x => x.Id == int.Parse(id)).First());
                    }
                }

                output.Add(s);
            }

            return output;
        }

        public static void SaveToRepairFile(this List<RepairModel> models)
        {
            List<string> lines = new List<string>();

            foreach (RepairModel r in models)
            {
                lines.Add($"{ r.Id },{ r.CreatedDate.ToShortDateString() },{ r.Description },{ r.Price }");
            }

            File.WriteAllLines(GlobalConfig.RepairsFile.FullFilePath(), lines);
        }

        public static void SaveToVehicleFile(this List<VehicleModel> models)
        {
            List<string> lines = new List<string>();

            foreach (VehicleModel v in models)
            {
                lines.Add($"{ v.Id },{ v.VehicleIdentificationNumber },{ v.Plate },{ v.Make },{ v.Model },{ v.Color }");
            }

            File.WriteAllLines(GlobalConfig.VehiclesFile.FullFilePath(), lines);
        }

        public static void SaveToClientFile(this List<ClientModel> models)
        {
            List<string> lines = new List<string>();

            foreach (ClientModel c in models)
            {
                lines.Add($"{ c.Id },{ c.FirstName },{ c.LastName },{ c.CellphoneNumber },{ c.Address },{ c.Email },{ c.NationalCardNumber },{ c.PersonalIdentificationNumber },{ ConvertVehiclesListToString(c.VehicleAcquisition) }");
            }

            File.WriteAllLines(GlobalConfig.ClientsFile.FullFilePath(), lines);
        }

        public static void SaveToServiceFile(this List<ServiceModel> models)
        {
            List<string> lines = new List<string>();

            foreach (ServiceModel s in models)
            {
                lines.Add($"{ s.Id },{ s.Description },{ ConvertServicedClientToString(s.ServicedClients) },{ ConvertCreatedRepairToString(s.CreatedRepairs) }");
            }

            File.WriteAllLines(GlobalConfig.ServicesFile.FullFilePath(), lines);
        }

        private static string ConvertCreatedRepairToString(List<RepairModel> createdRepair)
        {
            string output = "";

            if (createdRepair.Count == 0)
            {
                return "";
            }

            foreach (RepairModel r in createdRepair)
            {
                output += $"{ r.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertServicedClientToString(List<ClientModel> servicedClient)
        {
            string output = "";

            if (servicedClient.Count == 0)
            {
                return "";
            }

            foreach (ClientModel c in servicedClient)
            {
                output += $"{ c.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertVehiclesListToString(List<VehicleModel> vehicle)
        {
            string output = "";

            if (vehicle.Count == 0)
            {
                return "";
            }

            foreach (VehicleModel v in vehicle)
            {
                output += $"{ v.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
