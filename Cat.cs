using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat : Name
    {
        
        public void Print_name()
        {
            Console.WriteLine($"Вашего кота зовут {Cat_name}");
        }
        public void Change_name()
        {
            Cat_name = Console.ReadLine();
        }

        public void Delete_name()
        {
            Cat_name = "";
        }

        public void Reverse_name()
        {
            string str = "";
            for (int i = Cat_name.Length - 1; i >= 0; i--)
            {
                str += Cat_name[i];
            }
            Cat_name = str;
        }
    }
}
