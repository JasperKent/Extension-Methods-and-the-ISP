using System.Text;

namespace CaseConverters
{
    public static class Extensions
    {
        public static string ToKebab (this string input, char replacement)
        {
            StringBuilder bob = new StringBuilder();

            foreach(char c in input)
            {
                if (c >= 'A' && c <= 'Z' && bob.Length > 0)
                    bob.Append(replacement);

                bob.Append(c);                
            }

            return bob.ToString().ToLower();
        }
    }
}
