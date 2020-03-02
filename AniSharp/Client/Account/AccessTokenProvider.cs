namespace AniSharp.Client.Account
{
	public abstract class AccessTokenProvider
	{
		public readonly int ClientId;

		public AccessTokenProvider(int clientId) => ClientId = clientId;
		public abstract AccessToken GetAccessToken();
	}
}