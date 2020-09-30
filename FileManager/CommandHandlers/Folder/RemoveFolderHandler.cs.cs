using System.IO;

using FileManager.Exceptions;

namespace FileManager.CommandHandlers.Folder {
	public class RemoveFolderHandler : ICommandHandler {
		public void Execute(string path) {
			try { 
				if (!Directory.Exists(path)) {
					throw new FolderNotFoundException();
				}

				Directory.Delete(path, true);
			}
			catch(FolderNotFoundException exception) {
				throw exception;
			}
		}
	}
}
