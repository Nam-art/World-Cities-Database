using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorldCities.Data.Model
{
    [Table("Countries")]
    public class Country
    {
        #region Constructor
        public Country()
        {

        }
        #endregion
        #region Properties
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("iso2")]
        public string ISO2 { get; set; }
        [JsonPropertyName("iso3")]
        public string ISO3 { get; set; }
        #endregion
        #region Navigation Properties
        [JsonIgnore]
        public virtual List<City> Cities { get; set; }
        #endregion
        [NotMapped]
        public int TotCities
        {
            get {
                return (Cities != null) ? Cities.Count : _TotCities;
            }
            set {
                _TotCities = value;
            }
        }
        private int _TotCities = 0;
    }
}
