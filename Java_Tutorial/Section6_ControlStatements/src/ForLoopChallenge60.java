public class ForLoopChallenge60 {

    public static void main(String[] args) {

        for(double rate=7.5; rate <= 10; rate += 0.25)
        {
            double interest = calculateInterest(100.00,rate);

            if(interest>8.5)
                break;

            System.out.println(interest);
        }

    }
    public static double calculateInterest(double amount, double rate)
    {
        return (amount*(rate/100));
    }
}
