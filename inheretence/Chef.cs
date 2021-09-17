using System;

namespace inheretence
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("Salad");
        }
        public virtual void MakeSpecialDish()//"virtual" to make you able to override
        {
            Console.WriteLine("MakeSpecialDish");
        }
    }
}
