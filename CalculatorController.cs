// Humble Object that interacts with the GUI
public class CalculatorController : Controller
{
    private readonly CalculatorService _calculatorService;

    public CalculatorController(CalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    public IActionResult AddNumbers(int a, int b)
    {
        var result = _calculatorService.Add(a, b);
        ViewData["Result"] = $"The sum of {a} and {b} is {result}.";
        return View();
    }
}