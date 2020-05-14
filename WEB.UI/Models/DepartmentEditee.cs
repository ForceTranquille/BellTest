using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.UI.Models
{
    public class DepartmentEditee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmentEditee()
        {
            this.EmployeeEditee = new HashSet<EmployeeEditee>();
        }

        public int DEPNO { get; set; }
        [Display(Name = "Nom du département")]
        public string DNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeEditee> EmployeeEditee { get; set; }
    }
}