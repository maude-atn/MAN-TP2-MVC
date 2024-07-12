using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Form
    {
        [Required]
        public string Nom {  get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Adresse { get; set; }
        [RegularExpression(@"^([\w]+)@([\w]+)\.( [\w]+)$")]
        [StringLength(5, MinimumLength = 5)]
        [Required]
        public string Cp { get; set; }
        [Required]
        public string Ville { get; set; }
        //[RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        //[Range(1, 12)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Formation { get; set; }
        [Required]
        public string Opinion { get; set; }
    }
}
