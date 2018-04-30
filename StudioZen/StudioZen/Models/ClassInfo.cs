using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioZen.Models
{
    public class ClassInfo
    {
		public int ClassInfoId { get; set; }
		public string Name  { get; set; }
		//time slot for later like 8.30 am
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		//boolean array for days of the week like [t,f,t,f,f,f,t]
		public int MaximumSpots{ get; set; }
		private static int nextId = 1;

		public ClassInfo()
		{
			ClassInfoId = nextId;
			nextId++;
		}
	}
}
