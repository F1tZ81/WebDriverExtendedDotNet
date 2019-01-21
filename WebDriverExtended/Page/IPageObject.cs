﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace WebDriverExtended.Page
{
    /// <summary>
    /// A basic page object interface
    /// </summary>
    public interface IPageObject
    {
        IWebDriver Driver { get; }
        string DisplayName { get; }

        /// <summary>
        /// Navigate to an address
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="url"></param>
        void Navigate(IWebDriver driver, string url);

        /// <summary>
        /// Navigate to an address
        /// </summary>
        /// <param name="url"></param>
        void Navigate(string url);
        

    }
}
