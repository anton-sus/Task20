using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//        В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
//-       метод получает входным параметром переменную типа double;
//-       метод возвращает значение типа double, которое является результатом вычисления.
//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-       длину окружности по формуле D = 2 * π * R;
//-       площадь круга по формуле S = π* R²;
//-       объем шара.Формула V = 4 / 3 * π * R³.
//Методы должны быть объявлены как статические.


namespace Task20
{
    class Program

    {
        delegate double MyDel(double R);

        static void Main(string[] args)
        {
            Console.Write("R=");
            double R = Convert.ToDouble(Console.ReadLine());

            MyDel myDel = CirlceLenght;
            double D = myDel(R);
            Console.WriteLine($"длина окружности {D}");

            myDel = CirlceArea;
            double S = myDel(R);
            Console.WriteLine($"площадь {S}");

            myDel = SphereVolume;
            double V = myDel(R);
            Console.WriteLine($"объём {V}");

            Console.ReadLine();
        }
        static double CirlceLenght(double R)=> 2 * Math.PI * R;
        static double CirlceArea(double R)=> Math.PI * R*R;
        static double SphereVolume(double R)=> Math.PI * 4 / 3 * Math.Pow(R,3);
    }
}
