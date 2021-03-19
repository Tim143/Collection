using System.Collections;

namespace Collection
{
    public interface ISuperCollection<T>: IEnumerator,IEnumerable
    {
        void AddElement(T element);

        void RemoveElement();

        void RemoveAllElements();

        void Sort();

        void FindElement();
    }
}