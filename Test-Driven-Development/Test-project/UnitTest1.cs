using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Test_Driven_Development;

namespace Test_project
{
    [TestClass]
    public class UnitTest1
    {
        // Naming convention used in the project:
        // [the name of the tested method]_[expected input / tested state]_[expected behavior].
        // Mock objects:  Mock<Customer> customerJonas = new Mock<Customer>();


        [TestMethod]
        public void TransferAmountBewteenAccounts_500kr_Successful()
        {
            //Arrange
            Customer customerJonas = new Customer("2206921111", "Jonas pedersen");
            Customer customerChristoffer = new Customer("2206921111", "Christoffer dunk");
            Account JonasAccount = new Account(1, customerJonas, 1000);
            Account ChristofferAccount = new Account(2, customerChristoffer, 2000);
            int TransferAmount = 500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert
            Assert.AreEqual(TransferAmount + ChristofferStatingBalance, ChristofferAccount.getBalance());
        }
       

        [TestMethod]
        public void TransferAmountBewteenAccounts_500kr_Successful_Mock()
        {
            //Arrange
            Customer customerJonas = new Customer("2206921111", "Jonas pedersen");
            Customer customerChristoffer = new Customer("2206921111", "Christoffer dunk");
            Account JonasAccount = new Account(1, customerJonas, 1000);
            Account ChristofferAccount = new Account(2, customerChristoffer, 2000);
            int TransferAmount = 500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert
            Assert.AreEqual(TransferAmount + ChristofferStatingBalance, ChristofferAccount.getBalance());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Amount is negative")]
        public void TransferNegativeAmountBewteenAccounts_Minus500kr_ExecptionThrown()
        {
            //Arrange 
            Customer customerJonas = new Customer("2206921111", "Jonas pedersen");
            Customer customerChristoffer = new Customer("2206921111", "Christoffer dunk");
            Account JonasAccount = new Account(1, customerJonas, 1000);
            Account ChristofferAccount = new Account(2, customerChristoffer, 2000);

            int TransferAmount = -500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //DateTime dateTime = DateTime.Now;
            //Movement movement = new Movement(TransferAmount, dateTime);

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert

        }

        [TestMethod]
        public void CreateAccountWith0Balance_Successful()
        {
            //Arrange
            Customer customerJonas = new Customer("2206921111", "Jonas pedersen");
            Account JonasAccount = new Account(1, customerJonas, 1000);
            int TransferAmount = 0;

            //Act

            //Assert
            Assert.AreEqual(0, JonasAccount.getBalance());
        }


        public void CheckBalance_1000kr_Successful()
        {
            //Arrange
            Customer customerJonas = new Customer("2206921111", "Jonas pedersen");
            Account JonasAccount = new Account(1, customerJonas, 1000);

            //Act 
            double currentBalance = JonasAccount.getBalance();

            //Assert
            Assert.AreEqual(1000, currentBalance);
        }
    }
}
