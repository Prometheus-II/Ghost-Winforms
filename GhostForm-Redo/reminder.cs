using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostForm_Redo
{
    public class reminder
    {
        DateTime date { get; set; }
        bool LongTerm;

        public reminder(DateTime d, bool term)
        {
            date = d;
            LongTerm = term;
        }

        public bool IsTime()
        {
            if(LongTerm)
            {
                return date.Date <= DateTime.Today;
            }
            else
            {
                return date.CompareTo(DateTime.Now) > 0;
            }
        }
    }
}
