//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf_Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.AttendanceMaster = new HashSet<AttendanceMaster>();
        }
    
        public int Person_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role_ID { get; set; }
    
        public virtual AttendanceDetail AttendanceDetail { get; set; }
        public virtual ICollection<AttendanceMaster> AttendanceMaster { get; set; }
        public virtual Role Role { get; set; }
    }
}
