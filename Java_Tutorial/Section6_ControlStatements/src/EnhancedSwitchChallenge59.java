public class EnhancedSwitchChallenge59 {

    public static void main(String[] args) {
        printDayOfWeek(0);
    }
    public static void printDayOfWeek(int day)
    {
        switch (day)
        {
            case 0 -> System.out.println(day+" is Sunday");
            case 1 -> System.out.println(day+" is Monday");
            case 2 -> System.out.println(day+" is Tuesday");
            case 3 -> System.out.println(day+" is Wednesday");
            case 4 -> System.out.println(day+" is Thursday");
            case 5 -> System.out.println(day+" is Friday");
            case 6 -> System.out.println(day+" is Saturday");
            default -> System.out.println(day+" is Invalid day");
        }
    }
}
