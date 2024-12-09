public class Hello {
    public static void main(String[] args) {
        System.out.println("Hello Shalini");
        System.out.println("Hello Shalini");

        boolean isAlien=false;
        if(isAlien == false)
        {
            System.out.println("Alien is not true");
        }

        int topScore=80;
        if(topScore!=100)
        {
            System.out.println("Ypu got the high score");
        }

        int secondTopScore=81;
        if(topScore < secondTopScore || topScore <70)
        {
            System.out.println("true");
        }

        //boolean
        boolean isCar=true;
                if(isCar)
                {
                    System.out.println("Car is true");
                }
                else if (!isCar)
                {
                    System.out.println("Car is false");
                }

        //ternary operator
         String makeofCar="VolksWagen";
                boolean isDomestic = makeofCar == "VolksWagen"?false : true;

          if(!isDomestic)
          {
              System.out.println("domestic");
          }
    }
}
