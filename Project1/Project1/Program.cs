using Project1.Models;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            while(true)
            {
                Console.WriteLine("1.Yeni gorus yarat");
                Console.WriteLine("2.Gorusu bitir");
                Console.WriteLine("3.Butun goruslere bax");
                Console.WriteLine("4.Bitmemis goruslere bax");
                Console.WriteLine("5.Cix");
                Console.Write("Seciminizi qeyd edin:");
                string info = Console.ReadLine();

                switch (info)
                {
                    case "1":

                        Console.Write("Xestenin adi:");
                        string patient = Console.ReadLine();

                        Console.Write("Hekimin adi:");
                        string doctor = Console.ReadLine();

                        Console.Write("Baslama saati:");
                        DateTime startDate = DateTime.Parse (Console.ReadLine());                     
                        break;

                    case "2":
                        Console.WriteLine("Bitirmek istediyiniz gorusu qeyd edin:");
                        int endAppointmentNo = int.Parse(Console.ReadLine());

                        break;

                    case "3":
                        hospital.GetAllAppointments();
                        break;

                    case "4":
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Yanlis secim.Bir daha sinayin");
                        break;
                }
            }
        }
    }
}
