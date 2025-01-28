# LinkShortener-MVC

## Overview
A simple and efficient URL Shortener built using ASP.NET Core MVC following SOLID principles. This project allows users to shorten long URLs into compact, easy-to-share links and redirect them back to their original destinations. The solution is structured using a service-based architecture to ensure maintainability and scalability

## Features

- Shorten long URLs into compact, shareable links.

- Redirect shortened URLs back to the original address.

- Implements Dependency Injection (DI) using IUrlShortenerService.

- Follows SOLID principles.

- Simple and intuitive user interface with Razor Views.

## Technologies Used
- ASP.NET Core MVC

- C#

- Dependency Injection

- Razor Views

- .NET 8.0

## Installation & Running the Project
### Prerequisites
- .NET SDK 8.0 or later installed
- Visual Studio, Rider, or VS Code

### Steps to Run Locally

1. Clone the repository:
 ```bash
git clone https://github.com/yourusername/LinkShortener.git
cd LinkShortener
```
2. Restore dependencies:
```bash
dotnet restore
```
3. Build and run the application:
 ```bash
dotnet run
```
4. Open a browser and go to:
```bash
http://localhost:{PORT}
```

## Project Structure

```
.
│── Controllers/      # MVC Controllers
│── Models/           # Data Models
│── Services/         # Business Logic Services
│── Views/            # Razor View Templates
│── wwwroot/          # Static files (CSS, JS, etc.)
│── appsettings.json  # Application Configurations
│── Program.cs        # Entry point of the application
│── LinkShortener.csproj # Project File
```

## Contribution
Feel free to fork this repository and contribute! Pull requests are welcome.
