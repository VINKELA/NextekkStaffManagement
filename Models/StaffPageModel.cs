using System;
using System.Collections.Generic;

namespace NextekkStaffManager.Models
{
    public partial class StaffPageModel
    {
        public List <Staffs> Subordinates{ get; set; }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string MaritalStatus { get; set; }
        public int NoOfChildren { get; set; }
        public string Active { get; set; }
        public string DayEmployed { get; set; }
        public string HighestQualification { get; set; }
        public string School { get; set; }
        public string TimeOfService { get; set; }
        public string Position { get; set; }
        public string LastPromoted { get; set; }
        public string AnnualSalary { get; set; }
    }
}
