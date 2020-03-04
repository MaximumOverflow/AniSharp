using AniSharp.Types.Media;
using CSGraphQL.GraphQL;

namespace AniSharp.Results.Pages
{
	public abstract class MediaPage : GraphQlType
	{
		public abstract MediaType MediaType { get; }
	}
}