using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;


namespace WordpressTests
{

    [TestClass]
   public  class PageTests
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialized();
        }

        [TestMethod]
        public void Can_Edit_A_Page()
        {
            LoginPage.Goto();
            LoginPage.LoginAs("paolaqa").WithPassword("LuzAmy210390*").Login();

            ListPostPage.Goto(PostType.Page);
            ListPostPage.SelectPost("Sample Page");

           //Assert.IsTrue(NewPostPage.IsInEditMode(), "Was not in edit mode");
          //  Assert.AreEqual("Sample Page", NewPostPage.Title, " Title did not match");




        }



        [TestCleanup]
         public void Cleanup()
        {
            Driver.Close();


        }

    }
}
