using NUnit.Framework;
using System;
using System.Collections.Generic;
using calcApi.Controllers;

namespace calcApi.Tests
{
    [TestFixture]
    public class ControllerTest
    {
        [Test]
        public void AddTestCase()
        {
        	double leftOp = 2;
        	double rightOp = 2;
        	var testData = new {
	            operation = "add",
	            arguments = new List<double> { leftOp, rightOp },
	            result = leftOp + rightOp
	        };
        	var controller = new CalcController();
        	var result = controller.GetAdd(leftOp, rightOp);
        	Assert.AreEqual(result.ToString(), testData.ToString());
        }

        [Test]
        public void SubtractTestCase()
        {
        	double leftOp = 2;
        	double rightOp = 2;
        	var testData = new {
	            operation = "subtract",
	            arguments = new List<double> { leftOp, rightOp },
	            result = leftOp - rightOp
	        };
        	var controller = new CalcController();
        	var result = controller.GetSub(leftOp, rightOp);
        	Assert.AreEqual(result.ToString(), testData.ToString());
        }

        [Test]
        public void MultiplyTestCase()
        {
        	double leftOp = 2;
        	double rightOp = 2;
        	var testData = new {
	            operation = "multiply",
	            arguments = new List<double> { leftOp, rightOp },
	            result = leftOp * rightOp
	        };
        	var controller = new CalcController();
        	var result = controller.GetMul(leftOp, rightOp);
        	Assert.AreEqual(result.ToString(), testData.ToString());
        }

        [Test]
        public void DivideTestCase()
        {
        	double leftOp = 2;
        	double rightOp = 2;
        	var testData = new {
	            operation = "divide",
	            arguments = new List<double> { leftOp, rightOp },
	            result = leftOp / rightOp
	        };
        	var controller = new CalcController();
        	var result = controller.GetDiv(leftOp, rightOp);
        	Assert.AreEqual(result.ToString(), testData.ToString());
        }
    }
}
