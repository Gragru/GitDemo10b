namespace GitDemo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.WriteText("Hejsan världen igen!");
            Console.WriteLine("Idag är det onsdag!");
            Console.WriteLine(Helpers.CoolFeature(13, 47));
            Helpers.MyLoop();
            Console.WriteLine(Helpers.TellJoke());
        }
    }
}
