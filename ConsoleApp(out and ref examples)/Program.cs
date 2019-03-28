using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_out_and_ref_examples_
{
    class Program
    {
        static void Main(string[] args)
        {
            // здесь мы задали две переменные для проверки метода с ключевым словом out.
            int x = 10, y = 15;

            //здесь задали три переменные для проверки метода с ключевым словом ref. 
            //обратите внимание что пока в третьей строковой переменной заключение строка Cool.
            string str1 = "Jack", str2 = "Miller";
            string str3 = "Cool";

            //присваиваем переменной summ значение нашего метода
           var summ = OutClass.GetSummAndVariable(x, y, out int c);

            // выводим в консоль переменные summ и c, последняя из которых мы использовали с ключевым словом out.
            Console.WriteLine("сумма {0}, переменная с ключевым словом out: {1}", summ, c);
            Console.WriteLine(); //данный метод просто чтоб была между нащими строками пустая строка, тоесть для красоты
            // получаем переменную summ через наш метод, 
            //а также переменная str3 изменяется и добавится к слову Cool восклицательный знак.
            var summWords = RefClass.SummWords(str1, str2, ref str3);

            //выводим переменные в консоль
            Console.WriteLine("сумма слов: {0}, измененная переменная str3: {1}", summWords, str3);

            Console.ReadKey();
            
        }
    }
}
