using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DNSimple
{
	public class ApiToken
	{
		private string _apiToken;

		public ApiToken(string token)
		{
			_apiToken = token;
		}

		public override string ToString()
		{
			return _apiToken;
		}
	}
}
