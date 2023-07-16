using NZZ.TSIM.Contracts;
using System.Runtime.CompilerServices;

namespace NZZ.TSIM.Core
{
  public sealed class FileLogger : ILogger
  {
    public FileLogger(string name, string logFolderPath)
    {
      this.name = name;
      this.logFolderPath = logFolderPath;
    }

    private readonly string name;
    private readonly string logFolderPath;

    public string LogFilePath => Path.Combine(logFolderPath, $"{DateTime.Today.ToString("yyyy-MM-dd")}.log");

    public void LogDebug(string message, [CallerMemberName] string sender = "")
    {
      Log("DEBUG", sender, message);
    }

    public void LogInfo(string message, [CallerMemberName] string sender = "")
    {
      Log("INFO", sender, message);
    }

    public void LogWarning(string message, [CallerMemberName] string sender = "")
    {
      Log("WARNING", sender, message);
    }

    public void LogError(string message, [CallerMemberName] string sender = "")
    {
      Log("ERROR", sender, message);
    }

    public void LogException(Exception ex, [CallerMemberName] string sender = "")
    {
      Log("EXCEPTION", sender, ex.ToString());
    }

    private void Log(string category, string message, string sender)
    {
      File.AppendAllLines(LogFilePath, new List<string> { $"{DateTime.Now.ToShortTimeString()}|{category}|{name}|{sender}|{message}" });
    }
  }
}