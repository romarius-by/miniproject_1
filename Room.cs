using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    public class Room : IDescribe, ISquare
    {
        public string Name;
        public int Square;
        public int FreeSpace;
        public List<KeyValuePair<Room, Furniture>> RoomFurniture = new List<KeyValuePair<Room, Furniture>>();

        public Room(string Name, int Square)
        {
            this.Name = Name;
            this.Square = Square;
            FreeSpace = Square;
        }

        public void AddFurniture(string name, int square, Room room)
        {
            try
            {
                RoomFurniture.Add(new KeyValuePair<Room, Furniture>(room, new Furniture(name, square)));
                FreeSpace -= square;
                    if (FreeSpace < 0)
                    {
                        throw new Exception($"Недостаточно места в комнате {room.Name}");
                    }
            }
            catch (Exception spaceException)
            {
                Console.WriteLine($"Ошибка: {spaceException.Message}");
                Environment.Exit(0);
            }
        }
    }
}
