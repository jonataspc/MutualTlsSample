using System.Security.Cryptography.X509Certificates;

namespace MutualTlsSample.Services
{
    public class CertificateValidationService : ICertificateValidationService
    {
        private readonly IConfiguration _configuration;

        public CertificateValidationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool ValidateCertificate(X509Certificate2 clientCertificate)
        {
            var clientCertificatesList = _configuration.GetSection("ClientCertificates").Get<string[]>() ?? throw new Exception("Invalid configuration");

            return clientCertificatesList.Contains(clientCertificate.Thumbprint);
        }
    }
}