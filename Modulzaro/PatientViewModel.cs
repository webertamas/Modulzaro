using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public class PatientViewModel:BaseModel
    {
        public ObservableCollection<Patient> PatientList { get; set; }
        public Patient SelectPatient { get; set; }

        public PatientViewModel()
        {
            PatientList = new ObservableCollection<Patient>
            {
                new Patient{Name="Kiss János", BirthPlace="Budapest",
                    BirthDate =DateTime.Parse("3/19/1974"), SSN=089283697}
            };
        }
    }
}
