//Marcel Rodriguez
//10-25-22
//Greater than or less than endpoint
//This controller will ask for 2 numbers in the url and output which one is greater, less, or if they're equal
//Peer review - Lerissa Lazar / works well, gives correct answers for all 3 
//outputs (greater than, less than, equal to) good job!
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMGreaterThanOrLessThanEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("greater/{numberOne}/{numberTwo}")]

    public string GreaterThanOr(string numberOne, string numberTwo)
    {
        string result = "";
        int convertNum1 = Convert.ToInt32(numberOne);
        int convertNum2 = Convert.ToInt32(numberTwo);

        if(convertNum1>convertNum2)
        {
            result = $"{numberOne} is greater than {numberTwo}!";
        }
        else if(convertNum2>convertNum1)
        {
            result = $"{numberOne} is less than {numberTwo}!";
        }
        else
        {
            result = $"{numberOne} is equal to {numberTwo}!";
        }

        return result;
    }
}
