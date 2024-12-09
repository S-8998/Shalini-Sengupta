import java.util.InputMismatchException;
import java.util.Scanner;

public class MinAndMaxChallenge {
    public static void main(String[] args) {
        int min = 0;
        int max = 0;
        int loopcount = 0;

        while(true)
        {
            Scanner scanner = new Scanner(System.in);
            System.out.println("Enter a valid number");

            try{
                int number = scanner.nextInt();

                if(loopcount==0 || number<min)
                {
                    min = number;
                    loopcount++;

                }

                if(number>max)
                {
                    max = number;

                }
            }
            catch (InputMismatchException e)
            {
                System.out.println("Minimum number"+min);
                System.out.println("Maximum number"+max);
                break;

            }

        }



    }
}
