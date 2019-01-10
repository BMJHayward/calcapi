using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace calcApi.Controllers
{
    public class CalcController : ApiController
    {
        // GET: api/calc/getadd/1/1
        public object GetAdd(double leftOp = 0, double rightOp = 0) => new
        {
            operation = "add",
            arguments = new List<double> { leftOp, rightOp },
            result = leftOp + rightOp
        };

        // GET: api/calc/getsub/1/1
        public object GetSub(double leftOp = 0, double rightOp = 0) => new
        {
            operation = "subtract",
            arguments = new List<double> { leftOp, rightOp },
            result = leftOp - rightOp
        };

        // GET: api/calc/getmul/1/1
        public object GetMul(double leftOp = 1, double rightOp = 1) => new
        {
            operation = "multiply",
            arguments = new List<double> { leftOp, rightOp },
            result = leftOp * rightOp
        };

        // GET: api/calc/getdiv/1/1
        public object GetDiv(double leftOp = 1, double rightOp = 1) => new
        {
            operation = "divide",
            arguments = new List<double> { leftOp, rightOp },
            result = leftOp / rightOp
        };
    }
}
