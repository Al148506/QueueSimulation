using Queue;

namespace QueueTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestPeekOnce()
        {
            Program program = new Program();
            program.Insert(1);
            program.Insert(2);
            int number = program.Seek();
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void TestPeekEmpty()
        {
            Program program = new Program();

            Assert.ThrowsException<ArgumentException>(() => program.Seek());
        }

        [TestMethod]
        public void TestPeekMultiple()
        {
            Program program = new Program();
            program.Insert(1);
            program.Insert(2);
            int number1 = program.Seek();
            program.Insert(3);
            int number2 = program.Seek();
            Assert.AreEqual(1, number1);
            Assert.AreEqual(number1, number2);
        }

        [TestMethod]
        public void TestUnqueueUnique()
        {
            Program program = new Program();
            program.Insert(1);
            Assert.AreEqual(1, program.Delete());
            Assert.IsTrue(program.IsEmpty());
        }

        [TestMethod]
        public void TestUnqueueMultiple()
        {
            Program program = new Program();
            program.Insert(1);
            program.Insert(2);
            Assert.AreEqual(1, program.Delete());
            Assert.AreEqual(2, program.Delete());
            Assert.IsTrue(program.IsEmpty());
        }
    }
}
