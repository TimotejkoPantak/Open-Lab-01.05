using NUnit.Framework;

namespace Open_Lab_01._05
{
    [TestFixture]
    public class Tests
    {
        [TestCase(true, false)]
        [TestCase(false, true)]
        public void Reverse(bool input, bool output)
        {
            output = !input;
            return;
        }
    }
}