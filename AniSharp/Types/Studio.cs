using AniSharp.Types.Connections;
using CSGraphQL.GraphQL;

namespace AniSharp.Types
{
	public class Studio : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public new string Name { get; set; }
		[TypeField] public bool IsAnimationStudio { get; set; }
		[TypeField] public MediaConnection Media { get; set; }
		[TypeField] public string SiteUrl { get; set; }
		[TypeField] public bool IsFavourite { get; set; }
		[TypeField] public int Favourites { get; set; }

	}
}