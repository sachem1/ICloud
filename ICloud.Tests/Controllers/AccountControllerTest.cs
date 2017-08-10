using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICloud.Controllers;

namespace ICloud.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void GetAccountList()
        {
            AccountController account = new AccountController();
            account.ForgotPassword();
        }
    }
}
