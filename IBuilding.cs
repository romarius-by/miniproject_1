using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    interface IBuilding
    {
        Room GetRoom(string name);
        void AddRoom(string name, int square, int windowsnum);
    }
}
