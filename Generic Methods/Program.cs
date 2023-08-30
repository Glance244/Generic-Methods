using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string sname = " ";
            GetInput<string>("Enter your Name: ", ref sname);
            int iAge = 0;
            GetInput<int>("Enter your age: ", ref iAge);
            DateTime dateofbirth = default(DateTime);
            GetInput<DateTime>("Enter your date of birth: ", ref dateofbirth);


            int marks = 0;
            string module = " ";
            Getinput<string, int>("Enter module: ","Enter Marks: ", ref module, ref marks);

            Console.WriteLine("\nYour name is "+sname+" you are "+iAge+" years old "+" and you were born in "+dateofbirth);
            Console.WriteLine("you got "+marks+" for "+module);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }
        private static void GetInput<B>(string _prompt, ref B input)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write(_prompt);
                    string sinput = Console.ReadLine();
                    input = (B)Convert.ChangeType(sinput, typeof(B));
                    isValid = true;
                }
                catch
                {

                    isValid = false;
                }
            }
        }
        private static void Getinput<B1, B2>(string prompt1, string prompt2, ref B1 input1, ref B2 input2)
        {
            Console.Write(prompt1);
            string sInput1 = Console.ReadLine();
            input1 = (B1)Convert.ChangeType(sInput1, typeof(B1));

            Console.Write(prompt2);
            string sInput2 = Console.ReadLine();
            input2 = (B2)Convert.ChangeType(sInput2, typeof(B1));



        }
    }
}
