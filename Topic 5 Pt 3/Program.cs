namespace Topic_5_Pt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string hurricaneCategory;
            int loop = 1;

            while (loop == 1)
            {
                Console.WriteLine("Enter Hurricane Category:");
                hurricaneCategory = Console.ReadLine();

                int hurricaneInt = Convert.ToInt32(hurricaneCategory);

                switch (hurricaneInt)
                {
                    case 1:
                        Console.WriteLine("A category 1 hurricane goes 119-153 KPH");
                        loop = 0;
                        break;

                    case 2:
                        Console.WriteLine("A category 2 hurricane goes 154-177 KPH");
                        loop = 0;
                        break;

                    case 3:
                        Console.WriteLine("A category 3 hurricane goes 178-209 KPH");
                        loop = 0;
                        break;

                    case 4:
                        Console.WriteLine("A category 4 hurricane goes 210-249 KPH");
                        loop = 0;
                        break;

                    case 5:
                        Console.WriteLine("A category 5 hurricane goes 250+ KPH");
                        loop = 0;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid hurricane category");
                        break;

                }
            }
        }
    }
}