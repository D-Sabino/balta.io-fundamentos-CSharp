using System;
using System.Data;

namespace MyApp{
    class Program{
        static void Main(string[] args){
            Console.Clear();

            var data = new DateTime(2020, 10, 12, 13, 23, 14);
            //var data = DateTime.Now;
            Console.WriteLine(data);

            var formatada = String.Format("{0:yyyy-MM-dd hh:mm:ss ff z}", data);
            Console.WriteLine(formatada);

            formatada = String.Format("{0:T}", data);
            Console.WriteLine(formatada);

            var dataAdd = DateTime.Now;
            Console.WriteLine("dataAdd:" + dataAdd);
            Console.WriteLine("dataAdd AddDays -12:" + dataAdd.AddDays(-12));
            Console.WriteLine("dataAdd AddMonths 1:" + dataAdd.AddMonths(1));
            Console.WriteLine("dataAdd AddYears 1:" + dataAdd.AddYears(1));

        }
    }
}