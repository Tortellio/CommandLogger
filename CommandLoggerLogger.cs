using System.IO;
using Logger = Rocket.Core.Logging.Logger;

namespace coolpuppy24.commandlogger
{
	/// <summary>
	/// Using this like an adapter for StreamWriter.
	/// </summary>
	public sealed class CommandLoggerLogger
	{
		private string m_filepath;
		private FileMode m_filemode;
		private FileAccess m_fileaccess;
		public CommandLoggerLogger()
		{
			this.m_filepath = CommandLoggerCore.Instance.Directory + @"\CoolPuppy24.WisserTg.CommandLogger.log";

			this.m_filemode = FileMode.Append;
			this.m_fileaccess = FileAccess.Write;
		}
		public CommandLoggerLogger(string FilePath) : this()
		{
			this.m_filepath = CommandLoggerCore.Instance.Directory + FilePath;
		}

		public void Log(string Message)
		{
			if (CommandLoggerCore.Instance.Configuration.Instance.LogToFile)
			{
				if (!File.Exists(this.m_filepath))
					this.m_filemode = FileMode.CreateNew;
				using (StreamWriter sw = new StreamWriter(new FileStream(this.m_filepath, this.m_filemode, this.m_fileaccess)))
					sw.WriteLine(Message);
				if (this.m_filemode == FileMode.CreateNew)
					this.m_filemode = FileMode.Append;
			}
			if (CommandLoggerCore.Instance.Configuration.Instance.LogToConsole)
				Logger.Log(Message);
		}
	}
}
