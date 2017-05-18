using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;





namespace WordpressTests
{
    [TestClass]
    public class LoginTest
    {


        [TestInitialize]
        public void Init()
        {
            Driver.Initialized(); 

        }


        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.Goto();
            LoginPage.LoginAs("paolaqa").WithPassword("LuzAmy210390*").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login");


                

        }

        [TestCleanup]

        public void Cleanup()
        {

            Driver.Close();

        }
    }
}

