using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subscription
{
    public class Events
    {
        /* =============================================================================================================================
                Publicher
        ============================================================================================================================= */
        
        public class Pub
        {
            //Using Event
            public event NewsHandler BroadcastNews;

            //Variables & Properties
            public string Name { get; }
            private string news;

            public string News
            {
                get { return news; }
                set
                {
                    if (news != value)
                    {
                        news = value;
                        OnBroadcast();
                    }
                }
            }

            //Constructor
            public Pub(string name)
            {
                this.Name = name;
            }

            //Broadcast Method
            private void OnBroadcast()
            {
                if (BroadcastNews != null)
                    BroadcastNews(news);
            }
        }

        /* =============================================================================================================================
                Publicher
        ============================================================================================================================= */

        public class Sub
        {
            //Variables & Properties
            public string Name { get; }

            //Constructor
            public Sub(string name)
            {
                this.Name = name;
            }

            //Print Method
            public void PrintNews(string news)
            {
                Console.WriteLine($"Subscriber '{Name}' recived the news '{news}'");
            }
        }
    }
}
