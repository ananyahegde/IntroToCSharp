namespace IntroApp
{
    internal class Account
    {
        // defining property in c# with getters and setters

        // private int _accountNumber;
        // private int getAccountNumber() {
        //     return _accountNumber;
        // }
        // private void setAccountNumber(int value) {
        //     _accountNumber = value;
        // }

        // shorthand
        public string accountNumber { get; set; } // string because you aint doing any math with this number.
                                                  // also solves the longint or unsurity of number or digits.
        public string accountHolderName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phone { get; set; }
        public double balance { get; set; }

        public Account()
        {
            Console.WriteLine("Nothing to see here.");
        }

        public Account(string accountNumber, string accountHolderName, DateTime dateOfBirth, string phone, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.dateOfBirth = dateOfBirth;
            this.phone = phone;
            this.balance = balance;
        }

        // override ToString() method of Object base class
        public override string ToString()
        {
            return $"Account Number: {accountNumber}, Account Holder Name: {accountHolderName}, Date of Birth: {dateOfBirth}, Phone: {phone}, Balance: {balance}";
        }
    }
}
