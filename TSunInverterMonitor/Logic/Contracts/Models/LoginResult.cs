namespace NZZ.TSIM.Contracts.Models
{
    public sealed class LoginResult
    {
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; } = "";
    }
}