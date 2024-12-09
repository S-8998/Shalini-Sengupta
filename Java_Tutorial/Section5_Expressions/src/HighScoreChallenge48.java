public class HighScoreChallenge48 {

    public static void main(String[] args) {
        calculateHighScorePosition(25);
    }

    public static void displayHighScorePosition( String name, int position)
    {
        System.out.println(name+ " managed to get into position "
                + position +" on the high score list");
    }

    public static int calculateHighScorePosition(int score)
    {
        if ( score >= 1000 )
        {
            displayHighScorePosition("Tim",1);
        }
        else if( score >= 500 && score < 1000 )
        {
            displayHighScorePosition("Tim",2);
        }
        else if( score >= 100 && score < 500 )
        {
            displayHighScorePosition("Tim",3);
        }
        else
        {
            displayHighScorePosition("Tim",4);
        }
        return score;
    }
}
