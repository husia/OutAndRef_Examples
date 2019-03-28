using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_out_and_ref_examples_
{
    public static class RefClass
    {
        // в данном методе используется ключевое слово ref. после выполнения метода, переменная с ключевым словом ref изменится, f jcnfkmyst ytn
        public static string SummWords(string a, string b, ref string c)
        {
            // получаем измененную переменную с.
            c = c + "!";
            //получаем нашу возращаемое значение
            var summString = a + b + c ;
            return summString;
        }
    }
}
