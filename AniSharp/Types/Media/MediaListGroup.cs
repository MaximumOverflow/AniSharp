using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaListGroup : GraphQlType
	{
		[TypeField] public MediaList[] Entries { get; set; }
		[TypeField] public string Name { get; set; }
		[TypeField] public bool IsCustomList { get; set; }
		[TypeField] public bool IsSplitCompletedList { get; set; }
		[TypeField] public MediaListStatus Status { get; set; }
	}
}