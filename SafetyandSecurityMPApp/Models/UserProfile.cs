using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafetyandSecurityMPApp.Models
{
    public class UserProfile
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string CellNumber { get; set; }
        public string EmailAddress { get; set; }
        public string EemergencyNumber { get; set; }
        public string EemergencyContactName { get; set; }


    }
}
