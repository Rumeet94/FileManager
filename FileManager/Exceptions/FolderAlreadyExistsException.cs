using System;

namespace FileManager.Exceptions {
	public class FolderAlreadyExistsException : Exception {
		private const string _errorMessage = "Указанный Вами каталог уже существует.";

		public FolderAlreadyExistsException() 
		: base(_errorMessage) {
		}
	}
}
