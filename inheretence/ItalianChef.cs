using System;

namespace inheretence
{
    class ItalianChef : Chef // inhereting
    {
        public void MakePasta()
        {
            Console.WriteLine("Pasta");
        }
        //oerridden method
        public override void MakeSpecialDish()//"override" keyword used to override from Chef class
        {
            Console.WriteLine("No dish ");
        }
    }
}
