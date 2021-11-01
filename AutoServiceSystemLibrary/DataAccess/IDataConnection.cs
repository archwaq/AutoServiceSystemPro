using AutoServiceSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateRepair(RepairModel model);

        void CreateVehicle(VehicleModel model);

        void CreateClient(ClientModel model);

        void CreateService(ServiceModel model);

        List<ClientModel> GetClient_All();

        List<VehicleModel> GetVehicle_All();

        List<ServiceModel> GetService_All();
    }
}
