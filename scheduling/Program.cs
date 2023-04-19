namespace scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PCB pcb = new PCB("Hacking", 1);
            PCB.Retrieve(pcb);

            Console.WriteLine(pcb.ToString());
            Console.ReadLine();
        }
    }



    public enum ProcessStateType
    {
        New, Ready, Run, Exit, Wait
    }

    public class PCB
    {
        //Variables & Properties
        public string ProcessName { get; set; }
        public int ProcessPriority { get; set; }

        public ProcessStateType ProcessState { get; set; }

        //Constructor
        public PCB(string processName, int processPriority)
        {
            this.ProcessName = processName;
            this.ProcessPriority = processPriority;
            ProcessState = ProcessStateType.New;
        }

        //Methods
        public static List<PCB> Retrieve(PCB pcb)
        {
            List<PCB> Process = new List<PCB>();
            Process.Add(pcb);
            return Process;
        }

        //string override
        public override string ToString()
        {
            return $"{ProcessName}({ProcessPriority})";
        }
    }
}