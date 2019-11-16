using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    class Builder
    {
        static void Main(string[] args)
        {
            Building bigHouse = new Building();
            bigHouse.AddRoom("Кабинет", 150, 2);
            bigHouse.GetRoom("Кабинет").Add("Стол", 15);
            bigHouse.GetRoom("Кабинет").Add("Стул", 10);
            bigHouse.GetRoom("Кабинет").Add(200);
            bigHouse.GetRoom("Кабинет").Add(300);
            bigHouse.AddRoom("Гостинная", 100, 3);
            bigHouse.GetRoom("Гостинная").Add("Телевизор", 25);
            bigHouse.GetRoom("Гостинная").Add("Журнальный столик", 18);
            bigHouse.GetRoom("Гостинная").Add("Фикус", 10);

            bigHouse.Describe();
        }
    }
}
