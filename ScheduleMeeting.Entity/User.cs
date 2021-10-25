using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMeeting.Entity
{
    public class User
    {
        public int UserID {  get; set; }
        public int CompanyID {  get; set; }
        public string LoginID {  get; set; }
        public string Password {  get; set; }
        public string Name {  get; set; }
        public string Phone {  get; set; }
        public string EmailId {  get; set; }
        public string Role {  get; set; }
        public string Status {  get; set; }
            
    } 
}
