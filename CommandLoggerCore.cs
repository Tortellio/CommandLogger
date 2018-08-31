using System.Linq;

using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using RocketLogger = Rocket.Core.Logging.Logger;

namespace coolpuppy24.commandlogger
{
	public class CommandLoggerCore : RocketPlugin<CommandLoggerConfiguration>
	{
		public static CommandLoggerCore Instance { get; private set; }
		private CommandLoggerLogger Logger { get; set; }

		protected override void Load()
		{
			CommandLoggerCore.Instance = this;
			this.Logger = new CommandLoggerLogger();
			RocketLogger.LogWarning("[CommandLogger] Made by: Coopyy");
			RocketLogger.LogWarning("[CommandLogger] Fork by: Wisser Tg");
			RocketLogger.LogWarning("----------------------------------------------");

			foreach (CommandLoggerEntry entry in this.Configuration.Instance.Entries)
				RocketLogger.LogWarning($"[CommandLogger] Registered logger command {entry.Name}" + (entry.Aliases != null && entry.Aliases.Length > 0 ? $" with {string.Join(", ", entry.GetAliases())}" : ""));

			UnturnedPlayerEvents.OnPlayerChatted += this.OnPlayerChatted;
		}
		private void OnPlayerChatted(Rocket.Unturned.Player.UnturnedPlayer player, ref UnityEngine.Color color, string message, SDG.Unturned.EChatMode chatMode, ref bool cancel)
		{
			// If player chatted like "Hey nigga" we'll return the method.
			if (!message.StartsWith("/"))
				return;
			// So, player entered the command and we'll deleting "/" letter from message.
			message = message.Remove(0);
			// Deleting command arguments bcuz we only need the command.
			string[] args = message.Split(' ').Skip(1).ToArray();
			// Set message to command name.
			message = message.Split(' ')[0];

			CommandLoggerEntry Entry = this.Configuration.Instance.Entries.Where(entry => entry.Name == message || entry.GetAliases().Contains(message)).FirstOrDefault();
			if (Entry.Equals(default(CommandLoggerEntry)))
				return;

			this.Logger.Log(string.Format(this.Configuration.Instance.LogFormat, System.DateTime.Now, player.DisplayName, player.CSteamID.m_SteamID, Entry.Name, message, string.Join(" ", args)));
		}
		protected override void Unload()
		{
			UnturnedPlayerEvents.OnPlayerChatted -= this.OnPlayerChatted;

			this.Logger = null;
			CommandLoggerCore.Instance = null;
		}
	}
}
