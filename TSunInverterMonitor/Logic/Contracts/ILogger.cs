using System.Runtime.CompilerServices;

namespace NZZ.TSIM.Contracts
{
  public interface ILogger
  {
    void LogDebug(string message, [CallerMemberName] string sender = "");
    void LogInfo(string message, [CallerMemberName] string sender = "");
    void LogWarning(string message, [CallerMemberName] string sender = "");
    void LogError(string message, [CallerMemberName] string sender = "");
    void LogException(Exception ex, [CallerMemberName] string sender = "");
  }
}