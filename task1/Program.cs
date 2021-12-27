using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Строка со скобками
        // Строка для проверки не правильная 123}9876516(2){$!$%sgsegg)waarafa}644sfa{6454qF ff]sdfsf
        // Строка для проверки правильная 123(98765162{$!$%sgsegg}waarafa)644sfa[6454qF ff]sdfsf
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую скобки (круглые (), квадратные [] и фигурные {}) и другие символы:");            
            string str = Console.ReadLine();
            Console.WriteLine(StrCheck(str) ? "В введенной строке - скобки расставлены правильно." : "В введенной строке - скобки расставлены не правильно!");
            Console.ReadKey();
        }
        static bool StrCheck(string str)
        {
            Stack<char> stak = new Stack<char>();
            foreach (var s in str)
            {
                if (s == '[')
                    stak.Push(']');
                if (s == '(')
                    stak.Push(')');
                if (s == '{')
                    stak.Push('}');
                if (stak.Count != 0 && s == stak.Peek())
                    stak.Pop();
            }
            if (stak.Count != 0)
                return false;
            return true;
        }
    }
}
