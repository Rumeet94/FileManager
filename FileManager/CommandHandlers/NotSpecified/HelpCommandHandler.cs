using System;
using System.Text;

namespace FileManager.CommandHandlers.NotSpecified {
	public class HelpCommandHandler : ICommandHandler {
		private readonly string _helpMessage = new StringBuilder()
			.AppendLine("Список команд:")
			.AppendLine("'mkdir' - создает дирректорию;")
			.AppendLine("'rmdir' - удаляет дирректорию;")
			.AppendLine("'mkfile' - удаляет дирректорию;")
			.AppendLine("'rmfile' - удаляет дирректорию;")
			.AppendLine("'exit' - выход из программы.")
			.ToString();


		public void Execute(string path) =>
			Console.WriteLine(_helpMessage);
	}
}
