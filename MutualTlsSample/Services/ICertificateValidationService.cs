using System.Security.Cryptography.X509Certificates;

namespace MutualTlsSample.Services
{
    public interface ICertificateValidationService
    {
        bool ValidateCertificate(X509Certificate2 clientCertificate);
    }
}