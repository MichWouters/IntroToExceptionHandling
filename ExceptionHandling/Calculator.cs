using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator
    {
        public int Divide(int number, int divideBy)
        {
            return number / divideBy;
        }

        public void TryParseShowCase()
        {
            string toParse = "vijfentwintig";

            int tryParsed;

            if (Int32.TryParse(toParse, out tryParsed))
            {
                Console.WriteLine($"Conversion was succcesful: {tryParsed}");
            }
            else
            {
                Console.WriteLine($"Conversion failed: { tryParsed}");
            }

            int parsed = Int32.Parse(toParse);
            Console.WriteLine($"Parsed result : {toParse}");
        }

        public void FooBar()
        {
            throw new System.NotImplementedException();
        }


        public void ReadFile()
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("@c:\file.txt");
                var content = reader.ReadToEnd();
            }
            // !!!BAD PRACTICE -> DO NOT MAKE EMPTY CATCH STATEMENTS!
            // DO THIS IF YOU WANT TO GET FIRED.
            catch(Exception e)
            {

            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                }
            }
        }
    }
}
