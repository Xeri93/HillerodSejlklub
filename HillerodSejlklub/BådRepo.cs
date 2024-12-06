using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
    public class BådRepo
    {
        private List<Båd> både;

        public BådRepo()
        {
            både = new List<Båd>();
        }

        //Create
        public void AddBåd(Båd båd)
        {
            både.Add(båd);
        }
        
        //Read

    }
}
