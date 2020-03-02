using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaStreamingEpisode : GraphQlType
	{
		[TypeField] public string Title { get; set; }
		[TypeField] public string Thumbnail { get; set; }
		[TypeField] public string Url { get; set; }
		[TypeField] public string Site { get; set; }
	}
}