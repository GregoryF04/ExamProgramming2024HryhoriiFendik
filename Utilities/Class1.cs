namespace Utilities
{
    public static class StringUtilities
    {
        public static int LongWordsCount(string input)
        {
            string[] words = input.Split(' ');
            return words.Count(word => word.Length > 2);
        }

        public static string ToSpinalCase(string input)
        {
            string[] words = input.Split(' ');
            return string.Join("-", words.Select(word => word.ToLower()));
        }

        public static string ToPascalCase(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i][1..].ToLower();
            }
            return string.Join("", words);
        }
    }
}