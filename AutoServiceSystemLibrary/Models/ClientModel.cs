using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemLibrary.Models
{
    /// <summary>
    /// Represents one client in the system.
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// Represents the unique indentifier for the client.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents client first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents client last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents client cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
        /// <summary>
        /// Represents client address.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Represents client email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Represents client national indentification number.
        /// </summary>
        public string NationalCardNumber { get; set; }
        /// <summary>
        /// Represents client personal identification number.
        /// </summary>
        public string PersonalIdentificationNumber { get; set; }
        /// <summary>
        /// Represents list of vehicles owned by the client. 
        /// </summary>
        public List<VehicleModel> VehicleAcquisition { get; set; } = new List<VehicleModel>();

        public string Identity
        {
            get
            {
                return $"{ FirstName } {LastName} {CellphoneNumber}";
            }
        }
    }
}
