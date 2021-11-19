using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class BCipher : ICipher
    {
        public void encode()
        {           
            char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
              'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
              'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
            string text = File.ReadAllText(@"TextForEncode.txt");
            Console.WriteLine(text.ToLower());
            List<char> tmp = new List<char>();
            foreach (char a in text)
            {            
                char x ;
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (Equals(a, alphabet[i]))
                    {
                        x = alphabet[alphabet.Length - (i+1)];                       
                        tmp.Add(x);
                    }                 
                }           
            }
            string textenc = String.Join("", tmp.ToArray());
            Console.WriteLine(textenc + "\n");
            string path = @"encodetext2.txt";
            File.WriteAllText(path, textenc);
        }
        public void decode()
        {
            char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
              'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
              'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
            string text = File.ReadAllText(@"encodetext2.txt");
            Console.WriteLine(text.ToLower());
            List<char> tmp = new List<char>();
            foreach (char a in text)
            {               
                char x;
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (Equals(a, alphabet[i]))
                    {
                        x = alphabet[alphabet.Length - (i + 1)];                       
                        tmp.Add(x);
                    }
                }
            }
            string textenc = String.Join("", tmp.ToArray());
            Console.WriteLine(textenc +"\n");
        }
    }
}
