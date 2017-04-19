using System;
using System.Linq;
using System.Reflection;
using Rocket.API;
using Rocket.Unturned.Player;
using UnityEngine;
using SDG.Unturned;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.API.Collections;
using Rocket.Unturned.Chat;
using Rocket.Core;
using System.Collections.Generic;
using Rocket.Unturned.Events;
using System.IO;

namespace coolpuppy24.commandlogger
{
    public class Main : RocketPlugin<Config>
    {

        public string CommandLogger = System.IO.Directory.GetCurrentDirectory() + @"\Plugins\CommandLogger\CommandLog.txt";

        public static Main Instance = null;

        protected override void Load()
        {
            Instance = this;

            System.IO.File.Create(CommandLogger).Close();

            UnturnedPlayerEvents.OnPlayerChatted += UnturnedPlayerEvents_OnPlayerChatted;
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Made by: Coolpuppy24");
            Rocket.Core.Logging.Logger.LogWarning("----------------------------------------------");
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Vanish Command: " + Configuration.Instance.LogVanishCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log I Command: " + Configuration.Instance.LogICommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Item Command: " + Configuration.Instance.LogItemCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Give Command: " + Configuration.Instance.LogGiveCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log God Command: " + Configuration.Instance.LogGodCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log V Command: " + Configuration.Instance.LogVCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Vehicle Command: " + Configuration.Instance.LogVehicleCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log TP Command: " + Configuration.Instance.LogTPCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Teleport Command: " + Configuration.Instance.LogTeleportCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Spy Command: " + Configuration.Instance.LogSpyCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log TPHere Command: " + Configuration.Instance.LogTPHereCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Investigate Command: " + Configuration.Instance.LogInvestigateCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Kill Command: " + Configuration.Instance.LogKillCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Ban Command: " + Configuration.Instance.LogBanCommand);
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Log Kick Command: " + Configuration.Instance.LogKickCommand);
            Rocket.Core.Logging.Logger.Log("[CommandLogger] Successfully Loaded!");

    }

        private void UnturnedPlayerEvents_OnPlayerChatted(UnturnedPlayer player, ref Color color, string message, EChatMode chatMode, ref bool cancel)
        {
            if (message.StartsWith("/vanish") && Configuration.Instance.LogVanishCommand) {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/i") && Configuration.Instance.LogVanishCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/give") && Configuration.Instance.LogGiveCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/god") && Configuration.Instance.LogGodCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/v") && Configuration.Instance.LogVCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/vehicle") && Configuration.Instance.LogVehicleCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/item") && Configuration.Instance.LogItemCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/tp") && Configuration.Instance.LogTPCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/teleport") && Configuration.Instance.LogTeleportCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/spy") && Configuration.Instance.LogSpyCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/tphere") && Configuration.Instance.LogTPHereCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/investigate") && Configuration.Instance.LogInvestigateCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/ban") && Configuration.Instance.LogBanCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/kill") && Configuration.Instance.LogBanCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/kick") && Configuration.Instance.LogKickCommand)
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }

        }



        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerChatted -= UnturnedPlayerEvents_OnPlayerChatted;
            Rocket.Core.Logging.Logger.Log("Unload");
        }
    }


}
