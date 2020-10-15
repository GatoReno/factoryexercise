using System;
using Generics.models;

namespace Generics
{
    public class BookList
    {
        public void Add(Book b)
        {
            Console.WriteLine(b.Name + " added");
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {

    }

    public class GenericList<T>
    {
        public void Add(T val)
        {
            Console.WriteLine(" added");
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
