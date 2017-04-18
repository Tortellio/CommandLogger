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

namespace coolpuppy24.plugintemplate
{
    public class Main : RocketPlugin
    {

        public string CommandLogger = System.IO.Directory.GetCurrentDirectory() + @"\Plugins\CommandLogger\CommandLog.txt";

        public static Main Instance = null;

        protected override void Load()
        {
            Instance = this;

            System.IO.File.Create(CommandLogger).Close();

            UnturnedPlayerEvents.OnPlayerChatted += UnturnedPlayerEvents_OnPlayerChatted;
            Rocket.Core.Logging.Logger.LogWarning("[CommandLogger] Made by: Coolpuppy24");

            Rocket.Core.Logging.Logger.Log("[CommandLogger] Successfully Loaded!");

    }

        private void UnturnedPlayerEvents_OnPlayerChatted(UnturnedPlayer player, ref Color color, string message, EChatMode chatMode, ref bool cancel)
        {
            if (message.StartsWith("/vanish")) {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/i"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/give"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/god"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/v"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/vehicle"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/item"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/tp"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/teleport"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/spy"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/tphere"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/investigate"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/ban"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (message.StartsWith("/kick"))
            {
                File.AppendAllText(CommandLogger, "[" + DateTime.Now + "] " + player.CharacterName + " (" + player.CSteamID + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }

        }



        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }
    }


}
