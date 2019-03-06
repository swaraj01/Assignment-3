using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input5point6and4point4_Returns10point0()
        {
            //Arrange
            double number1 = 5.6;
            double number2 = 4.4;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input2point3and3point7_Returns6point0()
        {
            //Arrange
            double number1 = 2.3;
            double number2 = 3.7;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input6point8and5point2_Returns12point0()
        {
            //Arrange
            double number1 = 6.8;
            double number2 = 5.2;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input7point8and5point6_Returns2point2()
        {
            //Arrange
            double number1 = 7.8;
            double number2 = 5.6;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]

        public void GetSubtraction_Input4point6and2point3_Returns2point3()
        {
            //Arrange
            double number1 = 4.6;
            double number2 = 2.3;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input9point1and5point1_Returns4point0()
        {
            //Arrange
            double number1 = 9.1;
            double number2 = 5.1;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input10point5and2point1_Returns5point0()
        {
            //Arrange
            double number1 = 10.5;
            double number2 = 2.1;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input18point0and3point0_Returns6point0()
        {
            //Arrange
            double number1 = 18.0;
            double number2 = 3.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input8point4and2point4_Returns4point2()
        {
            //Arrange
            double number1 = 8.4;
            double number2 = 2.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplcation_Input4point3and2point0_Returns8point6()
        {
            //Arrange
            double number1 = 4.3;
            double number2 = 2.0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplcation_Input4point4and4point1_Returns16point4()
        {
            //Arrange
            double number1 = 4.0;
            double number2 = 4.1;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplcation_Input9point4and2point5_Returns23point5()
        {
            //Arrange
            double number1 = 9.4;
            double number2 = 2.5;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input1and3_Returns0point3()
        {
            //Arrange
            double number1 = 1;
            double number2 = 3;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input2and1_Returns2()
        {
            //Arrange
            double number1 = 2;
            double number2 = 1;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input9and3_Returns3()
        {
            //Arrange
            double number1 = 9;
            double number2 = 3;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

