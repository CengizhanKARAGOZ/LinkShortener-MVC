using Microsoft.AspNetCore.Mvc;
using LinkShortener.Models;
using LinkShortener.Services;

namespace LinkShortener.Controllers;

public class HomeController : Controller
{
    private readonly IUrlShortenerService _urlShortenerService;

    public HomeController(IUrlShortenerService urlShortenerService)
    {
        _urlShortenerService = urlShortenerService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Shorten(string originalUrl)
    {
        if (string.IsNullOrEmpty(originalUrl))
        {
            ViewBag.Error = "Please enter a valid URL.";
            return View("Index");
        }

        try
        {
            var shortUrl = _urlShortenerService.ShortenUrl(new UrlMapping{OriginalUrl = originalUrl});
            ViewBag.ShortUrl = shortUrl;
        }
        catch (Exception ex)
        {
            ViewBag.Error = ex.Message;
        }

        return View("Index");
    }

    [HttpGet]
    public ActionResult RedirectToOriginal(string shortCode)
    {
        var originalUrl = _urlShortenerService.GetOriginalUrl(shortCode);
        if (originalUrl != null)
        {
            return Redirect(originalUrl);
        }

        return NotFound("URL not found.");
    }
}