using CSGraphQL.GraphQL.Short;

namespace AniSharp.Results.Single
{
	public class Anime : Media
	{
		[Field] public int? Episodes { get; set; }
		[Field] public int? Duration { get; set; }
	}
}