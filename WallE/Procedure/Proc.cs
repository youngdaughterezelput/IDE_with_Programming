using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using WallE.Tools;
using WallE.MATLAN;
using WallE.MATLAN.Instructions;
using WallE.World.WorldObjects;

namespace WallE.Routine
{
    /// <summary>
    /// Процедура в ML
    /// </summary>
    public class Proc : ICloneable, IEnumerable<Instruction>
    {
        #region Fields
        /// <summary>
        /// Представляет перчисленные подпрограммы.
        /// </summary>
        private IEnumerator<Instruction> enumerator;
        #endregion

        #region Properties
        /// <summary>
        /// Основной блок
        /// </summary>
        public MatrixInstruction Body { get; private set; }
        /// <summary>
        /// Имя подпрограммы не является обязательным, оно используется только для различения подпрограмм и для сохранения подпрограммы с именем..
        /// </summary>
        public string Name { get; set; }

        ///<summary>
        /// Записи о процедуре.
        /// </summary>
        public Registry RegistryRoutine { get; internal set; }

        /// <summary>
        /// Целое число, указывающее индекс этой процедуры в списке роботов.
        /// </summary>
        public int Index { get; internal set; }
        /// <summary>
        /// Робот, с которым связана эта процедура.
        /// </summary>
        internal IProgrammable RobotRoutine { get; set; }
        /// <summary>
        /// Определяет, выполняется ли процедура в данный момент.
        /// </summary>
        public bool Executing { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Постройка процедуры
        /// </summary>
        public Proc( )
        {
            Simulator.Simulator.Error += StopExecutingByError;
            this.Body = new MatrixInstruction(0,0);
            this.RegistryRoutine = new Registry( );
            this.Name = string.Empty;
        }
        /// <summary>
        /// Создайте процедуру, учитывая набор инструкций.
        /// </summary>
        /// <param name="body"></param>
        public Proc(Proc.MatrixInstruction body)
        {
            this.Body = body;
            this.RegistryRoutine = new Registry( );
        }
        /// <summary>
        /// Создайте подпрограмму с пустым массивом и именем
        /// </summary>
        /// <param name="name">Имя массива.</param>
        public Proc(string name) : this( )
        {
            this.Name = name;
        }
        #endregion

        #region Event
        /// <summary>
        /// Событие, которое будет запускаться каждый раз, когда передается новая инструкция.
        /// </summary>
        public static event EventHandler ExecuteInstruction;
        /// <summary>
        /// Позиция последней выполненной инструкции, для которой срабатывает событие
        /// </summary>
        public static Position LastInstruction { get; private set; }
        /// <summary>
        /// Метод, запускающий событие ExecuteInstruction
        /// </summary>
        /// <param name="routine">Подпрограмма, которая выполняет инструкцию</param>
        /// <param name="instructionPosition">Позиция инструкции в программе.</param>
        public static void Executed(Proc routine,Position instructionPosition)
        {
            LastInstruction = instructionPosition;
            ExecuteInstruction(routine,new EventArgs( ));
            LastInstruction = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Запустите процедуру 
        /// </summary>
        public void Execute( )
        {
            //Пока подпрограмма выполняется, то есть возврат не был достигнут, или массив был исчерпан, или было достигнуто физическое действие.
            while ( Executing )
            {

                //Выполнить инструкцию, если на этом она завершает текущее выполнение, выйти из цикла.
                if ( ExecuteByInstruction( ) )
                    break;

                if ( !Executing )
                {
                    enumerator = null;
                    break;
                }
            }
        }
        /// <summary>
        /// Если возникает ошибка, он останавливает выполнение этой процедуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopExecutingByError(object sender,EventArgs e)
        {
            ( (IProgrammable) sender ).ExecutingStack.Peek( ).Executing = false;
        }
        /// <summary>
        /// Выполняет только следующую инструкцию подпрограммы и возвращает значение, 
        /// если при этом выполнении подпрограммы прекращается или не прекращается мгновенно.
        /// </summary>
        /// <returns></returns>
        public bool ExecuteByInstruction( )
        {
            if ( enumerator == null )
                GetEnumerator( );

            //я двигаю указатель
            enumerator.MoveNext( );
            //Если он не перемещается, это потому, что он вышел за границы массива, поэтому выполнение завершается, возвращая значение true.
            if ( !( (MatrixInstruction.MatrixEnumerator) enumerator ).Move )
            {
                Executing = false;
                return true;
            }

            //Инициировать событие ExecuteInstruction 
            Executed(this,this.Body.Flux.Position);

            //Если оператор пуст, это пустое место, которое возвращает false.
            if ( enumerator.Current == null )
                return false;

            //В противном случае запустите его.
            enumerator.Current.Execute(RobotRoutine);

            if ( !RobotRoutine.ExecutingStack.Peek( ).Equals(this) && RobotRoutine.ExecutingStack.Peek( ).Executing )
                return true;
            //Если то, что находится наверху стека, не выполняется, и это именно эта подпрограмма, она завершается, возвращая false.
            if ( !RobotRoutine.ExecutingStack.Peek( ).Executing && RobotRoutine.ExecutingStack.Peek( ).Equals(this) )
                return false;

            //Если было выполнено действие, оно в конечном итоге возвращает значение true.
            if ( enumerator.Current is IAction )
                return true;
            return false;
        }
        /// <summary>
        /// Сохраните процедуру в .txt
        /// </summary>
        /// <param name="pathInitial">Адрес, по которому вы хотите сохранить процедуру.</param>
        public void SaveRoutine(string pathInitial)
        {
            ControllerRoutine.SaveRoutine(this,pathInitial);
        }
        /// <summary>
        /// Возвращает строку, представляющую подпрограмму.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            string s = this.Body.CountInstruction.ToString( );
            for ( int i = 0; i < this.Body.Row; i++ )
                for ( int j = 0; j < this.Body.Column; j++ )
                    if ( this.Body[new Position(i,j)] != null )
                        s += "\n" + new Position(i,j).ToString( ) + " " + this.Body[new Position(i,j)].ToString( );
            return s;
        }
        /// <summary>
        /// Две подпрограммы равны, если они имеют одно и то же тело оператора.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Proc ) )
                return false;
            return this.Body.Equals(( (Proc) obj ).Body);
        }
        public override int GetHashCode( )
        {
            return (int) Math.Sqrt(( this.Body.GetHashCode( ) + this.RegistryRoutine.GetHashCode( ) ));
        }
        /// <summary>
        /// Возвращает другой массив с теми же инструкциями и тем же индексом.
        /// </summary>
        /// <returns></returns>
        public object Clone( )
        {
            var rut = new Proc((MatrixInstruction) this.Body.Clone( ));
            rut.Index = this.Index;
            return rut;
        }

