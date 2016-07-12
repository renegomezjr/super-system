using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower();
            Map map = new Map(8, 9);


            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (OutOfBoundsException ex)
            {
                Console.Write(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.Write("Exception not handled.");
            }
            catch (Exception)
            {
                Console.Write("That point is not on the map.");
            }

            Console.ReadKey();
        }
    }
}
