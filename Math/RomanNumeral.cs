using System.Dynamic;

public static class RomanNumeralToIntSolution{
    public static Dictionary<char,int> romanValues = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    public static int RomanToInt(string s) {
        int total = 0; // Initialize total to 0
        int prevValue = 0; // Initialize previous value to 0 for comparison

        // Iterate through the Roman numeral
        foreach (char c in s) {
            // Get the value of the current Roman symbol
            int value = romanValues[c];

            // Step 3 & 4: Add or subtract the value based on comparison with the previous value
            if (value > prevValue) {
                // Subtract twice the previous value since it was added once before
                total += value - 2 * prevValue;
            } else {
                total += value;
            }

            // Update previous value for the next iteration
            prevValue = value;
        }

        return total;
    }
}