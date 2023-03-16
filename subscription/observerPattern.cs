using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subscription
{
    public class observerPattern
    {
        /* =============================================================================================================================
                ObserverList & Observer
        ============================================================================================================================= */

        public abstract class ObserverList
        {
            //New Observer
            private List<Observer> observers = new List<Observer>();

            //Add, Remove & Notify observers
            public void Attach(Observer o)
            {
                observers.Add(o);
            }

            public void Detach(Observer o)
            {
                observers.Remove(o);
            }

            public void Notify()
            {
                foreach (Observer o in observers)
                {
                    o.Update();
                }
            }
        }

        public abstract class Observer
        {
            public abstract void Update();
        }

        /* =============================================================================================================================
                Publicher
        ============================================================================================================================= */
        
        public class PubMetaData : ObserverList
        {
            //Variables & Properties
            public string Name { get; }

            //Constructor
            public PubMetaData(string name)
            {
                this.Name = name;
            }
        }
        
        public class Pub : PubMetaData
        {
            //Variables & Properties
            private string message;

            //Constructor
            public Pub(string name) : base(name)
            {}

            //Broadcast Method
            public string Broadcast
            {
                get { return message; }
                set { message = value; Notify(); }
            }
        }

        /* =============================================================================================================================
                Subscriber
        ============================================================================================================================= */

        public class SubMetaData : Observer
        {
            //Variables & Properties
            public string Name { get; }

            //Constructor

            public SubMetaData(string name)
            {
                this.Name = name;
            }

            public override void Update()
            {}
        }

        public class Sub : SubMetaData
        {
            //Variables & Properties
            public string Message { get; set; }

            //
            private Pub content;

            //Constructor
            public Sub(Pub content, string name) : base(name)
            {
                this.content = content;
            }

            //Update
            public override void Update()
            {
                this.Message = this.content.Broadcast;
                string pubName = content.Name;
                Console.WriteLine($"Subscriber '{Name}' reviced the news '{Message}' from '{pubName}'");
            }

        }

    }
}
