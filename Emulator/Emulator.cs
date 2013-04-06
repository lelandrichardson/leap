using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace Emulator
{
    public class EmulatorController : Controller
    {

        public new bool AddListener(Listener listener)
        {
            
            //TODO:
            return true;
        }
        public new bool RemoveListener(Listener listener)
        {
            //TODO:
            return true;
        }


        public void EmulateFromFile(string filepath)
        {
            //TODO:
        }

        public new void Dispose()
        {
            base.Dispose();
        }

    }

    //class SampleProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        var listener = new Listener();
    //        var controller = new EmulatorController();
    //        controller.AddListener(listener);


    //        controller.EmulateFromFile(@"C:\testleapfile.json");




    //        controller.RemoveListener(listener);
    //        controller.Dispose();
    //    }
    //}
}
