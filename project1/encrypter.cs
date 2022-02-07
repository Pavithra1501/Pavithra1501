using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class encrypter
    {
        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textEncripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                textEncripted += letter.ToString();
            }
            return textEncripted;
        }

        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                textDecripted += letter.ToString();
            }
            return textDecripted;
        }
    }
    class TextEncrypted
    {
        static void Main()
        {
            bool debug = true;

            string newText = encrypter.Encrypt("pavan");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);

            if (debug)
                Console.ReadLine();
        }
    }
}




            