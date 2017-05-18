using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordpressTests
{
    [TestClass]
  public  class CreatePostTests
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialized();

        }


        [TestMethod]
        public void Can_Create_A_Basis_Post()
        {
            LoginPage.Goto();
            LoginPage.LoginAs("paolaqa").WithPassword("LuzAmy210390*").Login();
            NewPostPage.GoTo();
            NewPostPage.CreatePost("this is the test post title")
                .WithBoby("Mi, this is the boby")
                .Publish();



            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "This is the post title", "Title is not match new post ");



        }

        [TestCleanup]

        public void Cleanup()
        {

         //   Driver.Close();
        }
    }
}
