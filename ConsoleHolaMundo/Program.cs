using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleHolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string mMensaje = "Hola Mundo";
            Console.WriteLine(mMensaje);
            //Console.ReadKey();

            try
            {
                if (args == null) throw new ArgumentNullException("args");
                //1. Get the name of the output file
                //var fileName = args[0];
                var fileName = "testconsola";
                //2. Create the file
                var file = new FileStream(fileName, FileMode.OpenOrCreate);
                //3. Save the standard output
                var standardOutput = Console.Out;
                //4. Testing the console before changing the output
                Console.WriteLine("Hello world from the console!");
                //5. Create a StreamWriter
                using (var writer = new StreamWriter(file))
                {
                    //6. Set the new output
                    Console.SetOut(writer);
                    //7. Write something
                    Console.WriteLine("Hello World from the file!");
                    //8. Change the ouput again
                    Console.SetOut(standardOutput);
                }
                //9. Last testing
                Console.WriteLine("Here I am again!");
            }
            catch(Exception ex) {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}
