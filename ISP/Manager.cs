using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Manager
    {
        IWorker worker;
            void setWorker(IWorker _worker)
        {
            worker = _worker;
        }
        void manage()
        {
            this.worker.work();
        }
    }
}
