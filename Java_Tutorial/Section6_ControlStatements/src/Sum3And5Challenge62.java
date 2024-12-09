public class Sum3And5Challenge62 {

    public static void main(String[] args) {
        int count=0;
        int sum=0;
        for(int i=1; i<=1000; i++)
        {
            if(i%3==0 && i%5==0)
            {
                System.out.println(i);
                count++;
                sum = sum+i;
                if(count==5)
                    break;
            }
        }
        System.out.println("count is "+count);
        System.out.println("sum is "+sum);
    }
}
