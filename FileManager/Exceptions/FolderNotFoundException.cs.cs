using System;

namespace FileManager.Exceptions {
	public class FolderNotFoundException : Exception {
		private const string _errorMessage = "Указанный Вами каталог не существует.";

		public FolderNotFoundException() 
		: base(_errorMessage) {
		}
	}
}
