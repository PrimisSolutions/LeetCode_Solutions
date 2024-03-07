public static class ReverseIntSolution {
    public static int ReverseInt(int x){
        int reversed = 0;

        while (x != 0) {
            int lastDigit = x % 10;
            x /= 10;

            // Check for overflow/underflow before actually adding the digit
            if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && lastDigit > 7)) return 0;
            //Overflow
            if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && lastDigit < -8)) return 0; 
            // Underflow
            
            reversed = reversed * 10 + lastDigit;
        }

        return reversed;
    }
}