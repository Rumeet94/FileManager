using FileManager.Exceptions;

namespace FileManager.CommandHandlers {
	public class NotFoundCommandHandler : ICommandHandler {
		public void Execute(string path) =>
			throw new NotFoundCommandException();
	}
}
