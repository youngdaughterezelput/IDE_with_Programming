using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Набор датчиков, которые может использовать объект.
    /// </summary>
    public interface ISensitive
    {
        /// <summary>
        /// Определяет количество пустых мест от стартовой части 
        /// объекта до ближайшего или конца местности.
        /// </summary>
        /// <returns></returns>
        void Distance( );
        /// <summary>
        /// Определяет цвет объекта перед объектом.
        /// </summary>
        void Color( );
        /// <summary>
        /// Определяет форму объекта перед тем, который реализует интерфейс.
        /// </summary>
        void Shape( );
        /// <summary>
        /// Определяет идентификатор объекта, для которого реализуется интерфейс.
        /// </summary>
        void Code( );
        /// <summary>
        /// Определяет, есть ли внутри объекта другой объект.
        /// </summary>
        void Loaded( );
        /// <summary>
        /// Определяет количество раундов моделирования.
        /// </summary>
        void Time( );
        /// <summary>
        /// Определяет направление объекта в мире
        /// </summary>
        void Direction( );
    }
}
