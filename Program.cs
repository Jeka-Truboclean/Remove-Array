namespace _07._03
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericArray<int> intArray = new GenericArray<int>();

            intArray.Add(10);
            intArray.Add(20);
            intArray.Add(30);

            Console.WriteLine("Elements of int Array:");
            for (int i = 0; i < intArray.Length(); i++)
            {
                Console.WriteLine(intArray.GetElement(i));
            }

            intArray.RemoveAt(1);

            Console.WriteLine("\nElements of intArray after remove:");
            for (int i = 0; i < intArray.Length(); i++)
            {
                Console.WriteLine(intArray.GetElement(i));
            }

            GenericArray<string> stringArray = new GenericArray<string>();

            stringArray.Add("Hello");
            stringArray.Add("World");
            stringArray.Add("!");

            Console.WriteLine("\nElements of string Array:");
            for (int i = 0; i < stringArray.Length(); i++)
            {
                Console.WriteLine(stringArray.GetElement(i));
            }
        }
        public class GenericArray<T>
        {
            private T[] array;

            public GenericArray()
            {
                array = new T[0];
            }
            public void Add(T item)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = item;
            }
            public void RemoveAt(int index)
            {
                T[] newArray = new T[array.Length - 1];
                Array.Copy(array, 0, newArray, 0, index);
                Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
                array = newArray;
            }
            public T GetElement(int index)
            {
                return array[index];
            }
            public int Length()
            {
                return array.Length;
            }
        }
    }
}
