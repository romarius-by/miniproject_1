using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    public class Room : IAdd
    {
        public string Name;
        public int Square;
        public int FreeSpace;
        public int WindowsNum;
        public int RoomLight;
        public const int StandartWindowLuminosity = 300;

        public List<Furniture> RoomFurniture = new List<Furniture>();
        public List<Lamp> RoomLamps = new List<Lamp>();

        public Room(string Name, int Square, int WindowsNum)
        {
            this.Name = Name;
            this.Square = Square;
            this.WindowsNum = WindowsNum;
            RoomLight = WindowsNum * StandartWindowLuminosity;
            FreeSpace = Square;
        }

        public void Add(string name, int square)
        {
            try
            {
                RoomFurniture.Add(new Furniture(name, square));
                FreeSpace -= square;
                    if (FreeSpace < 0)
                    {
                        throw new Exception($"Недостаточно места в комнате {Name}");
                    }
            }
            catch (Exception spaceException)
            {
                Console.WriteLine($"Ошибка: {spaceException.Message}");
                Environment.Exit(0);
            }
        }

        public void Add(int luminosity)
        {
            try
            {
                RoomLamps.Add(new Lamp(luminosity));
                RoomLight += luminosity;
                if (RoomLight > 2000)
                {
                    throw new Exception($"Слишком светло в комнате {Name}");
                }
            }
            catch (Exception lightException)
            {
                Console.WriteLine($"Ошибка: {lightException.Message}");
                Environment.Exit(0);
            }
        }
    }
}
