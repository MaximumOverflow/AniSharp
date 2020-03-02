namespace AniSharp.Client.Account
{
	public abstract class AccessTokenProvider
	{
		public readonly int ClientId;
		public readonly string RedirectUrl;

		public AccessTokenProvider(int clientId, string redirectUrl = null)
		{
			ClientId = clientId;
			RedirectUrl = redirectUrl;
		}

		public abstract AccessToken GetAccessToken();

		public string AuthorizationCodeGrantUrl =>
			$"https://anilist.co/api/v2/oauth/authorize?client_id={ClientId}&redirect_uri={RedirectUrl}&response_type=code";

		public string ImplicitGrantUrl =>
			$"https://anilist.co/api/v2/oauth/authorize?client_id={ClientId}&response_type=token";
	}
}