using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    class Hospital
    {
        private  Appointment[] appointments = new Appointment[18];
        private int appointmentCount = 0;

        public void  AddAppointment (Appointment appointment )
        {
            if(appointmentCount < appointments.Length)
            {
                appointments[appointmentCount] = appointment;
                appointmentCount++;
                Console.WriteLine("Gorus teyin edildi");
            }
            else
            {
                Console.WriteLine("Bos vaxt yoxdur");
            }
        }

        public void EndAppointment(int no)
        {
            if(no > 0 && no < appointmentCount)
            {
                appointments[no].EndDate = DateTime.Now;
                Console.WriteLine($"Xeste {appointments[no].Patient} ucun gorus bitti:{appointments[no].EndDate}" );
            }
            else
            {
                Console.WriteLine("Sehv deyer");
            }
        }
        
        public Appointment GetAppointment(int no)
        {
            if(no > 0 && no < appointmentCount)
            {
                return appointments[no];
            }
            return null;
        }



        public void GetAllAppointments()
        {
            Console.WriteLine("Butun gorusler:");
            for (int no=0;no<appointmentCount;no++)
            {
                Console.WriteLine($"Xeste:{appointments[no].Patient} ; Hekim:{appointments[no].Doctor} ; Gorus basladi:{appointments[no].StartDate} ; Gorus bitti:{appointments[no].EndDate}");
            }
        }

        public void GetAllContinuingAppointments()
        {
            Console.WriteLine("Bitmemis gorusler");
            for (int no = 0; no < appointmentCount; no++)
            {
                if (appointments[no].EndDate == null)
                {
                    Console.WriteLine($"Xeste:{appointments[no].Patient} ; Hekim:{appointments[no].Doctor} ; Gorus basladi:{appointments[no].StartDate} ; Gorus bitti: Bitmemis");
                }
            }
        }
    }
}