        /// <summary>
        /// Возвращает перечислитель операторов. Изменяет поле перечислителя класса.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Instruction> GetEnumerator( )
        {
            return enumerator = this.Body.GetEnumerator( );
        }
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );
        /// <summary>
        /// Возвращает перечисляемое количество операторов и их положение в массиве.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<Instruction,Position>> GetAllInstructionAndPositions( )
        {
            for ( int i = 0; i < this.Body.Row; i++ )
                for ( int j = 0; j < this.Body.Column; j++ )
                    if ( Body[new Position(i,j)] != null )
                        yield return Tuple.Create(Body[new Position(i,j)],new Position(i,j));
        }
        /// <summary>
        /// Возвращает все инструкции массива, даже если они никогда не доступны потоку, 
        /// то есть возвращает все, что есть в массиве.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Instruction> GetAllInstruction( )
        {
            for ( int i = 0; i < this.Body.Row; i++ )
                for ( int j = 0; j < this.Body.Column; j++ )
                    if ( Body[new Position(i,j)] != null )
                        yield return Body[new Position(i,j)];
        }

        /// <summary>
        /// Проверяет массив, то есть проверяет, что он имеет {start}.
        /// </summary>
        /// <param name="routine"></param>
        /// <returns></returns>
        public static bool ValidateRut(Proc routine)
        {
            return routine.Body.StartPosition != null;
        }
        #endregion 


        /// <summary>
        /// Представляет запись подпрограммы.
        /// </summary>
        public class Registry : ICloneable
        {
            #region Field
            /// <summary>
            /// Записать
            /// </summary>
            private Dictionary<char,int> registry;
            #endregion

            #region Properties
            /// <summary>
            /// Индексация реестра
            /// </summary>
            /// <param name="letter"></param>
            /// <returns></returns>
            public int this[char letter]
            {
                get
                {
                    //Если с этим ключом ничего не было сохранено, возвращается 0.
                    if ( !registry.ContainsKey(letter) )
                        return 0;
                    return registry[letter];
                }
            }
            #endregion

            #region Constructor
            /// <summary>
            /// Создайте регистр емкостью N букв
            /// </summary>
            public Registry( )
            {
                this.registry = new Dictionary<char,int>(26);
            }
            #endregion

