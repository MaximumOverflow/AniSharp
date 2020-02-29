using AniSharp.Types;

namespace AniSharp.Results
{
	public class Manga : IResult
	{
		public readonly int? Id;
		public readonly MediaDate EndDate;
		public readonly MediaDate StartDate;
		public readonly MediaSeason? Season;
		public readonly int? SeasonYear;
		public readonly MediaType? Type;
		public readonly MediaFormat? Format;
		public readonly MediaStatus? Status;
		public readonly int? Chapters;
		public readonly int? Volumes;
		public readonly bool? IsAdult;
		public readonly int? AverageScore;
		public readonly int? Popularity;
		public readonly MediaSource? Source;
		public readonly string CountryOfOrigin;
		public MediaTitle Title;
		public string Description;
		public MediaCoverImage CoverImage;
		public string[] Genres;
		public string[] Synonyms;
		public MediaTag[] Tags;

		public Manga(Types.Manga manga)
		{
			Id  = manga.Id;
			EndDate  = manga.EndDate;
			StartDate  = manga.StartDate;
			Season  = manga.Season;
			SeasonYear  = manga.SeasonYear;
			Type  = manga.Type;
			Format  = manga.Format;
			Status  = manga.Status;
			Chapters  = manga.Chapters;
			Volumes  = manga.Volumes;
			IsAdult  = manga.IsAdult;
			AverageScore  = manga.AverageScore;
			Popularity  = manga.Popularity;
			Source  = manga.Source;
			CountryOfOrigin  = manga.CountryOfOrigin;
			Title  = manga.Title;
			Description  = manga.Description;
			CoverImage  = manga.CoverImage;
			Genres  = manga.Genres;
			Synonyms  = manga.Synonyms;
			Tags  = manga.Tags;
		}
	}
}