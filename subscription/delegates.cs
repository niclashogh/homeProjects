using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subscription
{
    //Instanciate Delegate
    public delegate void NewsHandler(string news);

    public class Delegate
    {
        /* =============================================================================================================================
                    Publicher
        ============================================================================================================================= */

        public class Pub
        {
            //Instanciate Delegate
            public NewsHandler BroadcastNews;

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

            //Broadcast method
            private void OnBroadcast()
            {
                if (BroadcastNews != null)
                    BroadcastNews(news);
            }
        }

        /* =============================================================================================================================
                    Subscriber
        ============================================================================================================================= */

        public class Sub
        {
            //Variables
            public string Name { get; }

            //Constructor
            public Sub(string name)
            {
                this.Name = name;
            }

            //Print method
            public void PrintNews(string news)
            {
                Console.WriteLine($"Subscriber '{Name}' recived the news '{news}'");
            }
        }

    }
}
