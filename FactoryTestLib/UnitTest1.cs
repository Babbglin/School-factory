using System;
using FactoryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNackademinFactory()
        {
            //Arrange
            NackademinFactory o = new NackademinFactory();
            IEducation e = o.CreatEducation();
            int expected = 22;
            //Act
            int actual = e.NumberOfStudents;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestJensenFactory()
        {
           JensenEducationFactory o = new JensenEducationFactory();
            IEducation e = o.CreatEducation();
            int expected = 17;

            int actual = e.NumberOfStudents;

            Assert.AreEqual(expected, actual);
        }
    }
}
