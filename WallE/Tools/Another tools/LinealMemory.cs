using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Представляет линейную память.
    /// </summary>
    public class LinealMemory : ICloneable
    {
        /// <summary>
        /// Массив, представляющий линейную память.
        /// </summary>
        int[] memory;

        /// <summary>
        /// РАзвитие линейную память.
        /// </summary>
        public LinealMemory( )
        {
            this.memory = new int[1000000];
        }

        /// <summary>
        /// Линейный индексатор памяти.
        /// </summary>
        /// <param name="index">индекс линейной памяти.</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if ( index < 0 || index >= 1000000 )
                    throw new IndexOutOfRangeException("Линейный индекс памяти вне допустимого диапазона.");
                return this.memory[index];
            }
            internal set
            {
                if ( index < 0 || index >= 1000000 )
                    throw new IndexOutOfRangeException("Линейный индекс памяти вне допустимого диапазона.");
                this.memory[index] = value;
            }
        }

        /// <summary>
        /// Возвращает новую линейную память.
        /// </summary>
        /// <returns></returns>
        public object Clone( )
        {
            LinealMemory memoryClone = new LinealMemory( );

            for ( int i = 0; i < this.memory.Length; i++ )
                memoryClone[i] = this.memory[i];

            return memoryClone;
        }
    }
}
