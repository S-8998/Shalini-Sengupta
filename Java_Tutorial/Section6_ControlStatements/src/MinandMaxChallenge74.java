import java.util.Scanner;

public class MinandMaxChallenge74 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String nextNumber;
        int min = 0;
        int max = 0;
        int count = 0;

        while(true)
        {
            System.out.println("Enter a valid number");
            try
            {
                nextNumber = sc.nextLine();
                int number = Integer.parseInt(nextNumber);
                if(count==0 || number<min)
                {
                    min=number;

                }
                if(count == 0 || number>max)
                {
                    max = number;

                }
                count++;
            } catch (NumberFormatException e)
            {
                System.out.println("Invalid number");
                break;
            }
        }

        if(count>0)
        {
            System.out.println("Min "+min+" And Max "+max);
        }
    }
}
