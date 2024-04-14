using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Generics
{
    // without generics
	internal class BookList
	{
        public void Add(Book number)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    //This can be a solution but have performance problem
    internal class ObjectList
    {
        internal void Add(object value)
        {
            throw new NotImplementedException();
        }

        internal object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    //Generics

    internal class GenericList<T>
    {
        internal void Add(T value)
        {
            throw new NotImplementedException();
        }

        internal T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    internal class GenericDictionary<TKey, TValue>
    {
        internal void Add(TKey key, TValue value)
        {

        }

        internal TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
