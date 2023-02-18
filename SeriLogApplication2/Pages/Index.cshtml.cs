using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace SeriLogApplication2.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Log.Verbose(new Exception("Ooops"), "Darn");

        Log.Information("Int: {P1}", 100);
        Log.Information("Date: {P1}", DateTime.Now);
        Log.Information("Bool: {P1}", true);

        Log.Warning("The {P1} is out of range", 222);

        string fileName = "People.json";
        Log.Error(new FileNotFoundException("Does not exist"), "Fail to find {P1}", fileName);

        int? nullValue = null;
        Log.Information("{P1}", nullValue);

        Log.Fatal("{P1} is crashing the app", DateTime.Now);


        Log.Warning("Out of range {@Position}", new { Top = 25, Left = 134 });

        Log.ForContext("CategoryName", "CategoryValue").Information("My Info {P1}", 555);
    }
}
