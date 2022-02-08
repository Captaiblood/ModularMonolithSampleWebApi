using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module.Company.Core.Entities
{
    public class CompanyDetail
    {
        [Key]
        public int Id { get; set; }
        public Guid GUID { get; set; }
        [Required]
        // The default allowed characters :
        //abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789-._@+
        [RegularExpression(@"[a-zA-Z0-9._@+-]{2,150}",
              ErrorMessage = "The {0} must be 2 to 150 valid characters which are any digit, any letter and -._@+.")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsLiquidated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
