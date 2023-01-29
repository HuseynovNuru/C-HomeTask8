using System;
using System.Transactions;

namespace CHomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle-Car task
            Car car1 = new Car(80, 40, "Land Rover", "Range Rover", 270.65);

            Console.WriteLine(car1.Brand+" "+car1.Model);
            Console.WriteLine( car1.AddFuel(20));
            Console.WriteLine(car1.CurrentFuel);




            //Human-Student task
            Student std = new Student("P231", "Nuru Huseynov");
            Student[] students = new Student[0];
            Console.WriteLine("Secim edin:");
            string option;
            do
            {
                Console.WriteLine("1.Butun telebelere bax");
                Console.WriteLine("2.Telebeler uzre axtarish et");
                Console.WriteLine("3.Telebe elave et");
                Console.WriteLine("0.Menudan chıx");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Butun Telebeleri goreceksizniz.");
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine($"Fullname : {students[i].Fullname} \nGroupNo : {students[i].GroupNo}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Telebleri axtaris edirsiz.");
                        string getvalue = Console.ReadLine();
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Hal-hazirda telebe yoxdur.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Telebe elave etdiniz.");

                        break;
                    case "0":
                        Console.WriteLine("Menudan cixis etdiniz");
                        break; 
                } 
                

                    
            } while(option=="0");



        }
    }
}
