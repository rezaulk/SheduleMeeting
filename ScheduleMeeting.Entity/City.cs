using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMeeting.Entity
{
    class City
    {
        [Key]
        public int Id {  get; set; }       
        public string CountryCode {  get; set; }
        public string CityCode {  get; set; }
        
        public string CityName {  get; set; }
    }

 
}
