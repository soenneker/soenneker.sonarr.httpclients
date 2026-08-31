[![](https://img.shields.io/nuget/v/soenneker.sonarr.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sonarr.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sonarr.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sonarr.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sonarr.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sonarr.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sonarr.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.sonarr.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Sonarr.HttpClients

Provides a reusable `HttpClient` configured for a Sonarr server and authenticated with its API key.

## Installation

```bash
dotnet add package Soenneker.Sonarr.HttpClients
```

## Configuration

```json
{
  "Sonarr": {
    "ApiKey": "your-sonarr-api-key",
    "ClientBaseUrl": "http://localhost:8989"
  }
}
```

## Usage

```csharp
using Soenneker.Sonarr.HttpClients.Abstract;
using Soenneker.Sonarr.HttpClients.Registrars;

services.AddSonarrOpenApiHttpClientAsSingleton();

HttpClient client = await sonarrHttpClient.Get(cancellationToken);
HttpResponseMessage response = await client.GetAsync(
    "api/v3/system/status",
    cancellationToken);
```

The provider owns the cached `HttpClient`; disposing the provider removes and disposes that client. Scoped registration creates an independently owned client for each scope.
