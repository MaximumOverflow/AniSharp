using CSGraphQL.GraphQL;

namespace AniSharp.Types
{
    //TODO Make it internal
    //TODO Add remaining fields
    public class Media : Type
    {
        [Variable] [Request] public int? Id { get; set; }
        [Variable] [Request] public int? IdMal { get; set; }
        [Variable("StartDate")] public int? EndDateInt { get; set; }
        [Variable("EndDate")] public int? StartDateInt { get; set; }
        [Variable] [Request] public MediaSeason? Season { get; set; }
        [Variable] [Request] public int? SeasonYear { get; set; }
        [Variable] [Request] public MediaType? Type { get; set; }
        [Variable] [Request] public MediaFormat? Format { get; set; }
        [Variable] [Request] public MediaStatus? Status { get; set; }
        [Variable] [Request] public int? Episodes { get; set; }
        [Variable] [Request] public int? Duration { get; set; }
        [Variable] [Request] public int? Chapters { get; set; }
        [Variable] [Request] public int? Volumes { get; set; }
        [Variable] [Request] public bool? IsAdult { get; set; }
        [Variable] public string Genre { get; set; }
        [Variable] public string Tag { get; set; }
        [Variable] public int? MinimumTagRank { get; set; }
        [Variable] public string TagCategory { get; set; }
        [Variable] public bool? OnList { get; set; }
        [Variable] public string LicensedBy { get; set; }
        [Variable] [Request] public int? AverageScore { get; set; }
        [Variable] [Request] public int? Popularity { get; set; }
        [Variable] [Request] public MediaSource? Source { get; set; }
        [Variable] [Request] public string CountryOfOrigin { get; set; }
        [Variable] public string Search { get; set; }
        [Variable] public MediaSort? Sort { get; set; }
        
        [Request] public MediaTitle Title { get; set; }
        [Request] public string Description { get; set; }
        [Request] public int SeasonInt { get; set; }
        [Request] public bool IsLicensed { get; set; }
        [Request] public string HashTag { get; set; }
        [Request] public MediaTrailer Trailer { get; set; }
        [Request] public int UpdatedAt { get; set; }
        [Request] public MediaCoverImage CoverImage { get; set; }
        [Request] public string BannerImage { get; set; }
        [Request] public string[] Genres { get; set; }
        [Request] public string[] Synonyms { get; set; }
        [Request] public int MeanScore { get; set; }
        [Request] public bool IsLocked { get; set; }
        [Request] public bool Trending { get; set; }
        [Request] public bool Favourites { get; set; }
        [Request] public MediaTag[] Tags { get; set; }
        [Request] public MediaDate EndDate { get; set; }
        [Request] public MediaDate StartDate { get; set; }
    }
}