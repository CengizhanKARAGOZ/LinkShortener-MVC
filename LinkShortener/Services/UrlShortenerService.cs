using LinkShortener.Models;

namespace LinkShortener.Services;

public class UrlShortenerService: IUrlShortenerService
{
    private readonly IDictionary<string, UrlMapping> _urlMappings;
    private readonly ICodeGenerator _codeGenerator;

    public UrlShortenerService(ICodeGenerator codeGenerator)
    {
        _urlMappings = new Dictionary<string, UrlMapping>();
        _codeGenerator = codeGenerator;
    }

    public string ShortenUrl(UrlMapping urlMapping)
    {
            foreach (var mapping in _urlMappings.Values)
            {
                if (mapping.OriginalUrl == urlMapping.OriginalUrl)
                {
                    return mapping.ShortCode;
                }
            }
        var shortCode = _codeGenerator.GenerateCode();
        _urlMappings[shortCode] = urlMapping;
        return shortCode;
    }

    public string GetOriginalUrl(string shortCode)
    {
        return _urlMappings.ContainsKey(shortCode) ? _urlMappings[shortCode].OriginalUrl : null;
    }
}