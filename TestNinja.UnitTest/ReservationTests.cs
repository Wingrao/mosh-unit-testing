using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CaneBeCancelledBy_UserIsAdmin_ReturnesTrue()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            Assert.IsTrue(result);

        }
        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
