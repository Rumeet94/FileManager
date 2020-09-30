using System;

namespace FileManager.Exceptions {
	public class NotFoundCommandException : Exception {
		private const string _errorMessage = "Неверная команда, введите команду help " +
			"для получения справки или exit для выхода.";

		public NotFoundCommandException() 
		: base(_errorMessage) {
		}
	}
}
