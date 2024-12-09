public class DigitSumChallenge {
    public static void main(String[] args) {
            System.out.println(sumDigits(32123));
    }

    public static int sumDigits(int number)
    {
        int sum = 0;

        while(number != 0)
        {
            int lastDigit = number%10;
            number = number/10;

            sum = sum + lastDigit;
        }

        return sum;
    }
}
