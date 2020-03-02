using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaCoverImage : GraphQlType
	{
		[TypeField] public string ExtraLarge { get; set; }
		[TypeField] public string Large { get; set; }
		[TypeField] public string Medium { get; set; }
		[TypeField] public string Color { get; set; }
	}
}