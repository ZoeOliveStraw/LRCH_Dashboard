using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRCH_Database_Prototype
{
    class Patient
    {
        public int patientNo { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }
        public string patientAddress { get; set; }
        public string patientCity { get; set; }
        public string patientProvince { get; set; }
        public string patientPostalCode { get; set; }
    }
}
