using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaExternalLink : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public string Url { get; set; }
		[TypeField] public string Site { get; set; }
	}
}