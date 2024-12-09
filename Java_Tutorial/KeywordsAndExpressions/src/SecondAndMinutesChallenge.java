public class SecondAndMinutesChallenge {
    public static void main(String[] args) {
        System.out.println(getDurationString(3954));

    }
    public static String getDurationString(int seconds)
    {
        if(seconds<0)
        {
            return "Invalid";
        }


        return getDurationString(seconds/60,seconds%60);
    }

    public static String getDurationString(int minutes,int seconds)
    {
        if(minutes<0 || seconds>59)
        {
            return "Invalid";
        }

        int hours = minutes/60;

        int remainingMinutes=minutes%60;
        int remainingSeconds=seconds%60;

        return hours+" h "+remainingMinutes+" m "+remainingSeconds+" s ";

    }
}
