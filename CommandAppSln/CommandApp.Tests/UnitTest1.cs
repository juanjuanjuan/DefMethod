using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Collections.Generic;

namespace CommandApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program _program;

        public UnitTest1() {
            Console.WriteLine(Environment.CurrentDirectory);
            _program = new Program();
        }

        [TestMethod]
        public void FilesExist()
        {
            Assert.IsTrue(File.Exists(@"..\..\..\..\Files\def-method-code-test-input-files\pipe.txt"));
            Assert.IsTrue(File.Exists(@"..\..\..\..\Files\def-method-code-test-input-files\comma.txt"));
            Assert.IsTrue(File.Exists(@"..\..\..\..\Files\def-method-code-test-input-files\space.txt"));
        }

        [TestMethod]
        public void PipeFileContet()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\..\Files\def-method-code-test-input-files\pipe.txt");
            Assert.AreNotEqual(0, lines.Length);
        }

        [TestMethod]
        public void CommaFileContent()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\..\Files\def-method-code-test-input-files\comma.txt");
            Assert.AreNotEqual(0, lines.Length);
        }

        [TestMethod]
        public void SpaceFileContent()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\..\Files\def-method-code-test-input-files\space.txt");
            Assert.AreNotEqual(0, lines.Length);
        }
    }
}
