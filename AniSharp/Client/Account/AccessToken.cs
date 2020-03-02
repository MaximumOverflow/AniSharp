using System.Collections.Generic;

namespace AniSharp.Client.Account
{
	public struct AccessToken
	{
		public readonly int? ClientId;
		public readonly string Token;

		public AccessToken(int clientId, string token)
		{
			ClientId = clientId;
			Token = token;
		}
		
		public KeyValuePair<string, string> AccessHeader 
			=> new KeyValuePair<string, string>("Authorization", $"Bearer {Token}");
	}
}