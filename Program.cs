namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            input inp = new();

            List<Tuple<string, string>> data = inp.input_d();

            Console.WriteLine("Производится расчёт");
        }
    }
}
