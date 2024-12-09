public class SecondsAndMinutesChallenge53 {

    public static void main(String[] args) {
         System.out.println(getDurationString(3945));
    }
    public static String getDurationString(int seconds)
    {
        if(seconds<0)
        {
            return "invalid value";
        }

            int minutes = seconds/60;
            return getDurationString(minutes,seconds%60);


    }

    public static String getDurationString(int minutes, int seconds)
    {
        if(minutes<0)
            return "invalid";

        if(seconds<0 || seconds>59)
            return "invalid";

        int hour = minutes/60; //hour 1

        int remainingMinutes = minutes%60; //min 5


        return hour+" h "+remainingMinutes+" m "+seconds+" s";
    }
}

