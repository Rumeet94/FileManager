namespace FileManager.Commands {
	public class ConsoleCommand {
		public ConsoleCommand(string name, string path = null) {
			Name = name;
			Path = path;
		}

		public string Name { get; set; }

		public string Path { get; set; }
	}
}