            #region Methods
            /// <summary>
            /// Добавить значение в реестр.
            /// </summary>
            /// <param name="letter">Индекс, в который необходимо добавить.</param>
            /// <param name="value">Значение для добавления.</param>
            internal void AddValueAt(char letter,int value)
            {

                if ( !Char.IsLetter(letter) )
                    throw new ArgumentException("Нет определения: ",letter.ToString( ));
                this.registry[letter.ToString().ToUpper().ToCharArray()[0]] = value;
            }

            /// <summary>
            /// Две записи равны, если равны связанные словари.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if ( !( obj is Registry ) )
                    return false;
                return this.registry.Equals(( (Registry) obj ).registry);
            }
            public override int GetHashCode( )
            {
                return 2 * this.registry.GetHashCode( );
            }
            /// <summary>
            /// Возвращает другую запись, но с теми же значениями и ключами.
            /// </summary>
            /// <returns></returns>
            public object Clone( )
            {
                Registry registryClone = new Registry( );
                foreach ( var item in this.registry )
                    registryClone.AddValueAt(item.Key,item.Value);
                return registryClone;
            }
            #endregion
        }
        public class MatrixInstruction : IEnumerable<Instruction>, ICloneable
        {
            #region Properties

            /// <summary>
            /// Матрица инструкций.
            /// </summary>
            internal Instruction[,] Matrix { get; private set; }

            /// <summary>
            /// Количество строк в матрице.
            /// </summary>
            public int Row => this.Matrix.GetLength(0);

            /// <summary>
            /// Количество столбцов в матрице.
            /// </summary>
            public int Column => this.Matrix.GetLength(1);

            /// <summary>
            /// Количество инструкций в массиве.
            /// </summary>
            internal int CountInstruction { get; private set; }

            /// <summary>
            /// Позиция команды Start в массиве.
            /// </summary>
            internal Position StartPosition { get; private set; }
            /// <summary>
            /// Курсор пути в массиве.
            /// </summary>
            internal Pointer Flux { get; private set; }

            #endregion

            #region Constructor
            /// <summary>
            /// Создайте массив инструкций.
            /// </summary>
            /// <param name="row">Количество рядов.</param>
            /// <param name="column">Количество столбцов.</param>
            public MatrixInstruction(int row,int column)
            {
                if ( row < 0 || column < 0 )
                    throw new ArgumentException("Невозможно построить массив операторов с количеством строк или столбцов меньше 0.");

                this.Matrix = new Instruction[row, column];
                this.StartPosition = null;
            }
            #endregion

            #region Methods

            #region Instruction Methods
            /// <summary>
            /// Добавляет оператор Start в заданную позицию.
            /// </summary>
            /// <param name="start"></param>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            private void AddStartAt(int indexRow,int indexColumn)
            {
                IsInside(indexRow,indexColumn);
                if ( this.StartPosition == null )
                {
                    this[indexRow,indexColumn] = new Start( );
                    StartPosition = new Position(indexRow,indexColumn);
                    this.CountInstruction++;
                }
                else
                    throw new InvalidOperationException("Начало.");
            }

            /// <summary>
            ///Добавляет инструкцию в массив в заданной позиции.
            /// </summary>
            /// <param name="instruction">инструкция по добавлению.</param>
            /// <param name="position">Позиция, в которую необходимо добавить инструкцию.</param>
            public void AddInstructionAt(Instruction instruction,Position position) => AddInstructionAt(instruction,position.X,position.Y);
            /// <summary>
            /// Добавляет оператор Start в заданную позицию.
            /// </summary>
            /// <param name="start"></param>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            private void AddInstructionAt(Instruction instruction,int indexRow,int indexColumn)
            {

                //Если позиция не существует, то увеличиваю свой массив и добавляю позицию.
                while ( indexRow >= this.Row )
                    AddLastRow( );
                while ( indexColumn >= this.Column )
                    AddLastColumn( );

                if ( this[indexRow,indexColumn] != null )
                    return;

                if ( instruction is Start )
                {
                    AddStartAt(indexRow,indexColumn);
                    return;
                }

                this[indexRow,indexColumn] = instruction;
                this.CountInstruction++;
            }

            /// <summary>
            /// Удаляет оператор в позиции.
            /// </summary>
            /// <param name="position"></param>
            public void RemoveInstructionAt(Position position) => RemoveInstructionAt(position.X,position.Y);
            /// <summary>
            /// Удаляет оператор в позиции.
            /// </summary>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            private void RemoveInstructionAt(int indexRow,int indexColumn)
            {
                IsInside(indexRow,indexColumn);
                if ( this[indexRow,indexColumn] is Start )
                    StartPosition = null;
                this[indexRow,indexColumn] = null;
                this.CountInstruction--;
            }
            #endregion

            #region Structural Methods
            ///<summary>
            /// Добавьте строку в конец массива.
            /// </summary>
            private void AddLastRow( )
            {
                AddRowAt(this.Row);
            }
            /// <summary>
            /// Добавляет столбец в конец массива.
            /// </summary>
            private void AddLastColumn( )
            {
                AddColumnAt(this.Column);
            }

            /// <summary>
            ///Добавляет строку в начало массива.
            /// </summary>
            private void AddFirstRow( )
            {
                Instruction[,] result = new Instruction[this.Row + 1, this.Column];

                for ( int i = 1; i < result.GetLength(0); i++ )
                    for ( int j = 0; j < result.GetLength(1); j++ )
                        result[i,j] = this[i - 1,j];
                this.Matrix = result;
            }
            /// <summary>
            /// Добавляет столбец в начало матрицы.
            /// </summary>
            private void AddFirstColumn( )
            {
                Instruction[,] result = new Instruction[this.Row, this.Column + 1];

                for ( int i = 0; i < result.GetLength(0); i++ )
                    for ( int j = 1; j < result.GetLength(1); j++ )
                        result[i,j] = this[i,j - 1];

                this.Matrix = result;
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
                    Instruction[,] result;
                    if ( index < this.Row )
                    {
                        result = new Instruction[this.Row + 1, this.Column];

                        for ( int i = 0; i < index; i++ )
                            for ( int j = 0; j < result.GetLength(1); j++ )
                                result[i,j] = this[i,j];
                        for ( int i = index + 1; i < result.GetLength(0); i++ )
                            for ( int j = 0; j < result.GetLength(1); j++ )
                                result[i,j] = this[i - 1,j];
                    }
                    else
                    {
                        result = new Instruction[index + 1, this.Column];

                        for ( int i = 0; i < this.Row; i++ )
                            for ( int j = 0; j < this.Column; j++ )
                                result[i,j] = this[i,j];
                    }
                    this.Matrix = result;
                }
            }

            /// <summary>
            /// Добавьте столбец в индекс.
            /// </summary>
            /// <param name="index"></param>
            public void AddColumnAt(int index)
            {
                if ( index < 0 )
                    AddFirstColumn( );
                else
                {
                    Instruction[,] result;
                    if ( index < this.Column )
                    {
                        result = new Instruction[this.Row, this.Column + 1];

                        for ( int i = 0; i < result.GetLength(0); i++ )
                            for ( int j = 0; j < index; j++ )
                                result[i,j] = this[i,j];
                        for ( int i = 0; i < result.GetLength(0); i++ )
                            for ( int j = index + 1; j < result.GetLength(1); j++ )
                                result[i,j] = this[i,j - 1];
                    }
                    else
                    {
                        result = new Instruction[this.Row, index + 1];

                        for ( int i = 0; i < this.Row; i++ )
                            for ( int j = 0; j < this.Column; j++ )
                                result[i,j] = this[i,j];
                    }
                    this.Matrix = result;
                }
            }

            /// <summary>
            /// Индексатор массива инструкций.
            /// </summary>
            /// <param name="position"></param>
            /// <returns></returns>
            public Instruction this[Position position]
            {
                get
                {
                    if ( position == null || this[position.X,position.Y] == null )
                        return null;
                    return this[position.X,position.Y];
                }
            }
            /// <summary>
            /// Индексатор массива инструкций
            /// </summary>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            /// <returns></returns>
            private Instruction this[int indexRow, int indexColumn]
            {
                get
                {
                    IsInside(indexRow,indexColumn);
                    if ( this.Matrix[indexRow,indexColumn] == null )
                        return null;
                    return this.Matrix[indexRow,indexColumn];
                }
                set
                {
                    if ( !( value is Instruction ) && value != null )
                        throw new ArgumentException("Не инструкция: ",value.ToString( ));
                    if ( value is Start && StartPosition != null )
                        throw new InvalidOperationException("Старт уже задан: " + StartPosition.ToString( ) + ".");
                    IsInside(indexRow,indexColumn);
                    this.Matrix[indexRow,indexColumn] = value;
                }
            }
            #endregion

            #region Enumerable

            /// <summary>
            /// Возвращает перечислитель операторов массива.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<Instruction> GetEnumerator( )
            {
                return new MatrixEnumerator(this);
            }
            IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

            #endregion

            #region Auxiliar Methods
            /// <summary>
            ///Выдает исключение, если параметры недействительны.
            /// </summary>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            public void IsInside(int indexRow,int indexColumn)
            {
                if ( indexRow < 0 || indexRow > this.Row )
                    throw new ArgumentOutOfRangeException("Некорректный ряд.");
                if ( indexColumn < 0 || indexColumn > this.Column )
                    throw new ArgumentOutOfRangeException("Некорректный столбец.");
            }
            /// <summary>
            /// Возвращает новый массив операторов с теми же операторами.
            /// </summary>
            /// <returns></returns>
            public object Clone( )
            {
                MatrixInstruction matrixClone = new MatrixInstruction(this.Row,this.Column);
                for ( int i = 0; i < this.Row; i++ )
                    for ( int j = 0; j < this.Column; j++ )
                        if ( this.Matrix[i,j] != null )
                            matrixClone.AddInstructionAt((Instruction) this[i,j].Clone( ),new Position(i,j));
                return matrixClone;
            }
            public override bool Equals(object obj)
            {
                if ( !( obj is MatrixInstruction ) )
                    return false;

                MatrixInstruction temp = obj as MatrixInstruction;

                if ( this.Row != temp.Row || this.Column != temp.Column )
                    return false;

                for ( int i = 0; i < temp.Row; i++ )
                    for ( int j = 0; j < temp.Column; j++ )
                        if ( this[i,j] == null && temp[i,j] == null )
                            continue;
                        else if ( !this[i,j].Equals(temp[i,j]) )
                            return false;

                return true;
            }
            public override int GetHashCode( )
            {
                int hash = 0;
                foreach ( var item in this )
                    hash += ( ( item.GetHashCode( ) - 7 ) / 3 );
                return hash;
            }
            #endregion

            #region Manage Pointer

            /// <summary>
            /// Поместите указатель массива в позицию {start}
            /// </summary>
            internal void FluxReset( )
            {
                this.Flux = new Pointer(StartPosition,2);
            }
            #endregion

            #endregion

            /// <summary>
            /// Указатель обхода массива.
            /// </summary>
            public class Pointer
            {
                #region Fields
                /// <summary>
                /// Положение указателя в массиве.
                /// </summary>
                private Position position;
                #endregion

                #region Properties
                /// <summary>
                /// Положение указателя в массиве.
                /// </summary>
                public Position Position => this.position;
                /// <summary>
                /// Адрес указателя в массиве.
                /// </summary>
                internal byte Direction { get; set; }
                #endregion

                #region Constructor
                public Pointer(Position position,byte direction)
                {
                    this.position = position;
                    this.Direction = direction;
                }
                #endregion

                #region Methods
                /// <summary>
                /// Переместите указатель в переднее положение.
                /// </summary>
                /// <param name="matrix"></param>
                public void Advance(MatrixInstruction matrix)
                {
                    Position frontPosition = position.FrontPosition(this.Direction);
                    if ( IsInside(matrix) )
                        this.position = frontPosition;
                    else
                        this.position = new Position(-1,-1);
                }
                /// <summary>
                /// Проверить позицию в массиве.
                /// </summary>
                /// <param name="position">Позиция для проверки.</param>
                /// <param name="matrix">Матрица, где вы хотите проверить позицию.</param>
                /// <returns></returns>
                public bool IsInside(MatrixInstruction matrix)
                {
                    return this.position.X >= 0 && this.position.X < matrix.Row && this.position.Y >= 0 && this.position.Y < matrix.Column;
                }
                #endregion
            }
            internal class MatrixEnumerator : IEnumerator<Instruction>
            {
                #region Fields
                MatrixInstruction matrix;
                Instruction current;
                internal bool Move
                {
                    get; private set;
                }
                #endregion

                #region Constructor
                public MatrixEnumerator(MatrixInstruction matrix)
                {
                    this.matrix = matrix;
                    this.Move = false;
                }
                #endregion

                #region Properties
                public Instruction Current
                {
                    get
                    {
                        if ( !Move )
                            throw new InvalidOperationException("Должен выполнить .MoveNext()");
                        return current;
                    }
                }
                object IEnumerator.Current => Current;
                #endregion

                #region Methods
                public void Dispose( )
                {

                }

                public bool MoveNext( )
                {
                    if ( matrix.Flux == null )
                    {
                        matrix.FluxReset( );
                        this.current = matrix[matrix.Flux.Position];
                        return Move = true;
                    }
                    else
                    {
                        matrix.Flux.Advance(matrix);
                        if ( matrix.Flux.IsInside(matrix) )
                        {
                            this.current = matrix[matrix.Flux.Position];
                            return Move = true;
                        }
                    }
                    return Move = false;
                }

                public void Reset( )
                {
                    current = null;
                    Move = false;
                    matrix.Flux = null;
                }
                #endregion
            }
        }
    }
}

