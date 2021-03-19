using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Dtos.Cities
{
    public class CityCreatedConfirmationDto
    {
        /// <summary>
        /// Unique identifier for a city
        /// </summary>
        public Guid CityId { get; set; }

        /// <summary>
        /// City name 
        /// </summary>
        public String CityName { get; set; }
    }
}
