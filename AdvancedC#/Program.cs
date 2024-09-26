namespace AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Any<int> a = new Any<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            Console.WriteLine($"check is Empty => {a.IsEmpty} ,, Count is {a.Count}");
            a.RemoveAt(1);
            a.Display();

        }
    }
}

class Any<T>
{
    private T[] _items;
    public void Add(T item)
    {
        if (_items == null)
            _items = new T[] { item };
        else
        {
            var length = _items.Length;
            var dest = new T[length + 1];
            for (int i = 0; i < length; i++)
                dest[i] = _items[i];
            dest[dest.Length-1] = item;
            _items = dest;
        }
    }
    public void RemoveAt(int position)
    {
        if (_items == null)
            return;
        var length = _items.Length;
        var dest = new T[length-1];
        var index = 0;
        for (int i = 0; i < length; i++)
        {
            if (i == position)
                continue;
            dest[index++] = _items[i];
        }
        _items = dest;
    }

    public bool IsEmpty=> _items.Length == 0 || _items is null;
    public int Count => _items.Length;

    public void Display()
    {
        Console.Write("[");
        for (int i = 0; i < _items.Length; i++)
        {
            Console.Write(_items[i]);
            if(i < _items.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}