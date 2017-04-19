using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coolpuppy24.commandlogger
{
    public class Config : IRocketPluginConfiguration
    {
        public bool LogVanishCommand;
        public bool LogICommand;
        public bool LogGiveCommand;
        public bool LogGodCommand;
        public bool LogVCommand;
        public bool LogVehicleCommand;
        public bool LogItemCommand;
        public bool LogTPCommand;
        public bool LogTeleportCommand;
        public bool LogSpyCommand;
        public bool LogTPHereCommand;
        public bool LogInvestigateCommand;
        public bool LogKillCommand;
        public bool LogBanCommand;
        public bool LogKickCommand;

        public void LoadDefaults()
        {
            LogVanishCommand = true;
            LogICommand = true;
            LogGiveCommand = true;
            LogGodCommand = true;
            LogVCommand = true;
            LogVehicleCommand = true;
            LogItemCommand = true;
            LogTPCommand = true;
            LogTeleportCommand = true;
            LogSpyCommand = true;
            LogTPHereCommand = true;
            LogInvestigateCommand = false;
            LogKillCommand = true;
            LogBanCommand = true;
            LogKickCommand = true;
        }
    }
}