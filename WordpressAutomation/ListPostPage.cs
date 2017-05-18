﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace WordpressAutomation
{
    public class ListPostPage
    {


        public static void Goto(PostType postType)
        { 
            switch (postType)
            {
                case PostType.Page:
                    Driver.Instance.FindElement(By.Id("menu-pages")).Click();
                    Driver.Instance.FindElement(By.LinkText("All Pages")).Click();
                    break;






             }



    }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText("Sample Page"));
            postLink.Click();

        }
    }



    public enum PostType
    {

        Page

    }


}
