using System.Security.Cryptography.X509Certificates;

namespace subscription
{
    public class Program
    {
        static void Main(string[] args)
        {
            Delegates();
            Events();
            ObserverPattern();
        }

        /* =============================================================================================================================
                Delegates
        ============================================================================================================================= */

        static void Delegates()
        {
            //New Publicher
            Delegate.Pub p1 = new Delegate.Pub("Tandlægen");

            //New Subscribers
            Delegate.Sub s1 = new Delegate.Sub("Hanne");
            Delegate.Sub s2 = new Delegate.Sub("Heidi");
            Delegate.Sub s3 = new Delegate.Sub("Henrik");

            //Asign Subs
            p1.BroadcastNews += s1.PrintNews;
            p1.BroadcastNews += s2.PrintNews;
            p1.BroadcastNews += s3.PrintNews;

            //Public News
            p1.News = "Husk at børste dit anus og vaske dine tænder.";

            //Await input
            Console.ReadLine();
            Console.Clear();
        }

        /* =============================================================================================================================
                Events
        ============================================================================================================================= */

        static void Events()
        {
            //New Publicher
            Events.Pub p1 = new Events.Pub("Blogger Hanne");

            //New Subscribers
            Events.Sub s1 = new Events.Sub("Heidi");
            Events.Sub s2 = new Events.Sub("Henrik");
            Events.Sub s3 = new Events.Sub("Tandlægen");

            //Asign Subscribers
            p1.BroadcastNews += s1.PrintNews;
            p1.BroadcastNews += s2.PrintNews;
            p1.BroadcastNews += s3.PrintNews;

            //Print News
            p1.News = "Min tandlæge er skide forvirret.";

            //Await
            Console.ReadLine();
            Console.Clear();
        }

        /* =============================================================================================================================
                ObserverPattern (Using Inheritance)
        ============================================================================================================================= */

        static void ObserverPattern()
        {
            //New Publicher
            var p = new observerPattern.Pub("UCL");

            //New Subscribers
            var s1 = new observerPattern.Sub(p, "Niclas"); // (Whom is subscribed to, Name of Subscriber)
            var s2 = new observerPattern.Sub(p, "Casper");
            var s3 = new observerPattern.Sub(p, "Møller");

            //Asign Subscribers
            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            //Broadcast Message
            p.Broadcast = "Tag en øl!";

            p.Detach(s3);
            p.Broadcast = "Tag en til.";

            //Await
            Console.ReadLine();
        }
    }
}