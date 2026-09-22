namespace PodcastRepo.Models

type ItunesEpisode =
    { Author: string
      Title: string
      PublishedDate: string
      AudioUrl: string
      AudioType: string
      AudioLength: string
      Duration: string
      Guid: string
      IsExplicit: string
      Description: string }

type ItunesPodcast =
    { Title: string
      Author: string
      AuthorEmail: string
      Category: string
      ImageUrl: string
      PodcastUrl: string
      Owner: string
      OwnerEmail: string
      Keywords: string
      Copyright: string
      ShortDescription: string
      Language: string
      IsExplicit: string
      PublishedDate: string
      FeedUrl: string
      Episode: ItunesEpisode array }

type ItunesTemplate =
    { Podcast: ItunesPodcast }