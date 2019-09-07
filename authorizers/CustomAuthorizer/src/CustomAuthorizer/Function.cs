using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CustomAuthorizer
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public object FunctionHandler(dynamic input, ILambdaContext context)
        {
            Console.WriteLine($"Input: {input}");

            string token = input.authorizationToken;
            token = token.Replace("Bearer ", "");

            Console.WriteLine($"Token: {token}");

            var policy = new
            {
                principalId = "principal",
                policyDocument = new
                {
                    Version = "2012-10-17",
                    Statement = new List<object> {
                        new {
                            Action = "execute-api:Invoke",
                            Effect = "Allow",
                            Resource = "arn:aws:execute-api:*:325090237772:*"
                        }
                    }
                }
            };

            Console.WriteLine($"Output: {JsonConvert.SerializeObject(policy)}");
            return JsonConvert.SerializeObject(policy);
        }
    }
}
