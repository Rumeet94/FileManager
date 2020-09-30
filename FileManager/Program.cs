using System;

using FileManager.Commands;

namespace FileManager {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Введите комманду и путь. Для справки введите команду help.");

			var reader = new CommandReader();
			reader.Read();
		}
	}
}
