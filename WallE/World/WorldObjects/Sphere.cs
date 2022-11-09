using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;

namespace WallE.World.WorldObjects
{
    /// <summary>
    /// Сфера
    /// </summary>
    public class Sphere : WallEObjects
    {

        #region Properties
        public override bool IsLoad => this.ObjSize == (int) Sizes.Small;

        public override bool IsObstacle => false;
        #endregion

        #region Constructors
        /// <summary>
        /// Создайте экземпляр сферы.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        public Sphere(Position position,ref Map world,int size = 2,int color = 1) : base(1,size,color,position,ref world) { }
        public Sphere( int size = 2, int color = 1 ) : base(1, size, color)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Возвращает строку, представляющую сферу.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return base.ToString( );
        }

        /// <summary>
        /// Определяет, равен ли экземпляр объекту.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Sphere ) )
                return false;
            return ( this.ObjSize == ( (Sphere) obj ).ObjSize && this.ObjColor == ( (Sphere) obj ).ObjColor && this.ObjNumber == ( (Sphere) obj ).ObjNumber );
        }
        public override int GetHashCode( )
        {
            return base.GetHashCode( );
        }
        /// <summary>
        /// Возвращает клон  растения.
        /// </summary>
        /// <returns></returns>
        public override object Clone( )
        {
            return new Sphere(this.ObjSize,this.ObjColor) { ObjNumber = this.ObjNumber };
        }

        public override bool IsMovable(Direction direction)
        {
            Position frontPosition = ObjPosition.FrontPosition(direction.ID);

            if ( !Map.IsValidPosition(world,frontPosition) )
                return false;
            else if ( this.world[frontPosition] == null )
                return true;
            else if ( this.world[frontPosition] is Sphere && this.world[frontPosition].ObjSize != (int) Sizes.Large )
                return ( (Sphere) this.world[frontPosition] ).IsMovable(direction);
            else
                return false;
        }


        #endregion
    }
}
