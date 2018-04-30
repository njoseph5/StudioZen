using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioZen.ViewModels
{
    public class AddClassInfoViewModel
    {
		[Required(ErrorMessage = "Name is mandatory.")]
		[Display(Name="Class Name")]
		public string Name { get; set; }

		[DataType(DataType.Date)]
		[Display(Name="Start Date of the Class")]
		public DateTime StartDate { get; set; }

		[DataType(DataType.Date)]
		[Display(Name ="End Date for Class")]
		public DateTime EndDate { get; set; }

		[Range(5,15,ErrorMessage = "Please enter a number between 5 and 15")]
		
		public int MaximumSpots { get; set; }
	}
}
