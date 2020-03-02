using AniSharp.Types.Connections;
using AniSharp.Types.Media.Statistics;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class Media : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public int IdMal { get; set; }
		[TypeField] public MediaTitle Title { get; set; }
		[TypeField] public MediaType Type { get; set; }
		[TypeField] public MediaFormat Format { get; set; }
		[TypeField] public MediaStatus Status { get; set; }
		[TypeField] public string Description { get; set; }
		[TypeField] public Date StartDate { get; set; }
		[TypeField] public Date EndDate { get; set; }
		[TypeField] public MediaSeason Season { get; set; }
		[TypeField] public int SeasonYear { get; set; }
		[TypeField] public int SeasonInt { get; set; }
		[TypeField] public int Episodes { get; set; }
		[TypeField] public int Duration { get; set; }
		[TypeField] public int Chapters { get; set; }
		[TypeField] public int Volumes { get; set; }
		[TypeField] public string CountryOfOrigin { get; set; }
		[TypeField] public bool IsLicensed { get; set; }
		[TypeField] public MediaSource Source { get; set; }
		[TypeField] public string Hashtag { get; set; }
		[TypeField] public MediaTrailer Trailer { get; set; }
		[TypeField] public int UpdatedAt { get; set; }
		[TypeField] public MediaCoverImage CoverImage { get; set; }
		[TypeField] public string BannerImage { get; set; }
		[TypeField] public string[] Genres { get; set; }
		[TypeField] public string[] Synonyms { get; set; }
		[TypeField] public int AverageScore { get; set; }
		[TypeField] public int MeanScore { get; set; }
		[TypeField] public int Popularity { get; set; }
		[TypeField] public bool IsLocked { get; set; }
		[TypeField] public int Trending { get; set; }
		[TypeField] public int Favourites { get; set; }
		[TypeField] public MediaTag[] Tags { get; set; }
		[TypeField] public MediaConnection Relations { get; set; }
		[TypeField] public CharacterConnection Characters { get; set; }
		[TypeField] public StaffConnection Staff { get; set; }
		[TypeField] public StudioConnection Studios { get; set; }
		[TypeField] public bool IsFavourite { get; set; }
		[TypeField] public bool IsAdult { get; set; }
		[TypeField] public AiringSchedule NextAiringEpisode { get; set; }
		[TypeField] public AiringScheduleConnection AiringSchedule { get; set; }
		[TypeField] public MediaTrendConnection Trends { get; set; }
		[TypeField] public MediaExternalLink[] ExternalLinks { get; set; }
		[TypeField] public MediaStreamingEpisode[] StreamingEpisodes { get; set; }
		[TypeField] public MediaRank[] Rankings { get; set; }
		[TypeField] public MediaList MediaListEntry { get; set; }
		[TypeField] public ReviewConnection Reviews { get; set; }
		[TypeField] public RecommendationConnection Recommendations { get; set; }
		[TypeField] public MediaStats Stats { get; set; }
		[TypeField] public string SiteUrl { get; set; }
		[TypeField] public bool AutoCreateForumThread { get; set; }
		[TypeField] public bool IsRecommendationBlocked { get; set; }
		[TypeField] public string ModNotes { get; set; }
	}
}