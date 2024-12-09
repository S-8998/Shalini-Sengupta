public class Customer {

    private String name;
    private double creditLimit;
    private String email;

    public String getName() {
        return name;
    }

    public double getCreditLimit() {
        return creditLimit;
    }

    public String getEmail() {
        return email;
    }

    public Customer(String name, double creditLimit, String email)
    {
        this.name=name;
        this.creditLimit=creditLimit;
        this.email=email;
        System.out.println("All Arguments constructor");
    }

    public Customer()
    {
        this("Tim",30000,"Tim@gmai.com");
        System.out.println("Empty Constructor");
    }

    public Customer(double creditLimit)
    {
        this("Shalini",creditLimit,"Shalini@gmail.com");
        System.out.println("Single Arguments constructor" + creditLimit);
    }
}
