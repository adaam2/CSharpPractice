using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace CSharpPractice
{
    class Asynchrony
    {
        public Asynchrony()
        {
            try
            {
                //int length = await ExampleMethodAsync();
                // Note that you could put "await ExampleMethodAsync()" in the next line where
                // "length" is, but due to when '+=' fetches the value of ResultsTextBox, you
                // would not see the global side effect of ExampleMethodAsync setting the text.
               
            }
            catch (Exception)
            {
                // Process the exception if one occurs.
            }
        }
        public async Task<int> ExampleMethodAsync()
        {
            var httpClient = new HttpClient();
            int exampleInt = (await httpClient.GetStringAsync("http://msdn.microsoft.com")).Length;
            
            // After the following return statement, any method that's awaiting
            // ExampleMethodAsync (in this case, StartButton_Click) can get the 
            // integer result.
            return exampleInt;
        }
    }
}
