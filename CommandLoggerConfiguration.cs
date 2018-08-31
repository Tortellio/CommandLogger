using System.Xml.Serialization;
using System.Linq;

using Rocket.API;

namespace coolpuppy24.commandlogger
{
	public struct CommandLoggerEntry
	{
		/// <summary>
		/// Name of the command (ex: /god : god is a name)
		/// </summary>
		[XmlAttribute("name")]
		public string Name;
		/// <summary>
		/// Command aliases (ex: /i, /item, /give : is aliases separated by ,)
		/// </summary>
		[XmlAttribute("aliases")]
		public string Aliases;

		/// <summary>
		/// Get aliases as Array
		/// </summary>
		/// <returns>string[]</returns>
		public string[] GetAliases() => (from i in Aliases.Split(',') select i.Trim()).ToArray();

		public CommandLoggerEntry(string Name, params string[] Aliases)
		{
			this.Name = Name;
			this.Aliases = string.Join(",", Aliases);
		}
	}
	public sealed class CommandLoggerConfiguration : IDefaultable, IRocketPluginConfiguration
	{
		[XmlElement("LogFormat")]
		public string LogFormat;

		[XmlArray("CommandEntries"), XmlArrayItem("CommandEntry")]
		public CommandLoggerEntry[] Entries;

		public void LoadDefaults()
		{
			this.LogFormat = "[{0}] {1} ({2}) executed \"{3}\" command as \"{4}\" with \"{5}\" arguments.";
			this.Entries = new CommandLoggerEntry[]
			{
				new CommandLoggerEntry("god"),
				new CommandLoggerEntry("vanish"),
				new CommandLoggerEntry("investigate"),
				new CommandLoggerEntry("item", "i", "give"),
				new CommandLoggerEntry("vehicle", "v"),
				new CommandLoggerEntry("teleport", "tp", "tphere"),
				new CommandLoggerEntry("spy"),
				new CommandLoggerEntry("ban"),
				new CommandLoggerEntry("kick"),
				new CommandLoggerEntry("kill", "slay")
			};
		}
	}
}