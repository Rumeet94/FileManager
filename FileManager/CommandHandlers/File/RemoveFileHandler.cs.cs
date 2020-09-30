using System.IO;

namespace FileManager.CommandHandlers.Files {
	public class RemoveFileHandler : ICommandHandler {
		public void Execute(string path) {
			try { 
				if (!File.Exists(path)) {
					throw new FileNotFoundException("Указанный Вами файл не существует.");
				}

				File.Delete(path);
			}
			catch(FileNotFoundException exception) {
				throw exception;
			}
		}
	}
}
