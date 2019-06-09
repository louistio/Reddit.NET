﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Reddit.Controllers;
using Reddit.Models.Converters;
using System;
using System.Collections.Generic;

namespace Reddit.Things
{
    [Serializable]
    public class Post
    {
        [JsonProperty("approved_at_utc")]
        [JsonConverter(typeof(UtcTimestampConverter))]
        public DateTime ApprovedAtUTC;

        [JsonProperty("subreddit")]
        public string Subreddit;

        [JsonProperty("selftext")]
        public string SelfText;

        [JsonProperty("user_reports")]
        public JArray UserReports;

        [JsonProperty("saved")]
        public bool Saved;

        [JsonProperty("mod_reason_title")]
        public string ModReasonTitle;

        // TODO - Assuming this is supposed to be boolean.  Not sure what else the int value could be for (it's either gilded or it's not, right?).  --Kris
        [JsonProperty("gilded")]
        [JsonConverter(typeof(IntBoolConvert))]
        public bool Gilded;

        [JsonProperty("clicked")]
        public bool Clicked;

        [JsonProperty("title")]
        public string Title;

        // TODO - Only had an empty example so not sure if the structure is right.  --Kris
        [JsonProperty("link_flair_richtext")]
        public object PublicFlairRichtext;

        [JsonProperty("subreddit_name_prefixed")]
        public string SubredditNamePrefixed;

        [JsonProperty("hidden")]
        public bool Hidden;

        // TODO - No idea what this is.  --Kris
        [JsonProperty("pwls")]
        public string Pwls;

        [JsonProperty("link_flair_css_class")]
        public string LinkFlairCSSClass;

        [JsonProperty("downs")]
        public int Downs;

        [JsonProperty("thumbnail_height")]
        public int? ThumbnailHeight;

        [JsonProperty("parent_whitelist_status")]
        public string ParentWhitelistStatus;

        [JsonProperty("hide_score")]
        public bool HideScore;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("quarantine")]
        public bool Quarantine;

        [JsonProperty("link_flair_text_color")]
        public string LinkFlairTextColor;

        [JsonProperty("upvote_ratio")]
        public double UpvoteRatio;

        [JsonProperty("author_flair_background_color")]
        public string AuthorFlairBackgroundColor;

        [JsonProperty("subreddit_type")]
        public string SubredditType;

        [JsonProperty("ups")]
        public int Ups;

        [JsonProperty("domain")]
        public string Domain;

        // TODO - No idea what this does.  It's always empty when I see it.  --Kris
        [JsonProperty("media_embed")]
        public object MediaEmbed;

        [JsonProperty("thumbnail_width")]
        public int? ThumbnailWidth;

        [JsonProperty("author_flair_template_id")]
        public string AuthorFlairTemplateId;

        [JsonProperty("is_original_content")]
        public bool IsOriginalContent;

        [JsonProperty("author_fullname")]
        public string AuthorFullname;

        [JsonProperty("secure_media")]
        public object SecureMedia;

        [JsonProperty("is_reddit_media_domain")]
        public bool IsRedditMediaDomain;

        [JsonProperty("is_meta")]
        public bool IsMeta;

        [JsonProperty("category")]
        public string category;

        [JsonProperty("num_comments")]
        public int NumComments;

        // TODO - Same as MediaEmbed.  Not sure what this is supposed to be.  --Kris
        [JsonProperty("secure_media_embed")]
        public object SecureMediaEmbed;

        [JsonProperty("link_flair_text")]
        public string LinkFlairText;

        [JsonProperty("can_mod_post")]
        public bool CanModPost;

        [JsonProperty("score")]
        public int Score;

        [JsonProperty("approved_by")]
        public string ApprovedBy;

        [JsonProperty("ignore_reports")]
        public bool IgnoreReports;

        [JsonProperty("thumbnail")]
        public string Thumbnail;

        [JsonProperty("edited")]
        [JsonConverter(typeof(UtcTimestampConverter))]
        public DateTime Edited;

        [JsonProperty("author_flair_css_class")]
        public string AuthorFlairCSSClass;

        [JsonProperty("previous_visits")]
        //[JsonConverter(typeof(List<TimestampConvert>))]
        public object PreviousVisits;

        // TODO - Is this a list or a string or what?  --Kris
        [JsonProperty("author_flair_richtext")]
        public List<object> AuthorFlairRichtext;

        [JsonProperty("gildings")]
        public Dictionary<string, int> Gildings;

        [JsonProperty("post_hint")]
        public string PostHint;

        [JsonProperty("content_categories")]
        public object ContentCategories;

        [JsonProperty("is_self")]
        public bool IsSelf;

        [JsonProperty("mod_note")]
        public string ModNote;

        [JsonProperty("created")]
        [JsonConverter(typeof(LocalTimestampConverter))]
        [Obsolete("Using this date can lead to unexpected results, please use " + nameof(CreatedUTC) + " instead.")]
        public DateTime Created;

