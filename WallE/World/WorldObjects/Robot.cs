using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Rout;
using WallE.Simulator;

namespace WallE.World.WorldObjects
{
    public class Robot : WallEObjects, ISensitive, IProgrammable, ILoader
    {
        #region Fields
        public override string MainCharacteristics => (Shapes) this.ObjShape + "_" + (Colors) this.ObjColor;

        /// <summary>
        /// Представляет встроенный объект внутри робота.
        /// </summary>
        WallEObjects objectsInside;

        /// <summary>
        /// Представляет стек роботов.
        /// </summary>
        public Stack<int> Stack { get; set; }

        /// <summary>
        /// Представляет собой стек подпрограмм, которые выполняются при моделировании мира.
        /// </summary>
        public Stack<Proc> ExecutingStack { get; set; }

        /// <summary>
        /// Представляет линейную память робота.
        /// </summary>
        public LinealMemory Memory { get; set; }

        /// <summary>
        /// Количество раундов моделирования роботов.
        /// </summary>
        int time;
        #endregion

        #region Properties
        /// <summary>
        /// Представляет список подпрограмм робота.
        /// </summary>
        public ProcList ListRout { get; set; }

        /// <summary>
        /// Количество раундов моделирования роботов.
        /// </summary>
        public int Times
        {
            get
            { return time; }
            set
            {
                if ( value < 0 )
                    throw new ArgumentException("Круг не корректный.");
                this.time = value;
            }
        }

        /// <summary>
        /// Определяет адрес робота в мире.
        /// </summary>
        public int Directions { get; set; }

        /// <summary>
        /// Представляет объект, который находится у робота.
        /// </summary>
        public WallEObjects ObjectInside
        {
            get { return this.objectsInside; }
            set
            {
                if ( value is IProgrammable )
                    throw new InvalidOperationException("Робот не может взаимодействовать с другим программируемым объектом. В этом случае: " + value.ToString( ) + ".");
                this.objectsInside = value;
            }
        }

        /// <summary>
        /// Определить, является ли этот объект препятствием
        /// </summary>
        public override bool IsObstacle => true;

        public override bool IsLoad => false;


        #endregion

        #region Constructors
        /// <summary>
        /// Создание экземпляра робота.
        /// </summary>
        /// <param name="number">ID  robot.</param>
        /// <param name="List">Список процедур робота</param>
        /// <param name="direction">Адрес робота в мире.</param>
        public Robot(Position position,ref Map world,int direction = 1,int color = 1) : base(4,3,color,position,ref world)
        {
            this.ListRout = new ProcList( );
            this.ListRout.bot = this;
            this.Directions = direction;
            this.Memory = new LinealMemory( );
            this.Stack = new Stack<int>( );
            this.ExecutingStack = new Stack<Proc>( );
            this.time = 0;
        }

        public Robot(int direction = 1,int color = 1) : base(4,3,color)
        {
            this.ListRout = new ProcList( );
            this.ListRout.bot = this;
            this.Directions = direction;
            this.Memory = new LinealMemory( );
            this.Stack = new Stack<int>( );
            this.ExecutingStack = new Stack<Proc>( );
            this.time = 0;
        }
        #endregion

