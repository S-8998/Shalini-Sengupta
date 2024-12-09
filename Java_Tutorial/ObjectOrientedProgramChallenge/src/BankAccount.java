public class BankAccount {

    private String accountNumber ;
    private double balance ;
    private String name ;
    private String email ;
    private String phoneNumber ;

    public String getAccountNumber() {
        return accountNumber;
    }

    public void setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public double deposit(double balance){
            double balanceAfterDeposit = this.balance+balance;

            return balanceAfterDeposit;
    }

    public double withdraw(double balance){
        double balanceAfterWithdraw = this.balance-balance;
        if(balanceAfterWithdraw<0)
        {
            System.out.println("Cannot withdraw balance");
        }

        return balanceAfterWithdraw;

    }


}
