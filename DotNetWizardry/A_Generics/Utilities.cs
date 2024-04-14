using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Generics;

//for applying constraints to the Generic class <T>
internal class Utilities<T> where T : IComparable, new()
{
    //internal int Max(int a, int b)
    //{
    //    return a > b ? a : b;
    //}


    //constraints on T
    //internal T Max<T>(T a, T b) where T : IComparable
    //{
    //    //return a > b ? a : b;

    //    return a.CompareTo(b) > 0 ? a : b;
    //}

    internal T Max(T a, T b)
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}


// 5 types of constraints
// where T : IComparable // (any interface)
// where T : Product // (any class)
// where T : struct // (value type)
// where T : class // (referance)
// where T : new() // (have a default constructor)

internal class DiscountCalculator<TProduct> where TProduct : Product
{
    internal double CalculateDiscount(TProduct product)
    {
        return product.Price;
    }
}

// Constraints to a value type
// In some value type the value cannot be null
internal class Nullable<T> where T : struct
{
    private object _value;

    internal bool HasValue
    {
        get { return _value != null; }
    }

    internal Nullable()
    {
    }

    internal Nullable(T value)
    {
        _value = value;
    }

    internal T GetValueOrDefault()
    {
        if (HasValue)
            return (T)_value;

        return default(T);
    }
}