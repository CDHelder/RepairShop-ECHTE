using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Data.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name="Repair status")]
        public Status StatusRepair { get; set; }

        [Display(Name = "Repair Employee")]
        public Employee RepairEmployee { get; set; }

        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }

        [Required]
        [Display(Name="Begin date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }
        
        [Required]
        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Parts")] // ik denk iets van datatype toevoegen zodat het een dropdownbox wordt?
        public Parts RepairParts { get; set; }

        [Display(Name = "PartType")] // ik denk iets van datatype toevoegen zodat het een dropdownbox wordt?
        public PartType PartType { get; set; } // part id, 

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
