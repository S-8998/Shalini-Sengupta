using System;
using Newtonsoft.Json.Linq;

namespace CSharpSeleniumFramework.utilities
{
	public class JsonReader
	{
		public JsonReader()
		{
		}

		public string extractData(String tokenName)
		{
			String myJsonString = File.ReadAllText("utilities/TestData.json");

            var jsonObject = JToken.Parse(myJsonString);
			return jsonObject.SelectToken(tokenName).Value<String>();
		}

        public string[] extractDataArray(String tokenName)
        {
            String myJsonString = File.ReadAllText("utilities/TestData.json");

            var jsonObject = JToken.Parse(myJsonString);
            List<String> productsArray = jsonObject.SelectTokens(tokenName).Values<string>().ToList();
			return productsArray.ToArray();
		}
    }
}

