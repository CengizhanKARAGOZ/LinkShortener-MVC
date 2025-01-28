using LinkShortener.Models;

namespace LinkShortener.Services;

public interface IUrlShortenerService
{
    string ShortenUrl(UrlMapping urlMapping);
    string GetOriginalUrl(string shortCode);
}