using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManClass;

namespace HangmanTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkGuess()
        {
            //arrange
            var h1 = new Hangman();

            //act
            h1.checkGuess('g', "good");

            //assert
            Assert.AreEqual()

        }
    }
}
