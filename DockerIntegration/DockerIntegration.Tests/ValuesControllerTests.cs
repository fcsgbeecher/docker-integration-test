using System;
using System.Linq;
using DockerIntegration.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DockerIntegration.Tests
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void CanGetValues()
        {
            var controller = new ValuesController();
            var vals = controller.Get();
            Assert.IsTrue(vals.Any());
        }
    }
}
