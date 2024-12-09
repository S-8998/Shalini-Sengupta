public class SumOfDigitsChallenge66 {

    public static void main(String[] args) {
        System.out.println("sum is "+sumDigits(-100));
    }
    public static int sumDigits(int number)
    {
        int sum = 0;
        int divisor;
        if(number<0)
            return -1;
        else
        {
            while(number>0)
            {
                divisor = number%10;
                sum = sum+divisor;
                number = number/10;
            }

            return sum;
        }
    }
}
