using System;
namespace latihanclassobject
{
    public class Taxi
    {
        public string DriverName {get; set;}
        public bool OnDuty {get; set;}
        public float NumPassenger {get; set;}
    
    
        public void TaxiInfo()
        {
            Console.WriteLine("Nama: {0}", DriverName);
            if(OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Jumlah Penumpang: {0}\n", NumPassenger);
        }
    
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput Penumpang", DriverName);
        }
        
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}