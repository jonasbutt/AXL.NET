namespace AxlNetClient
{
    public interface IAxlClientSettings
    {
        string Server { get; set; }

        string User { get; set; }

        string Password { get; set; }
    }
}