public class Methods {
    public static void main(String[] args) {

        displayHighScorePosition("Tim",calculateHighScorePosition(700));
    }

    public static void displayHighScorePosition(String playersName,int playersPosition)
    {

       System.out.println(playersName+ " managed to get into position "+playersPosition+" on the high score list");
    }

    public static int calculateHighScorePosition(int score)
    {
        int playersPosition;
        if(score>=1000)
        {
            playersPosition=1;
            System.out.println("Result : 1");
        } else if (score>=500 && score<=1000) {
            playersPosition=2;
            System.out.println("Result : 2");
        } else if (score>=100 && score<=500) {
            playersPosition=3;
            System.out.println("Result : 3");
        }
        else{
            playersPosition=4;
            System.out.println("Result : 4");
        }
        return playersPosition;
    }
}
