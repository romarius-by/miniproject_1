using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    public class Building : IBuilding, IDescribe
    {
        public List<KeyValuePair<string, Room>> Rooms = new List<KeyValuePair<string, Room>>();


        public void AddRoom(string name, int square, int windowsnum)
        {
            Rooms.Add(new KeyValuePair<string, Room>(name, new Room(name, square, windowsnum)));
        }

        public Room GetRoom(string name)
        {
            Room empty = new Room("",0, 0); 
            foreach (KeyValuePair<string, Room> room in Rooms)
            {
                if (room.Key == name)
                    empty = room.Value;
            }
            return empty;
        }

        public void Describe()
        {
            foreach (KeyValuePair<string, Room> room in Rooms)
            {
                Console.WriteLine(room.Value.Name + " Площадь комнаты: " + room.Value.Square + " м2, Свободное место: " + room.Value.FreeSpace + " м2," + " Число окон: " + room.Value.WindowsNum + ", Освещенность комнаты: " + room.Value.RoomLight + " лм.");
                foreach (var furn in room.Value.RoomFurniture)
                {
                        Console.WriteLine(furn.Name + " Площадь: " + furn.Square + " м2");
                }
                foreach (var lamp in room.Value.RoomLamps)
                {
                    Console.WriteLine("Источник света " + " Светимость: " + lamp.Luminosity + " лм");
                }
            }
        }
            
    }
}
