using FileManager.CommandHandlers.Files;
using FileManager.CommandHandlers.Folder;
using FileManager.CommandHandlers.NotSpecified;

namespace FileManager.CommandHandlers {
	public class CommandHandlerFactory {
		public ICommandHandler Create(string command) {
			switch (command) {
				case "mkdir": return new CreateFolderHandler();
				case "rmdir": return new RemoveFolderHandler();
				case "mkfile": return new CreateFileHandler();
				case "rmfile": return new RemoveFileHandler();
				case "help": return new HelpCommandHandler();
				default: break;
			}

			return new NotFoundCommandHandler();
		}
	}
}
