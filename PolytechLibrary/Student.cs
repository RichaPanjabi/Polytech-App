using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolytechLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { level5, level7, level8, level9 }
        public GradeLevels GradeLevel {get; set;}

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
