using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Model
{
    [Table("Cities")]
    public class City
    {
        #region Constructor
        public City()
        {

        }
        #endregion
        #region Properties
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name_ASCII { get; set; }
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lat { get; set; }
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lon { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        #endregion
        #region Naviagation Properties
        public virtual Country Country { get; set; }
        #endregion
    }
}
