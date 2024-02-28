using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherEcho
{
    public class Cypher
    {
        public string Encrypt(string input, int lockcode)
        {
            return ShiftText(input, lockcode);
        }

        public string Decrypt(string input, int unlockcode)
        {
            return ShiftText(input, -unlockcode);


        }

        private string ShiftText(string input, int shift)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char originalChar = input[i];

                if (char.IsLetter(originalChar))
                {
                    char shiftedChar = (char)(originalChar + shift);

                    if (char.IsLower(originalChar))
                    {
                        if (shiftedChar < 'a')
                        {

                            shiftedChar = (char)(shiftedChar + 26);
                        }

                        else if (shiftedChar > 'z')
                        {
                            shiftedChar = (char)(shiftedChar - 26);

                        }
                    }
                    else if (char.IsUpper(originalChar))
                    {
                        if (shiftedChar < 'A')
                        {
                            shiftedChar = (char)(shiftedChar + 26);
                        }
                        else if (shiftedChar > 'Z')
                        {

                            
                            shiftedChar = (char)(shiftedChar - 26);
                        }

                    }

                    result[i] = shiftedChar;
                }
                else
                {
                    result[i] = originalChar;
                }
            }




            return new string(result);

       
    
        }
    }



}
