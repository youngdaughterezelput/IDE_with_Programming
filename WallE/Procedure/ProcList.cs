using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using WallE.Tools;
using WallE.World.WorldObjects;
using WallE.InstrLan;

namespace WallE.Rout
{
    /// <summary>
    /// Представляет список подпрограмм, который есть у робота.
    /// </summary>
    public class ProcList : IEnumerable<Proc>, ICloneable
    {
        #region Fields
        /// <summary>
        /// Список процедур
        /// </summary>
        List<Proc> list;
        internal IProgrammable bot;
        #endregion

        #region Properties
        /// <summary>
        /// Количество подпрограмм в списке.
        /// </summary>
        public int Count => this.list.Count;



        /// <summary>
        /// Обычный индексатор списка.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Proc this[int index]
        {
            get { return list[index]; }
            private set { list[index] = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Создайте пустой список процедурных действий.
        /// </summary>
        public ProcList( )
        {
            this.list = new List<Proc>( );
        }
        /// <summary>
        /// Создайте список подпрограмм из массива подпрограмм.
        /// </summary>
        /// <param name="list"></param>
        public ProcList(params Proc[] list)
        {
            this.list = list.ToList<Proc>( );
        }
        #endregion

        #region Methods
        /// <summary>
        /// Загрузите процедуру из .txt в этот список.
        /// </summary>
        /// <param name="path">Путь подпрограммы .txt.</param>
        /// <returns></returns>
        public void LoadRoutine(string path)
        {
            bool load = false;
            var rut = ControllerRoutine.LoadRoutine(path, out load);
            this.AddRoutine(rut);
        }

        /// <summary>
        /// Необходимо добавить процедуру в список
        /// </summary>
        /// <param name="routine">Массив подпрограмм для добавления в список робота.</param>
        public void AddRoutine(params Proc[] routine)
        {
            for ( int i = 0; i < routine.Length; i++ )
            {
                if ( routine[i].RobotRut == null )
                {
                    routine[i].RobotRut = this.bot;
                    routine[i].Index = list.Count;
                    this.list.Add(routine[i]);
                }
                else
                {
                    Proc routineCopy = (Proc) routine[i].Clone( );
                    routineCopy.RobotRut = this.bot;
                    routineCopy.Index = list.Count;
                    this.list.Add(routineCopy);
                }
            }

        }

        /// <summary>
        /// Удалить подпрограмму по заданному индексу.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveRoutineAt(int index)
        {
            if ( index >= this.list.Count )
                throw new IndexOutOfRangeException("такого индекса не существует.");
            for ( int i = index + 1; i < list.Count; i++ )
                list[i].Index = i - 1;
            this.list.RemoveAt(index);
        }

        public IEnumerator<Proc> GetEnumerator( )
        {
            return list.GetEnumerator( );
        }
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        public object Clone( )
        {
            ProcList listClone = new ProcList( ) { bot = this.bot };

            foreach ( var item in this )
                listClone.AddRoutine((Proc) item.Clone( ));
            return listClone;
        }

        /// <summary>
        /// Выполнить список подпрограмм данного IProgrammable.
        /// </summary>
        internal void Execute( )
        {
            //Robot sin rutinas
            if ( list.Count == 0 || list[0] == null )
            {
                //В зависимости от того, как пользователь хочет контролировать ошибки,
                //выдается ошибка или ошибка просто печатается в консоли приложения.
                Errors.Error error = new Errors.Error("Робот без подпрограмм или без основной программы.");
                //Пользователь не хочет ошибок, симуляция окончена.
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(bot,error);
                    return;
                }
                Simulator.WallE_Console.Print(bot,error.ToString( ));
                return;
            }
            //Если в стеке выполнения этого робота нет подпрограмм, то он помещает подпрограмму с индексом 0.
            if ( this.bot.ExecutingStack.Count == 0 )
            {
                var rut = (Proc) list[0].Clone( );
                rut.RobotRut = bot;
                ( (Robot) bot ).ExecutingStack.Push(rut);
            }
            //Он помечен как работающий
            this.bot.ExecutingStack.Peek( ).Executing = true;
            //Он выполняется до тех пор, пока  действие или поток не покинет матрицу.
            this.bot.ExecutingStack.Peek( ).Execute( );
            //Если он завершил выполнение при выходе, удалите его из вершины стека.
            if ( !bot.ExecutingStack.Peek( ).Executing )
                bot.ExecutingStack.Pop( );
        }
        /// <summary>
        /// Выполняет список подпрограмм в объекте IProgrammable, оператор за оператором.
        /// </summary>
        /// <returns></returns>
        internal bool ExecuteByInstruction( )
        {
            /* Этот метод подобен выполнению до физического действия только с той разницей, что выполняется инструкция, а метод завершается.
             Возвращается логическое значение, указывающее, завершает ли объект IProgrammable свой ход этой инструкцией.*/
            if ( list.Count == 0 || list[0] == null )
            {
                Errors.Error error = new Errors.Error("Робот без подпрограмм или без основной программы.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(bot,error);
                    return false;
                }
                Simulator.WallE_Console.Print(bot,error.ToString( ));
                return false;
            }
            if ( this.bot.ExecutingStack.Count == 0 )
            {
                var rut = (Proc) list[0].Clone( );
                rut.RobotRut = bot;
                ( (Robot) bot ).ExecutingStack.Push(rut);
            }

            this.bot.ExecutingStack.Peek( ).Executing = true;
            var returned = this.bot.ExecutingStack.Peek( ).ExecuteByInstruction( );
            if ( !bot.ExecutingStack.Peek( ).Executing )
                bot.ExecutingStack.Pop( );
            return returned;
        }
        #endregion
    }
}
