using System;

namespace Store
{
    public class Book
    {
        /*
        * Это не поле, а свойство с модификатором get т е только на чтение 
        */
        public int Id { get; }
        /*
        * Это не поле, а свойство с модификатором get т е только на чтение 
        */
        public string Title { get; }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
