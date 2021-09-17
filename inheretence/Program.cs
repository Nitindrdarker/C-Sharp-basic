using System;

namespace inheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            Chef chef = new Chef();
            italianChef.MakeSpecialDish();
            chef.MakeSpecialDish();
        }
    }
}
