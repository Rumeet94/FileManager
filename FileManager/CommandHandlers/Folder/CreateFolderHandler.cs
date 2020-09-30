using System.IO;

using FileManager.Exceptions;

namespace FileManager.CommandHandlers.Folder {
	public class CreateFolderHandler : ICommandHandler {
		public void Execute(string path) {
			try { 
				if (Directory.Exists(path)) {
					throw new FolderAlreadyExistsException();
				}

				Directory.CreateDirectory(path);
			}
			catch(FolderAlreadyExistsException exception) {
				throw exception;
			}
			catch {
				throw new PathNotExistsException();
			}
		}
	}
}
