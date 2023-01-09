using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class CardHolder
    {
        private string cardNum;
        private int pin;
        private string firstName;
        private string lastName;
        private double balance;

        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getCardNum { get { return cardNum; } }   
        public int getPin { get { return pin; } }              
        public string getFirstName { get { return firstName; } }
        public string getLastName { get { return lastName; } }
        public double getBalance { get { return balance; } }

                
        public void SetNum(string newCardNum) { cardNum = newCardNum; } 
        public void SetPin(int newpin) { pin = newpin; }
        public void SetFirstName(string newfirstName) { firstName = newfirstName; }
        public void SetLastName(string newlastName) { lastName = newlastName; }
        public void SetBalance(double newbalance) { balance = newbalance; }



    }
}
