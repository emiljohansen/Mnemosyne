using Microsoft.AspNetCore.Mvc;

namespace Mnemosyne.Controllers;

[Route(Names.Routes.WebhookControllerRoute)]
[ApiVersion("1")]
public class WebhookController : ControllerBase 
{
    private readonly ILogger<WebhookController> _logger;

    public WebhookController(ILogger<WebhookController> logger)
    {
        _logger = logger;
    }

    [HttpPost(nameof(RegisterWebhook))]
    public IResult RegisterWebhook()
    {
        return Results.Ok();
    }

    [HttpGet(nameof(GetRegisteredWebhooks))]
    public IResult GetRegisteredWebhooks() { return Results.Ok(); }

    [HttpDelete(nameof(DeregisterWebhook))]
    public IResult DeregisterWebhook(long webhookId)
    {
        return Results.NoContent();
    }
}