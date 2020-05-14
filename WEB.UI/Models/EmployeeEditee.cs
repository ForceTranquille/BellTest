using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.UI.Models
{
    public class EmployeeEditee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeEditee()
        {
            this.TicketEditee = new HashSet<TicketEditee>();
        }
        [Display(Name = "Demandé par")]
        [Required]
        public int EMPNO { get; set; }
        [Display(Name = "Nom de l'employee")]
        [Required]
        public string ENAME { get; set; }
        [Display(Name = "Nom du département")]
        [Required]
        public int DEPNO { get; set; }

        public virtual DepartmentEditee DepartmentEditee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketEditee> TicketEditee { get; set; }
    }
}