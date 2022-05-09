namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HelloTest()
        {
            var s = "hello world";
            var o = new ClassLibrary12.Class1();
            Assert.Equal(s, o.SayHello().ToLowerInvariant());
        }

        [Fact]
        public void GoodbyeTest()
        {
            var s = "goodbye world";
            var o = new ClassLibrary12.Class1();
            Assert.Equal(s, o.SayGoodbye().ToLowerInvariant());
        }

        [Fact]
        public void GoodbyeTestFail()
        {
            var s = "goodbye world!";
            var o = new ClassLibrary12.Class1();
            Assert.Equal(s, o.SayGoodbye().ToLowerInvariant());
        }
    }
}