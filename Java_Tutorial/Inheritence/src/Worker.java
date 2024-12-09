public class Worker {

    public String name;
    public String birthDate;
    public String endDate;

    public int getAge()
    {
        int age = Integer.parseInt(endDate)-Integer.parseInt(birthDate);
        return age;
    }

    public double collectPay(double salary)
    {
        return salary;
    }

    public void terminate(String endDate)
    {
        System.out.println("terminated on "+endDate);
    }


    public static void main(String[] args) {
        SalariedEmployee 
    }
}
