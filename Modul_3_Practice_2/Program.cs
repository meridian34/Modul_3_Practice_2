namespace Modul_3_Practice_2
{
    public class Program
    {
        public static void Main()
        {
            var td = new Task_Delegate();
            td.Start();

            var tl = new Task_LINQ();
            tl.Start();
        }
    }
}
