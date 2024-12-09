public class PrimeNumberChallenge61 {

    public static void main(String[] args) {
        isPrime(10);
        System.out.println(primeCount(10,20));
    }
    public static boolean isPrime(int number)
    {
        int counter = 0;
        for (int i=1; i<=number/2; i++)
        {
            if(number%i==0)
                counter ++;
        }
        if(counter==1)
        {
            System.out.println(number+" is prime number");
            return true;
        }
        else
        {
            System.out.println(number+" is not prime number");
            return false;
        }
    }

    public static int primeCount(int startRange, int endRange)
    {
        int count = 0;
        for(int i=startRange; i<=endRange; i++)
        {
            if(isPrime(i))
            {
                count++;
                if(count==3)
                    break;
            }
        }
        return count;
    }
}
