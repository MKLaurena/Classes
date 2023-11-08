using System;

namespace Classes
{
    internal class Cittadino
    {
        static void Main(string[] args)
        {
            Citoyen citoyen = new Citoyen(true, 20, 25, 55, 2, 150, false, false);

            bool result = citoyen.HasRightToGetSocialMoney();
            Console.WriteLine("");
        }
    }
}
