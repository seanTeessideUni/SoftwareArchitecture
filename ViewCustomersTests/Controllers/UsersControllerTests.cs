using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViewCustomers.Controllers;

namespace ViewCustomers.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            ViewResult result = controller.Details() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        public void Edit()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            ViewResult result = controller.Edit() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        public void Delete()
        {
            // Arrange
            UsersController controller = new UsersController();

            // Act
            ViewResult result = controller.Delete() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
