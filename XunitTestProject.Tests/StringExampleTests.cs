using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.IO;

namespace XunitTestProject.Tests
{
    public class StringExampleTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = StringExample.ExampleLoadTextFile("This is a valid file name");

            Assert.True(actual.Length > 10);
        }


        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<FileNotFoundException>(() => StringExample.ExampleLoadTextFile(""));
        }
    }
}
