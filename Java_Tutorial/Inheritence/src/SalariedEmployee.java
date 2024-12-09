public class SalariedEmployee extends Employee{

    public double annualSalary;
    public boolean isRetired;

    public void retire()
    {
        if(Integer.parseInt(endDate)>Integer.parseInt(hireDate))
        {
            isRetired=true;
            System.out.println(isRetired);
        }
    }
}
