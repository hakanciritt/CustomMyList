using System;

namespace CustomMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> listem = new MyList<string>();
            listem.Add("hakan");
            listem.Add("ahmet");
            listem.Add("furkan");

            Console.WriteLine("Adet : " + listem.Count());

            foreach (var item in listem.Listem)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
        }
    }
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public T[] Listem
        {
            get { return items; }
        }

        public int Count()
        {
            return items.Length;
        }
    }
}
