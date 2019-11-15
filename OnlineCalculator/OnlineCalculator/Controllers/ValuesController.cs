using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/values/GetFiveRandomNumbers

        [HttpGet("GetFiveRandomNumbers")]

        public List<int> GetFiveRandomNumbers()

        {

            var numbers = new List<int>();

            var rnd = new Random();

            int count = 0;

            while (count < 5)
            {

                int newNum = rnd.Next(1, 21); // generate a random number between 1- 20

                if (!numbers.Contains(newNum))
                {

                    numbers.Add(newNum);

                    count++;

                }

            }

            return numbers;

        }

        //  fun 2
        // GET api/values/To_reverse_sentence 

        [HttpGet("To_reverse_sentence")]
        public string To_reverse_sentence(string x)
        {
            if(x==null)
            {
                return "error";
            }

            string text = x;
            string newtext = null ;
            string[] words = text.Split(' ');
            int k = words.Length - 1;
            for (int i = k; i >= 0; i--)
            {
                newtext = newtext+ " "  + words[i];
                    
            }

            return newtext;

        }

        // fun 10
        // GET api/values/Location_of_letters

        [HttpGet("Location_of_letters")]
        public List<int> Location_of_letters(string x)
        {

            var numbers = new List<int>();
            if (x == null)
            {
                numbers.Add(-1); //means error
                return numbers;
            }
            char[] letters = x.ToCharArray();

            foreach (char c in letters)
            {
                if ((c > 64 && c < 91) || (c > 96 && c < 123))
                {
                    var index = (c < 97 ? c - 64 : c - 96);
                    numbers.Add(index);
                }
                else
                    numbers.Add(-1); //means error

            }
            return numbers;
        }


        // fun 13
        // GET api/values/Print_four_Arithmetic

        [HttpGet("Print_four_Arithmetic")]
        public List<double> Print_four_Arithmetic(double x, double y)
        {
            var numbers = new List<double>();

            numbers.Add(x + y);
            numbers.Add(x - y);
            numbers.Add(x * y);

            if (y == 0)
                numbers.Add(-1); //means error
            else
                numbers.Add(x / y);
            return numbers;
        }

        // fun 18
        // GET api/values/print_Word_from_index

        [HttpGet("print_Word_from_index")]
        public string print_Word_from_index(string x, int i)
        {
 
            if (i==0||x==null)
                return "error";

            string[] words = x.Split(' ');
            if (words.Length >= i && i > 0)
                return words[i - 1];
            else
                return "error";
        }

        // fun 19
        // GET api/values/Print_little_numbers
        
        [HttpGet("Print_little_numbers")]
        public List<int> Print_little_numbers(int x)
        {
            var numbers = new List<int>();

            if (x <= 0)
            {
                numbers.Add(-1); //means error
                return numbers;
            }
            for (int i = 0; i < x - 1; i++)
            {
                numbers.Add(i + 1);
            }
            return numbers;
        }

    }
}
