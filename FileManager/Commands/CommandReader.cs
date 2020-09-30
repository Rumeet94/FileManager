using System;

using FileManager.CommandHandlers;

namespace FileManager.Commands {
	public class CommandReader {
		private readonly CommandHandlerFactory _commandHandlerFactory = new CommandHandlerFactory();

		public void Read() {
			var command = GetCommand();

			while(!command.Name.Equals("exit")) {
				if (command == null) {
					command = GetCommand();

					continue;
				}

				try {
					ExecuteCommand(command);
					PrintState(command.Name);
				}
				catch(Exception e) {
					Console.WriteLine(e.Message);
					Console.WriteLine();
				}

				command = GetCommand();
			}
		}

		private ConsoleCommand GetCommand() {
			string[] commandItems = null;
			try {
				var command = Console.ReadLine();
				commandItems = command.Split(" ");

				return new ConsoleCommand(commandItems[0], commandItems[1]);
			}
			catch {
				return new ConsoleCommand(commandItems[0]);
			}
		}

		private void ExecuteCommand(ConsoleCommand command) =>
			_commandHandlerFactory
				.Create(command.Name)
				.Execute(command.Path);

		private void PrintState(string commandName) {
			if (!commandName.Equals("help")) { 
				Console.WriteLine($"Комманда {commandName} успешно выполнена.");
				Console.WriteLine();
			}
		}
	}
}
