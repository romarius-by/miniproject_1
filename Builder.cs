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
            bigHouse.GetRoom("Кабинет").AddFurniture("Стол", 15);
            bigHouse.GetRoom("Кабинет").AddFurniture("Стул", 10);
            bigHouse.GetRoom("Кабинет").AddLamp("Лампочка", 200);
            bigHouse.GetRoom("Кабинет").AddLamp("Торшер", 300);
            bigHouse.AddRoom("Гостинная", 100, 3);
            bigHouse.GetRoom("Гостинная").AddFurniture("Телевизор", 25);
            bigHouse.GetRoom("Гостинная").AddFurniture("Журнальный столик", 18);
            bigHouse.GetRoom("Гостинная").AddFurniture("Фикус", 10);

            bigHouse.Describe();
        }
    }
}
