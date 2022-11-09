using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Представляет расширяемое перечисление адресов
    /// </summary>
    public class Direction : EnumBaseType<Direction>
    {
        #region Fields
        public static readonly Direction North = new Direction("North");
        public static readonly Direction East = new Direction("East");
        public static readonly Direction South = new Direction("South");
        public static readonly Direction West = new Direction("West");
        #endregion

        #region Constructor
        public Direction(string value) : base(value) { }
        #endregion

        #region Methods
        /// <summary>
        /// Возвращает коллекцию всех адресов.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Direction> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Возвращает адрес по его ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Direction GetByID(int id) => GetBaseByID(id);
        /// <summary>
        /// Явное приведение целого числа к Direction.
        /// </summary>
        /// <param name="direction"></param>
        public static explicit operator Direction(int direction) => GetByID(direction);
        /// <summary>
        /// Явное приведение Direction к целому числу
        /// </summary>
        /// <param name="direction"></param>
        public static explicit operator int (Direction direction) => direction.ID;
        #endregion
    }
}
