public class MotivationalQuote
{
    private List<string> _quotes = new List<string>
    {
        "God is on your side, keep pushing, you're doing great!",
        "Every day present fresh start and opportunity.",
        "Always prepare for great opportunities.",
        "Small steps add up and prepare for big changes.",
        "Your journal is your safe space.",
        "Write what you feel, no judgment here.",
        "Reflect. Grow. Repeat."
    };

    private Random _random = new Random();

    public string GetRandomQuote()
    {
        int index = _random.Next(_quotes.Count);
        return _quotes[index];
    }
}