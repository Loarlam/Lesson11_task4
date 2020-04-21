/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections. 
*/
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("QQ, friend");
            arrayList.Add(4.5);
            arrayList.Add('Y');
            arrayList.Add(525252525m);

            Console.WriteLine(arrayList.ToString());

            Console.ReadKey();
        }
    }
}
