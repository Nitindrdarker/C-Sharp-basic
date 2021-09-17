using System;

namespace classes_objects
{
    class new_class
    {   //class variable
        private string title;
        private string author;
        private int pages;
        //head back to program.cs
        public new_class(string title, string author, int pages)//consturctor
        {
            this.title = title;
            this.author = author;
            //this.pages = pages;
            Pages = pages; // for setter and getter
            //Console.WriteLine("Constructor called");
            Console.WriteLine(this.title + " " + this.author + " " + this.pages);
;        }
        //getter and setter
        public int Pages//int because page is of integet type
        {
            get{ return pages; }//get the page attribute in one of the valid page no.
            set{
                if(value == 100 || value == 200 || value == 300)
                {
                    this.pages = value;
                }
                else
                {
                    this.pages = 0;
                }
            }
        }


    }
}