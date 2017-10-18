using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public class TreatmentViewModel:BaseModel
    {
        public ObservableCollection<Treatment> TreatmentList { get; set; }
        

        public TreatmentViewModel()
        {
            TreatmentList = new ObservableCollection<Treatment>
            {
                new Treatment{BNO="BNO E6690 - Elhízás", Notes="Fogyáshoz kér segítséget, jelenleg túlsúlyos"},
                
            };
        }
    }
}
