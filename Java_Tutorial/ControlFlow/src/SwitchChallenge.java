public class SwitchChallenge {
    public static void main(String[] args) {
        char nato = 'd';

        switch (nato){
            case 'a'-> System.out.println("Able");
            case 'b'-> System.out.println("Baker");
            case 'c'-> System.out.println("Charlie");
            case 'd'-> System.out.println("Dog");
            case 'e'-> System.out.println("Easy");
            default -> System.out.println("not matching");
        }
    }
}
