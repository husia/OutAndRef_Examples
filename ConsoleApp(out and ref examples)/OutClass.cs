using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_out_and_ref_examples_
{
    static class OutClass
    {
        //переменная с ключевым слово out может использоваться в коде где вызывается данный метод 
        // без инициализации. В даном случае в этом методе мы получим сумму двух переменных а также переменную c.
        public static int GetSummAndVariable(int a, int b, out int c)
        {
            var sum = a + b;
            //для наглядности получим значение переменной с через умножение других переменных
            c = a * b;
            //возвращаем нашу сумму переменных.
            return sum;

        }
    }
}
