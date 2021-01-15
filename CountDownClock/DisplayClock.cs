using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class DisplayClock
    {
        // given a clock, subscribe to its SecondChangedHandler event
        // HW 17-1 method
        //public void Subscribe(Clock theClock)
        //{
        //    theClock.SecondChanged += TimeHasChanged;

        //}

        //public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        //{
        //    //Console.WriteLine("Current Time: {0}", ti.second.ToString()); 
        //}

        // Anonymous method style
        //----------------------------------
        //public void Subscribe(Clock clock)
        //{
        //    clock.SecondChanged += delegate(object theClock, TimeInfoEventArgs ti)
        //    {
        //        Console.WriteLine("Current Time: {0}", ti.second.ToString());
        //    };
        //}
        ////----------------------------------


        // HW 17-4 Style Lambda Expression
        //-----------------------------------
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += 
            (aclock, ti) => 
            {
             Console.WriteLine("Current Time: {0}", ti.second.ToString()); 
            };
        }
        //----------------------------------
    }
}
