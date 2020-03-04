using CSGraphQL.GraphQL.Short;

namespace AniSharp.Results.Single
{
	public class Manga : Media
	{
		[Field] public int? Chapters { get; set; }
		[Field] public int? Volumes { get; set; }
	}
}