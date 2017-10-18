using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public class Treatment:BaseModel
    {
        string _bno;

        public  string BNO
        {
            get { return _bno; }
            set { _bno = value; OnPropertyChange(); }
        }

        string _notes;

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; OnPropertyChange(); }
        }
    }
}
