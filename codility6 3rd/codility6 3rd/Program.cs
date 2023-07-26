using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility6_3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check");
           string S= Console.ReadLine();
            //String S = "xxxtxxxttt";

            Console.WriteLine(solut(S));
            Console.ReadKey();
        }
        public static string solut(string S)
        {
            string[] result = new  string[S.Length*S.Length];
           

            int numner = 0;
            int j = 0;
            for (int i = 0; i < S.Length - 2; i++)
            {
                if (S[i] == S[i + 1] && S[i] == S[i + 2])
                {             
                    
                        if (numner == 0)
                        {
                            result[j] = S.Remove(i, 1);
                            numner++;
                            j++;
                        }
                        else if(numner==j)
                        {
                            result[j] = result[j].Remove(i, 1);
                            numner++;
                             j++;
                        }
                         




                    // "xxxtxxx"
                    //  "xxtxxx"
                    //   xxxtxx
                }
            }
            return result[numner-1];
        }
    }
}
