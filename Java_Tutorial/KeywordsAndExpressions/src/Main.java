public class Main {
    public static void main(String[] args) {
//        boolean gameOver=true;
//        int score = 800;
//        int levelCompleted = 5;
//        int bonus = 100;

        //int finalScore = score;

        int highScore = calculateScore(true,100,9,200);
        System.out.println(highScore);

        System.out.println(calculateScore(true,10000,8,200));

//        if(gameOver)
//        {
//            finalScore += (levelCompleted * bonus);
//            System.out.println("your final score is "+ finalScore);
//        }


    }

    public static int calculateScore(boolean gameOver,int score,int levelCompleted,int bonus)
    {
        int finalScore = score;
        if(gameOver)
        {
            finalScore += (levelCompleted * bonus);
            finalScore += 1000;
            System.out.println("Final score "+finalScore);
        }
        return finalScore;
    }
}
