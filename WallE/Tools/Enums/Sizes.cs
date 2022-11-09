using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Представляет все размеры, которые могут иметь объекты.
    /// </summary>
    public class Sizes : EnumBaseType<Sizes>
    {
        public readonly static Sizes Empty = new Sizes("Empty");
        public readonly static Sizes Small = new Sizes("Small");
        public readonly static Sizes Medium = new Sizes("Medium");
        public readonly static Sizes Large = new Sizes("Large");

        public Sizes(string value) : base(value)
        {

        }
        /// <summary>
        /// Возвращает коллекцию всех возможных значений размера.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Sizes> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Возвращает размер по его идентификатору.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Sizes GetByID(int id) => GetBaseByID(id);
        /// <summary>
        /// Явное приведение из целого числа к размеру.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Sizes(int id) => GetByID(id);

        /// <summary>
        /// Явное приведение Size к целому числу
        /// </summary>
        /// <param name="size"></param>
        public static explicit operator int (Sizes size) => size.ID;
    }
}
