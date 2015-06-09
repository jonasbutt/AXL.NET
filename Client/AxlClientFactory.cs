using System.Net;
using System.ServiceModel;

namespace AxlNetClient
{
    public class AxlClientFactory : IAxlClientFactory
    {
        private const string AxlEndpointUrlFormat = "https://{0}:8443/axl/";

        public AXLPortClient CreateClient(IAxlClientSettings settings)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            ServicePointManager.Expect100Continue = false;
            var basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            var axlEndpointUrl = string.Format(AxlEndpointUrlFormat, settings.Server);
            var endpointAddress = new EndpointAddress(axlEndpointUrl);
            var axlClient = new AXLPortClient(basicHttpBinding, endpointAddress);
            axlClient.ClientCredentials.UserName.UserName = settings.User;
            axlClient.ClientCredentials.UserName.Password = settings.Password;
            return axlClient;
        }
    }
}