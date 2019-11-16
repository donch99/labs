using System;

namespace lab3
{
    /// <summary>
    /// Элемент списка
    /// </summary>
    public class mListItem<T>
    {
        /// <summary>
        /// Данные
        /// </summary>
        public T data { get; set; }

        /// <summary>
        /// Следующий элемент
        /// </summary>
        public mListItem<T> next { get; set; }

        ///конструктор
        public mListItem(T param)
        {
            this.data = param;
        }
    }
}
