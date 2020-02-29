using CSGraphQL.GraphQL;

namespace AniSharp.Types
{
    public sealed class PageInfo : Type
    {
        [Request] public int Total { get; set; }
        [Request] public int PerPage { get; set; }
        [Request] public int CurrentPage { get; set; }
        [Request] public int LastPage { get; set; }
        [Request] public bool HasNextPage { get; set; }
    }
    
    public sealed class MediaTitle : Type
    {
        [Request] public string Native { get; set; }
        [Request] public string Romaji { get; set; }
        [Request] public string English { get; set; }
    }

    public sealed class MediaDate : Type
    {
        [Request] public int Year { get; set; }
        [Request] public int Month { get; set; }
        [Request] public int Day { get; set; }
    }

    public sealed class MediaCoverImage : Type
    {
        [Request] public string ExtraLarge { get; set; }
        [Request] public string Large { get; set; }
        [Request] public string Medium { get; set; }
    }

    public sealed class MediaTrailer : Type
    {
        [Request] public string Id { get; set; }
        [Request] public string Site { get; set; }
        [Request] public string Thumbnail { get; set; }
    }
    
    public sealed class MediaTag : Type
    {
        [Request] public int Id { get; set; }
        [Request] public string Name { get; set; }
        [Request] public string Description { get; set; }
        [Request] public string Category { get; set; }
        [Request] public int Rank { get; set; }
        [Request] public bool IsGeneralSpoiler { get; set; }
        [Request] public bool IsMediaSpoiler { get; set; }
        [Request] public bool IsAdult { get; set; }
    }

    public sealed class MediaEdge : Type
    {
        [Request] public Media Node { get; set; }
        [Request] public int Id { get; set; }
        [Request] public MediaRelation RelationType { get; set; }
        [Request] public bool IsMainStudio { get; set; }
    }

    public sealed class CharacterName : Type
    {
        [Request] public string First { get; set; }
        [Request] public string Last { get; set; }
        [Request] public string Full { get; set; }
        [Request] public string Native { get; set; }
        [Request] public string[] Alternative { get; set; }
    }

    public sealed class CharacterImage : Type
    {
        [Request] public string Large { get; set; }
        [Request] public string Medium { get; set; }
    }
    
    public sealed class Character : Type
    {
        [Request] public int Id { get; set; }
        [Request] public CharacterName Name { get; set; }
        [Request] public CharacterImage Image { get; set; }
        [Request] public string Description { get; set; }
        [Request] public string SiteUrl { get; set; }
        //TODO Add other fields
    }
}