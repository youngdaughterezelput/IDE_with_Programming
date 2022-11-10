using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World.WorldObjects;
using System.Collections;

namespace WallE.World
{
    /// <summary>
    /// Представляет собой карту мира Wall-E
    /// </summary>
    public class Map : IEnumerable<WallEObjects>, ICloneable
    {
        #region Fields

        /// <summary>
        /// Представляет карту.
        /// </summary>
        private WallEObjects[,] map;
        #endregion

        #region Properties
        /// <summary>
        /// Количество объектов.
        /// </summary>
        public int CountObjects { get; set; }

        /// <summary>
        /// Представляет количество строк на карте.
        /// </summary>
        public int Rows => this.map.GetLength(0);

        /// <summary>
        /// Представляет количество столбцов на карте.
        /// </summary>
        public int Columns => this.map.GetLength(1);

        /// <summary>
        /// индексатор карт
        /// </summary>
        /// <param name="position">Позиция для индексации.</param>
        /// <returns></returns>
        public WallEObjects this[Position position]
        {
            get
            {
                if ( !IsValidPosition(this,position) )
                    throw new InvalidOperationException("Позиция не корректна.");
                return this.map[position.X,position.Y];
            }
        }

        /// <summary>
        /// индексатор карт
        /// </summary>
        /// <param name="indexRow">Строка для индексации.</param>
        /// <param name="indexColumn">Столбец для индексации.</param>
        /// <returns></returns>
        public WallEObjects this[int indexRow, int indexColumn] => this[new Position(indexRow,indexColumn)];
        #endregion

        #region Constructor
        /// <summary>
        /// Создайте экземпляр карты.
        /// </summary>
        /// <param name="rows">Количество рядов. По умолчанию 10</param>
        /// <param name="columns">Число столбцов. По умолчанию 20.</param>
        public Map(int row = 10,int columns = 20) : this(null,row,columns) { }

        /// <summary>
        /// Создайте экземпляр карты.
        /// </summary>
        /// <param name="knowObjectsPosition">Объекты, которые имеют известное положение.</param>
        /// <param name="rows">количество рядов.</param>
        /// <param name="columns">количество столбцов.</param>
        public Map(Tuple<WallEObjects,Position>[] knowObjectsPosition,int rows = 10,int columns = 20)
        {
            if ( rows <= 0 || columns <= 0 )
                throw new ArgumentException("Параметры не корректны.");
            this.map = new WallEObjects[rows, columns];

            if ( knowObjectsPosition != null )
                this.map = FillWith(map,knowObjectsPosition);
        }
        #endregion

        #region Methods

        #region Controller Wall-E Objects

        /// <summary>
        /// Добавьте новый объект в позицию.
        /// </summary>
        /// <param name="objects">Новый объект.</param>
        /// <param name="position"></param>
        public void AddNewObjectAt(WallEObjects objects)
        {
            if ( !IsValidPosition(this,objects.ObjPosition) )
                throw new InvalidOperationException("Вы не можете добавить объект в неправильное положение.");
            if ( !CanAddAt(objects.ObjPosition) )
                throw new InvalidOperationException("Позиция занята на карте.");

            this.map[objects.ObjPosition.X,objects.ObjPosition.Y] = objects;
            var tempWorld = this;
            objects.AddWorld(ref tempWorld);
            objects.ObjNumber = ++this.CountObjects;
        }
        /// <summary>
        /// Удаляет объект с определенной позиции.
        /// </summary>
        /// <param name="position">Определенное положение.</param>
        public void RemoveAt(Position position,out WallEObjects objects)
        {
            if ( !IsValidPosition(this,position) )
                throw new ArgumentException("Некорректная позиция.");
            objects = this.map[position.X,position.Y];
            if ( objects == null )
                return;
            objects.ObjPosition = new Position(-1,-1);
            this.map[position.X,position.Y] = null;
            this.CountObjects--;
        }
        /// <summary>
        /// Переместите объект из начального положения в конечное положение.
        /// </summary>
        /// <param name="posInitial"></param>
        /// <param name="posEnd"></param>
        internal void MoveObjectTo(Position posInitial,Position posEnd)
        {
            if ( !IsValidPosition(this,posInitial) || !IsValidPosition(this,posEnd) )
                throw new InvalidOperationException("Некорректная позиция.");

            WallEObjects tempObject;
            RemoveAt(posInitial,out tempObject);
            InsertOldObjectAt(tempObject,posEnd);
        }

        #endregion

        #region Auxiliar Methods

