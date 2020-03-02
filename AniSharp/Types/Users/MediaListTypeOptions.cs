using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class MediaListTypeOptions : GraphQlType
	{
		[TypeField] public string[] SectionOrder { get; set; }
		[TypeField] public bool SplitCompletedSectionByFormat { get; set; }
		[TypeField] public string[] CustomLists { get; set; }
		[TypeField] public string[] AdvancedScoring { get; set; }
		[TypeField] public bool AdvancedScoringEnabled { get; set; }
	}
}