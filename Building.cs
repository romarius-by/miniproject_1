using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    public class Building
    {
        public List<KeyValuePair<string, Room>> Rooms = new List<KeyValuePair<string, Room>>();


        public void AddRoom(string name, int square)
        {
            Rooms.Add(new KeyValuePair<string, Room>(name, new Room(name, square)));
        }

        public Room GetRoom(string name)
        {
            Room empty = new Room("",0); 
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
                Console.WriteLine(room.Value.Name + " Площадь комнаты: " + room.Value.Square + " м2  Свободное место: " + room.Value.FreeSpace + " м2");
                foreach (KeyValuePair<Room, Furniture> f in room.Value.RoomFurniture)
                {
                        Console.WriteLine(f.Value.Name + " " + f.Value.Square);
                }
            }
        }
            
    }
}
