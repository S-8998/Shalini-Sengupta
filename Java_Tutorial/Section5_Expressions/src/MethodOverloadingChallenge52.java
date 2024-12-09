public class MethodOverloadingChallenge52 {

    public static void main(String[] args) {
        System.out.println("5 ft 8 inches = "+convertToCentimeters(5,8)+" cm");
        System.out.println("68 inches = "+convertToCentimeters(68)+" cm");
    }

    public static double convertToCentimeters(int inch)
    {
        return inch*2.54;
    }

    public static double convertToCentimeters(int feet, int inch)
    {
        inch = (feet*12)+inch;
        return convertToCentimeters(inch);
    }
}
