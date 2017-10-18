using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public class PatientFormViewModel:BaseModel
    {
        public Patient Patient { get; set; }
        public bool IsNew { get; set; }

        Patient patient;

        public PatientFormViewModel(Patient patient)
        {
            this.Patient = patient;
            if (IsNew)
            {

            }
        }

        public void Save()
        {
            if (IsNew)
            {
                patient = new Patient
                {
                    Name = Patient.Name,
                    BirthDate = Patient.BirthDate,
                    BirthPlace = Patient.BirthPlace,
                    SSN = Patient.SSN
                };
            }
        }
    }
}
