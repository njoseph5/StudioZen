using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioZen.Models
{
    public class ClassInfoData
    {
		static private List<ClassInfo> classInfo = new List<ClassInfo>();

		public static List<ClassInfo> GetAll()
		{
			return classInfo;
		}
		public static void Add(ClassInfo newclassinfo)
		{
			classInfo.Add(newclassinfo);
		}

	}
}
