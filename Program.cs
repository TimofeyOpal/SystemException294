
using System;

namespace SystemException294
{
    class Program
    {
        static void Main(string[] args)
        { 
            Car ca = new Car(15, "mini");
            try
            {
                ca.Accelerate(50);

            }

            catch(CarlsDeadException e){
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);

            }
            Console.ReadLine();
        }
    }
}
