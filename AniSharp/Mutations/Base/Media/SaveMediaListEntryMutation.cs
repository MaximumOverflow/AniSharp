using AniSharp.Types.Media;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Mutations.Base.Media
{
	[MutationName("SaveMediaListEntry")]
	public abstract class SaveMediaListEntryMutation : MediaMutation
	{
		[Variable] public MediaListStatus? Status { get; set; }
		[Variable] public float? Score { get; set; }
		[Variable] public int? ScoreRaw { get; set; }
		[Variable] public int? Progress { get; set; }
		[Variable] public int? ProgressVolumes { get; set; }
		[Variable] public int? Repeat { get; set; }
		[Variable] public int? Priority { get; set; }
		[Variable] public bool? Private { get; set; }
		[Variable] public string Notes { get; set; }
		[Variable] public bool? HiddenFromStatusLists { get; set; }
		[Variable] public string[] CustomLists { get; set; }
		[Variable] public float[] AdvancedScores { get; set; }
		[Variable] public Date StartedAt { get; set; }
		[Variable] public Date CompletedAt { get; set; }
		
		protected SaveMediaListEntryMutation(int mediaId) : base(mediaId) {}
	}
}