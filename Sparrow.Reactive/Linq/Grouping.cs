using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Reactive.Linq
{
    public class Grouping<TKey, TElement> : IGrouping<TKey, TElement> {
        public TKey Key { get; set; }
        public List<TElement> elements;

        public IEnumerator<TElement> GetEnumerator() {
            return this.elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}