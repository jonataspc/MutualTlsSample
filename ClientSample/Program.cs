using System.Security.Cryptography.X509Certificates;

// wait for server startup
await Task.Delay(TimeSpan.FromSeconds(5));

const string certificatePath = @"D:\temp\child_a_dev.pfx";
const string certificatePassword = "1234";
const string endpointUrl = @"https://localhost:7176/WeatherForecast";

var clientCertificate = new X509Certificate2(certificatePath, certificatePassword);

var handler = new HttpClientHandler();
handler.ClientCertificates.Add(clientCertificate);

var client = new HttpClient(handler);

var httpResponseMessage = await client.GetAsync(endpointUrl);

if (httpResponseMessage.IsSuccessStatusCode)
{
    var result = await httpResponseMessage.Content.ReadAsStringAsync();
    Console.WriteLine("Success:");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine($"Error: {httpResponseMessage.StatusCode}");
}

Console.ReadKey();