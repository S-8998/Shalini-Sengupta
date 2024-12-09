public class EvenNumberChallenge65 {

    public static void main(String[] args) {
        int number = 5;
        int countofEven = 0;
        int countofOdd = 0;
        while(number<=20)
        {
            if(isEvenNumber(number))
            {
                System.out.println(number+" is even number");
                countofEven++;
            }
            else
            {
                System.out.println(number+" is odd number");
                countofOdd++;
            }
            number++;
            if(countofEven==5)
                break;
        }

        System.out.println("Even number count"+countofEven);
        System.out.println("Odd number count"+countofOdd);
    }
    public static boolean isEvenNumber(int number)
    {
        if(number%2==0)
            return true;
        else
            return false;
    }
}
