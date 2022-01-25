using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerialization
{
    [Serializable]
    public class Seriaz:BaseSer
    {
        public string userName;
        public int userAge;

        public Seriaz(){}
        public Seriaz(string userName, int userAge, string company) :base(company)
        {
            this.userAge=userAge;
            this.userName=userName;
        }
    }
}
