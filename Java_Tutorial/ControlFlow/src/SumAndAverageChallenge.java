import java.util.InputMismatchException;
import java.util.Scanner;

public class SumAndAverageChallenge {

    public static void main(String[] args) {
        double sum = 0;
        long avg = 0;
        int loopcount = 0;

        while(true)
        {
            Scanner scanner = new Scanner(System.in);

            try{
                int number = scanner.nextInt();
                loopcount++;
                sum = sum + number;
                avg = Math.round((double)sum/loopcount);
            }




            catch(InputMismatchException e)
            {
                System.out.println("SUM = "+sum+" AVG = "+avg);
                break;
            }

        }
    }
}
