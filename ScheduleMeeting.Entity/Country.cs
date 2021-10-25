using System;
using System.ComponentModel.DataAnnotations;

namespace ScheduleMeeting.Entity
{
    public class Country
    {
        [Key]
        public int CountryId {  get; set; }
        public string RegionCode {  get; set; }
        public string CountryCode {  get; set; }
        public string CountryName {  get; set; }
            
        public string PhoneNumber {  get; set; }
    }
}
