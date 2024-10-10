namespace ClassLibrary1;

public class BankAccount
{

    private string SavingsAccount;
    private int savingsBalance;
    public BankAccount(string SavingsAccount, int savingsBalance)
    {

        this.SavingsAccount = SavingsAccount;
        this.savingsBalance = savingsBalance;

    }

    public void Deposit(int amount)
    {
        this.savingsBalance = amount + this.savingsBalance;
    }

    public int GetBalance()
    {
        return savingsBalance;
    }

    public void AccountName(string name)
    {
        this.SavingsAccount = name;
    }

    public string GetName()
    {
        return SavingsAccount;
    }

    public void Withdraw(int amount)
    {
        savingsBalance -= amount;
    }
}


    public class Employee
    {


        private string _employeeId;

        public Employee(string id)
        {
            this._employeeId = id;
        }

        public void SetEmployeeId(string id)
        {
            this._employeeId = id;
        }

        public string GetEmployeeId()
        {
            return _employeeId;
        }

    }



    // 6. Test for modifying age to an invalid value
    public class Customer : Employee
    {

        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public Customer(string name, int age, string id) : base(id)
        {
            _name = name;
            _age = age;
        }

        public string GetCustomerDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }


    public class Manager
    {
        private string _managerID;
        private string _managerDept;
        public Manager(string managerID, string managerDeptartment)
        {
            this._managerID = managerID;
            this._managerDept = managerDeptartment;
        }

        public string GetManagerID()
        {
            return _managerID;
        }

        public void SetManagerID(string managerID)
        {

            this._managerID = managerID;
        }

        public void SetManagerDept(string managerDept)
        {

            this._managerDept = managerDept;
        }


        public string GetManagerDept()
        {
            return _managerDept;
        }
    }







    
