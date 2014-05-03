using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitHutTestProject.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndexMoreThanTen()
        {
            List<Translation> translations = new List<Translation>();
            for (int i = 0; i < 15; i++)
            {
                translations.Add(new Translation{
                    ID = i,
                    namespace = "Translation " + i.ToString();,
                    DateTime = DateTime.Now.AddDays(i),
                    UserWhoAdded = "dabs"
                }
            }
        }
    }
}
