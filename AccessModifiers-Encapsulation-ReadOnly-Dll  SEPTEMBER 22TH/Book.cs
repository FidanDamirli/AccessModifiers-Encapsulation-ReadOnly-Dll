using System;
namespace AccessModifiers_Encapsulation_ReadOnly_Dll__SEPTEMBER_22TH
{
    public class Book : Product
    {
        public string Genre;

        public Book(string name, decimal price, string genre) : base(name, price)
        {
            Genre = genre;
        }
    }
}

