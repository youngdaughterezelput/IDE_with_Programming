using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World;
using WallE.World.WorldObjects;
using WallE.InstrLan;
using WallE.Routine;


namespace WallE.Simulator
{
    public class Round : IEnumerable<IProgrammable>
    {
        public static bool IsExecutingByInstruction { get; private set; }
        /// <summary>
        ///Список со всеми IProgrammable объектами моделирования. 
        /// </summary>
        List<IProgrammable> tempListProgrammable;
        /// <summary>
        /// Счетчик с кольцевой развязки.
        /// </summary>
        IEnumerator<IProgrammable> enumerator;

        bool lastExecutionInstruction;

        /// <summary>
        /// "Построить"
        /// </summary>
        /// <param name="tempListProgrammable">Список всех IProgrammable объектов в мире.</param>
        public Round(List<IProgrammable> tempListProgrammable)
        {
            //Сохраняю список в поле tempListProgrammable
            this.tempListProgrammable = tempListProgrammable;
            //Взть счетчик круга
            enumerator = GetEnumerator( );
            enumerator.MoveNext( );
        }

        /// <summary>
        /// Возвращает перечислитель объектов IProgrammable.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IProgrammable> GetEnumerator( )
        {
            return new RoundEnumerator(tempListProgrammable);
        }
        /// <summary>
        ///Возвращает перечислитель объекта.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        /// <summary>
        /// Запускайте списки роботов, пока не дойдете до действия.
        /// </summary>
        internal void Execute( )
        {
            IsExecutingByInstruction = false;
            foreach ( var item in this )
            {
                item.Times++;
                item.ListRoutine.Execute( );
                if(Simulator.CurrentError != null)
                    return;
            }
        }
        /// <summary>
        /// Выполняйте списки подпрограмм, пока не дойдете до действия --> инструкция за инструкцией.
        /// </summary>
        /// <returns></returns>
        internal bool ExecuteByInstruction( )
        {
            IsExecutingByInstruction = true;
            bool isntLastProgrammable = true;
            if ( !lastExecutionInstruction )
                lastExecutionInstruction = enumerator.Current.ListRoutine.ExecuteByInstruction( );
            else
            {
                enumerator.Current.Times++;
                if ( isntLastProgrammable = enumerator.MoveNext( ) )
                {
                    lastExecutionInstruction = enumerator.Current.ListRoutine.ExecuteByInstruction( );
                    enumerator.Current.Times++;
                }
            }
            return isntLastProgrammable;
        }


        class RoundEnumerator : IEnumerator<IProgrammable>
        {
            /// <summary>
            /// Индекс к списку объектов IProgrammable.
            /// </summary>
            int index;
            /// <summary>
            /// Список программируемых объектов.
            /// </summary>
            List<IProgrammable> tempListProgrammable;
            /// <summary>
            /// Текущий объект IProgrammble.
            /// </summary>
            IProgrammable current;
            /// <summary>
            /// Логическое значение, определяющее, был ли ход.
            /// </summary>
            bool move;

            public RoundEnumerator(List<IProgrammable> tempListProgrammable)
            {
                this.tempListProgrammable = tempListProgrammable;
                this.index = -1;
            }
            public IProgrammable Current
            {
                get
                {
                    if ( !move )
                        throw new InvalidOperationException("Робот не выполнил .MoveNext()");
                    return current;
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose( )
            {
                return;
            }

            public bool MoveNext( )
            {
                if ( ++index < tempListProgrammable.Count )
                {
                    current = tempListProgrammable[index];
                    return move = true;
                }
                else return move = false;
            }

            public void Reset( )
            {
                this.current = null;
                this.move = false;
                this.index = -1;
            }
        }

    }
}
