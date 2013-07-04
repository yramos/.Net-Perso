using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    class FizzBuzz
    {
        public FizzBuzz() { }

        public List<String> listeDesCentsPremiersFizzBuzz() 
        {
            List<string> listeDesCentsPremiersFizzBuzz = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (i == 3)
                {
                    listeDesCentsPremiersFizzBuzz.Add("Fizz");
                }
                else if (i == 5)
                {
                    listeDesCentsPremiersFizzBuzz.Add("Buzz");
                }
                else
                {
                    listeDesCentsPremiersFizzBuzz.Add(i.ToString());
                }
                
            }
            return listeDesCentsPremiersFizzBuzz;
        }
        
    }
}
