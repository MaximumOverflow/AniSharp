using AniSharp.Types.Media;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users.Statistics
{
	public class UserFormatStatistic : UserStatistic { [TypeField] public MediaFormat Format { get; set; } }
	public class UserStatusStatistic : UserStatistic { [TypeField] public MediaListStatus Format { get; set; } }
	public class UserScoreStatistic : UserStatistic { [TypeField] public int Score { get; set; } }
	public class UserLengthStatistic : UserStatistic { [TypeField] public string Length { get; set; } }
	public class UserReleaseYearStatistic : UserStatistic { [TypeField] public int ReleaseYear { get; set; } }
	public class UserStartYearStatistic : UserStatistic { [TypeField] public int StartYear { get; set; } }
	public class UserGenreStatistic : UserStatistic { [TypeField] public string Genre { get; set; } }
	public class UserTagStatistic : UserStatistic { [TypeField] public MediaTag Tag { get; set; } }
	public class UserCountryStatistic : UserStatistic { [TypeField] public string Country { get; set; } }
	public class UserStaffStatistic : UserStatistic { [TypeField] public Staff.Staff VoiceActor { get; set; } }
	public class UserVoiceActorStatistic : UserStaffStatistic { [TypeField] public int[] CharacterIds { get; set; } }
	public class UserStudioStatistic : UserStatistic { [TypeField] public Studio Studio { get; set; } }
	
	public abstract class UserStatistic : GraphQlType
	{
		[TypeField] public int Count { get; set; }
		[TypeField] public float MeanScore { get; set; }
		[TypeField] public int MinutesWatched { get; set; }
		[TypeField] public int ChaptersRead { get; set; }
		[TypeField] public int[] MediaIds { get; set; }
	}
	
	public class UserStatistics : GraphQlType
	{
		[TypeField] public int Count { get; set; }
		[TypeField] public float MeanScore { get; set; }
		[TypeField] public float StandardDeviation { get; set; }
		[TypeField] public int MinutesWatched { get; set; }
		[TypeField] public int EpisodesWatched { get; set; }
		[TypeField] public int ChaptersRead { get; set; }
		[TypeField] public int VolumesRead { get; set; }
		[TypeField] public UserFormatStatistic[] Formats { get; set; }
		[TypeField] public UserStatusStatistic[] Statuses { get; set; }
		[TypeField] public UserScoreStatistic[] Scores { get; set; }
		[TypeField] public UserLengthStatistic[] Lengths { get; set; }
		[TypeField] public UserReleaseYearStatistic[] ReleaseYears { get; set; }
		[TypeField] public UserStartYearStatistic[] StartYears { get; set; }
		[TypeField] public UserGenreStatistic[] Genres { get; set; }
		[TypeField] public UserTagStatistic[] Tags { get; set; }
		[TypeField] public UserCountryStatistic[] Countries { get; set; }
		[TypeField] public UserVoiceActorStatistic[] VoiceActors { get; set; }
		[TypeField] public UserStaffStatistic[] Staff { get; set; }
		[TypeField] public UserStudioStatistic[] Studios { get; set; }
	}
}