namespace COLogger {
    /// <summary>
    /// The main <see cref="Logger"/> class for <see cref="COLogger"/>
    /// </summary>
    public class Logger {

        /// <summary>
        /// Writes a message to the <see cref="Console"/>.
        /// </summary>
        /// <param name="message">The message to write to the <see cref="Console"/> converted into a <see cref="string"/></param>
        /// <param name="logType">The type of message to log</param>
        /// <exception cref="Exception">Exception thrown when using <see cref="LogType.FatalError"/></exception>
        public static void Log(object message, LogType logType = LogType.Log) {
            switch (logType) {
                case LogType.Log:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"[LOG] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogType.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"[WARNING] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[ERROR] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogType.FatalError:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"[FATAL ERROR] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    throw new Exception(message.ToString());
            }

        }

    }

    /// <summary>
    /// The type of message to log
    /// </summary>
    public enum LogType {
        /// <summary>
        ///  Writes the message to the console in white using the prefix [LOG]
        /// </summary>
        Log,

        /// <summary>
        /// Writes the message to the console in dark yellow using the prefix [WARNING]
        /// </summary>
        Warning,

        /// <summary>
        /// Writes the message to the console in red using the prefix [ERROR]
        /// </summary>
        Error,

        /// <summary>
        /// Writes the message to the console in dark red using the prefix "[FATAL ERROR]". This also throws a new <see cref="Exception"/> using the message as the <see cref="Exception.Message"/>.
        /// </summary>
        FatalError
    }
}