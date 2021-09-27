using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    { 
        ValuesController controllers = new ValuesController();     

        [Fact]
        public void GetReturnMyName()
        {
              var returnValue = controllers.Get(1);
              Assert.Equal("Naveen", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
