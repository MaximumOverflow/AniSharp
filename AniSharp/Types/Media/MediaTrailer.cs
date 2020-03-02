using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaTrailer : GraphQlType
	{
		[TypeField] public string Id { get; set; }
		[TypeField] public string Site { get; set; }
		[TypeField] public string Thumbnail { get; set; }
	}
}