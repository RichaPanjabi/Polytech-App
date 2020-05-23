using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolytechLibrary
{
    public class Polytech
    {
        private string Pname;
        private string Paddress;
        private string Pcity;
        private string Pregion;
        private string Ppostcode;
        private string PphoneNumber;
        private string PtwitterAddress;

        public Polytech() { }

        public Polytech (string name, string address, string city, string region, string postcode, string phoneNumber, string twitterAddress)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postcode = postcode;
            this.phoneNumber = phoneNumber;
            this.twitterAddress = twitterAddress;   
        }

        public string name { get => Pname; set => Pname = value; }
        public string address { get => Paddress; set => Paddress = value; }
        public string city { get => Pcity; set => Pcity = value; }
        public string region { get => Pregion; set => Pregion = value; }
        public string postcode{ get => Ppostcode; set => Ppostcode = value; }
        public string phoneNumber { get => PphoneNumber; set => PphoneNumber = value; }

        public string twitterAddress
        {

            get{
                return this.PtwitterAddress;
            }
            set{
                if (!PtwitterAddress.StartsWith("@"))
                {
                    throw new Exception("The twitter address must begin with @");
                }
                else
                {
                    PtwitterAddress = value;
                }
            }
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Pname);
            sb.AppendLine(Paddress);
            sb.AppendLine(Pcity);
            sb.AppendLine(Pregion);
            sb.AppendLine(Ppostcode);
            sb.AppendLine(PphoneNumber);
            sb.AppendLine(PtwitterAddress);

            return sb.ToString();

        }



    }
}
