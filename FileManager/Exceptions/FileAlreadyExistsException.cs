using System;

namespace FileManager.Exceptions {
	public class FileAlreadyExistsException : Exception {
		private const string _errorMessage = "Указанный Вами файл уже существует.";

		public FileAlreadyExistsException() 
		: base(_errorMessage) {
		}
	}
}