        #region Methods
        #region Implement of ISensor
        /// <summary>
        /// Стек адрес робота в мире.
        /// </summary>
        public void Direction( )
        {
            try { this.Stack.Push(Directions); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        public void Time( )
        {
            try { this.Stack.Push(Times); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        /// <summary>
        /// Расстояние от робота до ближайшего объекта или до края мира.
        /// </summary>
        /// <returns></returns>
        public void Distance( )
        {
            try { this.Stack.Push(this.world.ObjectMoreNear(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        /// <summary>
        /// Определяет цвет объекта перед роботом.
        /// </summary>
        public void Color( ) {
            try
            { this.Stack.Push(this.world.ColorScanner(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        /// <summary>
        /// Сложите форму объекта впереди.
        /// </summary>
        public void Shape( ) {
            try
            { this.Stack.Push(this.world.ShapeScanner(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        /// <summary>
        /// Определяет ID объекта впереди.
        /// </summary>
        public void Code( ) {
            try
            { this.Stack.Push(this.world.Scanner(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        /// <summary>
        ///Определите, есть ли внутри этого робота предмет.
        /// </summary>
        public void Loaded( )
        {
            try {
                if ( this.ObjectInside == null )
                    this.Stack.Push(0);
                this.Stack.Push(1); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("Стек заполнен, поэтому вы не сможете добавить это значение."));
            }
        }
        #endregion

        #region Basic type
        /// <summary>
        /// Возвращает строку экземпляра робота.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return (Shapes) this.ObjShape + " " + this.ObjNumber + " " + (Colors) this.ObjColor + " " + (Direction) this.Directions;
        }
        /// <summary>
        /// Определяет, равен ли экземпляр робота другому объекту.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Robot ) )
                return false;
            return this.Equals(obj as Robot);
        }
        private bool Equals(Robot robot) => this.ObjNumber == robot.ObjNumber;
        public override int GetHashCode( )
        {
            return 7 * this.ObjNumber;
        }
        public override object Clone( )
        {
            Robot robotClone = new Robot(this.Directions);
            robotClone.ObjColor = this.ObjColor;
            robotClone.ObjNumber = this.ObjNumber;
            if ( this.ObjectInside != null )
                robotClone.ObjectInside = (WallEObjects) this.ObjectInside.Clone( );
            robotClone.Memory = (LinealMemory) this.Memory.Clone( );
            robotClone.ListRout = (ProcList) this.ListRout.Clone( );
            robotClone.ListRout.bot = robotClone;

            return robotClone;
        }
        #endregion
        #endregion

        #region Physic methods
        public virtual void Back( )
        {
            Position backPosition = ObjPosition.BackPosition(this.Directions);

            if ( this.IsMovable((Direction) ( Directions == 2 ? 0 : Directions == 3 ? 1 : Directions + 2 )) )
            {
                this.world.MoveObjectTo(ObjPosition,backPosition);
                this.ObjPosition = backPosition;
            }
        }
        public virtual void Advance( )
        {
            Position frontPosition = ObjPosition.FrontPosition(Directions);

            if ( !IsMovable((Direction) Directions) )
                return;
            //Если впереди никого нет
            if ( world[frontPosition] == null )
                world.MoveObjectTo(ObjPosition,frontPosition);
            //Если то, что впереди, загружаемое, а робот пустой
            else if ( this.world[frontPosition].IsLoad && this.ObjectInside == null )
            {
                this.world.RemoveAt(frontPosition,out this.objectsInside);
                this.world.MoveObjectTo(ObjPosition,frontPosition);
            }
            //Если то, что находится впереди, является Sphere, то оно продвигается
            else if ( this.world[frontPosition] is Sphere && this.world[frontPosition].IsMovable((Direction) Directions) )
            {
                Position lastEmptyPosition;

                if ( world.InLineSphere(frontPosition,Directions,out lastEmptyPosition) )
                {
                    Position tempObjPosition = (Position) ObjPosition.Clone( );
                    while ( !lastEmptyPosition.Equals(tempObjPosition) )
                    {
                        world.MoveObjectTo(lastEmptyPosition.BackPosition(Directions),lastEmptyPosition);
                        lastEmptyPosition = lastEmptyPosition.BackPosition(Directions);
                    }
                }
            }
            //Если то, что находится впереди, является объектом, который не может быть перемещен или является препятствием из-за его собственных характеристик,
            //никакого прогресса не происходит.
            else if ( ( this.ObjectInside != null && this.world[frontPosition].IsLoad )
                || this.world[frontPosition].IsObstacle )
                return;
            //Если то, что находится перед вами, подвижно, то двигайтесь вперед.
            else if ( this.world[frontPosition].IsMovable((Direction) Directions) )
            {
                world.MoveObjectTo(frontPosition,frontPosition.FrontPosition(Directions));
                world.MoveObjectTo(ObjPosition,frontPosition);
            }
            else return;
        }
        public void Drop( )
        {
            Position frontPosition = ObjPosition.FrontPosition(Directions);

            if ( Map.IsValidPosition(world,frontPosition) )
                //Если робот "наехал" на объект...
                if ( this.ObjectInside != null && world[frontPosition] == null )
                {
                    //Если объект никогда не был в мире, добавьте к нему идентификатор (на случай, если робот запустится с объектом внутри.)
                    if ( this.ObjectInside.ObjNumber == 0 )
                        this.ObjectInside.ObjNumber = this.world.CountObjects++;
                    //Бросьте предмет  перед собой...
                    world.InsertOldObjectAt(this.ObjectInside,frontPosition);
                    this.ObjectInside = null;
                }
        }
        public override bool IsMovable(Direction direction)
        {
            Position frontPosition = ObjPosition.FrontPosition(direction.ID);

            return Map.IsValidPosition(world,frontPosition) && ( world[frontPosition] == null || world[frontPosition].IsMovable(direction) );
        }
        #endregion
    }
}

