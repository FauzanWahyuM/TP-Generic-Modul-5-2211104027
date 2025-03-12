using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_2211104027
{
    class Program
    {
        static void Main()
        {
            // Memanggil metode generic SapaUser
            HaloGeneric.SapaUser("Fauzan");
        }
    }

    // HaloGeneric.cs
    class HaloGeneric
    {
        public static void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

}
