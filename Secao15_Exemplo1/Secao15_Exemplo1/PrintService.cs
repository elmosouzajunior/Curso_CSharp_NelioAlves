using System;

namespace Secao15_Exemplo1
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print service is full");
            }
            else
            {
                _values[_count] = value;
                _count++;
            }
        }
        
        public T First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count; i++)
            {
                if (i < _count - 1)
                {
                    Console.Write(_values[i] + ", ");
                }
                else
                {
                    Console.Write(_values[i]);
                }
            }
            Console.WriteLine("]");
        }
    }
}
