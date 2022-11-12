using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Представляет все цвета, которые могут иметь объекты.
    /// </summary>
    public class Colors : EnumBaseType<Colors>
    {

        public readonly static Colors Transparent = new Colors("Transparent");
        public readonly static Colors Red = new Colors("Red");
        public readonly static Colors Yellow = new Colors("Yellow");
        public readonly static Colors Green = new Colors("Green");
        public readonly static Colors Blue = new Colors("Blue");
        //public readonly static Colors Brown = new Colors("Brown");
        //public readonly static Colors Black = new Colors("Black");
        //public readonly static Colors White = new Colors("White");

        public Colors(string value) : base(value)
        {
        }
        /// <summary>
        /// Возвращает коллекцию всех возможных значений цвета.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Colors> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Возвращает цвет по его идентификатору.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Colors GetByID(int id) => GetBaseByID(id);

        /// <summary>
        /// Явное приведение из целого числа к цвету.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Colors(int id) => GetBaseByID(id);

        /// <summary>
        /// Явное приведение цветов к целому числу
        /// </summary>
        /// <param name="color"></param>
        public static explicit operator int (Colors color) => color.ID;
    }
}
