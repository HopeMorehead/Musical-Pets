using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            bool saveExit = false;

            if (saveExit == false)
            {

                Console.WriteLine(" Welcome to the wonderful world of musical pets." +
                                  " Where collecting a pet or two provides users with an array of music notes," +
                                  " which can be put together to make a sympathy of sounds!");
                Console.WriteLine("Press Enter to move forward press S to save and exit");
                String userInput = Console.ReadLine().ToUpper();

                if (userInput == "S")
                {
                    saveExit = true;
                    Console.WriteLine("Bye Bye");
                    //Environment.Exit(0) terminates this 
                    //process and gives the underlying operating system the specified exit code. 
                    //It is more generally used in console applications.
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Let's Begin");

                    // if (dogs[0] == null)
                    // {
                    //     Console.WriteLine("crap");
                    // }
                    string[] dogs = new string[4];
                    string[] copyDogs = new string[dogs.Length + 4];
                    for (int index = 0; index < dogs.Length; index++)
                    {
                        dogs[index] = Console.ReadLine();
                        copyDogs[index] = dogs[index];
                    }
                    Console.WriteLine(copyDogs.Length);

                    for (int index = 4; index < copyDogs.Length; index++)
                    {
                        copyDogs[index] = Console.ReadLine();
                    }
                    Console.WriteLine(copyDogs[0]);
                    Console.WriteLine(copyDogs[1]);
                    Console.WriteLine(copyDogs[2]);
                    Console.WriteLine(copyDogs[3]);
                    Console.WriteLine(copyDogs[4]);
                    Console.WriteLine(copyDogs[5]);
                    Console.WriteLine(copyDogs[6]);
                    Console.WriteLine(copyDogs[7]);
                    //   if (dogs[0] == null)
                    //  {
                    //      Console.WriteLine("null");
                    //  }
                    //  else
                    // {
                    //   Console.WriteLine("not null");
                    //  Console.WriteLine(dogType);
                    string[] dog4 = copyDogs;
                    string[] samedogarray = new string[8];
                    for (int index = 0; index < dog4.Length; index++)
                    {
                        Console.WriteLine(dog4[0].ToCharArray());
                        //Char dog5=Convert.ToChar(dog4[0]);

                        foreach (Char c in dog4[0])
                            Console.WriteLine(c.ToString());
                        if (dog4[0] == dog4[1])
                        {

                            Console.WriteLine("youcan't pick the same dog");
                            samedogarray[0] = dog4[1];
                        }
                    }
                    Console.WriteLine($"added to seprate array{dog4[1]}");


                    Console.ReadKey();

                }
             }
            
         }

        public int myMethod() {
            int[] n = { 1, 2, 3 };
            int total = n[0] + n[1] + n[2];
            string total1 = $"{n[0]} + {n[1] }+ {n[2]}={total}";

            return total;
                 }
        










            //    Console.WriteLine(dogType);


            // string dogType = dogs[];


            //    dogs[0] = null;

            // for (int index =0 ;index <dogs.Length; index++)

            //  { 

            //  string dogType = (Console.ReadLine());

            //  for (string name=null; dogType == name; index++)

            //   Console.WriteLine(dogType);
            //  Console.WriteLine(dogs[2]);
            //   }



            //  String dogType = Console.ReadLine();
            //  Double dogTypeConvert = Convert.ToDouble();




            
         //   }

     }
}

