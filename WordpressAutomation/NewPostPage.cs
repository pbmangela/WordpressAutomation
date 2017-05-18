using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace WordpressAutomation
{
    public class NewPostPage
    {

        public static void GoTo()
        {
            var menuPost = Driver.Instance.FindElement(By.Id("menu-posts"));
            menuPost.Click();
            var addNew = Driver.Instance.FindElement(By.LinkText("Add New"));
            addNew.Click();
        }

        public static CreatePostCommand CreatePost(string title)
        {

            return new CreatePostCommand(title);
        }

        public static void GoToNewPost()
        {

            var message = Driver.Instance.FindElement(By.Id("message"));
            var newPostlink = message.FindElements(By.TagName("a"))[0];
            newPostlink.Click();
        }



    }



    public class CreatePostCommand
    {
        private readonly string title;
        private string boby;
        public CreatePostCommand(string title)
        {
            this.title = title;

        }

        public CreatePostCommand WithBoby(string boby)
        {
            this.boby = boby;
            return this;

        }


        public void Publish()
        {
           
            Driver.Instance.FindElement(By.Id("title-prompt-text")).SendKeys(title);
            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(boby);
            Driver.Instance.SwitchTo().DefaultContent();

            Thread.Sleep(1000);

            Driver.Instance.FindElement(By.Id("publish")).Click();



        }

    }

}


    

