using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolytechLibrary
{
    public class Teacher : Person
    {
        string subject;

        public string Subject { get => subject; set => subject = value; }

        public override float ComputeGradeAverage()
        {
            //FIX LATER
            return 0.0f;
        }

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
