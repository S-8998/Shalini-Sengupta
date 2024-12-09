public class SharedDigit {

    public static void main(String[] args) {
        hasSharedDigit(31,23);
    }
    public static boolean hasSharedDigit(int firstNumber, int lastNumber)
    {
        if(firstNumber<10 || firstNumber>99 || lastNumber<10 || lastNumber>99)

        {
            return false;
        }

        else
        {
            while(firstNumber != 0)
            {
                int lastDigit = firstNumber%10;
                firstNumber = firstNumber/10;

                while(lastNumber != 0)
                {
                    int lastOfLastNumber = lastNumber%10;
                    if(lastOfLastNumber == lastDigit)
                    {
                        System.out.println("true");
                        return true;
                    }

                    lastNumber = lastNumber/10;

                    if(lastOfLastNumber == lastDigit)
                    {
                        System.out.println("true");
                        return true;
                    }



                }
            }
        }
        System.out.println("false");
        return false;
    }
}
