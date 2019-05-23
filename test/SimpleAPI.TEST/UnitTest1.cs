using System;
using Xunit;
using SimpleAPI.Controllers;



namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        public UnitTest1()
        {
        }

        [Fact]
        public void GetReturnesMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("ib sy", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
