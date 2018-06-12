using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestSelenium
{
    public partial class Form1 : Form
    {
        public static IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
            // Khởi tạo webDriver trên chrome.
            InitSelenium();
        }

        private void InitSelenium()
        {
            // Các định dạng (Tùy chọn) của chrome.
            ChromeOptions chromeOpt = new ChromeOptions();
            // Tùy chọn về kích thước chrome.
            chromeOpt.AddArguments("--windown-size=1000,500");
            // Tùy chọn chrome ẩn danh (Nếu c thích :)) )
            // chromeOpt.AddArguments("--incognito");
            driver = new ChromeDriver(chromeOpt);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            if (url.Equals(""))
            {
                url = "https://code.luongit.pro";
            }
            driver.Navigate().GoToUrl(url);
            // Đợi 2 s cho hành đồng.
            Thread.Sleep(2000);
            if (rdTimKiem.Checked) {
                driver.FindElement(By.ClassName("input-search")).SendKeys("Áo da" + OpenQA.Selenium.Keys.Enter);
            }
            else if (rdDangNhap.Checked)
            {

            }
            else {
                driver.FindElement(By.ClassName("input-search")).SendKeys("Áo dạ" + OpenQA.Selenium.Keys.Enter);
                // Đợi 2 s cho hành đồng.
                Thread.Sleep(2000);
                driver.FindElement(By.ClassName("item")).Click();
            }
        }
    }
}
