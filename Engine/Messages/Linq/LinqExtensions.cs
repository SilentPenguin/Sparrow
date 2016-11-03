using System;

namespace Sparrow.Messages.Linq
{
    public static class LinqExtensions
    {
        public static ISender<TResult> Cast<TSource, TResult> (this ISender<TSource> sender) where TSource : TResult
        {
            return new CastMessenger<TSource, TResult>(sender);
        }

        public static ISender<T> Concat<T> (this ISender<T> sender, ISender<T> other)
        {
            return new ConcatMessenger<T>(sender, other);
        }

        public static ISender<TResult> Select<TSource, TResult> (this ISender<TSource> sender, Func<TSource, TResult> predicate)
        {
            return new SelectMessenger<TSource, TResult>(sender, predicate);
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