using System;

namespace FileManager.Exceptions {
	public class PathNotExistsException : Exception {
		private const string _errorMessage = "Путь указан некоректно, попробуйте еще раз.";

		public PathNotExistsException() 
		: base(_errorMessage) {
		}
	}
}
