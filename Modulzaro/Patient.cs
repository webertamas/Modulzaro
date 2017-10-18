using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public class Patient:BaseModel
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChange(); }
        }

        string _birthPlace;

        public string BirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; OnPropertyChange(); }
        }

        DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; OnPropertyChange(); }
        }

        int _ssn;

        public int SSN
        {
            get { return _ssn; }
            set { _ssn = value; OnPropertyChange(); }
        }

        public ObservableCollection<Treatment> TreatmentList { get; set; } 

    }
}
