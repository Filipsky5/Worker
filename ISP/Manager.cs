using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Manager : Worker
    {
   
        void manage()
        {
            this.work();
        }
    }
}
