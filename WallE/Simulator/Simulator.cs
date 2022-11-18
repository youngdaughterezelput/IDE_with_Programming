using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World;
using WallE.Errors;

namespace WallE.Simulator
{
    public class Simulator : IEnumerable<Round>
    {
        #region Fields
        /// <summary>
        /// Модель мира
        /// </summary>
        private Map world;
        /// <summary>
        /// Переменная, которая сохраняет начальное состояние симуляции.
        /// </summary>
        private readonly Map initialWorldState;
        /// <summary>
        /// Счетчик кругов
        /// </summary>
        private IEnumerator<Round> enumerator;
        /// <summary>
        /// время между "раундами"
        /// </summary>
        double time;
        #endregion

        #region Properties
        /// <summary>
        /// Время между кругами
        /// </summary>
        public double TimeSimulation
        {
            get
            {
                return time;
            }
            set
            {
                if ( value < 0.2 )
                    throw new ArgumentException("Недопустимое значение времени. Должно быть больше 0,2 секунды");
                time = value;
            }
        }
        /// <summary>
        /// Отладка //нет
        /// </summary>
        public bool IsDebugging { get; private set; }
        /// <summary>
        /// Допустить вывод ошибок
        /// </summary>
        public static bool NoAllowErrors { get; set; }
        public static Error CurrentError { get;  internal set; }
        /// <summary>
        /// Мир симуляции.
        /// </summary>
        public Map World => this.world;

        /// <summary>
        /// Количество раундов симулятора.
        /// </summary>
        public int Rounds { get; private set; }
        /// <summary>
        /// Симуляция в текущем режиме
        /// </summary>
        public bool IsRunning { get; /*private*/ set; }

        #endregion

        #region Constructor
        public Simulator(Map world)
        {
            this.world = world;

            this.initialWorldState = (Map) world.Clone( );
            foreach ( var item in initialWorldState )
                item.world = initialWorldState;

            GetEnumerator( );
        }

        #endregion

        #region Methods

        #region Execution
        /// <summary>
        /// Останавливает симуляцию и возвращает ее в исходное состояние.
        /// </summary>
        public virtual void Stop( )
        {
            this.IsDebugging = false;
            this.IsRunning = false;
            this.world = (Map) initialWorldState.Clone( );
            this.Rounds = 0;
            GetEnumerator( );
            Simulator.CurrentError = null;

        }
        /// <summary>
        /// Останавливает симуляцию на следующем раунде.
        /// </summary>
        public virtual void Pause( )
        {
            IsRunning = false;
            IsDebugging = false;
        }
        /// <summary>
        /// Продвиньтесь на один раунд симуляции.
        /// </summary>
        public virtual void Advance( )
        {
            IsDebugging = false;
            IsRunning = true;

            if ( enumerator.MoveNext( ) )
            {
                enumerator.Current.Execute();
                this.Rounds++;
            }

            if ( Simulator.CurrentError != null && Simulator.NoAllowErrors )
                Stop( );

            IsRunning = false;
        }
        /// <summary>
        /// Выполняет инструкцию за инструкцией.
        /// </summary>
        public virtual void Debug( )
        {
            if ( !IsDebugging )
            {
                enumerator.MoveNext( );
                IsDebugging = enumerator.Current.ExecuteByInstruction( );
            }
            else
                IsDebugging = enumerator.Current.ExecuteByInstruction( );
            if ( !IsDebugging )
                this.Rounds++;
        }
        #endregion

        #region Auxiliar Methods
        /// <summary>
        /// Возвращает новый раунд.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Round> GetEnumerator( )
        {
            return enumerator = new SimulatorEnumerator(this.world.SelectIProgrammables( ));
        }
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        #endregion

        #endregion

        #region Events
        /// <summary>
        /// Метод, который сообщает об ошибке в моделировании.
        /// </summary>
        /// <param name="robot">IProgrammable объект с ошибкой.</param>
        /// <param name="error"></param>
        public static void ReportError(IProgrammable robot,Errors.Error error)
        {
            CurrentError = error;
            Error(robot,new EventArgs( ));
        }
        /// <summary>
        /// Событие, возникающее при возникновении ошибки.
        /// </summary>
        public static event EventHandler Error;
        #endregion 
    }
}