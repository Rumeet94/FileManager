using System.IO;

using FileManager.Exceptions;

namespace FileManager.CommandHandlers.Files {
	public class CreateFileHandler : ICommandHandler {
		public void Execute(string path) {
			try { 
				if (File.Exists(path)) { 
					throw new FileAlreadyExistsException();
				}

				using var stream = File.Create(path);
			}
			catch(FileAlreadyExistsException exception) {
				throw exception;
			}
			catch {
				throw new PathNotExistsException();
			}
		}
	}
}
