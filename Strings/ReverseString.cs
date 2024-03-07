public static class ReverseStringSolution {
    public static string ReverseString(string s) {
        // Convert the string to a char array
        char[] charArray = s.ToCharArray();
        
        // Initialize pointers for the start and end of the array
        int start = 0;
        int end = s.Length - 1;
        
        // Loop until the start index is less than the end index
        while (start < end) {
            // Swap characters at start and end
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            
            // Move the start index forward and the end index backward
            start++;
            end--;
        }
        
        // Convert the char array back to a string and return it
        return new string(charArray);
    }

    public static string ReverseString(char[] s) {
        int start = 0;
        int end = s.Length - 1;

        while (start < end) {
            // Swap characters at start and end
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;

            // Move the start index forward and the end index backward
            start++;
            end--;
        }

        return new string(s);
    }
}