## Mutual TLS (mTLS) ASP.NET Core WebAPI Sample

Project developed to demonstrate mutual TLS (mTLS, or Two-Way SSL) authentication using ASP.NET Core. It was based on the <a href="https://learn.microsoft.com/en-us/aspnet/core/security/authentication/certauth?view=aspnetcore-7.0">official documentation</a>.

The generated certificates are located on the "Certificates" directory. Don't forget to <a href="https://learn.microsoft.com/en-us/aspnet/core/security/authentication/certauth?view=aspnetcore-7.0#install-in-the-trusted-root">add the CA certificate to the trusted root</a>.	

The WebAPI validates the client's certificate by checking if its thumbprint exists on the "ClientCertificates" allowable list on the "appsettings.json" file.

In order to test the WebAPI using Postman you must add the client certificate as described <a href="https://learning.postman.com/docs/sending-requests/certificates/#adding-client-certificates">here</a>. Simply add the "child_a_dev.pfx" file.

There is also a client console project ("ClientSample") that consumes the WebAPI using the client certificate.