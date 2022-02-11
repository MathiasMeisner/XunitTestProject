using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitTestProject.Tests
{
    public class MessageAdderTests
    {
        private readonly MessageAdder messageAdder;


        public MessageAdderTests()
        {
            messageAdder = new MessageAdder();
        }

        [Fact]
        public void IsMessageAdded_ShouldPass()
        {
            // arrange
            string message = "Hej";
            string sender = "Mathias";

            // act
            bool isAdded = messageAdder.IsMessageAdded(message, sender);

            // assert
            Assert.True(isAdded);
        }

        [Theory]
        [InlineData("hej", "Mathias")]
        public void IsMessageAdded_ShouldFail(string message, string sender)
        {
            // arrange

            // act
            bool isAdded = messageAdder.IsMessageAdded(message, sender);

            // assert

            Assert.False(isAdded);
        }
    }
}
