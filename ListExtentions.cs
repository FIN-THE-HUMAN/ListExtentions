using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtentions
{
    public static class ListExtentions
    {
        public static List<T> Plus<T>(this List<T> array, List<T> list)
        {
            array.AddRange(list);
            return array;
        }

        public static List<double> Plus(this List<double> array, double number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<double> Minus(this List<double> array, double number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<double> Mul(this List<double> array, double number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<double> Div(this List<double> array, double number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<float> Plus(this List<float> array, float number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<float> Minus(this List<float> array, float number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<float> Mul(this List<float> array, float number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<float> Div(this List<float> array, float number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<int> Plus(this List<int> array, int number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<int> Minus(this List<int> array, int number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<int> Mul(this List<int> array, int number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<int> Div(this List<int> array, int number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<long> Plus(this List<long> array, long number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<long> Minus(this List<long> array, long number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<long> Mul(this List<long> array, long number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<long> Div(this List<long> array, long number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<uint> Plus(this List<uint> array, uint number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<uint> Minus(this List<uint> array, uint number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<uint> Mul(this List<uint> array, uint number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<uint> Div(this List<uint> array, uint number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<sbyte> Plus(this List<sbyte> array, sbyte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<sbyte> Minus(this List<sbyte> array, sbyte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<sbyte> Mul(this List<sbyte> array, sbyte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<sbyte> Div(this List<sbyte> array, sbyte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<short> Plus(this List<short> array, short number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<short> Minus(this List<short> array, short number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<short> Mul(this List<short> array, short number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<short> Div(this List<short> array, short number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<byte> Plus(this List<byte> array, byte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<byte> Minus(this List<byte> array, byte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<byte> Mul(this List<byte> array, byte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<byte> Div(this List<byte> array, byte number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<ushort> Plus(this List<ushort> array, ushort number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<ushort> Minus(this List<ushort> array, ushort number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<ushort> Mul(this List<ushort> array, ushort number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<ushort> Div(this List<ushort> array, ushort number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static List<ulong> Plus(this List<ulong> array, ulong number)
        {
            for (int i = 0; i < array.Count; i++) array[i] += number;
            return array;
        }

        public static List<ulong> Minus(this List<ulong> array, ulong number)
        {
            for (int i = 0; i < array.Count; i++) array[i] -= number;
            return array;
        }

        public static List<ulong> Mul(this List<ulong> array, ulong number)
        {
            for (int i = 0; i < array.Count; i++) array[i] *= number;
            return array;
        }

        public static List<ulong> Div(this List<ulong> array, ulong number)
        {
            for (int i = 0; i < array.Count; i++) array[i] /= number;
            return array;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            if (list.Count == 0) return true;
            return false;
        }

        public static List<T> Combine<T>(this List<T> thisList, List<T> list)
        {
            var result = new List<T>();
            result.AddRange(thisList);
            result.AddRange(list);
            return result;
        }

        public static T Max<T>(this List<T> list) where T : IComparable
        {
            if (list.IsEmpty()) return default(T);
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
                if (max.CompareTo(list[i]) < 0)
                    max = list[i];
            return max;
        }

        public static T Min<T>(this List<T> list) where T : IComparable
        {
            if (list.IsEmpty()) return default(T);
            T min = list[0];
            for (int i = 1; i < list.Count; i++)
                if (min.CompareTo(list[i]) > 0)
                    min = list[i];
            return min;
        }

        /// <summary>
        /// Возвращает список без всех вхождений указанного объекта
        /// </summary>
        public static List<T> DeleteAll<T>(this List<T> list, T item)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Equals(item)) result.Add(list[i]);
            }
            return result;
        }

        /// <summary>
        /// Возвращает список со всеми элементами меньше указанного
        /// </summary>
        public static List<T> AllLessThan<T>(this List<T> list, T item) where T : IComparable
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(item) < 0) result.Add(list[i]);
            }
            return result;
        }

        /// <summary>
        /// Возвращает список со всеми элементами удовлетворяющими заданному условию
        /// </summary>
        public static List<T> Where<T>(this List<T> list, Func<T, bool> predicate) where T : IComparable
        {
            List<T> result = new List<T>();
            foreach (var e in list)
                if (predicate(e)) result.Add(e);
            return result;
        }

        public static List<T>[] Split<T>(this List<T> list, int index)
        {
            if (index < 0 || index > list.Count) throw new IndexOutOfRangeException();
            var result = new List<T>[2];

            result[0] = new List<T>();
            result[1] = new List<T>();

            for (int i = 0; i < index; i++) result[0].Add(list[i]);
            for (int i = index; i < list.Count; i++) result[1].Add(list[i]);
            return result;
        }

        public static List<T> SetValues<T>(this List<T> arr, int size, T value)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < size; i++) list.Add(value);
            return list;
        }

        public static T[] SetValues<T>(this T[] arr, int size, T value)
        {
            T[] array = new T[size];
            for (int i = 0; i < size; i++) array[i] = value;
            return array;
        }

        public static string ElementsToString<T>(this List<T> list)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++) sb.Append(list[i].ToString() + " ");
            return sb.ToString();
        }

        public static string ElementsToString<T>(this List<T> list, string format)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++) sb.Append(string.Format(format, list[i]));
            return sb.ToString();
        }

        public static string ElementsToString<T>(this List<T> list, Func<T, string> func)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++) sb.Append(func(list[i]));
            return sb.ToString();
        }

        public static IEnumerable<T> Map<T>(this IEnumerable<T> enumerable, Func<T, T> func)
        {
            var result = new List<T>();
            foreach (var e in enumerable)
                result.Add(func(e));
            return result;
        }

        public static int Size<T>(this IEnumerable<T> enumerable)
        {
            int size = 0;
            foreach (var e in enumerable)
                size++;
            return size;
        }

        public static T Get<T>(this IEnumerable<T> enumerable, int i)
        {
            if (i < 0 || i > enumerable.Size()) throw new IndexOutOfRangeException();
            T result = default(T);
            int index = 0;

            foreach (var e in enumerable)
            {
                if (index == i)
                    return e;

                index++;
            }

            return result;
        }

        private static T _Reduce<T>(this IEnumerable<T> enumerable, Func<T, T, T> func, int index, T temp)
        {
            if (index >= enumerable.Size()) return temp;

            return _Reduce(enumerable, func, index + 1, func(temp, enumerable.Get(index)));
        }

        public static T Reduce<T>(this IEnumerable<T> enumerable, Func<T, T, T> func)
        {
            if (enumerable.Size() <= 0) return default(T);
            if (enumerable.Size() == 1) return enumerable.Get(0);

            return _Reduce(enumerable, func, 1, enumerable.Get(0));
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var e in enumerable) action(e);
        }
        
        public static string ToString<T>(this List<T> list, Func<T, string> func)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var e in list)
                sb.Append(func(e));
            return sb.ToString();  
        }
    }
}
