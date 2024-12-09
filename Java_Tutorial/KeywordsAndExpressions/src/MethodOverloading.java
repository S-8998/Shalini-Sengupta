public class MethodOverloading {
    public static void main(String[] args) {
        double result = convertToCentimeters(5,8);
        System.out.println(result);
    }

    public static double convertToCentimeters(int height)
    {
        return (double)height*2.54;
    }

    public static double convertToCentimeters(int feet,int inches)
    {
        inches = inches+feet*12;
        return(convertToCentimeters(inches));


    }
}
