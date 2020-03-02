using CSGraphQL.GraphQL.Short;

namespace AniSharp.Results
{
	public class Manga : Media
	{
		[Field] public int? Chapters { get; set; }
		[Field] public int? Volumes { get; set; }
	}
}