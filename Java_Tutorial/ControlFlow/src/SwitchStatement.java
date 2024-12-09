public class SwitchStatement {
    public static void main(String[] args) {
        int switchValue = 4;

//        switch (switchValue){
//            case 1 :
//                System.out.println("Value is 1");
//                break;
//            case 2 :
//                System.out.println("Value is 2");
//                break;
//            case 3: case 4: case 5:
//                System.out.println("was a 3 or a 4 or a 5");
//                break;
//            default:
//                System.out.println("Neither 1, 2, 3, 4, 5");
//                break;

        // enhanced switch statement after version 14
        switch (switchValue) {
            case 1 -> System.out.println("Value is 1");
            case 2 -> System.out.println("Value is 2");
            case 3, 4, 5 -> System.out.println("was a 3 or a 4 or a 5");
            default -> System.out.println("Neither 1, 2, 3, 4, 5");
        }
        String quarter = quarter("April");
        System.out.println(quarter);
    }

    public static String quarter(String month)
    {
        switch (month) {
            case "JANUARY", "February", "March" -> {
                return "1st quarter";
            }
            case "April", "May", "June" -> {
                return "2nd quarter";
            }
            case "July", "August", "September" -> {
                return "3rd quarter";
            }
            case "October", "November", "December" -> {
                return "4th quarter";
            }
        }
        return "bad";
    }
}
