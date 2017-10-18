using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public static class Statistics
    {
        //public static int MostTreatedPatient(IEnumerable<Patient> patients)
        //{
        //    return patients.Max(x => x.)

        //}

        public static int NumberOfPatient(IEnumerable<Patient> patients)
        {
            return patients.Count();
        }
      
    }
}