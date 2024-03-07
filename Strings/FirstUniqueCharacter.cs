public static class FirstUniqueCharacterSolution {
    public static int FirstUniqueChar(string s) {
        /* Given a string s return the index of the first non-repeating character.
        If there is no such character, return -1. */

        // Dictionary to store the count of each character
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        // First pass: Count occurrences of each character
        foreach (char c in s) {
            if (charCounts.ContainsKey(c)) {
                charCounts[c]++;
            } else {
                charCounts.Add(c, 1);
            }
        }

        // Second pass: Find the index of the first character with a count of 1
        for (int i = 0; i < s.Length; i++) {
            if (charCounts[s[i]] == 1) {
                return i;
            }
        }

        // If no non-repeating character was found, return -1
        return -1;
    }
}