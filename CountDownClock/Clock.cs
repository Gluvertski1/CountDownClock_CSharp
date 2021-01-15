using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tester
{
    class Clock
    {
        // creating the time variables.
        private int second;

        // the delegate the subscribers must implement
        public delegate void SecondChangedHandler(object clock, TimeInfoEventArgs timeInformation);

        public event SecondChangedHandler SecondChanged;

        public void Run(int waitTime)
        {
            do
            {
                Thread.Sleep(waitTime*1000);

                System.DateTime dt = System.DateTime.Now;

                if (dt.Second != second)
                {
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Second);

                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInformation);
                    }
                }


                //update the state
                this.second = dt.Second;

            }
            while (second <= waitTime);
        }
    }
}
