using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using System.Media;

namespace WallE.Errors
{
    /// <summary>
    /// Класс представляет ошибку любого рода, которая может возникнуть во время моделирования.
    /// </summary>
    public class Error
    {
        #region Properties
        /// <summary>
        /// Сообщение об ошибке с объяснением причин и последствий ошибки.
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// Текущая ошибка в моделировании.
        /// </summary>
        public static Error CurrentError { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Ошибка конструктура.
        /// </summary>
        /// <param name="message">Сообщение об ошибке.</param>
        public Error(string message)
        {
            this.Message = message;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Текстовая строка, представляющая данную ошибку.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return "ERROR!!!! " + this.Message;
        }
        /// <summary>
        /// Метод, сообщающий об ошибке и вызывающий событие SystemError.
        /// </summary>
        /// <param name="sender">Объект IProgrammble, который отправляет ошибку.</param>
        /// <param name="error">Сообщение об ошибке.</param>
        public static void ReportError(IProgrammable sender,Error error)
        {
            CurrentError = error;
            SystemSounds.Exclamation.Play( );
            SystemError(sender,new EventArgs( ));
        }

        #endregion

        #region Event
        /// <summary>
        /// Событие, которое запускается при обнаружении ошибки выполнения подпрограммы, например, стек выполнения заполнен, стек робота перегружен.
        /// </summary>
        public static event EventHandler SystemError;
        #endregion

    }
}
