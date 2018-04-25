using BabySittingTrackingApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BabySittingTrackingApp.Tests.Controllers
{
    [TestClass]
    public class BabySittingControllerTest
    {
        [TestMethod]
        public void whenBabySittingControllerIndexIsLoadedVerifyItIsNotNULL()
        {
            // Arrange
            BabySittingController controller = new BabySittingController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
