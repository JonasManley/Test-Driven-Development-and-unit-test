using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Driven_Development;

namespace Test_project
{
    [TestClass]
    public class UnitTest1
    {
        // Naming convention used in the project:
        // [the name of the tested method]_[expected input / tested state]_[expected behavior].
        [TestMethod]
        public void TransferAmountBewteenAccounts_500kr_Successful()
        {
            //Arrange
            Account JonasAccount = new Account(1, 1000);
            Account ChristofferAccount = new Account(2, 2000);
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
            Account JonasAccount = new Account(1, 1000);
            Account ChristofferAccount = new Account(2, 2000);
            int TransferAmount = -500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert
           
        }
    }
}
