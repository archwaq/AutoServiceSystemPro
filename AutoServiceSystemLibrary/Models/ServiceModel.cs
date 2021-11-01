using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemLibrary.Models
{
    /// <summary>
    /// Represents one service in the system.
    /// </summary>
    public class ServiceModel
    {       
        /// <summary>
        /// Represents the unique indentifier for the service.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of service.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Represents output of serviced client.
        /// </summary>
        public List<ClientModel> ServicedClients { get; set; } = new List<ClientModel>();
        /// <summary>
        /// Represents output of created repairs.
        /// </summary>
        public List<RepairModel> CreatedRepairs { get; set; } = new List<RepairModel>();
    }
}
