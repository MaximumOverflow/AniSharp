using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaTag : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public new string Name { get; set; }
		[TypeField] public string Description { get; set; }
		[TypeField] public string Category { get; set; }		
		[TypeField] public int Rank { get; set; }
		[TypeField] public bool IsGeneralSpoiler { get; set; }
		[TypeField] public bool IsMediaSpoiler { get; set; }
		[TypeField] public bool IsAdult { get; set; }
	}
}