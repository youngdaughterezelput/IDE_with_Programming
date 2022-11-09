using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Он представляет все формы, которые могут иметь объекты.
    /// </summary>
    public class Shapes : EnumBaseType<Shapes>
    {
        #region Fields
        public static readonly Shapes Nothing = new Shapes("Empty");
        public static readonly Shapes Sphere = new Shapes("Sphere");
        public static readonly Shapes Box = new Shapes("Box");
        public static readonly Shapes Plant = new Shapes("Plant");
        public static readonly Shapes Robot = new Shapes("Robot");
        #endregion

        #region Constructor
        public Shapes(string value) : base(value) { }
        #endregion

        #region Methods
        /// <summary>
        /// Возвращает коллекцию всех возможных значений формы.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Shapes> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Возвращает форму по ее идентификатору.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Shapes GetByID(int id) => GetBaseByID(id);
        /// <summary>
        /// Явное приведение целого числа к Shape.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Shapes(int id) => (Shapes) GetByID(id);
        /// <summary>
        /// Явное приведение фигур к целому числу
        /// </summary>
        /// <param name="shape"></param>
        public static explicit operator int (Shapes shape) => shape.ID;
        #endregion
    }
}
