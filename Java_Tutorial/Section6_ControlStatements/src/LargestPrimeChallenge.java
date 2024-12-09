public class LargestPrimeChallenge {

    public static void main(String[] args) {
        System.out.println(largestPrimeNumber(217));
    }

    public static int largestPrimeNumber(int number)
    {
        int divisor = 0;
        int prime = 0;


        for(int i=1; i<=number; i++)
        {
            if(number%i==0)
            {
                int count = 0;
                while (i>divisor)
                {
                    divisor = i;
                    for(int j=1; j<=divisor; j++)
                    {
                        if(divisor%j==0)
                            count ++;


                    }

                    if(count==2)
                        prime = divisor;
                }

            }
        }

        return prime;
    }
}
