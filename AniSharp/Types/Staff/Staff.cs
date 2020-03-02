using AniSharp.Types.Connections;
using AniSharp.Types.Misc;
using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Staff
{
	public class Staff : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public StaffName Name { get; set; }
		[TypeField] public StaffLanguage Language { get; set; }
		[TypeField] public string Description { get; set; }
		[TypeField] public bool IsFavourite { get; set; }
		[TypeField] public string SiteUrl { get; set; }
		[TypeField] public MediaConnection StaffMedia { get; set; }
		[TypeField] public CharacterConnection Characters { get; set; }
		[TypeField("Staff")] public Staff Staff_ { get; set; }
		[TypeField] public User Submitter { get; set; }
		[TypeField] public int SubmissionStatus { get; set; }
		[TypeField] public string SubmissionNotes { get; set; }
		[TypeField] public int Favourites { get; set; }
	}
}