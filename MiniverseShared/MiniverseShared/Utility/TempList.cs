using System;
using System.Buffers;

namespace MiniverseShared.Utility
{
    public ref struct TempList<T>
    {
        private int index;
        private T[] array;
    
        public ReadOnlySpan<T> Span => array.AsSpan(0, index);
        public int Count => index;

        public TempList(int defaultCapacity = 16)
        {
            this.array = ArrayPool<T>.Shared.Rent(defaultCapacity);
            this.index = 0;
        }

        public void Add(T item)
        {
            if(array.Length <= index)
            {
                var newArray = ArrayPool<T>.Shared.Rent(index * 2);
                Array.Copy(array, newArray, index);
                ArrayPool<T>.Shared.Return(array, true);
                array = newArray;
            }

            array[index++] = item;
        }

        public ref T this[int i]
        {
            get
            {
                if (i < 0 || i >= index)
                    throw new ArgumentOutOfRangeException(nameof(i), $"Index {i} is out of range. Valid range: 0-{index - 1}");
                return ref array[i];
            }
        }

        public void Dispose()
        {
            if(array is null) return;
            ArrayPool<T>.Shared.Return(array, true);
        }

        public ReadOnlySpan<T>.Enumerator GetEnumerator() => Span.GetEnumerator();
    }
}
