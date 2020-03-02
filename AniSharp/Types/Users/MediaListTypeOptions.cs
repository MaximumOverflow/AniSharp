using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class MediaListTypeOptions : GraphQlType
	{
		[TypeField] private string SectionOrder { get; set; }
		[TypeField] private bool SplitCompletedSectionByFormat { get; set; }
		[TypeField] private string[] CustomLists { get; set; }
		[TypeField] private string[] AdvancedScoring { get; set; }
		[TypeField] private bool AdvancedScoringEnabled { get; set; }
	}
}