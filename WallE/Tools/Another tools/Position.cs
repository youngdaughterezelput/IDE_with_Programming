using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Представляет позиции в двумерном массиве
    /// </summary>
    public class Position : ICloneable
    {
        #region Fields
        /// <summary>
        /// Представлять позицию в двумерном массиве
        /// </summary>
        int x;
        /// <summary>
        /// Представляет координаты осей Y.
        /// </summary>
        int y;
        #endregion

        #region Properties
        /// <summary>
        /// Представляет координаты осей X.
        /// </summary>
        public int X
        {
            get { return this.x; }
            private set
            {
                if ( value < -1 )
                    throw new ArgumentException("Координата Х не корректна.");
                this.x = value;
            }
        }
        /// <summary>
        /// Представляет координаты осей Y.
        /// </summary>
        public int Y
        {
            get { return this.y; }
            private set
            {
                if ( value < -1 )
                    throw new ArgumentException("Координата Y не корректна.");
                this.y = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Выстроить правильную позицию.
        /// </summary>
        /// <param name="axisX">Координация X.</param>
        /// <param name="axisY">Координация Y.</param>
        public Position(int axisX = 0,int axisY = 0)
        {
            this.X = axisX;
            this.Y = axisY;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Определяет, равен ли объект текущей позиции.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Position ) )
                return false;
            return this.X == ( (Position) obj ).X && this.Y == ( (Position) obj ).Y;
        }
        public override int GetHashCode( )
        {
            return base.GetHashCode( );
        }
        /// <summary>
        /// Возвращает строку, представляющую эту позицию.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return this.X.ToString( ) + " " + this.Y.ToString( );
        }
        public Position FrontPosition(int direction)
        {
            return new Position(X + DirectionalArray.Indexer(direction).Item1,Y + DirectionalArray.Indexer(direction).Item2);
        }
        public Position BackPosition(int directionInverse)
        {
            return new Position(X + DirectionalArray.Indexer(directionInverse != 2 ? directionInverse + 2 : directionInverse == 2 ? 0 : 1).Item1,
                                                    Y + DirectionalArray.Indexer(directionInverse != 2 ? directionInverse + 2 : directionInverse == 2 ? 0 : 1).Item2);
        }

        public object Clone( )
        {
            return new Position(this.X,this.Y);
        }
        #endregion
    }
}
