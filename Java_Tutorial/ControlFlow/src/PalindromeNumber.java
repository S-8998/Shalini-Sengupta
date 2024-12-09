public class PalindromeNumber {
    // write code here
    public static void main(String[] args) {
        isPalindrome(123321);
    }
    public static boolean isPalindrome(int number)
    {
        int reverse = 0;

        while(number != 0)
        {
            int lastDigit = number%10;
            number = number/10;

            reverse = (reverse*10)+lastDigit;

        }



        if(reverse==number)
        {
            System.out.println(reverse);
            return true;
        }

        else
        {
            System.out.println(reverse);
            return false;
        }
    }
}


