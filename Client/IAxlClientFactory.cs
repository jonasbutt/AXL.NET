namespace AxlNetClient
{
    public interface IAxlClientFactory
    {
        AXLPortClient CreateClient(IAxlClientSettings settings);
    }
}