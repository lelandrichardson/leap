using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace TestConsoleApp
{
    public class GestureListener : Listener
    {
        private Object thisLock = new Object();


        public override void OnFrame(Controller controller)
        {
            var frame = controller.Frame();

            if (!frame.Hands.Empty)
            {
                
            }

        }

        
        private GestureHandlerCollection handlerCollection = new GestureHandlerCollection();

        public string On(string eventName, Action<object> callback)
        {
            return handlerCollection.Register(eventName, callback);
        }

        public IEnumerable<string> On(IEnumerable<string> eventNames, Action<object> callback)
        {
            var guids = new List<string>();
            foreach (var eventName in eventNames)
            {
                guids.Add(handlerCollection.Register(eventName, callback));
            }
            return guids;
        }

        private void Off(int id)
        {
            //unbind

        }





    }

    public class GestureHandlerCollection : Dictionary<string, List<Tuple<string,Action<object>>>>
    {
        public string Register(string eventName, Action<object> handler)
        {
            var guid = Guid.NewGuid().ToString();
            if (!ContainsKey(eventName))
            {
                Add(eventName, new List<Tuple<string, Action<object>>>());
            }
            base[eventName].Add(new Tuple<string, Action<object>>(guid, handler));
            return guid;
        }

        public void CallAll(string eventName, object p)
        {
            if (!ContainsKey(eventName)) return;

            var handlers = base[eventName];
            foreach (var handler in handlers)
            {
                handler.Item2(p);
            }
        }
    }
}
