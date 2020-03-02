using AniSharp.Types.Misc;
using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaList : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public int UserId { get; set; }
		[TypeField] public int MediaId { get; set; }
		[TypeField] public MediaListStatus Status { get; set; }
		[TypeField] public float Score { get; set; }
		[TypeField] public int Progress { get; set; }
		[TypeField] public int ProgressVolumes { get; set; }
		[TypeField] public int Repeat { get; set; }
		[TypeField] public int Priority { get; set; }
		[TypeField] public bool Private { get; set; }
		[TypeField] public string Notes { get; set; }
		[TypeField] public bool HiddenFromStatusLists { get; set; }
		[TypeField] public Date StartedAt { get; set; }
		[TypeField] public Date CompletedAt { get; set; }
		[TypeField] public Date UpdatedAt { get; set; }
		[TypeField] public Date CreatedAt { get; set; }
		[TypeField] public Media Media { get; set; }
		[TypeField] public User User { get; set; }
	}
}