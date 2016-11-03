using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public static class LinqExtensions
    {
        public static ISender<T> Aggregate<T> (this ISender<T> sender, Func<T, T, T> predicate)
        {
            return new AggregateMessenger<T>(sender, predicate);
        }

        public static ISender<bool> All<T> (this ISender<T> sender, Func<T, bool> predicate)
        {
            return new AllMessenger<T>(sender, predicate);
        }

        public static ISender<bool> Any<T> (this ISender<T> sender, Func<T, bool> predicate)
        {
            return new AnyMessenger<T>(sender, predicate);
        }

        public static ISender<TResult> Cast<TSource, TResult> (this ISender<TSource> sender) where TSource : TResult
        {
            return new CastMessenger<TSource, TResult>(sender);
        }

        public static ISender<T> Concat<T> (this ISender<T> sender, ISender<T> other)
        {
            return new ConcatMessenger<T>(sender, other);
        }

        public static ISender<bool> Contains<T> (this ISender<T> sender, T value) where T : IEquatable<T>
        {
            return new ContainsMessenger<T>(sender, value);
        }

        public static ISender<int> Count<T> (this ISender<T> sender)
        {
            return new CountMessenger<T>(sender);
        }

        public static ISender<T> First<T>(this ISender<T> sender)
        {
            return new TakeMessenger<T>(sender, 1);
        }

        public static ISender<T> Max<T>(this ISender<T> sender) where T : IComparable<T>
        {
            return new MaxMessenger<T>(sender);
        }

        public static ISender<T> Distinct<T>(this ISender<T> sender)
        {
            return new DistinctMessenger<T>(sender);
        }

        public static ISender<IGrouping<TKey, T>> GroupBy<T, TKey>(this ISender<T> sender, Func<T, TKey> predicate)
        {
            return new GroupByMessenger<T, TKey>(sender, predicate);
        }

        public static ISender<IGrouping<int, T>> GroupOf<T>(this ISender<T> sender, int count)
        {
            return new GroupOfMessenger<T>(sender, count);
        }

        public static ISender<IGrouping<TKey, T>> GroupWhen<T, TKey>(this ISender<T> sender, ISender<TKey> trigger)
        {
            return new GroupWhenMessenger<T, TKey>(sender, trigger);
        }

        public static ISender<T> Max<T, TCompare>(this ISender<T> sender, Func<T, TCompare> predicate) where TCompare : IComparable<TCompare>
        {
            return new MinSelectMessenger<T, TCompare>(sender, predicate);
        }

        public static ISender<T> Min<T>(this ISender<T> sender) where T : IComparable<T>
        {
            return new MinMessenger<T>(sender);
        }

        public static ISender<T> Min<T, TCompare>(this ISender<T> sender, Func<T, TCompare> predicate) where TCompare : IComparable<TCompare>
        {
            return new MinSelectMessenger<T, TCompare>(sender, predicate);
        }

        public static ISender<TResult> Pair<TSource, TOther, TResult>(this ISender<TSource> sender, ISender<TOther> other, Func<TSource, TOther, TResult> predicate)
        {
            return new PairMessenger<TSource, TOther, TResult>(sender, other, predicate);
        }

        public static ISender<T> QueueBy<T, TKey>(this ISender<T> sender, Func<T, TKey> predicate)
        {
            return new QueueByMessenger<T, TKey>(sender, predicate);
        }

        public static ISender<T> QueueOf<T>(this ISender<T> sender, int count)
        {
            return new QueueOfMessenger<T>(sender, count);
        }

        public static ISender<T> QueueWhen<T, TKey>(this ISender<T> sender, ISender<TKey> trigger)
        {
            return new QueueWhenMessenger<T, TKey>(sender, trigger);
        }

        public static ISender<TResult> Select<TSource, TResult> (this ISender<TSource> sender, Func<TSource, TResult> predicate)
        {
            return new SelectMessenger<TSource, TResult>(sender, predicate);
        }

        public static ISender<TResult> SelectMany<TSource, TResult> (this ISender<TSource> sender, Func<TSource, IEnumerable<TResult>> predicate)
        {
            return new SelectManyMessenger<TSource, TResult>(sender, predicate);
        }

        public static ISender<T> Skip<T> (this ISender<T> sender, int count)
        {
            return new SkipMessenger<T>(sender, count);
        }

        public static ISender<T> SkipWhile<T> (this ISender<T> sender, Func<T, bool> predicate)
        {
            return new SkipWhileMessenger<T>(sender, predicate);
        }

        public static ISender<T> Sum<T> (this ISender<T> sender) where T : struct
        {
            return new SumMessenger<T>(sender);
        }

        public static ISender<T> Take<T> (this ISender<T> sender, int count)
        {
            return new TakeMessenger<T>(sender, count);
        }

        public static ISender<T> TakeWhile<T> (this ISender<T> sender, Func<T, bool> predicate)
        {
            return new TakeWhileMessenger<T>(sender, predicate);
        }

        public static ISender<T> Where<T> (this ISender<T> sender, Func<T, bool> predicate)
        {
            return new WhereMessenger<T>(sender, predicate);
        }

        public static ISender<TResult> Zip<TSource, TOther, TResult>(this ISender<TSource> sender, ISender<TOther> other, Func<TSource, TOther, TResult> predicate)
        {
            return new ZipMessenger<TSource, TOther, TResult>(sender, other, predicate);
        }
    }
}