using ATMConsoleApp;
using System.Security;

internal class Program
{
    private static void Main(string[] args)
    {

        void printOptions()
        {
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }


        void deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.SetBalance(currentUser.getBalance + deposit);

            Console.WriteLine("Thank you! Your deposit is complete! Your new balance is: " + currentUser.getBalance);
        }

        void withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());

            if(currentUser.getBalance < withdraw)
            {
                Console.WriteLine("You have insufficent balance!");
            }
            else
            {
                currentUser.SetBalance(currentUser.getBalance - withdraw);
                Console.WriteLine("Withdrawal successfull!");
                Console.WriteLine("Your new balance is: " + currentUser.getBalance);
            }
        }

        void balance(CardHolder currentUser)
        {
            Console.WriteLine("Your current balance is: " + currentUser.getBalance);
        }


        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("1233454565675",1234,"John","Smith",150.40));
        cardHolders.Add(new CardHolder("1233454548466",3211, "Mary", "White", 250.40));
        cardHolders.Add(new CardHolder("1233454347563",7899, "Brian", "Wazalwski", 800.40));
        cardHolders.Add(new CardHolder("3453423454544",4566, "Jack", "Uderwood", 350.40));
        cardHolders.Add(new CardHolder("1233454564562",9855, "Marta", "Sallsbury", 1050.40));

        //Prompt the user
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your card number:" );

        string cardNumber = "";
        CardHolder currentUser;

        while (true)
        {
            try
            {
                cardNumber = Console.ReadLine();

                currentUser = cardHolders.FirstOrDefault(a => a.getCardNum == cardNumber);
                if(currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not recgonized. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Card not recgonized. Please try again.");
            }
        }

        Console.WriteLine("PLease enter your pin: ");

        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());

                if(currentUser.getPin == userPin) 
                { 
                    break; 
                }
                else
                {
                    Console.WriteLine("Incorrect pin. Please try again.");
                }

            }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again.");
            }
           


        }

        Console.WriteLine("Welcome " + currentUser.getFirstName + "!");
        int option = 0;

        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if(option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }

        } while (option != 4);
        Console.WriteLine("Thank you! Have a nice day!");

    }



}