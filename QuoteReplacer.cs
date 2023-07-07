using System.Text.RegularExpressions;

namespace remove_double_quotes
{
    public class QuoteReplacer
    {
        public string ReplaceDuplicateQuotes(string input)
        {
            string pattern = "\"{2,}";
            string replacement = "\"";
            string result = Regex.Replace(input, pattern, replacement);

            return result;
        }
    }
}