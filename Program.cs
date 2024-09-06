namespace ConsoleApp2
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " +
                "u can choose 1 - print your cat's name\n" +
                "2 - delete your cat's name\n" +
                "3 - change your cat's name\n" +
                "4 - reverse your cat's name\n" +
                "5 - exit\n" +
                "Have a good day :)");
            bool flag = true;
            Cat cat = new Cat();
            Message mes = cat.Print_name;
            while (flag)
            {
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    //cat.Print_name();
                    mes();
                }
                else if (choose == "2")
                {
                    cat.Delete_name();
                }
                else if (choose == "3")
                {
                    cat.Change_name();
                }
                else if (choose == "4")
                {
                    cat.Reverse_name();
                }
                else if (choose == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
