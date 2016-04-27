using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class SuperWorker : IWorkable, IEatable
    {
        public void eat()
        {
            //--- Healthy food... lovely 
        }

        public void work()
        {
            //-- I love my work
        }
    }
}
