import java.util.Scanner;

public class ReadingUserInputChallenge73 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        double sum = 0.0;
        int counter=1;

        while(counter<=5)
        {
            System.out.println("Enter number #"+counter);
            String nextNumber = sc.nextLine();

            try{
                double number = Double.parseDouble(nextNumber);
                counter++;
                sum = sum+number;
            } catch (NumberFormatException e)
            {
                System.out.println("Invalid Value");
            }


        }

        System.out.println("The sum = "+sum);

    }
}
