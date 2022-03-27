using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemLibrary.Models
{
    /// <summary>
    /// Represents one vehicle in the system.
    /// </summary>
    public class VehicleModel
    {
        /// <summary>
        /// Represents the unique indentifier for the vehicle.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents vehicle identification number.
        /// </summary>
        public string VehicleIdentificationNumber { get; set; }
        /// <summary>
        /// Represents vehicle registration plate.
        /// </summary>
        public string Plate { get; set; }
        /// <summary>
        /// Represents vehicle make.
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// Represents vehicle model.
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Represents vehicle color.
        /// </summary>
        public string Color { get; set; }

        public string Details
        {
            get
            {
                return $"{ Make } {Model} {Plate}";
            }
        }

        public VehicleModel()
        {

        }

        public VehicleModel(string vin, string plate, string make, string model, string color)
        {
            VehicleIdentificationNumber = vin;
            Plate = plate;
            Make = make;
            Model = model;
            Color = color;
        }

    }
}
