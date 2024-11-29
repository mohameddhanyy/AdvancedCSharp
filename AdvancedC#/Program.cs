using System.Collections;
using AdvancedC_.ExceptionExample;
using System.Drawing;

namespace AdvancedC_
{
    public delegate void C(int x);

    internal class Programs
    {
        static void Main(string[] args)
        {
            #region Generic

            var p = new Person("Mohamed", "Hany");
            var s = new Person("MAY", "HANY");

            var a = new Any<Person>();
            //a.Add(p);
            //a.Add(s);
            //a.Display();

            //a.Add(1);
            //a.Add(2);
            //a.Add(3);
            //Console.WriteLine($"check is Empty => {a.IsEmpty} ,, Count is {a.Count}");
            //a.RemoveAt(1);
            //a.Display();

            #endregion

            #region Generic Delegate Type

            IEnumerable<int> l = new int[] { 1, 2, 5, 3, 4, 6, 7, 8, 9, 10 };
            IEnumerable<decimal> d = new decimal[]
                { 1.22m, 3.55m, 5.55m, 3.99m, 4.99m, 6.44m, 7.66m, 8.22m, 9.11m, 10.00m };

            //PrintNumber(l, x => x > 6, () => Console.WriteLine("numbers greater than 6"));

            //PrintNumber(l, x => x > 7, () => Console.WriteLine("numbers greater than 7"));

            //PrintNumber(l, x => x % 2 == 0, () => Console.WriteLine("Is Even"));

            #endregion

            #region Exceptions

            Delivery process1 = new Delivery()
            {
                Id = 1,
                Name = "Mohamed Hany",
                Address = "Minya",
                Status = DeliveryStatus.UNKNOWN
            };

            //Console.WriteLine(process1);

            var service = new Service();
            //service.Start(process1);

            //Console.WriteLine(process1);

            #endregion

            #region GenericAdvanced

            Point[] Points =
            {
                new Point(5, 9),
                new Point(2, 5),
                new Point(6, 4),
                new Point(3, 0),
            };

            Helper<Point>.BubbleSort(Points);
            // foreach (Point item in Points)
                // Console.WriteLine(item);

            Employeeees[] emps = new Employeeees[]
            {
                new Employeeees(5, "Mohamed", 6050),
                new Employeeees(6, "Amr", 1000),
                new Employeeees(7, "Hany", 8000),
                new Employeeees(8, "Sohilaa", 9000),
            };

            Helper<Employeeees>.BubbleSort(emps);
            //foreach (Employeeees e in emps)
            //    Console.WriteLine(e);

            #endregion

            #region DelegateAdvanced

            //Console.WriteLine("======================================");
            int[] arrr = new int[] { 1, 5, 3, 9, 22, 36, 4, 6, 11, 19 };
            SortingDelegate.BubbleSort(arrr, Compare.CompareDesc);
            //foreach (int item in arrr)
            //    Console.WriteLine(item);

            #endregion

            #region Extension Method

            DateTime dt = DateTime.Now;
            Console.WriteLine($"DateTime: {dt}");
            // dt = new DateTime(2000, 1, 1);
            // Console.WriteLine($"DateTime: {dt}");
            dt = dt.AddDays(4);
            // Console.WriteLine(dt);
            // Console.WriteLine(dt.IsWeekday());
            // Console.WriteLine(dt.IsWeekend());
            DateTimeOffset offset = DateTimeOffset.Now;
            // Console.WriteLine(offset);
            #endregion
            

            Employe e1 = new Employe()
            {
                id = 10,
                name = "John Doe",
                age = 15,
            };
            Employe e2 = new Employe()
            {
                id = 10,
                name = "John Doe",
                age = 15,
            };

            FiveIntegers nums = new FiveIntegers(1, 2, 3, 4, 5);
            // foreach (var num in nums)
            // {
            //     Console.WriteLine($"this number is {num} ");
            // }

            //Console.WriteLine(e1.Equals(e2));
            Console.ReadKey();
        }

        static void PrintNumber<T>(IEnumerable<T> nums, Predicate<T> predicate, Action a)
        {
            a();
            foreach (T n in nums)
            {
                if (predicate(n))
                {
                    Console.WriteLine(n);
                }
            }
        }

        static int BadMethod()
        {
            var x = 2;
            var y = 0;
            return x / y;
        }

        #region Generic

        class Person
        {
            private string fname;
            private string lname;

            public Person(string fname, string lname)
            {
                this.fname = fname;
                this.lname = lname;
            }

            public override string ToString()
            {
                return $"'{fname} {lname}'";
            }
        }

        class Any<T> where T : class
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
                    dest[dest.Length - 1] = item;
                    _items = dest;
                }
            }

            public void RemoveAt(int position)
            {
                if (_items == null)
                    return;
                var length = _items.Length;
                var dest = new T[length - 1];
                var index = 0;
                for (int i = 0; i < length; i++)
                {
                    if (i == position)
                        continue;
                    dest[index++] = _items[i];
                }

                _items = dest;
            }

            public bool IsEmpty => _items.Length == 0 || _items is null;
            public int Count => _items.Length;

            public void Display()
            {
                Console.Write("[");
                for (int i = 0; i < _items.Length; i++)
                {
                    Console.Write(_items[i]);
                    if (i < _items.Length - 1)
                        Console.Write(", ");
                }

                Console.WriteLine("]");
            }
        }

        #endregion
    }
}

class FiveIntegers : IEnumerable
{
    private int[] fives;

    public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
    {
        fives = new int[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in fives)
        {
            yield return item;
        }
    }
}

public delegate bool CompareFuncDelegate(int x, int y);

internal static class SortingDelegate
{
    public static void BubbleSort(int[] arr, CompareFuncDelegate dele)
    {
        for (var i = 0; i < arr.Length; i++)
        for (var j = 0; j < arr.Length - i - 1; j++)
            if (dele(arr[j], arr[j + 1]))
                Swap(ref arr[j], ref arr[j + 1]);
    }


    private static void Swap(ref int x, ref int y)
    {
        (x, y) = (y, x);
    }
}

internal static class Compare
{
    public static bool CompareDesc(int x, int y)
    {
        return x < y;
    }
}

