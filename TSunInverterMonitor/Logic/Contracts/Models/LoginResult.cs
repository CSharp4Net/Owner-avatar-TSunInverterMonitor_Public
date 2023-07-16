namespace NZZ.TSIM.Contracts.Models
{
  public sealed class LoginResult
  {
    public LoginResult()
    {
      Successful = true;
    }
    public LoginResult(string errorMessage)
    {
      ErrorMessage = errorMessage;
    }

    public bool Successful { get; set; }
    public string ErrorMessage { get; set; } = "";
  }
}