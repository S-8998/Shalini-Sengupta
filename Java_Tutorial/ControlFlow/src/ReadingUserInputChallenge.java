import java.util.Scanner;

public class ReadingUserInputChallenge {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int sum = 0;
        int count = 1;
        while(count<=5)
        {


            System.out.println("Enter number #"+count);
            String integer = scanner.nextLine();
            try{
                int nextNumber = Integer.parseInt(integer);
                count++;
                sum = sum + nextNumber;
            }
            catch (NumberFormatException e)
            {
                System.out.println("Invalid number");
            }
        }

        System.out.println(sum);
    }


}
