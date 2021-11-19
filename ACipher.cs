using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{ //\Users\User\source\repos\Homework9\bin\Debug\*/
    class ACipher : ICipher
    {
        public void encode()
        {
            string text = File.ReadAllText(@"C:\Users\User\source\repos\Homework9\bin\Debug\TextForEncode.txt");
            Console.WriteLine(text.ToLower());
            List<char> tmp = new List<char>();
            foreach (char a in text)
            {               
                char x;
                if (!Equals(a, 'я'))
                {
                    x = (char)((int)a + 1);
                }
                else
                {
                    x = 'a';
                }
                tmp.Add(x);
            }
            string textenc = String.Join("", tmp.ToArray());
            Console.WriteLine(textenc + "\n");
            string path = @"encodetext.txt";
            File.WriteAllText(path, textenc);
        }
        public void decode()
        {
            string text = File.ReadAllText(@"encodetext.txt");
            Console.WriteLine(text.ToLower());
            List<char> tmp = new List<char>();
            foreach (char a in text)
            {               
                char x;
                if (!Equals(a, 'а'))
                {
                    x = (char)((int)a - 1);
                }
                else
                {
                    x = 'я';
                }
                tmp.Add(x);
            }
            string textenc = String.Join("", tmp.ToArray());
            Console.WriteLine(textenc + "\n");
            //string path = @"C:\Users\User\source\repos\Homework9\bin\Debug\Encodetext.txt";
            //File.WriteAllText(path, textenc);
        }
    }
}