        [JsonProperty("link_flair_type")]
        public string LinkFlairType;

        // TODO - No idea what this is.  --Kris
        [JsonProperty("wls")]
        public string Wls;

        [JsonProperty("banned_by")]
        public string BannedBy;

        [JsonProperty("author_flair_type")]
        public string AuthorFlairType;

        [JsonProperty("contest_mode")]
        public bool ContestMode;

        [JsonProperty("selftext_html")]
        public string SelfTextHTML;

        [JsonProperty("likes")]
        public bool? Likes;

        [JsonProperty("suggested_sort")]
        public string SuggestedSort;

        [JsonProperty("banned_at_utc")]
        [JsonConverter(typeof(UtcTimestampConverter))]
        public DateTime BannedAtUTC;

        [JsonProperty("view_count")]
        public int? ViewCount;

        [JsonProperty("archived")]
        public bool Archived;

        [JsonProperty("no_follow")]
        public bool NoFollow;

        [JsonProperty("spam")]
        public bool Spam;

        [JsonProperty("is_crosspostable")]
        public bool IsCrosspostable;

        [JsonProperty("pinned")]
        public bool Pinned;

        [JsonProperty("over_18")]
        public bool Over18;

        [JsonProperty("preview")]
        public JObject Preview;

        [JsonProperty("media_only")]
        public bool MediaOnly;

        [JsonProperty("link_flair_template_id")]
        public string LinkFlairTemplateId;

        [JsonProperty("can_gild")]
        public bool CanGild;

        [JsonProperty("removed")]
        public bool Removed;

        [JsonProperty("spoiler")]
        public bool Spoiler;

        [JsonProperty("locked")]
        public bool Locked;

        [JsonProperty("author_flair_text")]
        public string AuthorFlairText;

        [JsonProperty("rte_mode")]
        public string RteMode;

        [JsonProperty("visited")]
        public bool Visited;

        [JsonProperty("num_reports")]
        public int? NumReports;

        [JsonProperty("distinguished")]
        public string Distinguished;

        [JsonProperty("subreddit_id")]
        public string SubredditId;

        [JsonProperty("mod_reason_by")]
        public string ModReasonBy;

        [JsonProperty("removal_reason")]
        public string RemovalReason;

        [JsonProperty("link_flair_background_color")]
        public string LinkFlairBackgroundColor;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("report_reasons")]
        public List<string> ReportReasons;

        [JsonProperty("author")]
        public string Author;

        [JsonProperty("num_crossposts")]
        public int NumCrossposts;

        [JsonProperty("media")]
        public object Media;

        [JsonProperty("send_replies")]
        public bool SendReplies;

        [JsonProperty("approved")]
        public bool Approved;

        [JsonProperty("author_flair_text_color")]
        public string AuthorFlairTextColor;

        [JsonProperty("permalink")]
        public string Permalink;

        [JsonProperty("whitelist_status")]
        public string WhitelistStatus;

        [JsonProperty("stickied")]
        public bool Stickied;

        [JsonProperty("url")]
        public string URL;

        [JsonProperty("subreddit_subscribers")]
        public int SubredditSubscribers;

        [JsonProperty("created_utc")]
        [JsonConverter(typeof(UtcTimestampConverter))]
        public DateTime CreatedUTC;

        [JsonProperty("mod_reports")]
        public JArray ModReports;

        [JsonProperty("is_video")]
        public bool IsVideo;

        [JsonProperty("sr_detail")]
        public Subreddit SrDetail;

        public Post(Controllers.Post post)
        {
            ImportFromPost(post);
        }

        public Post(SelfPost selfPost)
        {
            ImportFromSelfPost(selfPost);
        }

        public Post(LinkPost linkPost)
        {
            ImportFromLinkPost(linkPost);
        }

        private void ImportFromPost(Controllers.Post post)
        {
            Subreddit = post.Subreddit;
            Title = post.Title;
            Author = post.Author;
            Id = post.Id;
            Name = post.Fullname;
            Permalink = post.Permalink;
            CreatedUTC = post.Created;
            Edited = post.Edited;
            Score = post.Score;
            Ups = post.UpVotes;
            Downs = post.DownVotes;
            Removed = post.Removed;
            Spam = post.Spam;
            Over18 = post.NSFW;
        }

        private void ImportFromSelfPost(SelfPost selfPost)
        {
            ImportFromPost(selfPost);

            SelfText = selfPost.SelfText;
            SelfTextHTML = selfPost.SelfTextHTML;
        }

        private void ImportFromLinkPost(LinkPost linkPost)
        {
            ImportFromPost(linkPost);

            Preview = linkPost.Preview;
            URL = linkPost.URL;
            Thumbnail = linkPost.Thumbnail;
            ThumbnailHeight = linkPost.ThumbnailHeight;
            ThumbnailWidth = linkPost.ThumbnailWidth;
        }

        public Post() { }
    }
}
