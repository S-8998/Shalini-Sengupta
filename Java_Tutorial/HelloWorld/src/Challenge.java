public class Challenge {
    public static void main(String[] args) {

        double firstValue = 24.00d;
         double secondValue = 31.00d;

         double total = (firstValue + secondValue) * 100;

        double remainder = total % 40.0;

        boolean isValue;

        if (remainder==0.0)
        {
            isValue=true;
            System.out.println("true");
        }
        else
        {
            isValue=false;
            System.out.println("got some remainder"+remainder);
        }
    }




}
