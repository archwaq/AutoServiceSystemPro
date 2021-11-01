using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystemLibrary.Models
{
    /// <summary>
    /// Represents one repair in the system.
    /// </summary>
    public class RepairModel
    {
        /// <summary>
        /// Represents the unique indentifier for the repair.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents description of repair.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Represents price of repair.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Represents the date of created repair.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Represents the default constructor
        /// </summary>
        public RepairModel()
        {

        }
        /// <summary>
        /// Represents custom constructor with three parameters
        /// </summary>
        /// <param name="description"> The data information </param>
        /// <param name="price"> The data information </param>
        /// <param name="createdDate"> The data information </param>
        public RepairModel(string description, string price, string createdDate)
        {
            Description = description;

            decimal repairPriceValue = 0;
            decimal.TryParse(price, out repairPriceValue);
            Price = repairPriceValue;

            CreatedDate = Convert.ToDateTime(createdDate);

        }
        /// <summary>
        /// Represents inside function that return combined properties: Description, Price
        /// </summary>
        public string FinalResult
        {
            get
            {
                return $"{ Description } {Price}";
            }
        }
    }
}
