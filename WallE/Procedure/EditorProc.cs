using System;
using System.Linq;
using System.IO;
using WallE.Tools;
using WallE.MATLAN;
using WallE.MATLAN.Instructions;

namespace WallE.Routine
{
    /// <summary>
    /// Обрабатывает все, что связано с загрузкой и сохранением подпрограмм в приложении..
    /// </summary>
    public static class ControllerRoutine
    {
        /// <summary>
        /// Сохраните процедуру в формате .txt
        /// </summary>
        /// <param name="routine">Процедура, которую необходимо сохранить.</param>
        /// <param name="path">Путь, по которому необходимо посмотреть.</param>
        public static void SaveRoutine(Proc routine,string path)
        {
            if ( !Directory.Exists(path) )
                Directory.CreateDirectory(path);

            string pathFinal = path + "\\" + routine.Name + ".txt";

            if ( routine.Body.CountInstruction == 0 )
                throw new InvalidOperationException("Вы не можете сохранить процедуру без инструкций.");
            File.WriteAllLines(pathFinal,routine.ToString( ).Split('\n'));
        }
        /// <summary>
        /// Парсер .txt, откуда получены подпрограммы.
        /// </summary>
        /// <param name="path">Путь на диске, где находится подпрограмма.</param>
        /// <param name="loadOk">Возвращает true, если у процедуры есть начало, возвращает false, если нет..</param>
        /// <returns></returns>
        public static Proc LoadRoutine(string path, out bool loadOk)
        {
            loadOk = false;
            if ( Directory.Exists(path) )
                throw new InvalidProgramException("Неверный адрес на диске.");

            string[] stringRut = File.ReadLines(path).ToArray( );

            Proc rutResult =
                new Proc(path.Split(new char[] { '\\' },StringSplitOptions.RemoveEmptyEntries).Last( ).Split(new char[] { '.' },StringSplitOptions.RemoveEmptyEntries).First( ));

            int countInstruction = 0;
            try { countInstruction = int.Parse(stringRut[0]); }
            catch ( Exception )
            {
                throw new InvalidCastException("Неверный формат количества инструкций.");
            }

            if ( countInstruction != stringRut.Length - 1 )
                throw new ArgumentException("Неверный формат файла подпрограммы, так как он " + (stringRut.Length -1)+ " инструкции, когда должен был " + countInstruction + " в иснтрукции.");

            for ( int i = 1; i < stringRut.Length; i++ )
            {
                string[] tempLineRut = stringRut[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                if ( tempLineRut.Length != 3 )
                    throw new ArgumentException("Формат строки: " + i + " не выполнен.");

                Position tempPosition = StringToPosition(tempLineRut[0],tempLineRut[1]);

                var tempInstruction = Instruction.ExecuteCreation(tempLineRut[2]);

                if ( tempInstruction is Start && rutResult.Body.StartPosition != null )
                    throw new InvalidOperationException("В этой подпрограмме уже есть {start}.");

                rutResult.Body.AddInstructionAt(tempInstruction,tempPosition);
            }

            if ( rutResult.Body.StartPosition != null )
                loadOk = true;
            else
                throw new InvalidDataException("Эта процедура не имеет начала.");

            return rutResult;
        }
        /// <summary>
        /// Попробуйте разобрать две текстовые строки в позицию.
        /// </summary>
        /// <param name="x">Строка, связанная с компонентом X позиции</param>
        /// <param name="y">Строка, связанная с компонентом Y позиции</param>
        /// <returns></returns>
        private static Position StringToPosition(string x,string y)
        {
            int finalX, finalY;
            try { finalX = int.Parse(x); }
            catch ( Exception ) { throw new InvalidCastException("Неверная координата X."); }

            try { finalY = int.Parse(y); }
            catch ( Exception ) { throw new InvalidCastException("Недопустимая координата Y."); }

            return new Position(finalX,finalY);
        }
    }
}