        /// <summary>
        /// Добавить объект в положение на карте.
        /// </summary>
        /// <param name="wallEObject">объект для добавления на карту.</param>
        /// <param name="position">Позиция, где вы хотите добавить объект.</param>
        internal void InsertOldObjectAt(WallEObjects wallEObject,Position position)
        {
            if ( IsValidPosition(this,position) && CanAddAt(position) )
            {
                this.map[position.X,position.Y] = wallEObject;
                wallEObject.ObjPosition = position;
            }
            else
                throw new InvalidOperationException("Вы не можете добавить объект в эту позицию.");
        }

        /// <summary>
        /// Определяет, можно ли добавлять объекты WallE в определенное место на карте..
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private bool CanAddAt(Position position)
        {
            return this[position] == null;
        }
        /// <summary>
        ///Вернуть клон карты.
        /// </summary>
        /// <returns></returns>
        public object Clone( )
        {
            Map mapClone = new Map(this.Rows,this.Columns);
            for ( int i = 0; i < this.Rows; i++ )
                for ( int j = 0; j < this.Columns; j++ )
                    if ( this[i,j] != null )
                    {
                        WallEObjects objectTemp = (WallEObjects) this[i,j].Clone( );
                        objectTemp.AddWorld(ref mapClone);
                        mapClone.InsertOldObjectAt(objectTemp,new Position(i,j));
                    }
            return mapClone;
        }
        /// <summary>
        /// Возвращает идентификатор объекта, который находится впереди.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int Scanner(IProgrammable bot)
        {
            if ( bot is ISensitive) //Удалить «бот WallEObjects»
            {
                if ( !Map.IsValidPosition(this,( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)) )
                    return 0;
                if ( this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)] == null )
                    return 0;
                return this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)].ObjNumber;
            }
            throw new InvalidOperationException("Этот объект не реализует этот датчик.");
        }
        /// <summary>
        ///Возвращает количество свободных плиток в мире до ближайшего объекта или до мира.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int ObjectMoreNear(IProgrammable bot)
        {
            if ( bot is ISensitive) //Удалить «бот WallEObjects»
            {
                int countEmptyPosition = 0;

                for ( Position frontPosition = ( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions);
                        Map.IsValidPosition(this,frontPosition) && this[frontPosition] == null;
                            frontPosition = frontPosition.FrontPosition(bot.Directions) )
                    countEmptyPosition++;

                return countEmptyPosition;
            }
            throw new InvalidOperationException("Этот объект не реализует этот датчик.");
        }
        /// <summary>
        /// Возвращает форму объекта перед ним.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int ShapeScanner(IProgrammable bot)
        {
            if ( bot is ISensitive) //Удалить «бот WallEObjects»
            {
                if ( !Map.IsValidPosition(this,( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)) )
                    return 0;
                if ( this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)] == null )
                    return 0;

                return this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)].ObjShape;
            }
            throw new InvalidOperationException("Этот объект не реализует этот датчик.");
        }
        /// <summary>
        /// Возвращает цвет объекта перед ним.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int ColorScanner(IProgrammable bot)
        {
            if ( bot is ISensitive )
            {

                if ( !Map.IsValidPosition(this,( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)) )
                    return 0;
                if ( this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)] == null )
                    return 0;

                return this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)].ObjColor;
            }
            throw new InvalidOperationException("Этот объект не реализует этот датчик.");
        }
        #endregion

        #region Basic type methods
        /// <summary>
        /// Определяет, равен ли объект текущему миру.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Map ) )
                return false;
            if ( this.map.GetLength(0) != ( (Map) obj ).map.GetLength(0) || this.map.GetLength(1) != ( (Map) obj ).map.GetLength(1) )
                return false;

            for ( int i = 0; i < this.map.GetLength(0); i++ )
                for ( int j = 0; j < this.map.GetLength(1); j++ )
                    if ( !this.map[i,j].Equals(( (Map) obj ).map[i,j]) )
                        return false;
            return true;
        }
        /// <summary>
        /// Возвращает хэш-код этого объекта.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode( )
        {
            int i = 0;
            foreach ( var item in this )
                i += ( item.GetHashCode( ) / ( Rows + Columns ) );
            return i;
        }

        /// <summary>
        /// Возвращает строку, представляющую мир.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            string mapString = string.Empty;
            for ( int i = 0; i < this.map.GetLength(0); i++ )
            {
                for ( int j = 0; j < this.map.GetLength(1); j++ )
                {
                    if ( map[i,j] == null )
                        mapString += "-";
                    else
                        mapString += this.map[i,j].ToString( );
                    mapString += "\t" + "||" + "\t";
                }
                mapString += "\n";
            }
            return mapString;
        }
        #endregion

        #region Map Methods
        ///<summary>
        /// Добавьте строку в конец массива.
        /// </summary>
        public void AddLastRow( )
        {
            AddRowAt(this.Rows);
        }
        /// <summary>
        /// Добавляет столбец в конец массива.
        /// </summary>
        public void AddLastColumn( )
        {
            AddColumnAt(this.Columns);
        }

        /// <summary>
        /// Добавляет строку в начало массива.
        /// </summary>
        private void AddFirstRow( )
        {
            WallEObjects[,] result = new WallEObjects[this.Rows + 1, this.Columns];

            for ( int i = 1; i < result.GetLength(0); i++ )
                for ( int j = 0; j < result.GetLength(1); j++ )
                    if ( this.map[i - 1,j] != null )
                    {
                        result[i,j] = this.map[i - 1,j];
                        result[i,j].ObjPosition = new Position(i,j);
                    }
            this.map = result;
        }
        /// <summary>
        /// Добавляет столбец в начало матрицы.
        /// </summary>
        private void AddFirstColumn( )
        {
            WallEObjects[,] result = new WallEObjects[this.Rows, this.Columns + 1];

            for ( int i = 0; i < result.GetLength(0); i++ )
                for ( int j = 1; j < result.GetLength(1); j++ )
                    if ( this.map[i,j - 1] != null )
                    {
                        result[i,j] = this.map[i,j - 1];
                        result[i,j].ObjPosition = new Position(i,j);
                    }
            this.map = result;
        }
        /// <summary>
        /// Добавьте строку в index.
        /// </summary>
        /// <param name="index"></param>
        public void AddRowAt(int index)
        {
            if ( index < 0 )
                AddFirstRow( );
            else
            {
                WallEObjects[,] result;
                if ( index < this.Rows )
                {
                    result = new WallEObjects[this.Rows + 1, this.Columns];

                    for ( int i = 0; i < index; i++ )
                        for ( int j = 0; j < result.GetLength(1); j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                    for ( int i = index + 1; i < result.GetLength(0); i++ )
                        for ( int j = 0; j < result.GetLength(1); j++ )
                            if ( this.map[i - 1,j] != null )
                            {
                                result[i,j] = this.map[i - 1,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                else
                {
                    result = new WallEObjects[index + 1, this.Columns];

                    for ( int i = 0; i < this.Rows; i++ )
                        for ( int j = 0; j < this.Columns; j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                this.map = result;
            }
        }

        /// <summary>
        /// Добавить столбец в индекс.
        /// </summary>
        /// <param name="index"></param>
        public void AddColumnAt(int index)
        {
            if ( index < 0 )
                AddFirstColumn( );
            else
            {
                WallEObjects[,] result;
                if ( index < this.Columns )
                {
                    result = new WallEObjects[this.Rows, this.Columns + 1];

                    for ( int i = 0; i < result.GetLength(0); i++ )
                        for ( int j = 0; j < index; j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                    for ( int i = 0; i < result.GetLength(0); i++ )
                        for ( int j = index + 1; j < result.GetLength(1); j++ )
                            if ( this.map[i,j - 1] != null )
                            {
                                result[i,j] = this.map[i,j - 1];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                else
                {
                    result = new WallEObjects[this.Rows, index + 1];

                    for ( int i = 0; i < this.Rows; i++ )
                        for ( int j = 0; j < this.Columns; j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                this.map = result;
            }
        }

        /// <summary>
        /// Удаляет столбец по указанному индексу.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveColumnAt(int index)
        {
            if ( index <= 0 && this.Columns == 1 )
                throw new InvalidOperationException("Вы не можете удалить единственный столбец.");

            if ( index >= this.Columns )
                throw new InvalidOperationException("Вы не можете удалить несуществующий столбец.");

            WallEObjects[,] mapTemp = new WallEObjects[this.Rows, this.Columns - 1];
            if ( index <= 0 )
            {
                for ( int i = 0; i < this.Rows; i++ )
                    for ( int j = 0; j < this.Columns - 1; j++ )
                        if ( this.map[i,j + 1] != null )
                        {
                            mapTemp[i,j] = this.map[i,j + 1];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }
            }
            else
            {
                for ( int i = 0; i < this.Rows; i++ )
                    for ( int j = 0; j < index; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i,j] = this.map[i,j];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }
                for ( int i = 0; i < this.Rows; i++ )
                    for ( int j = index + 1; j < this.Columns; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i,j - 1] = this.map[i,j];
                            mapTemp[i,j - 1].ObjPosition = new Position(i,j - 1);
                        }
               
            }
            this.map = mapTemp;
        }
        public void RemoveRowAt(int index)
        {
            if ( index <= 0 && this.Rows == 1 )
                throw new InvalidOperationException("Вы не можете удалить единственный ряд.");
            if ( index >= this.Rows )
                throw new InvalidOperationException("Вы не можете удалить несуществующий ряд.");

            WallEObjects[,] mapTemp = new WallEObjects[this.Rows - 1, this.Columns];
            if ( index <= 0 )
            {
                for ( int i = 0; i < this.Rows - 1; i++ )
                    for ( int j = 0; j < this.Columns - 1; j++ )
                        if ( this.map[i + 1,j] != null )
                        {
                            mapTemp[i,j] = this.map[i + 1,j];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }
            }
            else
            {
                for ( int i = 0; i < index; i++ )
                    for ( int j = 0; j < this.Columns; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i,j] = this.map[i,j];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }

                for ( int i = index + 1; i < this.Rows; i++ )
                    for ( int j = 0; j < this.Columns; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i -1,j] = this.map[i,j];
                            mapTemp[i -1,j].ObjPosition = new Position(i-1,j);
                        }
            }
            this.map = mapTemp;
        }
        #endregion

        #region Enumerable
        /// <summary>
        /// Возвращает перечисление мира.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<WallEObjects> GetEnumerator( )
        {
            return new MapEnumerator(map);
        }
        /// <summary>
        /// Возвращает перечисление мира.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        /// <summary>
        /// Возвращает перечислимое с IProgrammables мира.
        /// </summary>
        /// <returns></returns>
        public List<IProgrammable> SelectIProgrammables( )
        {
            IEnumerable<WallEObjects> iProgrammable = this.Where((c) => c is IProgrammable);
            List<IProgrammable> result = new List<IProgrammable>( );
            foreach ( var item in iProgrammable )
                result.Add(item as IProgrammable);
            return result;
        }
        #endregion

        #endregion

        #region Static Methods
        /// <summary>
        /// Заполнить карту известными объектами.
        /// </summary>
        /// <param name="map">Карта создана пустой.</param>
        /// <param name="knowObjectsPosition">Объекты, положение которых известно.</param>
        /// <returns></returns>
        private WallEObjects[,] FillWith(WallEObjects[,] map,Tuple<WallEObjects,Position>[] knowObjectsPosition)
        {
            WallEObjects[,] result = new WallEObjects[map.GetLength(0), map.GetLength(1)];
            for ( int i = 0; i < knowObjectsPosition.Length; i++, ++this.CountObjects )
            {
                result[knowObjectsPosition[i].Item2.X,knowObjectsPosition[i].Item2.Y] = knowObjectsPosition[i].Item1;
                knowObjectsPosition[i].Item1.ObjNumber = CountObjects;
            }
            return result;
        }
        /// <summary>
        /// Определяет заданную карту и позицию, если она действительна.
        /// </summary>
        /// <param name="map">Карта мира.</param>
        /// <param name="position">Позиция для проверки.</param>
        /// <returns></returns>
        public static bool IsValidPosition(Map map,Position position)
        {
            return position.X >= 0 && position.X < map.Rows && position.Y >= 0 && position.Y < map.Columns;
        }
        internal bool InLineSphere(Position position,int direction,out Position lastEmptyPosition)
        {
            //Пока позиция действительна и то, что находится перед ней, является шаром или пусто...
            while ( Map.IsValidPosition(this,position.FrontPosition(direction))
                && ( this[position.FrontPosition(direction)] is Sphere
                    || this[position.FrontPosition(direction)] == null ) )
            {
                //Если следующее поле пусто, то если условие выполнено
                if ( this[position.FrontPosition(direction)] == null )
                {
                    lastEmptyPosition = position.FrontPosition(direction);
                    return true;
                }
                else if ( this[position.FrontPosition(direction)].ObjSize == (int) Sizes.Small || this[position.FrontPosition(direction)].ObjSize == (int) Sizes.Medium )
                    position = position.FrontPosition(direction);
            }
            lastEmptyPosition = new Position(-1,-1);
            return false;
        }

        #endregion

       
    }
    class MapEnumerator : IEnumerator<WallEObjects>
    {
        WallEObjects current;
        bool move;
        WallEObjects[,] map;
        Queue<WallEObjects> wObjects;

        public MapEnumerator(WallEObjects[,] map)
        {
            this.map = map;
            wObjects = SelectObjects( );
        }
        public WallEObjects Current
        {
            get
            {
                if ( !move )
                    throw new InvalidOperationException("Не выполнил MoveNext()");
                return current;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose( ) { }

        public bool MoveNext( )
        {
            if ( wObjects.Count == 0 )
                return move = false;
            current = wObjects.Dequeue( );
            return move = true;
        }

        public void Reset( )
        {
            this.current = null;
            this.move = false;
            wObjects = SelectObjects( );
        }

        private Queue<WallEObjects> SelectObjects( )
        {
            Queue<WallEObjects> tempWObjects = new Queue<WallEObjects>( );
            for ( int i = 0; i < map.GetLength(0); i++ )
                for ( int j = 0; j < map.GetLength(1); j++ )
                    if ( map[i,j] != null )
                        tempWObjects.Enqueue(map[i,j]);
            return tempWObjects;
        }
    }
}
