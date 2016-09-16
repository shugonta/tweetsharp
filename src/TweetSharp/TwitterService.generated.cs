﻿/// <summary>
/// This code is generated. Any changes to it will be destroyed on subsequent generations. Use the DSL instead.
/// </summary>

using System;
using System.IO;
using System.Collections.Generic;
using Hammock;
using Hammock.Web;

#if PLATFORM_SUPPORTS_ASYNC_AWAIT
using System.Threading.Tasks;
#endif

namespace TweetSharp
{
#region Options 
    		
	public class ListTweetsMentioningMeOptions
	{ 
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? ContributorDetails { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListTweetsOnUserTimelineOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? SinceId { get; set; }  
		public int? Count { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? ExcludeReplies { get; set; }  
		public bool? ContributorDetails { get; set; }  
		public bool? IncludeRts { get; set; } 			
	}			
 
    		
	public class ListTweetsOnHomeTimelineOptions
	{ 
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? ExcludeReplies { get; set; }  
		public bool? ContributorDetails { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListRetweetsOfMyTweetsOptions
	{ 
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? IncludeUserEntities { get; set; } 			
	}			
 
    		
	public class RetweetsOptions
	{ 
		public long Id { get; set; }  
		public int? Count { get; set; }  
		public bool? TrimUser { get; set; } 			
	}			
 
    		
	public class GetTweetOptions
	{ 
		public long Id { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? IncludeMyRetweet { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class DeleteTweetOptions
	{ 
		public long Id { get; set; }  
		public bool TrimUser { get; set; } 			
	}			
 
    		
	public class SendTweetOptions
	{ 
		public string Status { get; set; }  
		public long? InReplyToStatusId { get; set; }  
		public double? Lat { get; set; }  
		public double? @Long { get; set; }  
		public string PlaceId { get; set; }  
		public bool? DisplayCoordinates { get; set; }  
		public bool? TrimUser { get; set; }  
		public IEnumerable<String> MediaIds { get; set; } 			
	}			
 
    		
	public class RetweetOptions
	{ 
		public long Id { get; set; }  
		public bool? TrimUser { get; set; } 			
	}			
 
    [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]		
	public class SendTweetWithMediaOptions
	{ 
		public string Status { get; set; }  
		public bool? PossiblySensitive { get; set; }  
		public long? InReplyToStatusId { get; set; }  
		public double? Lat { get; set; }  
		public double? @Long { get; set; }  
		public string PlaceId { get; set; }  
		public bool? DisplayCoordinates { get; set; }  
		public IDictionary<string,Stream> Images { get; set; } 			
	}			
 
    		
	public class UploadMediaOptions
	{ 
		public MediaFile Media { get; set; } 			
	}			
 
    		
	public class UploadMediaInitOptions
	{ 
		public string MediaType { get; set; }  
		public string MediaCategory { get; set; }  
		public long TotalBytes { get; set; } 			
	}			
 
    		
	public class UploadMediaAppendOptions
	{ 
		public long MediaId { get; set; }  
		public long SegmentIndex { get; set; }  
		public MediaFile Media { get; set; } 			
	}			
 
    		
	public class UploadMediaFinalizeOptions
	{ 
		public long MediaId { get; set; } 			
	}			
 
    		
	public class UploadMediaCheckStatusOptions
	{ 
		public long MediaId { get; set; } 			
	}			
 
    		
	public class SearchOptions
	{ 
		public string Q { get; set; }  
		public TwitterGeoLocationSearch Geocode { get; set; }  
		public string Lang { get; set; }  
		public string Locale { get; set; }  
		public TwitterSearchResultType? Resulttype { get; set; }  
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public string Callback { get; set; }  
		public DateTime? Until { get; set; } 			
	}			
 
    		
	public class ListDirectMessagesReceivedOptions
	{ 
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public int? Count { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? FullText { get; set; } 			
	}			
 
    		
	public class ListDirectMessagesSentOptions
	{ 
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public int? Count { get; set; }  
		public int? Page { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? FullText { get; set; } 			
	}			
 
    		
	public class GetDirectMessageOptions
	{ 
		public long Id { get; set; }  
		public bool? FullText { get; set; } 			
	}			
 
    		
	public class DeleteDirectMessageOptions
	{ 
		public long Id { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class SendDirectMessageOptions
	{ 
		public string Text { get; set; }  
		public long UserId { get; set; }  
		public string ScreenName { get; set; } 			
	}			
 
    		
	public class ListFriendIdsOfOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public int? Count { get; set; } 			
	}			
 
    		
	public class ListFollowerIdsOfOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public int? Count { get; set; } 			
	}			
 
    		
	public class ListFriendshipsForOptions
	{ 
		public IEnumerable<string> ScreenName { get; set; }  
		public IEnumerable<long> UserId { get; set; } 			
	}			
 
    		
	public class GetIncomingFriendRequestsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class GetOutgoingFriendRequestsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class FollowUserOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; }  
		public bool? Follow { get; set; } 			
	}			
 
    		
	public class UnfollowUserOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; } 			
	}			
 
    		
	public class UpdateFriendshipOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; }  
		public bool? Device { get; set; }  
		public bool? Retweets { get; set; } 			
	}			
 
    		
	public class GetFriendshipInfoOptions
	{ 
		public string SourceId { get; set; }  
		public string SourceScreenName { get; set; }  
		public string TargetId { get; set; }  
		public string TargetScreenName { get; set; } 			
	}			
 
    		
	public class ListFriendsOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? Cursor { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? IncludeUserEntities { get; set; } 			
	}			
 
    		
	public class ListFollowersOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? Cursor { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? IncludeUserEntities { get; set; } 			
	}			
 
    		
	public class GetUserProfileOptions
	{ 
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? IncludeEmail { get; set; } 			
	}			
 
    		
	public class VerifyCredentialsOptions
	{ 
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? IncludeEmail { get; set; } 			
	}			
 
    		
	public class UpdateAccountSettingsOptions
	{ 
		public int? TrendLocationWoeid { get; set; }  
		public bool? SleepTimeEnabled { get; set; }  
		public int? StartSleepTime { get; set; }  
		public int? EndSleepTime { get; set; }  
		public string TimeZone { get; set; }  
		public string Lang { get; set; } 			
	}			
 
    		
	public class UpdateDeliveryDeviceOptions
	{ 
		public TwitterDeliveryDevice Device { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class UpdateProfileOptions
	{ 
		public string Name { get; set; }  
		public string Url { get; set; }  
		public string Location { get; set; }  
		public string Description { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UpdateProfileBackgroundImageOptions
	{ 
		public string Imagepath { get; set; }  
		public bool? Tile { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? Use { get; set; } 			
	}			
 
    		
	public class UpdateProfileColorsOptions
	{ 
		public string ProfileBackgroundColor { get; set; }  
		public string ProfileLinkColor { get; set; }  
		public string ProfileSidebarBorderColor { get; set; }  
		public string ProfileSidebarFillColor { get; set; }  
		public string ProfileTextColor { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UpdateProfileImageOptions
	{ 
		public string ImagePath { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class ListBlockedUsersOptions
	{ 
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class ListBlockedUserIdsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class BlockUserOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UnblockUserOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class MuteUserOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; } 			
	}			
 
    		
	public class UnmuteUserOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; } 			
	}			
 
    		
	public class ListMutedUserIdsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class ListMutedUsersOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class ListUserProfilesForOptions
	{ 
		public IEnumerable<string> ScreenName { get; set; }  
		public IEnumerable<long> UserId { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class GetUserProfileForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class SearchForUserOptions
	{ 
		public string Q { get; set; }  
		public int? Page { get; set; }  
		public int? Count { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class GetProfileBannerForOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; } 			
	}			
 
    		
	public class ListSuggestedUsersOptions
	{ 
		public string Slug { get; set; }  
		public string Lang { get; set; } 			
	}			
 
    		
	public class ListSuggestedUserCategoriesOptions
	{ 
		public string Lang { get; set; } 			
	}			
 
    		
	public class GetSuggestedUserMembersOptions
	{ 
		public string Slug { get; set; } 			
	}			
 
    		
	public class ListFavoriteTweetsOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class UnfavoriteTweetOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class FavoriteTweetOptions
	{ 
		public long Id { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListListsForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; } 			
	}			
 
    		
	public class ListOwnedListsForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class ListTweetsOnListOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public int? Count { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? IncludeRts { get; set; } 			
	}			
 
    		
	public class RemoveListMemberOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class ListListMembershipsForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public bool? FilterToOwnedLists { get; set; } 			
	}			
 
    		
	public class ListListSubscribersOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? Cursor { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class FollowListOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; } 			
	}			
 
    		
	public class VerifyListSubscriptionOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UnfollowListOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class AddListMembersOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public IEnumerable<long> UserId { get; set; }  
		public IEnumerable<string> ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class VerifyListMembershipOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class ListListMembersOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public int? Count { get; set; }  
		public long? Cursor { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class AddListMemberOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class DeleteListOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; } 			
	}			
 
    		
	public class UpdateListOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public TwitterListMode? Mode { get; set; }  
		public string Name { get; set; }  
		public string Description { get; set; } 			
	}			
 
    		
	public class CreateListOptions
	{ 
		public string ListOwner { get; set; }  
		public string Name { get; set; }  
		public TwitterListMode Mode { get; set; }  
		public string Description { get; set; } 			
	}			
 
    		
	public class GetListOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class ListSubscriptionsOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class GetSavedSearchOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class CreateSavedSearchOptions
	{ 
		public string Query { get; set; } 			
	}			
 
    		
	public class DeleteSavedSearchOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class GetPlaceOptions
	{ 
		public string PlaceId { get; set; } 			
	}			
 
    		
	public class ReverseGeocodeOptions
	{ 
		public double Lat { get; set; }  
		public double @Long { get; set; }  
		public string Accuracy { get; set; }  
		public string Granularity { get; set; }  
		public int? MaxResults { get; set; }  
		public string Callback { get; set; } 			
	}			
 
    		
	public class GeoSearchOptions
	{ 
		public double? Lat { get; set; }  
		public double? @Long { get; set; }  
		public string Query { get; set; }  
		public string Ip { get; set; }  
		public string Granularity { get; set; }  
		public string Accuracy { get; set; }  
		public int? MaxResults { get; set; }  
		public string ContainedWithin { get; set; }  
		public string Callback { get; set; } 			
	}			
 
    		
	public class ListLocalTrendsForOptions
	{ 
		public long Id { get; set; }  
		public string Exclude { get; set; } 			
	}			
 
    		
	public class ListClosestTrendsLocationsOptions
	{ 
		public double Lat { get; set; }  
		public double @Long { get; set; } 			
	}			
 
    		
	public class GetRateLimitStatusOptions
	{ 
		public IEnumerable<string> Resources { get; set; } 			
	}			
 
    		
	public class ReportSpamOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; } 			
	}			
#endregion

#region Interface
	public partial interface ITwitterService
	{
#if !SILVERLIGHT && !WINRT
		#region Sequential Methods 
        
		TwitterConfiguration GetConfiguration();	

 
        
		IEnumerable<TwitterStatus> ListTweetsMentioningMe(ListTweetsMentioningMeOptions options);	

 
        
		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options);	

 
        
		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options);	

 
        
		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options);	

 
        
		IEnumerable<TwitterStatus> Retweets(RetweetsOptions options);	

 
        
		TwitterStatus GetTweet(GetTweetOptions options);	

 
        
		TwitterStatus DeleteTweet(DeleteTweetOptions options);	

 
        
		TwitterStatus SendTweet(SendTweetOptions options);	

 
        
		TwitterStatus Retweet(RetweetOptions options);	

 
        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		TwitterStatus SendTweetWithMedia(SendTweetWithMediaOptions options);	

 
        
		TwitterUploadedMedia UploadMedia(UploadMediaOptions options);	

 
        
		TwitterChunkedMedia UploadMediaInit(UploadMediaInitOptions options);	

 
        
		void UploadMediaAppend(UploadMediaAppendOptions options);	

 
        
		UploadMediaResult UploadMediaFinalize(UploadMediaFinalizeOptions options);	

 
        
		UploadMediaResult UploadMediaCheckStatus(UploadMediaCheckStatusOptions options);	

 
        
		TwitterSearchResult Search(SearchOptions options);	

 
        
		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options);	

 
        
		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(ListDirectMessagesSentOptions options);	

 
        
		TwitterDirectMessage GetDirectMessage(GetDirectMessageOptions options);	

 
        
		TwitterDirectMessage DeleteDirectMessage(DeleteDirectMessageOptions options);	

 
        
		TwitterDirectMessage SendDirectMessage(SendDirectMessageOptions options);	

 
        
		TwitterCursorList<long> ListFriendIdsOf(ListFriendIdsOfOptions options);	

 
        
		TwitterCursorList<long> ListFollowerIdsOf(ListFollowerIdsOfOptions options);	

 
        
		IEnumerable<TwitterFriendshipLookup> ListFriendshipsFor(ListFriendshipsForOptions options);	

 
        
		TwitterCursorList<long> GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options);	

 
        
		TwitterCursorList<long> GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options);	

 
        
		TwitterUser FollowUser(FollowUserOptions options);	

 
        
		TwitterUser UnfollowUser(UnfollowUserOptions options);	

 
        
		TwitterFriendship UpdateFriendship(UpdateFriendshipOptions options);	

 
        
		TwitterFriendship GetFriendshipInfo(GetFriendshipInfoOptions options);	

 
        
		TwitterCursorList<TwitterUser> ListFriends(ListFriendsOptions options);	

 
        
		TwitterCursorList<TwitterUser> ListFollowers(ListFollowersOptions options);	

 
        
		TwitterAccount GetAccountSettings();	

 
        
		TwitterUser GetUserProfile(GetUserProfileOptions options);	

 
        
		TwitterUser VerifyCredentials(VerifyCredentialsOptions options);	

 
        
		TwitterAccount UpdateAccountSettings(UpdateAccountSettingsOptions options);	

 
        
		TwitterUser UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options);	

 
        
		TwitterUser UpdateProfile(UpdateProfileOptions options);	

 
        
		TwitterUser UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options);	

 
        
		TwitterUser UpdateProfileColors(UpdateProfileColorsOptions options);	

 
        
		TwitterUser UpdateProfileImage(UpdateProfileImageOptions options);	

 
        
		TwitterCursorList<TwitterUser> ListBlockedUsers(ListBlockedUsersOptions options);	

 
        
		TwitterCursorList<long> ListBlockedUserIds(ListBlockedUserIdsOptions options);	

 
        
		TwitterUser BlockUser(BlockUserOptions options);	

 
        
		TwitterUser UnblockUser(UnblockUserOptions options);	

 
        
		TwitterUser MuteUser(MuteUserOptions options);	

 
        
		TwitterUser UnmuteUser(UnmuteUserOptions options);	

 
        
		TwitterCursorList<long> ListMutedUserIds(ListMutedUserIdsOptions options);	

 
        
		TwitterCursorList<long> ListMutedUsers(ListMutedUsersOptions options);	

 
        
		IEnumerable<TwitterUser> ListUserProfilesFor(ListUserProfilesForOptions options);	

 
        
		TwitterUser GetUserProfileFor(GetUserProfileForOptions options);	

 
        
		IEnumerable<TwitterUser> SearchForUser(SearchForUserOptions options);	

 
        
		ProfileBanners GetProfileBannerFor(GetProfileBannerForOptions options);	

 
        
		TwitterUserSuggestions ListSuggestedUsers(ListSuggestedUsersOptions options);	

 
        
		IEnumerable<TwitterUserSuggestions> ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options);	

 
        
		IEnumerable<TwitterUser> GetSuggestedUserMembers(GetSuggestedUserMembersOptions options);	

 
        
		IEnumerable<TwitterStatus> ListFavoriteTweets(ListFavoriteTweetsOptions options);	

 
        
		TwitterStatus UnfavoriteTweet(UnfavoriteTweetOptions options);	

 
        
		TwitterStatus FavoriteTweet(FavoriteTweetOptions options);	

 
        
		IEnumerable<TwitterList> ListListsFor(ListListsForOptions options);	

 
        
		TwitterCursorList<TwitterList> ListOwnedListsFor(ListOwnedListsForOptions options);	

 
        
		IEnumerable<TwitterStatus> ListTweetsOnList(ListTweetsOnListOptions options);	

 
        
		TwitterUser RemoveListMember(RemoveListMemberOptions options);	

 
        
		TwitterCursorList<TwitterList> ListListMembershipsFor(ListListMembershipsForOptions options);	

 
        
		TwitterCursorList<TwitterUser> ListListSubscribers(ListListSubscribersOptions options);	

 
        
		TwitterUser FollowList(FollowListOptions options);	

 
        
		TwitterUser VerifyListSubscription(VerifyListSubscriptionOptions options);	

 
        
		TwitterUser UnfollowList(UnfollowListOptions options);	

 
        
		TwitterList AddListMembers(AddListMembersOptions options);	

 
        
		TwitterUser VerifyListMembership(VerifyListMembershipOptions options);	

 
        
		TwitterCursorList<TwitterUser> ListListMembers(ListListMembersOptions options);	

 
        
		TwitterUser AddListMember(AddListMemberOptions options);	

 
        
		TwitterList DeleteList(DeleteListOptions options);	

 
        
		TwitterList UpdateList(UpdateListOptions options);	

 
        
		TwitterList CreateList(CreateListOptions options);	

 
        
		TwitterList GetList(GetListOptions options);	

 
        
		TwitterCursorList<TwitterList> ListSubscriptions(ListSubscriptionsOptions options);	

 
        
		IEnumerable<TwitterSavedSearch> ListSavedSearches();	

 
        
		TwitterSavedSearch GetSavedSearch(GetSavedSearchOptions options);	

 
        
		TwitterSavedSearch CreateSavedSearch(CreateSavedSearchOptions options);	

 
        
		TwitterSavedSearch DeleteSavedSearch(DeleteSavedSearchOptions options);	

 
        
		TwitterPlace GetPlace(GetPlaceOptions options);	

 
        
		IEnumerable<TwitterPlace> ReverseGeocode(ReverseGeocodeOptions options);	

 
        
		IEnumerable<TwitterPlace> GeoSearch(GeoSearchOptions options);	

 
        
		TwitterTrends ListLocalTrendsFor(ListLocalTrendsForOptions options);	

 
        
		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations();	

 
        
		IEnumerable<WhereOnEarthLocation> ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options);	

 
        
		TwitterRateLimitStatusSummary GetRateLimitStatus(GetRateLimitStatusOptions options);	

 
        
		TwitterUser ReportSpam(ReportSpamOptions options);	

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with IAsyncResult)
        
		IAsyncResult GetConfiguration(Action<TwitterConfiguration, TwitterResponse>  action);

        
		IAsyncResult ListTweetsMentioningMe(ListTweetsMentioningMeOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult Retweets(RetweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult GetTweet(GetTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		IAsyncResult DeleteTweet(DeleteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		IAsyncResult SendTweet(SendTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		IAsyncResult Retweet(RetweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		IAsyncResult SendTweetWithMedia(SendTweetWithMediaOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		IAsyncResult UploadMedia(UploadMediaOptions options, Action<TwitterUploadedMedia, TwitterResponse>  action);

        
		IAsyncResult UploadMediaInit(UploadMediaInitOptions options, Action<TwitterChunkedMedia, TwitterResponse>  action);

        
		IAsyncResult UploadMediaAppend(UploadMediaAppendOptions options, Action<TwitterResponse> action);

        
		IAsyncResult UploadMediaFinalize(UploadMediaFinalizeOptions options, Action<UploadMediaResult, TwitterResponse>  action);

        
		IAsyncResult UploadMediaCheckStatus(UploadMediaCheckStatusOptions options, Action<UploadMediaResult, TwitterResponse>  action);

        
		IAsyncResult Search(SearchOptions options, Action<TwitterSearchResult, TwitterResponse>  action);

        
		IAsyncResult ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action);

        
		IAsyncResult ListDirectMessagesSent(ListDirectMessagesSentOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action);

        
		IAsyncResult GetDirectMessage(GetDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action);

        
		IAsyncResult DeleteDirectMessage(DeleteDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action);

        
		IAsyncResult SendDirectMessage(SendDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action);

        
		IAsyncResult ListFriendIdsOf(ListFriendIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult ListFollowerIdsOf(ListFollowerIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult ListFriendshipsFor(ListFriendshipsForOptions options, Action<IEnumerable<TwitterFriendshipLookup>, TwitterResponse>  action);

        
		IAsyncResult GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult FollowUser(FollowUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UnfollowUser(UnfollowUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UpdateFriendship(UpdateFriendshipOptions options, Action<TwitterFriendship, TwitterResponse>  action);

        
		IAsyncResult GetFriendshipInfo(GetFriendshipInfoOptions options, Action<TwitterFriendship, TwitterResponse>  action);

        
		IAsyncResult ListFriends(ListFriendsOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult ListFollowers(ListFollowersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult GetAccountSettings(Action<TwitterAccount, TwitterResponse>  action);

        
		IAsyncResult GetUserProfile(GetUserProfileOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult VerifyCredentials(VerifyCredentialsOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UpdateAccountSettings(UpdateAccountSettingsOptions options, Action<TwitterAccount, TwitterResponse>  action);

        
		IAsyncResult UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UpdateProfile(UpdateProfileOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UpdateProfileColors(UpdateProfileColorsOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UpdateProfileImage(UpdateProfileImageOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult ListBlockedUsers(ListBlockedUsersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult ListBlockedUserIds(ListBlockedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult BlockUser(BlockUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UnblockUser(UnblockUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult MuteUser(MuteUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UnmuteUser(UnmuteUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult ListMutedUserIds(ListMutedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult ListMutedUsers(ListMutedUsersOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		IAsyncResult ListUserProfilesFor(ListUserProfilesForOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult GetUserProfileFor(GetUserProfileForOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult SearchForUser(SearchForUserOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult GetProfileBannerFor(GetProfileBannerForOptions options, Action<ProfileBanners, TwitterResponse>  action);

        
		IAsyncResult ListSuggestedUsers(ListSuggestedUsersOptions options, Action<TwitterUserSuggestions, TwitterResponse>  action);

        
		IAsyncResult ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options, Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse>  action);

        
		IAsyncResult GetSuggestedUserMembers(GetSuggestedUserMembersOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult ListFavoriteTweets(ListFavoriteTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult UnfavoriteTweet(UnfavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		IAsyncResult FavoriteTweet(FavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		IAsyncResult ListListsFor(ListListsForOptions options, Action<IEnumerable<TwitterList>, TwitterResponse>  action);

        
		IAsyncResult ListOwnedListsFor(ListOwnedListsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action);

        
		IAsyncResult ListTweetsOnList(ListTweetsOnListOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		IAsyncResult RemoveListMember(RemoveListMemberOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult ListListMembershipsFor(ListListMembershipsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action);

        
		IAsyncResult ListListSubscribers(ListListSubscribersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult FollowList(FollowListOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult VerifyListSubscription(VerifyListSubscriptionOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult UnfollowList(UnfollowListOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult AddListMembers(AddListMembersOptions options, Action<TwitterList, TwitterResponse>  action);

        
		IAsyncResult VerifyListMembership(VerifyListMembershipOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult ListListMembers(ListListMembersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		IAsyncResult AddListMember(AddListMemberOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		IAsyncResult DeleteList(DeleteListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		IAsyncResult UpdateList(UpdateListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		IAsyncResult CreateList(CreateListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		IAsyncResult GetList(GetListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		IAsyncResult ListSubscriptions(ListSubscriptionsOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action);

        
		IAsyncResult ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse>  action);

        
		IAsyncResult GetSavedSearch(GetSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action);

        
		IAsyncResult CreateSavedSearch(CreateSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action);

        
		IAsyncResult DeleteSavedSearch(DeleteSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action);

        
		IAsyncResult GetPlace(GetPlaceOptions options, Action<TwitterPlace, TwitterResponse>  action);

        
		IAsyncResult ReverseGeocode(ReverseGeocodeOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action);

        
		IAsyncResult GeoSearch(GeoSearchOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action);

        
		IAsyncResult ListLocalTrendsFor(ListLocalTrendsForOptions options, Action<TwitterTrends, TwitterResponse>  action);

        
		IAsyncResult ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action);

        
		IAsyncResult ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action);

        
		IAsyncResult GetRateLimitStatus(GetRateLimitStatusOptions options, Action<TwitterRateLimitStatusSummary, TwitterResponse>  action);

        
		IAsyncResult ReportSpam(ReportSpamOptions options, Action<TwitterUser, TwitterResponse>  action);

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with Begin/End pattern)
        
		IAsyncResult BeginGetConfiguration();

		TwitterConfiguration EndGetConfiguration(IAsyncResult result);		

		TwitterConfiguration EndGetConfiguration(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListTweetsMentioningMe(ListTweetsMentioningMeOptions options);

		IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options);

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options);

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options);

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginRetweets(RetweetsOptions options);

		IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetTweet(GetTweetOptions options);

		TwitterStatus EndGetTweet(IAsyncResult result);		

		TwitterStatus EndGetTweet(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginDeleteTweet(DeleteTweetOptions options);

		TwitterStatus EndDeleteTweet(IAsyncResult result);		

		TwitterStatus EndDeleteTweet(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginSendTweet(SendTweetOptions options);

		TwitterStatus EndSendTweet(IAsyncResult result);		

		TwitterStatus EndSendTweet(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginRetweet(RetweetOptions options);

		TwitterStatus EndRetweet(IAsyncResult result);		

		TwitterStatus EndRetweet(IAsyncResult result, TimeSpan timeout);

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		IAsyncResult BeginSendTweetWithMedia(SendTweetWithMediaOptions options);

		TwitterStatus EndSendTweetWithMedia(IAsyncResult result);		

		TwitterStatus EndSendTweetWithMedia(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUploadMedia(UploadMediaOptions options);

		TwitterUploadedMedia EndUploadMedia(IAsyncResult result);		

		TwitterUploadedMedia EndUploadMedia(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUploadMediaInit(UploadMediaInitOptions options);

		TwitterChunkedMedia EndUploadMediaInit(IAsyncResult result);		

		TwitterChunkedMedia EndUploadMediaInit(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUploadMediaAppend(UploadMediaAppendOptions options);

		void EndUploadMediaAppend(IAsyncResult result);		

		void EndUploadMediaAppend(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUploadMediaFinalize(UploadMediaFinalizeOptions options);

		UploadMediaResult EndUploadMediaFinalize(IAsyncResult result);		

		UploadMediaResult EndUploadMediaFinalize(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUploadMediaCheckStatus(UploadMediaCheckStatusOptions options);

		UploadMediaResult EndUploadMediaCheckStatus(IAsyncResult result);		

		UploadMediaResult EndUploadMediaCheckStatus(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginSearch(SearchOptions options);

		TwitterSearchResult EndSearch(IAsyncResult result);		

		TwitterSearchResult EndSearch(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListDirectMessagesReceived(ListDirectMessagesReceivedOptions options);

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListDirectMessagesSent(ListDirectMessagesSentOptions options);

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetDirectMessage(GetDirectMessageOptions options);

		TwitterDirectMessage EndGetDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndGetDirectMessage(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginDeleteDirectMessage(DeleteDirectMessageOptions options);

		TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginSendDirectMessage(SendDirectMessageOptions options);

		TwitterDirectMessage EndSendDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndSendDirectMessage(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListFriendIdsOf(ListFriendIdsOfOptions options);

		TwitterCursorList<long> EndListFriendIdsOf(IAsyncResult result);		

		TwitterCursorList<long> EndListFriendIdsOf(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListFollowerIdsOf(ListFollowerIdsOfOptions options);

		TwitterCursorList<long> EndListFollowerIdsOf(IAsyncResult result);		

		TwitterCursorList<long> EndListFollowerIdsOf(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListFriendshipsFor(ListFriendshipsForOptions options);

		IEnumerable<TwitterFriendshipLookup> EndListFriendshipsFor(IAsyncResult result);		

		IEnumerable<TwitterFriendshipLookup> EndListFriendshipsFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetIncomingFriendRequests(GetIncomingFriendRequestsOptions options);

		TwitterCursorList<long> EndGetIncomingFriendRequests(IAsyncResult result);		

		TwitterCursorList<long> EndGetIncomingFriendRequests(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options);

		TwitterCursorList<long> EndGetOutgoingFriendRequests(IAsyncResult result);		

		TwitterCursorList<long> EndGetOutgoingFriendRequests(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginFollowUser(FollowUserOptions options);

		TwitterUser EndFollowUser(IAsyncResult result);		

		TwitterUser EndFollowUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUnfollowUser(UnfollowUserOptions options);

		TwitterUser EndUnfollowUser(IAsyncResult result);		

		TwitterUser EndUnfollowUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateFriendship(UpdateFriendshipOptions options);

		TwitterFriendship EndUpdateFriendship(IAsyncResult result);		

		TwitterFriendship EndUpdateFriendship(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetFriendshipInfo(GetFriendshipInfoOptions options);

		TwitterFriendship EndGetFriendshipInfo(IAsyncResult result);		

		TwitterFriendship EndGetFriendshipInfo(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListFriends(ListFriendsOptions options);

		TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListFollowers(ListFollowersOptions options);

		TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetAccountSettings();

		TwitterAccount EndGetAccountSettings(IAsyncResult result);		

		TwitterAccount EndGetAccountSettings(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetUserProfile(GetUserProfileOptions options);

		TwitterUser EndGetUserProfile(IAsyncResult result);		

		TwitterUser EndGetUserProfile(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginVerifyCredentials(VerifyCredentialsOptions options);

		TwitterUser EndVerifyCredentials(IAsyncResult result);		

		TwitterUser EndVerifyCredentials(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsOptions options);

		TwitterAccount EndUpdateAccountSettings(IAsyncResult result);		

		TwitterAccount EndUpdateAccountSettings(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateDeliveryDevice(UpdateDeliveryDeviceOptions options);

		TwitterUser EndUpdateDeliveryDevice(IAsyncResult result);		

		TwitterUser EndUpdateDeliveryDevice(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateProfile(UpdateProfileOptions options);

		TwitterUser EndUpdateProfile(IAsyncResult result);		

		TwitterUser EndUpdateProfile(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options);

		TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result);		

		TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateProfileColors(UpdateProfileColorsOptions options);

		TwitterUser EndUpdateProfileColors(IAsyncResult result);		

		TwitterUser EndUpdateProfileColors(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateProfileImage(UpdateProfileImageOptions options);

		TwitterUser EndUpdateProfileImage(IAsyncResult result);		

		TwitterUser EndUpdateProfileImage(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListBlockedUsers(ListBlockedUsersOptions options);

		TwitterCursorList<TwitterUser> EndListBlockedUsers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListBlockedUsers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListBlockedUserIds(ListBlockedUserIdsOptions options);

		TwitterCursorList<long> EndListBlockedUserIds(IAsyncResult result);		

		TwitterCursorList<long> EndListBlockedUserIds(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginBlockUser(BlockUserOptions options);

		TwitterUser EndBlockUser(IAsyncResult result);		

		TwitterUser EndBlockUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUnblockUser(UnblockUserOptions options);

		TwitterUser EndUnblockUser(IAsyncResult result);		

		TwitterUser EndUnblockUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginMuteUser(MuteUserOptions options);

		TwitterUser EndMuteUser(IAsyncResult result);		

		TwitterUser EndMuteUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUnmuteUser(UnmuteUserOptions options);

		TwitterUser EndUnmuteUser(IAsyncResult result);		

		TwitterUser EndUnmuteUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListMutedUserIds(ListMutedUserIdsOptions options);

		TwitterCursorList<long> EndListMutedUserIds(IAsyncResult result);		

		TwitterCursorList<long> EndListMutedUserIds(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListMutedUsers(ListMutedUsersOptions options);

		TwitterCursorList<long> EndListMutedUsers(IAsyncResult result);		

		TwitterCursorList<long> EndListMutedUsers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListUserProfilesFor(ListUserProfilesForOptions options);

		IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetUserProfileFor(GetUserProfileForOptions options);

		TwitterUser EndGetUserProfileFor(IAsyncResult result);		

		TwitterUser EndGetUserProfileFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginSearchForUser(SearchForUserOptions options);

		IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result);		

		IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetProfileBannerFor(GetProfileBannerForOptions options);

		ProfileBanners EndGetProfileBannerFor(IAsyncResult result);		

		ProfileBanners EndGetProfileBannerFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListSuggestedUsers(ListSuggestedUsersOptions options);

		TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result);		

		TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options);

		IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result);		

		IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetSuggestedUserMembers(GetSuggestedUserMembersOptions options);

		IEnumerable<TwitterUser> EndGetSuggestedUserMembers(IAsyncResult result);		

		IEnumerable<TwitterUser> EndGetSuggestedUserMembers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListFavoriteTweets(ListFavoriteTweetsOptions options);

		IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUnfavoriteTweet(UnfavoriteTweetOptions options);

		TwitterStatus EndUnfavoriteTweet(IAsyncResult result);		

		TwitterStatus EndUnfavoriteTweet(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginFavoriteTweet(FavoriteTweetOptions options);

		TwitterStatus EndFavoriteTweet(IAsyncResult result);		

		TwitterStatus EndFavoriteTweet(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListListsFor(ListListsForOptions options);

		IEnumerable<TwitterList> EndListListsFor(IAsyncResult result);		

		IEnumerable<TwitterList> EndListListsFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListOwnedListsFor(ListOwnedListsForOptions options);

		TwitterCursorList<TwitterList> EndListOwnedListsFor(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListOwnedListsFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListTweetsOnList(ListTweetsOnListOptions options);

		IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginRemoveListMember(RemoveListMemberOptions options);

		TwitterUser EndRemoveListMember(IAsyncResult result);		

		TwitterUser EndRemoveListMember(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListListMembershipsFor(ListListMembershipsForOptions options);

		TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListListSubscribers(ListListSubscribersOptions options);

		TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginFollowList(FollowListOptions options);

		TwitterUser EndFollowList(IAsyncResult result);		

		TwitterUser EndFollowList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginVerifyListSubscription(VerifyListSubscriptionOptions options);

		TwitterUser EndVerifyListSubscription(IAsyncResult result);		

		TwitterUser EndVerifyListSubscription(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUnfollowList(UnfollowListOptions options);

		TwitterUser EndUnfollowList(IAsyncResult result);		

		TwitterUser EndUnfollowList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginAddListMembers(AddListMembersOptions options);

		TwitterList EndAddListMembers(IAsyncResult result);		

		TwitterList EndAddListMembers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginVerifyListMembership(VerifyListMembershipOptions options);

		TwitterUser EndVerifyListMembership(IAsyncResult result);		

		TwitterUser EndVerifyListMembership(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListListMembers(ListListMembersOptions options);

		TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginAddListMember(AddListMemberOptions options);

		TwitterUser EndAddListMember(IAsyncResult result);		

		TwitterUser EndAddListMember(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginDeleteList(DeleteListOptions options);

		TwitterList EndDeleteList(IAsyncResult result);		

		TwitterList EndDeleteList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginUpdateList(UpdateListOptions options);

		TwitterList EndUpdateList(IAsyncResult result);		

		TwitterList EndUpdateList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginCreateList(CreateListOptions options);

		TwitterList EndCreateList(IAsyncResult result);		

		TwitterList EndCreateList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetList(GetListOptions options);

		TwitterList EndGetList(IAsyncResult result);		

		TwitterList EndGetList(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListSubscriptions(ListSubscriptionsOptions options);

		TwitterCursorList<TwitterList> EndListSubscriptions(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListSubscriptions(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListSavedSearches();

		IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result);		

		IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetSavedSearch(GetSavedSearchOptions options);

		TwitterSavedSearch EndGetSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndGetSavedSearch(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginCreateSavedSearch(CreateSavedSearchOptions options);

		TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginDeleteSavedSearch(DeleteSavedSearchOptions options);

		TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetPlace(GetPlaceOptions options);

		TwitterPlace EndGetPlace(IAsyncResult result);		

		TwitterPlace EndGetPlace(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginReverseGeocode(ReverseGeocodeOptions options);

		IEnumerable<TwitterPlace> EndReverseGeocode(IAsyncResult result);		

		IEnumerable<TwitterPlace> EndReverseGeocode(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGeoSearch(GeoSearchOptions options);

		IEnumerable<TwitterPlace> EndGeoSearch(IAsyncResult result);		

		IEnumerable<TwitterPlace> EndGeoSearch(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListLocalTrendsFor(ListLocalTrendsForOptions options);

		TwitterTrends EndListLocalTrendsFor(IAsyncResult result);		

		TwitterTrends EndListLocalTrendsFor(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListAvailableTrendsLocations();

		IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result);		

		IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginListClosestTrendsLocations(ListClosestTrendsLocationsOptions options);

		IEnumerable<WhereOnEarthLocation> EndListClosestTrendsLocations(IAsyncResult result);		

		IEnumerable<WhereOnEarthLocation> EndListClosestTrendsLocations(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginGetRateLimitStatus(GetRateLimitStatusOptions options);

		TwitterRateLimitStatusSummary EndGetRateLimitStatus(IAsyncResult result);		

		TwitterRateLimitStatusSummary EndGetRateLimitStatus(IAsyncResult result, TimeSpan timeout);

        
		IAsyncResult BeginReportSpam(ReportSpamOptions options);

		TwitterUser EndReportSpam(IAsyncResult result);		

		TwitterUser EndReportSpam(IAsyncResult result, TimeSpan timeout);

		#endregion
#endif
	
#if WINDOWS_PHONE
		#region Asynchronous Methods (without IAsyncResult)
        
		void GetConfiguration(Action<TwitterConfiguration, TwitterResponse>  action);

        
		void ListTweetsMentioningMe(ListTweetsMentioningMeOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void Retweets(RetweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void GetTweet(GetTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		void DeleteTweet(DeleteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		void SendTweet(SendTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		void Retweet(RetweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		void SendTweetWithMedia(SendTweetWithMediaOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		void UploadMedia(UploadMediaOptions options, Action<TwitterUploadedMedia, TwitterResponse>  action);

        
		void UploadMediaInit(UploadMediaInitOptions options, Action<TwitterChunkedMedia, TwitterResponse>  action);

        
		void UploadMediaAppend(UploadMediaAppendOptions options, Action<TwitterResponse> action);

        
		void UploadMediaFinalize(UploadMediaFinalizeOptions options, Action<UploadMediaResult, TwitterResponse>  action);

        
		void UploadMediaCheckStatus(UploadMediaCheckStatusOptions options, Action<UploadMediaResult, TwitterResponse>  action);

        
		void Search(SearchOptions options, Action<TwitterSearchResult, TwitterResponse>  action);

        
		void ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action);

        
		void ListDirectMessagesSent(ListDirectMessagesSentOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action);

        
		void GetDirectMessage(GetDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action);

        
		void DeleteDirectMessage(DeleteDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action);

        
		void SendDirectMessage(SendDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action);

        
		void ListFriendIdsOf(ListFriendIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void ListFollowerIdsOf(ListFollowerIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void ListFriendshipsFor(ListFriendshipsForOptions options, Action<IEnumerable<TwitterFriendshipLookup>, TwitterResponse>  action);

        
		void GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void FollowUser(FollowUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UnfollowUser(UnfollowUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UpdateFriendship(UpdateFriendshipOptions options, Action<TwitterFriendship, TwitterResponse>  action);

        
		void GetFriendshipInfo(GetFriendshipInfoOptions options, Action<TwitterFriendship, TwitterResponse>  action);

        
		void ListFriends(ListFriendsOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		void ListFollowers(ListFollowersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		void GetAccountSettings(Action<TwitterAccount, TwitterResponse>  action);

        
		void GetUserProfile(GetUserProfileOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void VerifyCredentials(VerifyCredentialsOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UpdateAccountSettings(UpdateAccountSettingsOptions options, Action<TwitterAccount, TwitterResponse>  action);

        
		void UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UpdateProfile(UpdateProfileOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UpdateProfileColors(UpdateProfileColorsOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UpdateProfileImage(UpdateProfileImageOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void ListBlockedUsers(ListBlockedUsersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		void ListBlockedUserIds(ListBlockedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void BlockUser(BlockUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UnblockUser(UnblockUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void MuteUser(MuteUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UnmuteUser(UnmuteUserOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void ListMutedUserIds(ListMutedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void ListMutedUsers(ListMutedUsersOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action);

        
		void ListUserProfilesFor(ListUserProfilesForOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action);

        
		void GetUserProfileFor(GetUserProfileForOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void SearchForUser(SearchForUserOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action);

        
		void GetProfileBannerFor(GetProfileBannerForOptions options, Action<ProfileBanners, TwitterResponse>  action);

        
		void ListSuggestedUsers(ListSuggestedUsersOptions options, Action<TwitterUserSuggestions, TwitterResponse>  action);

        
		void ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options, Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse>  action);

        
		void GetSuggestedUserMembers(GetSuggestedUserMembersOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action);

        
		void ListFavoriteTweets(ListFavoriteTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void UnfavoriteTweet(UnfavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		void FavoriteTweet(FavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action);

        
		void ListListsFor(ListListsForOptions options, Action<IEnumerable<TwitterList>, TwitterResponse>  action);

        
		void ListOwnedListsFor(ListOwnedListsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action);

        
		void ListTweetsOnList(ListTweetsOnListOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action);

        
		void RemoveListMember(RemoveListMemberOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void ListListMembershipsFor(ListListMembershipsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action);

        
		void ListListSubscribers(ListListSubscribersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		void FollowList(FollowListOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void VerifyListSubscription(VerifyListSubscriptionOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void UnfollowList(UnfollowListOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void AddListMembers(AddListMembersOptions options, Action<TwitterList, TwitterResponse>  action);

        
		void VerifyListMembership(VerifyListMembershipOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void ListListMembers(ListListMembersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action);

        
		void AddListMember(AddListMemberOptions options, Action<TwitterUser, TwitterResponse>  action);

        
		void DeleteList(DeleteListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		void UpdateList(UpdateListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		void CreateList(CreateListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		void GetList(GetListOptions options, Action<TwitterList, TwitterResponse>  action);

        
		void ListSubscriptions(ListSubscriptionsOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action);

        
		void ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse>  action);

        
		void GetSavedSearch(GetSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action);

        
		void CreateSavedSearch(CreateSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action);

        
		void DeleteSavedSearch(DeleteSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action);

        
		void GetPlace(GetPlaceOptions options, Action<TwitterPlace, TwitterResponse>  action);

        
		void ReverseGeocode(ReverseGeocodeOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action);

        
		void GeoSearch(GeoSearchOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action);

        
		void ListLocalTrendsFor(ListLocalTrendsForOptions options, Action<TwitterTrends, TwitterResponse>  action);

        
		void ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action);

        
		void ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action);

        
		void GetRateLimitStatus(GetRateLimitStatusOptions options, Action<TwitterRateLimitStatusSummary, TwitterResponse>  action);

        
		void ReportSpam(ReportSpamOptions options, Action<TwitterUser, TwitterResponse>  action);

		#endregion
#endif		

#if PLATFORM_SUPPORTS_ASYNC_AWAIT
		#region Async/Await Methods 
        

		 Task<TwitterAsyncResult<TwitterConfiguration>> GetConfigurationAsync();
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsMentioningMeAsync(ListTweetsMentioningMeOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsOnUserTimelineAsync(ListTweetsOnUserTimelineOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsOnHomeTimelineAsync(ListTweetsOnHomeTimelineOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListRetweetsOfMyTweetsAsync(ListRetweetsOfMyTweetsOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> RetweetsAsync(RetweetsOptions options);
        

		 Task<TwitterAsyncResult<TwitterStatus>> GetTweetAsync(GetTweetOptions options);
        

		 Task<TwitterAsyncResult<TwitterStatus>> DeleteTweetAsync(DeleteTweetOptions options);
        

		 Task<TwitterAsyncResult<TwitterStatus>> SendTweetAsync(SendTweetOptions options);
        

		 Task<TwitterAsyncResult<TwitterStatus>> RetweetAsync(RetweetOptions options);
        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]

		 Task<TwitterAsyncResult<TwitterStatus>> SendTweetWithMediaAsync(SendTweetWithMediaOptions options);
        

		 Task<TwitterAsyncResult<TwitterUploadedMedia>> UploadMediaAsync(UploadMediaOptions options);
        

		 Task<TwitterAsyncResult<TwitterChunkedMedia>> UploadMediaInitAsync(UploadMediaInitOptions options);
        

		 Task UploadMediaAppendAsync(UploadMediaAppendOptions options);
        

		 Task<TwitterAsyncResult<UploadMediaResult>> UploadMediaFinalizeAsync(UploadMediaFinalizeOptions options);
        

		 Task<TwitterAsyncResult<UploadMediaResult>> UploadMediaCheckStatusAsync(UploadMediaCheckStatusOptions options);
        

		 Task<TwitterAsyncResult<TwitterSearchResult>> SearchAsync(SearchOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesReceivedAsync(ListDirectMessagesReceivedOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesSentAsync(ListDirectMessagesSentOptions options);
        

		 Task<TwitterAsyncResult<TwitterDirectMessage>> GetDirectMessageAsync(GetDirectMessageOptions options);
        

		 Task<TwitterAsyncResult<TwitterDirectMessage>> DeleteDirectMessageAsync(DeleteDirectMessageOptions options);
        

		 Task<TwitterAsyncResult<TwitterDirectMessage>> SendDirectMessageAsync(SendDirectMessageOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> ListFriendIdsOfAsync(ListFriendIdsOfOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> ListFollowerIdsOfAsync(ListFollowerIdsOfOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterFriendshipLookup>>> ListFriendshipsForAsync(ListFriendshipsForOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> GetIncomingFriendRequestsAsync(GetIncomingFriendRequestsOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> GetOutgoingFriendRequestsAsync(GetOutgoingFriendRequestsOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> FollowUserAsync(FollowUserOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UnfollowUserAsync(UnfollowUserOptions options);
        

		 Task<TwitterAsyncResult<TwitterFriendship>> UpdateFriendshipAsync(UpdateFriendshipOptions options);
        

		 Task<TwitterAsyncResult<TwitterFriendship>> GetFriendshipInfoAsync(GetFriendshipInfoOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListFriendsAsync(ListFriendsOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListFollowersAsync(ListFollowersOptions options);
        

		 Task<TwitterAsyncResult<TwitterAccount>> GetAccountSettingsAsync();
        

		 Task<TwitterAsyncResult<TwitterUser>> GetUserProfileAsync(GetUserProfileOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> VerifyCredentialsAsync(VerifyCredentialsOptions options);
        

		 Task<TwitterAsyncResult<TwitterAccount>> UpdateAccountSettingsAsync(UpdateAccountSettingsOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UpdateDeliveryDeviceAsync(UpdateDeliveryDeviceOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UpdateProfileAsync(UpdateProfileOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UpdateProfileBackgroundImageAsync(UpdateProfileBackgroundImageOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UpdateProfileColorsAsync(UpdateProfileColorsOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UpdateProfileImageAsync(UpdateProfileImageOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListBlockedUsersAsync(ListBlockedUsersOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> ListBlockedUserIdsAsync(ListBlockedUserIdsOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> BlockUserAsync(BlockUserOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UnblockUserAsync(UnblockUserOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> MuteUserAsync(MuteUserOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UnmuteUserAsync(UnmuteUserOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> ListMutedUserIdsAsync(ListMutedUserIdsOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<long>>> ListMutedUsersAsync(ListMutedUsersOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterUser>>> ListUserProfilesForAsync(ListUserProfilesForOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> GetUserProfileForAsync(GetUserProfileForOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterUser>>> SearchForUserAsync(SearchForUserOptions options);
        

		 Task<TwitterAsyncResult<ProfileBanners>> GetProfileBannerForAsync(GetProfileBannerForOptions options);
        

		 Task<TwitterAsyncResult<TwitterUserSuggestions>> ListSuggestedUsersAsync(ListSuggestedUsersOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterUserSuggestions>>> ListSuggestedUserCategoriesAsync(ListSuggestedUserCategoriesOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterUser>>> GetSuggestedUserMembersAsync(GetSuggestedUserMembersOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListFavoriteTweetsAsync(ListFavoriteTweetsOptions options);
        

		 Task<TwitterAsyncResult<TwitterStatus>> UnfavoriteTweetAsync(UnfavoriteTweetOptions options);
        

		 Task<TwitterAsyncResult<TwitterStatus>> FavoriteTweetAsync(FavoriteTweetOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterList>>> ListListsForAsync(ListListsForOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterList>>> ListOwnedListsForAsync(ListOwnedListsForOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsOnListAsync(ListTweetsOnListOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> RemoveListMemberAsync(RemoveListMemberOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterList>>> ListListMembershipsForAsync(ListListMembershipsForOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListListSubscribersAsync(ListListSubscribersOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> FollowListAsync(FollowListOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> VerifyListSubscriptionAsync(VerifyListSubscriptionOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> UnfollowListAsync(UnfollowListOptions options);
        

		 Task<TwitterAsyncResult<TwitterList>> AddListMembersAsync(AddListMembersOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> VerifyListMembershipAsync(VerifyListMembershipOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListListMembersAsync(ListListMembersOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> AddListMemberAsync(AddListMemberOptions options);
        

		 Task<TwitterAsyncResult<TwitterList>> DeleteListAsync(DeleteListOptions options);
        

		 Task<TwitterAsyncResult<TwitterList>> UpdateListAsync(UpdateListOptions options);
        

		 Task<TwitterAsyncResult<TwitterList>> CreateListAsync(CreateListOptions options);
        

		 Task<TwitterAsyncResult<TwitterList>> GetListAsync(GetListOptions options);
        

		 Task<TwitterAsyncResult<TwitterCursorList<TwitterList>>> ListSubscriptionsAsync(ListSubscriptionsOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterSavedSearch>>> ListSavedSearchesAsync();
        

		 Task<TwitterAsyncResult<TwitterSavedSearch>> GetSavedSearchAsync(GetSavedSearchOptions options);
        

		 Task<TwitterAsyncResult<TwitterSavedSearch>> CreateSavedSearchAsync(CreateSavedSearchOptions options);
        

		 Task<TwitterAsyncResult<TwitterSavedSearch>> DeleteSavedSearchAsync(DeleteSavedSearchOptions options);
        

		 Task<TwitterAsyncResult<TwitterPlace>> GetPlaceAsync(GetPlaceOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterPlace>>> ReverseGeocodeAsync(ReverseGeocodeOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<TwitterPlace>>> GeoSearchAsync(GeoSearchOptions options);
        

		 Task<TwitterAsyncResult<TwitterTrends>> ListLocalTrendsForAsync(ListLocalTrendsForOptions options);
        

		 Task<TwitterAsyncResult<IEnumerable<WhereOnEarthLocation>>> ListAvailableTrendsLocationsAsync();
        

		 Task<TwitterAsyncResult<IEnumerable<WhereOnEarthLocation>>> ListClosestTrendsLocationsAsync(ListClosestTrendsLocationsOptions options);
        

		 Task<TwitterAsyncResult<TwitterRateLimitStatusSummary>> GetRateLimitStatusAsync(GetRateLimitStatusOptions options);
        

		 Task<TwitterAsyncResult<TwitterUser>> ReportSpamAsync(ReportSpamOptions options);
		#endregion
#endif		


	}
#endregion
}

namespace TweetSharp
{
#region Implementation
	public partial class TwitterService : ITwitterService
	{	
#if !SILVERLIGHT && !WINRT
		#region Sequential Methods
        
		public virtual TwitterConfiguration GetConfiguration()
		{
				
			
			return WithHammock<TwitterConfiguration>(_client, "help/configuration", FormatAsString);
		}

        
		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe(ListTweetsMentioningMeOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "statuses/mentions_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var since_id = options.SinceId;
			var count = options.Count;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_rts = options.IncludeRts;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "statuses/user_timeline", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&since_id=", since_id, "&count=", count, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_rts=", include_rts);
		}

        
		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "statuses/home_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var include_entities = options.IncludeEntities;
			var include_user_entities = options.IncludeUserEntities;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "statuses/retweets_of_me", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&include_entities=", include_entities, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IEnumerable<TwitterStatus> Retweets(RetweetsOptions options)
		{
			var id = options.Id;
			var count = options.Count;
			var trim_user = options.TrimUser;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count, "&trim_user=", trim_user);
		}

        
		public virtual TwitterStatus GetTweet(GetTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			var include_my_retweet = options.IncludeMyRetweet;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<TwitterStatus>(_client, "statuses/show/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user, "&include_my_retweet=", include_my_retweet, "&include_entities=", include_entities);
		}

        
		public virtual TwitterStatus DeleteTweet(DeleteTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				
			
			return WithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/destroy/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        
		public virtual TwitterStatus SendTweet(SendTweetOptions options)
		{
			var status = options.Status;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			var trim_user = options.TrimUser;
			var media_ids = options.MediaIds;
				
			
			return WithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates, "&trim_user=", trim_user, "&media_ids=", media_ids);
		}

        
		public virtual TwitterStatus Retweet(RetweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				
			
			return WithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual TwitterStatus SendTweetWithMedia(SendTweetWithMediaOptions options)
		{
			var status = options.Status;
			var possibly_sensitive = options.PossiblySensitive;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			 var images = options.Images;
				
			
			return WithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/update_with_media", images, FormatAsString, "?status=", status, "&possibly_sensitive=", possibly_sensitive, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates);
		}

        
		public virtual TwitterUploadedMedia UploadMedia(UploadMediaOptions options)
		{
			 var media = options.Media;
				
			
			return WithHammock<TwitterUploadedMedia>(_uploadMediaClient, WebMethod.Post, "media/upload", media, FormatAsString);
		}

        
		public virtual TwitterChunkedMedia UploadMediaInit(UploadMediaInitOptions options)
		{
			var media_type = options.MediaType;
			var media_category = options.MediaCategory;
			var total_bytes = options.TotalBytes;
				
			
			return WithHammock<TwitterChunkedMedia>(_uploadMediaClient, WebMethod.Post, "media/upload", FormatAsString, "?command=", "INIT", "&media_type=", media_type, "&media_category=", media_category, "&total_bytes=", total_bytes);
		}

        
		public virtual void UploadMediaAppend(UploadMediaAppendOptions options)
		{
			var media_id = options.MediaId;
			var segment_index = options.SegmentIndex;
			 var media = options.Media;
				
			
			 WithHammockNoResponse(_uploadMediaClient, WebMethod.Post, "media/upload", media, FormatAsString, "?command=", "APPEND", "&media_id=", media_id, "&segment_index=", segment_index);
		}

        
		public virtual UploadMediaResult UploadMediaFinalize(UploadMediaFinalizeOptions options)
		{
			var media_id = options.MediaId;
				
			
			return WithHammock<UploadMediaResult>(_uploadMediaClient, WebMethod.Post, "media/upload", FormatAsString, "?command=", "FINALIZE", "&media_id=", media_id);
		}

        
		public virtual UploadMediaResult UploadMediaCheckStatus(UploadMediaCheckStatusOptions options)
		{
			var media_id = options.MediaId;
				
			
			return WithHammock<UploadMediaResult>(_uploadMediaClient, "media/upload", FormatAsString, "?command=", "STATUS", "&media_id=", media_id);
		}

        
		public virtual TwitterSearchResult Search(SearchOptions options)
		{
			var q = options.Q;
			var geocode = options.Geocode;
			var lang = options.Lang;
			var locale = options.Locale;
			var resultType = options.Resulttype;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			var callback = options.Callback;
			var until = options.Until;
				
			
			return WithHammock<TwitterSearchResult>(_client, "search/tweets", FormatAsString, "?q=", q, "&geocode=", geocode, "&lang=", lang, "&locale=", locale, "&result_type=", resultType, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities, "&callback=", callback, "&until=", until);
		}

        
		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var full_text = options.FullText;
				
			
			return WithHammock<IEnumerable<TwitterDirectMessage>>(_client, "direct_messages", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&skip_status=", skip_status, "&full_text=", full_text);
		}

        
		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(ListDirectMessagesSentOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var page = options.Page;
			var include_entities = options.IncludeEntities;
			var full_text = options.FullText;
				
			
			return WithHammock<IEnumerable<TwitterDirectMessage>>(_client, "direct_messages/sent", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&page=", page, "&include_entities=", include_entities, "&full_text=", full_text);
		}

        
		public virtual TwitterDirectMessage GetDirectMessage(GetDirectMessageOptions options)
		{
			var id = options.Id;
			var full_text = options.FullText;
				
			
			return WithHammock<TwitterDirectMessage>(_client, "direct_messages/show", FormatAsString, "?id=", id, "&full_text=", full_text);
		}

        
		public virtual TwitterDirectMessage DeleteDirectMessage(DeleteDirectMessageOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<TwitterDirectMessage>(_client, WebMethod.Post, "direct_messages/destroy", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual TwitterDirectMessage SendDirectMessage(SendDirectMessageOptions options)
		{
			var text = options.Text;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				
			
			return WithHammock<TwitterDirectMessage>(_client, WebMethod.Post, "direct_messages/new", FormatAsString, "?text=", text, "&user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual TwitterCursorList<long> ListFriendIdsOf(ListFriendIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "friends/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual TwitterCursorList<long> ListFollowerIdsOf(ListFollowerIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "followers/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual IEnumerable<TwitterFriendshipLookup> ListFriendshipsFor(ListFriendshipsForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return WithHammock<IEnumerable<TwitterFriendshipLookup>>(_client, "friendships/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual TwitterCursorList<long> GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual TwitterCursorList<long> GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual TwitterUser FollowUser(FollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var follow = options.Follow;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&follow=", follow);
		}

        
		public virtual TwitterUser UnfollowUser(UnfollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "friendships/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual TwitterFriendship UpdateFriendship(UpdateFriendshipOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var device = options.Device;
			var retweets = options.Retweets;
				
			
			return WithHammock<TwitterFriendship>(_client, WebMethod.Post, "friendships/update", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&device=", device, "&retweets=", retweets);
		}

        
		public virtual TwitterFriendship GetFriendshipInfo(GetFriendshipInfoOptions options)
		{
			var source_id = options.SourceId;
			var source_screen_name = options.SourceScreenName;
			var target_id = options.TargetId;
			var target_screen_name = options.TargetScreenName;
				
			
			return WithHammock<TwitterFriendship>(_client, "friendships/show", FormatAsString, "?source_id=", source_id, "&source_screen_name=", source_screen_name, "&target_id=", target_id, "&target_screen_name=", target_screen_name);
		}

        
		public virtual TwitterCursorList<TwitterUser> ListFriends(ListFriendsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				
			
			return WithHammock<TwitterCursorList<TwitterUser>>(_client, "friends/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual TwitterCursorList<TwitterUser> ListFollowers(ListFollowersOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				
			
			return WithHammock<TwitterCursorList<TwitterUser>>(_client, "followers/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual TwitterAccount GetAccountSettings()
		{
				
			
			return WithHammock<TwitterAccount>(_client, "account/settings", FormatAsString);
		}

        
		public virtual TwitterUser GetUserProfile(GetUserProfileOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
				
			
			return WithHammock<TwitterUser>(_client, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual TwitterUser VerifyCredentials(VerifyCredentialsOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
				
			
			return WithHammock<TwitterUser>(_client, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual TwitterAccount UpdateAccountSettings(UpdateAccountSettingsOptions options)
		{
			var trend_location_woeid = options.TrendLocationWoeid;
			var sleep_time_enabled = options.SleepTimeEnabled;
			var start_sleep_time = options.StartSleepTime;
			var end_sleep_time = options.EndSleepTime;
			var time_zone = options.TimeZone;
			var lang = options.Lang;
				
			
			return WithHammock<TwitterAccount>(_client, WebMethod.Post, "account/settings", FormatAsString, "?trend_location_woeid=", trend_location_woeid, "&sleep_time_enabled=", sleep_time_enabled, "&start_sleep_time=", start_sleep_time, "&end_sleep_time=", end_sleep_time, "&time_zone=", time_zone, "&lang=", lang);
		}

        
		public virtual TwitterUser UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options)
		{
			var device = options.Device;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<TwitterUser>(_client, "account/update_delivery_device", FormatAsString, "?device=", device, "&include_entities=", include_entities);
		}

        
		public virtual TwitterUser UpdateProfile(UpdateProfileOptions options)
		{
			var name = options.Name;
			var url = options.Url;
			var location = options.Location;
			var description = options.Description;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&url=", url, "&location=", location, "&description=", description, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options)
		{
			var imagePath = options.Imagepath;
			var tile = options.Tile;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var use = options.Use;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?image_path=", imagePath, "&tile=", tile, "&include_entities=", include_entities, "&skip_status=", skip_status, "&use=", use);
		}

        
		public virtual TwitterUser UpdateProfileColors(UpdateProfileColorsOptions options)
		{
			var profile_background_color = options.ProfileBackgroundColor;
			var profile_link_color = options.ProfileLinkColor;
			var profile_sidebar_border_color = options.ProfileSidebarBorderColor;
			var profile_sidebar_fill_color = options.ProfileSidebarFillColor;
			var profile_text_color = options.ProfileTextColor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile_colors", FormatAsString, "?profile_background_color=", profile_background_color, "&profile_link_color=", profile_link_color, "&profile_sidebar_border_color=", profile_sidebar_border_color, "&profile_sidebar_fill_color=", profile_sidebar_fill_color, "&profile_text_color=", profile_text_color, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser UpdateProfileImage(UpdateProfileImageOptions options)
		{
			var image_path = options.ImagePath;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile_image", FormatAsString, "?image_path=", image_path, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterCursorList<TwitterUser> ListBlockedUsers(ListBlockedUsersOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<TwitterUser>>(_client, "blocks/list", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&cursor=", cursor);
		}

        
		public virtual TwitterCursorList<long> ListBlockedUserIds(ListBlockedUserIdsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "blocks/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual TwitterUser BlockUser(BlockUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser UnblockUser(UnblockUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "blocks/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser MuteUser(MuteUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "mutes/users/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual TwitterUser UnmuteUser(UnmuteUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "mutes/users/destroy", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual TwitterCursorList<long> ListMutedUserIds(ListMutedUserIdsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "mutes/users/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual TwitterCursorList<long> ListMutedUsers(ListMutedUsersOptions options)
		{
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<long>>(_client, "mutes/users/list", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IEnumerable<TwitterUser> ListUserProfilesFor(ListUserProfilesForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<IEnumerable<TwitterUser>>(_client, "users/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities);
		}

        
		public virtual TwitterUser GetUserProfileFor(GetUserProfileForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<TwitterUser>(_client, "users/show", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities);
		}

        
		public virtual IEnumerable<TwitterUser> SearchForUser(SearchForUserOptions options)
		{
			var q = options.Q;
			var page = options.Page;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<IEnumerable<TwitterUser>>(_client, "users/search", FormatAsString, "?q=", q, "&page=", page, "&count=", count, "&include_entities=", include_entities);
		}

        
		public virtual ProfileBanners GetProfileBannerFor(GetProfileBannerForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return WithHammock<ProfileBanners>(_client, "users/profile_banner", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual TwitterUserSuggestions ListSuggestedUsers(ListSuggestedUsersOptions options)
		{
			var slug = options.Slug;
			var lang = options.Lang;
				
			
			return WithHammock<TwitterUserSuggestions>(_client, "/users/suggestions/{slug}", FormatAsString, "?slug=", slug, "&lang=", lang);
		}

        
		public virtual IEnumerable<TwitterUserSuggestions> ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options)
		{
			var lang = options.Lang;
				
			
			return WithHammock<IEnumerable<TwitterUserSuggestions>>(_client, "users/suggestions", FormatAsString, "?lang=", lang);
		}

        
		public virtual IEnumerable<TwitterUser> GetSuggestedUserMembers(GetSuggestedUserMembersOptions options)
		{
			var slug = options.Slug;
				
			
			return WithHammock<IEnumerable<TwitterUser>>(_client, "/users/suggestions/{slug}/members", FormatAsString, "?slug=", slug);
		}

        
		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets(ListFavoriteTweetsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "favorites/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities);
		}

        
		public virtual TwitterStatus UnfavoriteTweet(UnfavoriteTweetOptions options)
		{
			var id = options.Id;
				
			
			return WithHammock<TwitterStatus>(_client, WebMethod.Post, "favorites/destroy", FormatAsString, "?id=", id);
		}

        
		public virtual TwitterStatus FavoriteTweet(FavoriteTweetOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				
			
			return WithHammock<TwitterStatus>(_client, WebMethod.Post, "favorites/create", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual IEnumerable<TwitterList> ListListsFor(ListListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				
			
			return WithHammock<IEnumerable<TwitterList>>(_client, "lists/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual TwitterCursorList<TwitterList> ListOwnedListsFor(ListOwnedListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<TwitterList>>(_client, "lists/ownerships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(ListTweetsOnListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var include_rts = options.IncludeRts;
				
			
			return WithHammock<IEnumerable<TwitterStatus>>(_client, "lists/statuses", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&include_rts=", include_rts);
		}

        
		public virtual TwitterUser RemoveListMember(RemoveListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(ListListMembershipsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var filter_to_owned_lists = options.FilterToOwnedLists;
				
			
			return WithHammock<TwitterCursorList<TwitterList>>(_client, "lists/memberships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&filter_to_owned_lists=", filter_to_owned_lists);
		}

        
		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(ListListSubscribersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterCursorList<TwitterUser>>(_client, "lists/subscribers", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser FollowList(FollowListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual TwitterUser VerifyListSubscription(VerifyListSubscriptionOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser UnfollowList(UnfollowListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual TwitterList AddListMembers(AddListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return WithHammock<TwitterList>(_client, WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual TwitterUser VerifyListMembership(VerifyListMembershipOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterUser>(_client, "lists/members/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterCursorList<TwitterUser> ListListMembers(ListListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var count = options.Count;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return WithHammock<TwitterCursorList<TwitterUser>>(_client, "lists/members", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&count=", count, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual TwitterUser AddListMember(AddListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual TwitterList DeleteList(DeleteListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				
			
			return WithHammock<TwitterList>(_client, WebMethod.Post, "lists/destroy", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual TwitterList UpdateList(UpdateListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var mode = options.Mode;
			var name = options.Name;
			var description = options.Description;
				
			
			return WithHammock<TwitterList>(_client, WebMethod.Post, "lists/update", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&mode=", mode, "&name=", name, "&description=", description);
		}

        
		public virtual TwitterList CreateList(CreateListOptions options)
		{
			var list_owner = options.ListOwner;
			var name = options.Name;
			var mode = options.Mode;
			var description = options.Description;
				
			
			return WithHammock<TwitterList>(_client, WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", list_owner, "&name=", name, "&mode=", mode, "&description=", description);
		}

        
		public virtual TwitterList GetList(GetListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return WithHammock<TwitterList>(_client, "lists/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual TwitterCursorList<TwitterList> ListSubscriptions(ListSubscriptionsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				
			
			return WithHammock<TwitterCursorList<TwitterList>>(_client, "lists/subscriptions", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual IEnumerable<TwitterSavedSearch> ListSavedSearches()
		{
				
			
			return WithHammock<IEnumerable<TwitterSavedSearch>>(_client, "saved_searches/list", FormatAsString);
		}

        
		public virtual TwitterSavedSearch GetSavedSearch(GetSavedSearchOptions options)
		{
			var id = options.Id;
				
			
			return WithHammock<TwitterSavedSearch>(_client, "saved_searches/show/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual TwitterSavedSearch CreateSavedSearch(CreateSavedSearchOptions options)
		{
			var query = options.Query;
				
			
			return WithHammock<TwitterSavedSearch>(_client, WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

        
		public virtual TwitterSavedSearch DeleteSavedSearch(DeleteSavedSearchOptions options)
		{
			var id = options.Id;
				
			
			return WithHammock<TwitterSavedSearch>(_client, WebMethod.Post, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual TwitterPlace GetPlace(GetPlaceOptions options)
		{
			var place_id = options.PlaceId;
				
			
			return WithHammock<TwitterPlace>(_client, "geo/id/{place_id}", FormatAsString, "?place_id=", place_id);
		}

        
		public virtual IEnumerable<TwitterPlace> ReverseGeocode(ReverseGeocodeOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var accuracy = options.Accuracy;
			var granularity = options.Granularity;
			var max_results = options.MaxResults;
			var callback = options.Callback;
				
			
			return WithHammock<IEnumerable<TwitterPlace>>(_client, "geo/reverse_geocode", FormatAsString, "?lat=", lat, "&long=", @long, "&accuracy=", accuracy, "&granularity=", granularity, "&max_results=", max_results, "&callback=", callback);
		}

        
		public virtual IEnumerable<TwitterPlace> GeoSearch(GeoSearchOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var query = options.Query;
			var ip = options.Ip;
			var granularity = options.Granularity;
			var accuracy = options.Accuracy;
			var max_results = options.MaxResults;
			var contained_within = options.ContainedWithin;
			var callback = options.Callback;
				
			
			return WithHammock<IEnumerable<TwitterPlace>>(_client, "geo/search", FormatAsString, "?lat=", lat, "&long=", @long, "&query=", query, "&ip=", ip, "&granularity=", granularity, "&accuracy=", accuracy, "&max_results=", max_results, "&contained_within=", contained_within, "&callback=", callback);
		}

        
		public virtual TwitterTrends ListLocalTrendsFor(ListLocalTrendsForOptions options)
		{
			var id = options.Id;
			var exclude = options.Exclude;
				
			
			return WithHammock<TwitterTrends>(_client, "trends/place", FormatAsString, "?id=", id, "&exclude=", exclude);
		}

        
		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations()
		{
				
			
			return WithHammock<IEnumerable<WhereOnEarthLocation>>(_client, "trends/available", FormatAsString);
		}

        
		public virtual IEnumerable<WhereOnEarthLocation> ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
				
			
			return WithHammock<IEnumerable<WhereOnEarthLocation>>(_client, "trends/closest", FormatAsString, "?lat=", lat, "&long=", @long);
		}

        
		public virtual TwitterRateLimitStatusSummary GetRateLimitStatus(GetRateLimitStatusOptions options)
		{
			var resources = options.Resources;
				
			
			return WithHammock<TwitterRateLimitStatusSummary>(_client, "application/rate_limit_status", FormatAsString, "?resources=", resources);
		}

        
		public virtual TwitterUser ReportSpam(ReportSpamOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return WithHammock<TwitterUser>(_client, WebMethod.Post, "users/report_spam", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with IAsyncResult)
        
		public virtual IAsyncResult GetConfiguration(Action<TwitterConfiguration, TwitterResponse>  action)
		{
				

			return  WithHammock<TwitterConfiguration>(_client, action, "help/configuration", FormatAsString);
		}

        
		public virtual IAsyncResult ListTweetsMentioningMe(ListTweetsMentioningMeOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/mentions_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var since_id = options.SinceId;
			var count = options.Count;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_rts = options.IncludeRts;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/user_timeline", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&since_id=", since_id, "&count=", count, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_rts=", include_rts);
		}

        
		public virtual IAsyncResult ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/home_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var include_entities = options.IncludeEntities;
			var include_user_entities = options.IncludeUserEntities;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/retweets_of_me", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&include_entities=", include_entities, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IAsyncResult Retweets(RetweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var id = options.Id;
			var count = options.Count;
			var trim_user = options.TrimUser;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count, "&trim_user=", trim_user);
		}

        
		public virtual IAsyncResult GetTweet(GetTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			var include_my_retweet = options.IncludeMyRetweet;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<TwitterStatus>(_client, action, "statuses/show/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user, "&include_my_retweet=", include_my_retweet, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult DeleteTweet(DeleteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				

			return  WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/destroy/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        
		public virtual IAsyncResult SendTweet(SendTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var status = options.Status;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			var trim_user = options.TrimUser;
			var media_ids = options.MediaIds;
				

			return  WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates, "&trim_user=", trim_user, "&media_ids=", media_ids);
		}

        
		public virtual IAsyncResult Retweet(RetweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				

			return  WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/retweet/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual IAsyncResult SendTweetWithMedia(SendTweetWithMediaOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var status = options.Status;
			var possibly_sensitive = options.PossiblySensitive;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			 var images = options.Images;
				

			return  WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/update_with_media", images, FormatAsString, "?status=", status, "&possibly_sensitive=", possibly_sensitive, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates);
		}

        
		public virtual IAsyncResult UploadMedia(UploadMediaOptions options, Action<TwitterUploadedMedia, TwitterResponse>  action)
		{
			 var media = options.Media;
				

			return  WithHammock<TwitterUploadedMedia>(_uploadMediaClient, WebMethod.Post, action, "media/upload", media, FormatAsString);
		}

        
		public virtual IAsyncResult UploadMediaInit(UploadMediaInitOptions options, Action<TwitterChunkedMedia, TwitterResponse>  action)
		{
			var media_type = options.MediaType;
			var media_category = options.MediaCategory;
			var total_bytes = options.TotalBytes;
				

			return  WithHammock<TwitterChunkedMedia>(_uploadMediaClient, WebMethod.Post, action, "media/upload", FormatAsString, "?command=", "INIT", "&media_type=", media_type, "&media_category=", media_category, "&total_bytes=", total_bytes);
		}

        
		public virtual IAsyncResult UploadMediaAppend(UploadMediaAppendOptions options, Action<TwitterResponse> action)
		{
			var media_id = options.MediaId;
			var segment_index = options.SegmentIndex;
			 var media = options.Media;
				

			return  WithHammockNoResponse(_uploadMediaClient, WebMethod.Post, action, "media/upload", media, FormatAsString, "?command=", "APPEND", "&media_id=", media_id, "&segment_index=", segment_index);
		}

        
		public virtual IAsyncResult UploadMediaFinalize(UploadMediaFinalizeOptions options, Action<UploadMediaResult, TwitterResponse>  action)
		{
			var media_id = options.MediaId;
				

			return  WithHammock<UploadMediaResult>(_uploadMediaClient, WebMethod.Post, action, "media/upload", FormatAsString, "?command=", "FINALIZE", "&media_id=", media_id);
		}

        
		public virtual IAsyncResult UploadMediaCheckStatus(UploadMediaCheckStatusOptions options, Action<UploadMediaResult, TwitterResponse>  action)
		{
			var media_id = options.MediaId;
				

			return  WithHammock<UploadMediaResult>(_uploadMediaClient, action, "media/upload", FormatAsString, "?command=", "STATUS", "&media_id=", media_id);
		}

        
		public virtual IAsyncResult Search(SearchOptions options, Action<TwitterSearchResult, TwitterResponse>  action)
		{
			var q = options.Q;
			var geocode = options.Geocode;
			var lang = options.Lang;
			var locale = options.Locale;
			var resultType = options.Resulttype;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			var callback = options.Callback;
			var until = options.Until;
				

			return  WithHammock<TwitterSearchResult>(_client, action, "search/tweets", FormatAsString, "?q=", q, "&geocode=", geocode, "&lang=", lang, "&locale=", locale, "&result_type=", resultType, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities, "&callback=", callback, "&until=", until);
		}

        
		public virtual IAsyncResult ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var full_text = options.FullText;
				

			return  WithHammock<IEnumerable<TwitterDirectMessage>>(_client, action, "direct_messages", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&skip_status=", skip_status, "&full_text=", full_text);
		}

        
		public virtual IAsyncResult ListDirectMessagesSent(ListDirectMessagesSentOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var page = options.Page;
			var include_entities = options.IncludeEntities;
			var full_text = options.FullText;
				

			return  WithHammock<IEnumerable<TwitterDirectMessage>>(_client, action, "direct_messages/sent", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&page=", page, "&include_entities=", include_entities, "&full_text=", full_text);
		}

        
		public virtual IAsyncResult GetDirectMessage(GetDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action)
		{
			var id = options.Id;
			var full_text = options.FullText;
				

			return  WithHammock<TwitterDirectMessage>(_client, action, "direct_messages/show", FormatAsString, "?id=", id, "&full_text=", full_text);
		}

        
		public virtual IAsyncResult DeleteDirectMessage(DeleteDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<TwitterDirectMessage>(_client, WebMethod.Post, action, "direct_messages/destroy", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult SendDirectMessage(SendDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action)
		{
			var text = options.Text;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return  WithHammock<TwitterDirectMessage>(_client, WebMethod.Post, action, "direct_messages/new", FormatAsString, "?text=", text, "&user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult ListFriendIdsOf(ListFriendIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "friends/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual IAsyncResult ListFollowerIdsOf(ListFollowerIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "followers/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual IAsyncResult ListFriendshipsFor(ListFriendshipsForOptions options, Action<IEnumerable<TwitterFriendshipLookup>, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return  WithHammock<IEnumerable<TwitterFriendshipLookup>>(_client, action, "friendships/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual IAsyncResult GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult FollowUser(FollowUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var follow = options.Follow;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "friendships/create", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&follow=", follow);
		}

        
		public virtual IAsyncResult UnfollowUser(UnfollowUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "friendships/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual IAsyncResult UpdateFriendship(UpdateFriendshipOptions options, Action<TwitterFriendship, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var device = options.Device;
			var retweets = options.Retweets;
				

			return  WithHammock<TwitterFriendship>(_client, WebMethod.Post, action, "friendships/update", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&device=", device, "&retweets=", retweets);
		}

        
		public virtual IAsyncResult GetFriendshipInfo(GetFriendshipInfoOptions options, Action<TwitterFriendship, TwitterResponse>  action)
		{
			var source_id = options.SourceId;
			var source_screen_name = options.SourceScreenName;
			var target_id = options.TargetId;
			var target_screen_name = options.TargetScreenName;
				

			return  WithHammock<TwitterFriendship>(_client, action, "friendships/show", FormatAsString, "?source_id=", source_id, "&source_screen_name=", source_screen_name, "&target_id=", target_id, "&target_screen_name=", target_screen_name);
		}

        
		public virtual IAsyncResult ListFriends(ListFriendsOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				

			return  WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "friends/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IAsyncResult ListFollowers(ListFollowersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				

			return  WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "followers/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IAsyncResult GetAccountSettings(Action<TwitterAccount, TwitterResponse>  action)
		{
				

			return  WithHammock<TwitterAccount>(_client, action, "account/settings", FormatAsString);
		}

        
		public virtual IAsyncResult GetUserProfile(GetUserProfileOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
				

			return  WithHammock<TwitterUser>(_client, action, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual IAsyncResult VerifyCredentials(VerifyCredentialsOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
				

			return  WithHammock<TwitterUser>(_client, action, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual IAsyncResult UpdateAccountSettings(UpdateAccountSettingsOptions options, Action<TwitterAccount, TwitterResponse>  action)
		{
			var trend_location_woeid = options.TrendLocationWoeid;
			var sleep_time_enabled = options.SleepTimeEnabled;
			var start_sleep_time = options.StartSleepTime;
			var end_sleep_time = options.EndSleepTime;
			var time_zone = options.TimeZone;
			var lang = options.Lang;
				

			return  WithHammock<TwitterAccount>(_client, WebMethod.Post, action, "account/settings", FormatAsString, "?trend_location_woeid=", trend_location_woeid, "&sleep_time_enabled=", sleep_time_enabled, "&start_sleep_time=", start_sleep_time, "&end_sleep_time=", end_sleep_time, "&time_zone=", time_zone, "&lang=", lang);
		}

        
		public virtual IAsyncResult UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var device = options.Device;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<TwitterUser>(_client, action, "account/update_delivery_device", FormatAsString, "?device=", device, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult UpdateProfile(UpdateProfileOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var name = options.Name;
			var url = options.Url;
			var location = options.Location;
			var description = options.Description;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile", FormatAsString, "?name=", name, "&url=", url, "&location=", location, "&description=", description, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var imagePath = options.Imagepath;
			var tile = options.Tile;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var use = options.Use;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile_background_image", FormatAsString, "?image_path=", imagePath, "&tile=", tile, "&include_entities=", include_entities, "&skip_status=", skip_status, "&use=", use);
		}

        
		public virtual IAsyncResult UpdateProfileColors(UpdateProfileColorsOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var profile_background_color = options.ProfileBackgroundColor;
			var profile_link_color = options.ProfileLinkColor;
			var profile_sidebar_border_color = options.ProfileSidebarBorderColor;
			var profile_sidebar_fill_color = options.ProfileSidebarFillColor;
			var profile_text_color = options.ProfileTextColor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?profile_background_color=", profile_background_color, "&profile_link_color=", profile_link_color, "&profile_sidebar_border_color=", profile_sidebar_border_color, "&profile_sidebar_fill_color=", profile_sidebar_fill_color, "&profile_text_color=", profile_text_color, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult UpdateProfileImage(UpdateProfileImageOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var image_path = options.ImagePath;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile_image", FormatAsString, "?image_path=", image_path, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult ListBlockedUsers(ListBlockedUsersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "blocks/list", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&cursor=", cursor);
		}

        
		public virtual IAsyncResult ListBlockedUserIds(ListBlockedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "blocks/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult BlockUser(BlockUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "blocks/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult UnblockUser(UnblockUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "blocks/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult MuteUser(MuteUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "mutes/users/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult UnmuteUser(UnmuteUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "mutes/users/destroy", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult ListMutedUserIds(ListMutedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "mutes/users/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult ListMutedUsers(ListMutedUsersOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<long>>(_client, action, "mutes/users/list", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult ListUserProfilesFor(ListUserProfilesForOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<IEnumerable<TwitterUser>>(_client, action, "users/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult GetUserProfileFor(GetUserProfileForOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<TwitterUser>(_client, action, "users/show", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult SearchForUser(SearchForUserOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action)
		{
			var q = options.Q;
			var page = options.Page;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<IEnumerable<TwitterUser>>(_client, action, "users/search", FormatAsString, "?q=", q, "&page=", page, "&count=", count, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult GetProfileBannerFor(GetProfileBannerForOptions options, Action<ProfileBanners, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return  WithHammock<ProfileBanners>(_client, action, "users/profile_banner", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual IAsyncResult ListSuggestedUsers(ListSuggestedUsersOptions options, Action<TwitterUserSuggestions, TwitterResponse>  action)
		{
			var slug = options.Slug;
			var lang = options.Lang;
				

			return  WithHammock<TwitterUserSuggestions>(_client, action, "/users/suggestions/{slug}", FormatAsString, "?slug=", slug, "&lang=", lang);
		}

        
		public virtual IAsyncResult ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options, Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse>  action)
		{
			var lang = options.Lang;
				

			return  WithHammock<IEnumerable<TwitterUserSuggestions>>(_client, action, "users/suggestions", FormatAsString, "?lang=", lang);
		}

        
		public virtual IAsyncResult GetSuggestedUserMembers(GetSuggestedUserMembersOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action)
		{
			var slug = options.Slug;
				

			return  WithHammock<IEnumerable<TwitterUser>>(_client, action, "/users/suggestions/{slug}/members", FormatAsString, "?slug=", slug);
		}

        
		public virtual IAsyncResult ListFavoriteTweets(ListFavoriteTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "favorites/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult UnfavoriteTweet(UnfavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
				

			return  WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "favorites/destroy", FormatAsString, "?id=", id);
		}

        
		public virtual IAsyncResult FavoriteTweet(FavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				

			return  WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "favorites/create", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult ListListsFor(ListListsForOptions options, Action<IEnumerable<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return  WithHammock<IEnumerable<TwitterList>>(_client, action, "lists/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult ListOwnedListsFor(ListOwnedListsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<TwitterList>>(_client, action, "lists/ownerships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual IAsyncResult ListTweetsOnList(ListTweetsOnListOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var include_rts = options.IncludeRts;
				

			return  WithHammock<IEnumerable<TwitterStatus>>(_client, action, "lists/statuses", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&include_rts=", include_rts);
		}

        
		public virtual IAsyncResult RemoveListMember(RemoveListMemberOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult ListListMembershipsFor(ListListMembershipsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var filter_to_owned_lists = options.FilterToOwnedLists;
				

			return  WithHammock<TwitterCursorList<TwitterList>>(_client, action, "lists/memberships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&filter_to_owned_lists=", filter_to_owned_lists);
		}

        
		public virtual IAsyncResult ListListSubscribers(ListListSubscribersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "lists/subscribers", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult FollowList(FollowListOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual IAsyncResult VerifyListSubscription(VerifyListSubscriptionOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, action, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult UnfollowList(UnfollowListOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/subscribers/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult AddListMembers(AddListMembersOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return  WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult VerifyListMembership(VerifyListMembershipOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterUser>(_client, action, "lists/members/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult ListListMembers(ListListMembersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var count = options.Count;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return  WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "lists/members", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&count=", count, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult AddListMember(AddListMemberOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/members/create", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult DeleteList(DeleteListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				

			return  WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/destroy", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual IAsyncResult UpdateList(UpdateListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var mode = options.Mode;
			var name = options.Name;
			var description = options.Description;
				

			return  WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/update", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&mode=", mode, "&name=", name, "&description=", description);
		}

        
		public virtual IAsyncResult CreateList(CreateListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var list_owner = options.ListOwner;
			var name = options.Name;
			var mode = options.Mode;
			var description = options.Description;
				

			return  WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", list_owner, "&name=", name, "&mode=", mode, "&description=", description);
		}

        
		public virtual IAsyncResult GetList(GetListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return  WithHammock<TwitterList>(_client, action, "lists/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult ListSubscriptions(ListSubscriptionsOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				

			return  WithHammock<TwitterCursorList<TwitterList>>(_client, action, "lists/subscriptions", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual IAsyncResult ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse>  action)
		{
				

			return  WithHammock<IEnumerable<TwitterSavedSearch>>(_client, action, "saved_searches/list", FormatAsString);
		}

        
		public virtual IAsyncResult GetSavedSearch(GetSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action)
		{
			var id = options.Id;
				

			return  WithHammock<TwitterSavedSearch>(_client, action, "saved_searches/show/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual IAsyncResult CreateSavedSearch(CreateSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action)
		{
			var query = options.Query;
				

			return  WithHammock<TwitterSavedSearch>(_client, WebMethod.Post, action, "saved_searches/create", FormatAsString, "?query=", query);
		}

        
		public virtual IAsyncResult DeleteSavedSearch(DeleteSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action)
		{
			var id = options.Id;
				

			return  WithHammock<TwitterSavedSearch>(_client, WebMethod.Post, action, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual IAsyncResult GetPlace(GetPlaceOptions options, Action<TwitterPlace, TwitterResponse>  action)
		{
			var place_id = options.PlaceId;
				

			return  WithHammock<TwitterPlace>(_client, action, "geo/id/{place_id}", FormatAsString, "?place_id=", place_id);
		}

        
		public virtual IAsyncResult ReverseGeocode(ReverseGeocodeOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var accuracy = options.Accuracy;
			var granularity = options.Granularity;
			var max_results = options.MaxResults;
			var callback = options.Callback;
				

			return  WithHammock<IEnumerable<TwitterPlace>>(_client, action, "geo/reverse_geocode", FormatAsString, "?lat=", lat, "&long=", @long, "&accuracy=", accuracy, "&granularity=", granularity, "&max_results=", max_results, "&callback=", callback);
		}

        
		public virtual IAsyncResult GeoSearch(GeoSearchOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var query = options.Query;
			var ip = options.Ip;
			var granularity = options.Granularity;
			var accuracy = options.Accuracy;
			var max_results = options.MaxResults;
			var contained_within = options.ContainedWithin;
			var callback = options.Callback;
				

			return  WithHammock<IEnumerable<TwitterPlace>>(_client, action, "geo/search", FormatAsString, "?lat=", lat, "&long=", @long, "&query=", query, "&ip=", ip, "&granularity=", granularity, "&accuracy=", accuracy, "&max_results=", max_results, "&contained_within=", contained_within, "&callback=", callback);
		}

        
		public virtual IAsyncResult ListLocalTrendsFor(ListLocalTrendsForOptions options, Action<TwitterTrends, TwitterResponse>  action)
		{
			var id = options.Id;
			var exclude = options.Exclude;
				

			return  WithHammock<TwitterTrends>(_client, action, "trends/place", FormatAsString, "?id=", id, "&exclude=", exclude);
		}

        
		public virtual IAsyncResult ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action)
		{
				

			return  WithHammock<IEnumerable<WhereOnEarthLocation>>(_client, action, "trends/available", FormatAsString);
		}

        
		public virtual IAsyncResult ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action)
		{
			var lat = options.Lat;
			var @long = options.@Long;
				

			return  WithHammock<IEnumerable<WhereOnEarthLocation>>(_client, action, "trends/closest", FormatAsString, "?lat=", lat, "&long=", @long);
		}

        
		public virtual IAsyncResult GetRateLimitStatus(GetRateLimitStatusOptions options, Action<TwitterRateLimitStatusSummary, TwitterResponse>  action)
		{
			var resources = options.Resources;
				

			return  WithHammock<TwitterRateLimitStatusSummary>(_client, action, "application/rate_limit_status", FormatAsString, "?resources=", resources);
		}

        
		public virtual IAsyncResult ReportSpam(ReportSpamOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return  WithHammock<TwitterUser>(_client, WebMethod.Post, action, "users/report_spam", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with Begin/End pattern)
        
		public virtual IAsyncResult BeginGetConfiguration()
		{
				

			return BeginWithHammock<TwitterConfiguration>(_client, WebMethod.Get, "help/configuration", FormatAsString);
		}

        
		public virtual IAsyncResult BeginListTweetsMentioningMe(ListTweetsMentioningMeOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "statuses/mentions_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var since_id = options.SinceId;
			var count = options.Count;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_rts = options.IncludeRts;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&since_id=", since_id, "&count=", count, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_rts=", include_rts);
		}

        
		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "statuses/home_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var include_entities = options.IncludeEntities;
			var include_user_entities = options.IncludeUserEntities;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&include_entities=", include_entities, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IAsyncResult BeginRetweets(RetweetsOptions options)
		{
			var id = options.Id;
			var count = options.Count;
			var trim_user = options.TrimUser;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count, "&trim_user=", trim_user);
		}

        
		public virtual IAsyncResult BeginGetTweet(GetTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			var include_my_retweet = options.IncludeMyRetweet;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Get, "statuses/show/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user, "&include_my_retweet=", include_my_retweet, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginDeleteTweet(DeleteTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/destroy/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        
		public virtual IAsyncResult BeginSendTweet(SendTweetOptions options)
		{
			var status = options.Status;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			var trim_user = options.TrimUser;
			var media_ids = options.MediaIds;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates, "&trim_user=", trim_user, "&media_ids=", media_ids);
		}

        
		public virtual IAsyncResult BeginRetweet(RetweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual IAsyncResult BeginSendTweetWithMedia(SendTweetWithMediaOptions options)
		{
			var status = options.Status;
			var possibly_sensitive = options.PossiblySensitive;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			 var images = options.Images;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Post, "statuses/update_with_media", images, FormatAsString, "?status=", status, "&possibly_sensitive=", possibly_sensitive, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates);
		}

        
		public virtual IAsyncResult BeginUploadMedia(UploadMediaOptions options)
		{
			 var media = options.Media;
				

			return BeginWithHammock<TwitterUploadedMedia>(_uploadMediaClient, WebMethod.Post, "media/upload", media, FormatAsString);
		}

        
		public virtual IAsyncResult BeginUploadMediaInit(UploadMediaInitOptions options)
		{
			var media_type = options.MediaType;
			var media_category = options.MediaCategory;
			var total_bytes = options.TotalBytes;
				

			return BeginWithHammock<TwitterChunkedMedia>(_uploadMediaClient, WebMethod.Post, "media/upload", FormatAsString, "?command=", "INIT", "&media_type=", media_type, "&media_category=", media_category, "&total_bytes=", total_bytes);
		}

        
		public virtual IAsyncResult BeginUploadMediaAppend(UploadMediaAppendOptions options)
		{
			var media_id = options.MediaId;
			var segment_index = options.SegmentIndex;
			 var media = options.Media;
				

			return  BeginWithHammockNoResponse(_uploadMediaClient, WebMethod.Post, "media/upload", media, FormatAsString, "?command=", "APPEND", "&media_id=", media_id, "&segment_index=", segment_index);
		}

        
		public virtual IAsyncResult BeginUploadMediaFinalize(UploadMediaFinalizeOptions options)
		{
			var media_id = options.MediaId;
				

			return BeginWithHammock<UploadMediaResult>(_uploadMediaClient, WebMethod.Post, "media/upload", FormatAsString, "?command=", "FINALIZE", "&media_id=", media_id);
		}

        
		public virtual IAsyncResult BeginUploadMediaCheckStatus(UploadMediaCheckStatusOptions options)
		{
			var media_id = options.MediaId;
				

			return BeginWithHammock<UploadMediaResult>(_uploadMediaClient, WebMethod.Get, "media/upload", FormatAsString, "?command=", "STATUS", "&media_id=", media_id);
		}

        
		public virtual IAsyncResult BeginSearch(SearchOptions options)
		{
			var q = options.Q;
			var geocode = options.Geocode;
			var lang = options.Lang;
			var locale = options.Locale;
			var resultType = options.Resulttype;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			var callback = options.Callback;
			var until = options.Until;
				

			return BeginWithHammock<TwitterSearchResult>(_client, WebMethod.Get, "search/tweets", FormatAsString, "?q=", q, "&geocode=", geocode, "&lang=", lang, "&locale=", locale, "&result_type=", resultType, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities, "&callback=", callback, "&until=", until);
		}

        
		public virtual IAsyncResult BeginListDirectMessagesReceived(ListDirectMessagesReceivedOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var full_text = options.FullText;
				

			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(_client, WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&skip_status=", skip_status, "&full_text=", full_text);
		}

        
		public virtual IAsyncResult BeginListDirectMessagesSent(ListDirectMessagesSentOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var page = options.Page;
			var include_entities = options.IncludeEntities;
			var full_text = options.FullText;
				

			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(_client, WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&page=", page, "&include_entities=", include_entities, "&full_text=", full_text);
		}

        
		public virtual IAsyncResult BeginGetDirectMessage(GetDirectMessageOptions options)
		{
			var id = options.Id;
			var full_text = options.FullText;
				

			return BeginWithHammock<TwitterDirectMessage>(_client, WebMethod.Get, "direct_messages/show", FormatAsString, "?id=", id, "&full_text=", full_text);
		}

        
		public virtual IAsyncResult BeginDeleteDirectMessage(DeleteDirectMessageOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<TwitterDirectMessage>(_client, WebMethod.Post, "direct_messages/destroy", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginSendDirectMessage(SendDirectMessageOptions options)
		{
			var text = options.Text;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return BeginWithHammock<TwitterDirectMessage>(_client, WebMethod.Post, "direct_messages/new", FormatAsString, "?text=", text, "&user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult BeginListFriendIdsOf(ListFriendIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "friends/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual IAsyncResult BeginListFollowerIdsOf(ListFollowerIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "followers/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual IAsyncResult BeginListFriendshipsFor(ListFriendshipsForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return BeginWithHammock<IEnumerable<TwitterFriendshipLookup>>(_client, WebMethod.Get, "friendships/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual IAsyncResult BeginGetIncomingFriendRequests(GetIncomingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginGetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginFollowUser(FollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var follow = options.Follow;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&follow=", follow);
		}

        
		public virtual IAsyncResult BeginUnfollowUser(UnfollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "friendships/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual IAsyncResult BeginUpdateFriendship(UpdateFriendshipOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var device = options.Device;
			var retweets = options.Retweets;
				

			return BeginWithHammock<TwitterFriendship>(_client, WebMethod.Post, "friendships/update", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&device=", device, "&retweets=", retweets);
		}

        
		public virtual IAsyncResult BeginGetFriendshipInfo(GetFriendshipInfoOptions options)
		{
			var source_id = options.SourceId;
			var source_screen_name = options.SourceScreenName;
			var target_id = options.TargetId;
			var target_screen_name = options.TargetScreenName;
				

			return BeginWithHammock<TwitterFriendship>(_client, WebMethod.Get, "friendships/show", FormatAsString, "?source_id=", source_id, "&source_screen_name=", source_screen_name, "&target_id=", target_id, "&target_screen_name=", target_screen_name);
		}

        
		public virtual IAsyncResult BeginListFriends(ListFriendsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				

			return BeginWithHammock<TwitterCursorList<TwitterUser>>(_client, WebMethod.Get, "friends/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IAsyncResult BeginListFollowers(ListFollowersOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				

			return BeginWithHammock<TwitterCursorList<TwitterUser>>(_client, WebMethod.Get, "followers/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual IAsyncResult BeginGetAccountSettings()
		{
				

			return BeginWithHammock<TwitterAccount>(_client, WebMethod.Get, "account/settings", FormatAsString);
		}

        
		public virtual IAsyncResult BeginGetUserProfile(GetUserProfileOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Get, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual IAsyncResult BeginVerifyCredentials(VerifyCredentialsOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Get, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsOptions options)
		{
			var trend_location_woeid = options.TrendLocationWoeid;
			var sleep_time_enabled = options.SleepTimeEnabled;
			var start_sleep_time = options.StartSleepTime;
			var end_sleep_time = options.EndSleepTime;
			var time_zone = options.TimeZone;
			var lang = options.Lang;
				

			return BeginWithHammock<TwitterAccount>(_client, WebMethod.Post, "account/settings", FormatAsString, "?trend_location_woeid=", trend_location_woeid, "&sleep_time_enabled=", sleep_time_enabled, "&start_sleep_time=", start_sleep_time, "&end_sleep_time=", end_sleep_time, "&time_zone=", time_zone, "&lang=", lang);
		}

        
		public virtual IAsyncResult BeginUpdateDeliveryDevice(UpdateDeliveryDeviceOptions options)
		{
			var device = options.Device;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Get, "account/update_delivery_device", FormatAsString, "?device=", device, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginUpdateProfile(UpdateProfileOptions options)
		{
			var name = options.Name;
			var url = options.Url;
			var location = options.Location;
			var description = options.Description;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&url=", url, "&location=", location, "&description=", description, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginUpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options)
		{
			var imagePath = options.Imagepath;
			var tile = options.Tile;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var use = options.Use;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?image_path=", imagePath, "&tile=", tile, "&include_entities=", include_entities, "&skip_status=", skip_status, "&use=", use);
		}

        
		public virtual IAsyncResult BeginUpdateProfileColors(UpdateProfileColorsOptions options)
		{
			var profile_background_color = options.ProfileBackgroundColor;
			var profile_link_color = options.ProfileLinkColor;
			var profile_sidebar_border_color = options.ProfileSidebarBorderColor;
			var profile_sidebar_fill_color = options.ProfileSidebarFillColor;
			var profile_text_color = options.ProfileTextColor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile_colors", FormatAsString, "?profile_background_color=", profile_background_color, "&profile_link_color=", profile_link_color, "&profile_sidebar_border_color=", profile_sidebar_border_color, "&profile_sidebar_fill_color=", profile_sidebar_fill_color, "&profile_text_color=", profile_text_color, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginUpdateProfileImage(UpdateProfileImageOptions options)
		{
			var image_path = options.ImagePath;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "account/update_profile_image", FormatAsString, "?image_path=", image_path, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginListBlockedUsers(ListBlockedUsersOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<TwitterUser>>(_client, WebMethod.Get, "blocks/list", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginListBlockedUserIds(ListBlockedUserIdsOptions options)
		{
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "blocks/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginBlockUser(BlockUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginUnblockUser(UnblockUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "blocks/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginMuteUser(MuteUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "mutes/users/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult BeginUnmuteUser(UnmuteUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "mutes/users/destroy", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult BeginListMutedUserIds(ListMutedUserIdsOptions options)
		{
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "mutes/users/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginListMutedUsers(ListMutedUsersOptions options)
		{
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<long>>(_client, WebMethod.Get, "mutes/users/list", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginListUserProfilesFor(ListUserProfilesForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<IEnumerable<TwitterUser>>(_client, WebMethod.Get, "users/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginGetUserProfileFor(GetUserProfileForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Get, "users/show", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginSearchForUser(SearchForUserOptions options)
		{
			var q = options.Q;
			var page = options.Page;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<IEnumerable<TwitterUser>>(_client, WebMethod.Get, "users/search", FormatAsString, "?q=", q, "&page=", page, "&count=", count, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginGetProfileBannerFor(GetProfileBannerForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return BeginWithHammock<ProfileBanners>(_client, WebMethod.Get, "users/profile_banner", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual IAsyncResult BeginListSuggestedUsers(ListSuggestedUsersOptions options)
		{
			var slug = options.Slug;
			var lang = options.Lang;
				

			return BeginWithHammock<TwitterUserSuggestions>(_client, WebMethod.Get, "/users/suggestions/{slug}", FormatAsString, "?slug=", slug, "&lang=", lang);
		}

        
		public virtual IAsyncResult BeginListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options)
		{
			var lang = options.Lang;
				

			return BeginWithHammock<IEnumerable<TwitterUserSuggestions>>(_client, WebMethod.Get, "users/suggestions", FormatAsString, "?lang=", lang);
		}

        
		public virtual IAsyncResult BeginGetSuggestedUserMembers(GetSuggestedUserMembersOptions options)
		{
			var slug = options.Slug;
				

			return BeginWithHammock<IEnumerable<TwitterUser>>(_client, WebMethod.Get, "/users/suggestions/{slug}/members", FormatAsString, "?slug=", slug);
		}

        
		public virtual IAsyncResult BeginListFavoriteTweets(ListFavoriteTweetsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "favorites/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginUnfavoriteTweet(UnfavoriteTweetOptions options)
		{
			var id = options.Id;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Post, "favorites/destroy", FormatAsString, "?id=", id);
		}

        
		public virtual IAsyncResult BeginFavoriteTweet(FavoriteTweetOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				

			return BeginWithHammock<TwitterStatus>(_client, WebMethod.Post, "favorites/create", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual IAsyncResult BeginListListsFor(ListListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				

			return BeginWithHammock<IEnumerable<TwitterList>>(_client, WebMethod.Get, "lists/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual IAsyncResult BeginListOwnedListsFor(ListOwnedListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<TwitterList>>(_client, WebMethod.Get, "lists/ownerships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginListTweetsOnList(ListTweetsOnListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var include_rts = options.IncludeRts;
				

			return BeginWithHammock<IEnumerable<TwitterStatus>>(_client, WebMethod.Get, "lists/statuses", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&include_rts=", include_rts);
		}

        
		public virtual IAsyncResult BeginRemoveListMember(RemoveListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult BeginListListMembershipsFor(ListListMembershipsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var filter_to_owned_lists = options.FilterToOwnedLists;
				

			return BeginWithHammock<TwitterCursorList<TwitterList>>(_client, WebMethod.Get, "lists/memberships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&filter_to_owned_lists=", filter_to_owned_lists);
		}

        
		public virtual IAsyncResult BeginListListSubscribers(ListListSubscribersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterCursorList<TwitterUser>>(_client, WebMethod.Get, "lists/subscribers", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginFollowList(FollowListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual IAsyncResult BeginVerifyListSubscription(VerifyListSubscriptionOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Get, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginUnfollowList(UnfollowListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult BeginAddListMembers(AddListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return BeginWithHammock<TwitterList>(_client, WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult BeginVerifyListMembership(VerifyListMembershipOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Get, "lists/members/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginListListMembers(ListListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var count = options.Count;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				

			return BeginWithHammock<TwitterCursorList<TwitterUser>>(_client, WebMethod.Get, "lists/members", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&count=", count, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual IAsyncResult BeginAddListMember(AddListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult BeginDeleteList(DeleteListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				

			return BeginWithHammock<TwitterList>(_client, WebMethod.Post, "lists/destroy", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual IAsyncResult BeginUpdateList(UpdateListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var mode = options.Mode;
			var name = options.Name;
			var description = options.Description;
				

			return BeginWithHammock<TwitterList>(_client, WebMethod.Post, "lists/update", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&mode=", mode, "&name=", name, "&description=", description);
		}

        
		public virtual IAsyncResult BeginCreateList(CreateListOptions options)
		{
			var list_owner = options.ListOwner;
			var name = options.Name;
			var mode = options.Mode;
			var description = options.Description;
				

			return BeginWithHammock<TwitterList>(_client, WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", list_owner, "&name=", name, "&mode=", mode, "&description=", description);
		}

        
		public virtual IAsyncResult BeginGetList(GetListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				

			return BeginWithHammock<TwitterList>(_client, WebMethod.Get, "lists/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual IAsyncResult BeginListSubscriptions(ListSubscriptionsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				

			return BeginWithHammock<TwitterCursorList<TwitterList>>(_client, WebMethod.Get, "lists/subscriptions", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual IAsyncResult BeginListSavedSearches()
		{
				

			return BeginWithHammock<IEnumerable<TwitterSavedSearch>>(_client, WebMethod.Get, "saved_searches/list", FormatAsString);
		}

        
		public virtual IAsyncResult BeginGetSavedSearch(GetSavedSearchOptions options)
		{
			var id = options.Id;
				

			return BeginWithHammock<TwitterSavedSearch>(_client, WebMethod.Get, "saved_searches/show/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual IAsyncResult BeginCreateSavedSearch(CreateSavedSearchOptions options)
		{
			var query = options.Query;
				

			return BeginWithHammock<TwitterSavedSearch>(_client, WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

        
		public virtual IAsyncResult BeginDeleteSavedSearch(DeleteSavedSearchOptions options)
		{
			var id = options.Id;
				

			return BeginWithHammock<TwitterSavedSearch>(_client, WebMethod.Post, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual IAsyncResult BeginGetPlace(GetPlaceOptions options)
		{
			var place_id = options.PlaceId;
				

			return BeginWithHammock<TwitterPlace>(_client, WebMethod.Get, "geo/id/{place_id}", FormatAsString, "?place_id=", place_id);
		}

        
		public virtual IAsyncResult BeginReverseGeocode(ReverseGeocodeOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var accuracy = options.Accuracy;
			var granularity = options.Granularity;
			var max_results = options.MaxResults;
			var callback = options.Callback;
				

			return BeginWithHammock<IEnumerable<TwitterPlace>>(_client, WebMethod.Get, "geo/reverse_geocode", FormatAsString, "?lat=", lat, "&long=", @long, "&accuracy=", accuracy, "&granularity=", granularity, "&max_results=", max_results, "&callback=", callback);
		}

        
		public virtual IAsyncResult BeginGeoSearch(GeoSearchOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var query = options.Query;
			var ip = options.Ip;
			var granularity = options.Granularity;
			var accuracy = options.Accuracy;
			var max_results = options.MaxResults;
			var contained_within = options.ContainedWithin;
			var callback = options.Callback;
				

			return BeginWithHammock<IEnumerable<TwitterPlace>>(_client, WebMethod.Get, "geo/search", FormatAsString, "?lat=", lat, "&long=", @long, "&query=", query, "&ip=", ip, "&granularity=", granularity, "&accuracy=", accuracy, "&max_results=", max_results, "&contained_within=", contained_within, "&callback=", callback);
		}

        
		public virtual IAsyncResult BeginListLocalTrendsFor(ListLocalTrendsForOptions options)
		{
			var id = options.Id;
			var exclude = options.Exclude;
				

			return BeginWithHammock<TwitterTrends>(_client, WebMethod.Get, "trends/place", FormatAsString, "?id=", id, "&exclude=", exclude);
		}

        
		public virtual IAsyncResult BeginListAvailableTrendsLocations()
		{
				

			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(_client, WebMethod.Get, "trends/available", FormatAsString);
		}

        
		public virtual IAsyncResult BeginListClosestTrendsLocations(ListClosestTrendsLocationsOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
				

			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(_client, WebMethod.Get, "trends/closest", FormatAsString, "?lat=", lat, "&long=", @long);
		}

        
		public virtual IAsyncResult BeginGetRateLimitStatus(GetRateLimitStatusOptions options)
		{
			var resources = options.Resources;
				

			return BeginWithHammock<TwitterRateLimitStatusSummary>(_client, WebMethod.Get, "application/rate_limit_status", FormatAsString, "?resources=", resources);
		}

        
		public virtual IAsyncResult BeginReportSpam(ReportSpamOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				

			return BeginWithHammock<TwitterUser>(_client, WebMethod.Post, "users/report_spam", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual TwitterConfiguration EndGetConfiguration(IAsyncResult result) 
		{
			return EndWithHammock<TwitterConfiguration>(result);
		}

		
		public virtual TwitterConfiguration EndGetConfiguration(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterConfiguration>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual TwitterStatus EndGetTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		
		public virtual TwitterStatus EndGetTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        
		public virtual TwitterStatus EndDeleteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		
		public virtual TwitterStatus EndDeleteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        
		public virtual TwitterStatus EndSendTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		
		public virtual TwitterStatus EndSendTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        
		public virtual TwitterStatus EndRetweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		
		public virtual TwitterStatus EndRetweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual TwitterStatus EndSendTweetWithMedia(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		[Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual TwitterStatus EndSendTweetWithMedia(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        
		public virtual TwitterUploadedMedia EndUploadMedia(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUploadedMedia>(result);
		}

		
		public virtual TwitterUploadedMedia EndUploadMedia(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUploadedMedia>(result, timeout);
		}

        
		public virtual TwitterChunkedMedia EndUploadMediaInit(IAsyncResult result) 
		{
			return EndWithHammock<TwitterChunkedMedia>(result);
		}

		
		public virtual TwitterChunkedMedia EndUploadMediaInit(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterChunkedMedia>(result, timeout);
		}

        
		public virtual void EndUploadMediaAppend(IAsyncResult result) 
		{
			 EndWithHammockNoResponse(result);
		}

		
		public virtual void EndUploadMediaAppend(IAsyncResult result, TimeSpan timeout) 
		{
			 EndWithHammockNoResponse(result, timeout);
		}

        
		public virtual UploadMediaResult EndUploadMediaFinalize(IAsyncResult result) 
		{
			return EndWithHammock<UploadMediaResult>(result);
		}

		
		public virtual UploadMediaResult EndUploadMediaFinalize(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<UploadMediaResult>(result, timeout);
		}

        
		public virtual UploadMediaResult EndUploadMediaCheckStatus(IAsyncResult result) 
		{
			return EndWithHammock<UploadMediaResult>(result);
		}

		
		public virtual UploadMediaResult EndUploadMediaCheckStatus(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<UploadMediaResult>(result, timeout);
		}

        
		public virtual TwitterSearchResult EndSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		
		public virtual TwitterSearchResult EndSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		
		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		
		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

        
		public virtual TwitterDirectMessage EndGetDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		
		public virtual TwitterDirectMessage EndGetDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

        
		public virtual TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		
		public virtual TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

        
		public virtual TwitterDirectMessage EndSendDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		
		public virtual TwitterDirectMessage EndSendDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndListFriendIdsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndListFriendIdsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndListFollowerIdsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndListFollowerIdsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterFriendshipLookup> EndListFriendshipsFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterFriendshipLookup>>(result);
		}

		
		public virtual IEnumerable<TwitterFriendshipLookup> EndListFriendshipsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterFriendshipLookup>>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndGetIncomingFriendRequests(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndGetIncomingFriendRequests(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndGetOutgoingFriendRequests(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndGetOutgoingFriendRequests(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual TwitterUser EndFollowUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndFollowUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUnfollowUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUnfollowUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterFriendship EndUpdateFriendship(IAsyncResult result) 
		{
			return EndWithHammock<TwitterFriendship>(result);
		}

		
		public virtual TwitterFriendship EndUpdateFriendship(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterFriendship>(result, timeout);
		}

        
		public virtual TwitterFriendship EndGetFriendshipInfo(IAsyncResult result) 
		{
			return EndWithHammock<TwitterFriendship>(result);
		}

		
		public virtual TwitterFriendship EndGetFriendshipInfo(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterFriendship>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		
		public virtual TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		
		public virtual TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

        
		public virtual TwitterAccount EndGetAccountSettings(IAsyncResult result) 
		{
			return EndWithHammock<TwitterAccount>(result);
		}

		
		public virtual TwitterAccount EndGetAccountSettings(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterAccount>(result, timeout);
		}

        
		public virtual TwitterUser EndGetUserProfile(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndGetUserProfile(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndVerifyCredentials(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndVerifyCredentials(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterAccount EndUpdateAccountSettings(IAsyncResult result) 
		{
			return EndWithHammock<TwitterAccount>(result);
		}

		
		public virtual TwitterAccount EndUpdateAccountSettings(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterAccount>(result, timeout);
		}

        
		public virtual TwitterUser EndUpdateDeliveryDevice(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUpdateDeliveryDevice(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUpdateProfile(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUpdateProfile(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUpdateProfileColors(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUpdateProfileColors(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUpdateProfileImage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUpdateProfileImage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterUser> EndListBlockedUsers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		
		public virtual TwitterCursorList<TwitterUser> EndListBlockedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndListBlockedUserIds(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndListBlockedUserIds(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual TwitterUser EndBlockUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndBlockUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUnblockUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUnblockUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndMuteUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndMuteUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUnmuteUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUnmuteUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndListMutedUserIds(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndListMutedUserIds(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual TwitterCursorList<long> EndListMutedUsers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result);
		}

		
		public virtual TwitterCursorList<long> EndListMutedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<long>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		
		public virtual IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

        
		public virtual TwitterUser EndGetUserProfileFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndGetUserProfileFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		
		public virtual IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

        
		public virtual ProfileBanners EndGetProfileBannerFor(IAsyncResult result) 
		{
			return EndWithHammock<ProfileBanners>(result);
		}

		
		public virtual ProfileBanners EndGetProfileBannerFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<ProfileBanners>(result, timeout);
		}

        
		public virtual TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUserSuggestions>(result);
		}

		
		public virtual TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUserSuggestions>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUserSuggestions>>(result);
		}

		
		public virtual IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUserSuggestions>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterUser> EndGetSuggestedUserMembers(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		
		public virtual IEnumerable<TwitterUser> EndGetSuggestedUserMembers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual TwitterStatus EndUnfavoriteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		
		public virtual TwitterStatus EndUnfavoriteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        
		public virtual TwitterStatus EndFavoriteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		
		public virtual TwitterStatus EndFavoriteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterList> EndListListsFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result);
		}

		
		public virtual IEnumerable<TwitterList> EndListListsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterList> EndListOwnedListsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		
		public virtual TwitterCursorList<TwitterList> EndListOwnedListsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		
		public virtual IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

        
		public virtual TwitterUser EndRemoveListMember(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndRemoveListMember(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		
		public virtual TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		
		public virtual TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

        
		public virtual TwitterUser EndFollowList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndFollowList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndVerifyListSubscription(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndVerifyListSubscription(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterUser EndUnfollowList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndUnfollowList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterList EndAddListMembers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		
		public virtual TwitterList EndAddListMembers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

        
		public virtual TwitterUser EndVerifyListMembership(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndVerifyListMembership(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		
		public virtual TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

        
		public virtual TwitterUser EndAddListMember(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndAddListMember(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

        
		public virtual TwitterList EndDeleteList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		
		public virtual TwitterList EndDeleteList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

        
		public virtual TwitterList EndUpdateList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		
		public virtual TwitterList EndUpdateList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

        
		public virtual TwitterList EndCreateList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		
		public virtual TwitterList EndCreateList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

        
		public virtual TwitterList EndGetList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		
		public virtual TwitterList EndGetList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

        
		public virtual TwitterCursorList<TwitterList> EndListSubscriptions(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		
		public virtual TwitterCursorList<TwitterList> EndListSubscriptions(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterSavedSearch>>(result);
		}

		
		public virtual IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterSavedSearch>>(result, timeout);
		}

        
		public virtual TwitterSavedSearch EndGetSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		
		public virtual TwitterSavedSearch EndGetSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

        
		public virtual TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		
		public virtual TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

        
		public virtual TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		
		public virtual TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

        
		public virtual TwitterPlace EndGetPlace(IAsyncResult result) 
		{
			return EndWithHammock<TwitterPlace>(result);
		}

		
		public virtual TwitterPlace EndGetPlace(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterPlace>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterPlace> EndReverseGeocode(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterPlace>>(result);
		}

		
		public virtual IEnumerable<TwitterPlace> EndReverseGeocode(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterPlace>>(result, timeout);
		}

        
		public virtual IEnumerable<TwitterPlace> EndGeoSearch(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterPlace>>(result);
		}

		
		public virtual IEnumerable<TwitterPlace> EndGeoSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterPlace>>(result, timeout);
		}

        
		public virtual TwitterTrends EndListLocalTrendsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterTrends>(result);
		}

		
		public virtual TwitterTrends EndListLocalTrendsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterTrends>(result, timeout);
		}

        
		public virtual IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result);
		}

		
		public virtual IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result, timeout);
		}

        
		public virtual IEnumerable<WhereOnEarthLocation> EndListClosestTrendsLocations(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result);
		}

		
		public virtual IEnumerable<WhereOnEarthLocation> EndListClosestTrendsLocations(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result, timeout);
		}

        
		public virtual TwitterRateLimitStatusSummary EndGetRateLimitStatus(IAsyncResult result) 
		{
			return EndWithHammock<TwitterRateLimitStatusSummary>(result);
		}

		
		public virtual TwitterRateLimitStatusSummary EndGetRateLimitStatus(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterRateLimitStatusSummary>(result, timeout);
		}

        
		public virtual TwitterUser EndReportSpam(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		
		public virtual TwitterUser EndReportSpam(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		#endregion
#endif

#if WINDOWS_PHONE
		#region Asynchronous Methods (without IAsyncResult)
        
		public virtual void GetConfiguration(Action<TwitterConfiguration, TwitterResponse>  action)
		{
			
			WithHammock<TwitterConfiguration>(_client, action, "help/configuration", FormatAsString);
		}

        
		public virtual void ListTweetsMentioningMe(ListTweetsMentioningMeOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/mentions_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual void ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var since_id = options.SinceId;
			var count = options.Count;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_rts = options.IncludeRts;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/user_timeline", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&since_id=", since_id, "&count=", count, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_rts=", include_rts);
		}

        
		public virtual void ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/home_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual void ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var include_entities = options.IncludeEntities;
			var include_user_entities = options.IncludeUserEntities;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/retweets_of_me", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&include_entities=", include_entities, "&include_user_entities=", include_user_entities);
		}

        
		public virtual void Retweets(RetweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var id = options.Id;
			var count = options.Count;
			var trim_user = options.TrimUser;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count, "&trim_user=", trim_user);
		}

        
		public virtual void GetTweet(GetTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			var include_my_retweet = options.IncludeMyRetweet;
			var include_entities = options.IncludeEntities;
			
			WithHammock<TwitterStatus>(_client, action, "statuses/show/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user, "&include_my_retweet=", include_my_retweet, "&include_entities=", include_entities);
		}

        
		public virtual void DeleteTweet(DeleteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			
			WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/destroy/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        
		public virtual void SendTweet(SendTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var status = options.Status;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			var trim_user = options.TrimUser;
			var media_ids = options.MediaIds;
			
			WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates, "&trim_user=", trim_user, "&media_ids=", media_ids);
		}

        
		public virtual void Retweet(RetweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			
			WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/retweet/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual void SendTweetWithMedia(SendTweetWithMediaOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var status = options.Status;
			var possibly_sensitive = options.PossiblySensitive;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			 var images = options.Images;
			
			WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "statuses/update_with_media", images, FormatAsString, "?status=", status, "&possibly_sensitive=", possibly_sensitive, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates);
		}

        
		public virtual void UploadMedia(UploadMediaOptions options, Action<TwitterUploadedMedia, TwitterResponse>  action)
		{
			 var media = options.Media;
			
			WithHammock<TwitterUploadedMedia>(_uploadMediaClient, WebMethod.Post, action, "media/upload", media, FormatAsString);
		}

        
		public virtual void UploadMediaInit(UploadMediaInitOptions options, Action<TwitterChunkedMedia, TwitterResponse>  action)
		{
			var media_type = options.MediaType;
			var media_category = options.MediaCategory;
			var total_bytes = options.TotalBytes;
			
			WithHammock<TwitterChunkedMedia>(_uploadMediaClient, WebMethod.Post, action, "media/upload", FormatAsString, "?command=", "INIT", "&media_type=", media_type, "&media_category=", media_category, "&total_bytes=", total_bytes);
		}

        
		public virtual void UploadMediaAppend(UploadMediaAppendOptions options, Action<TwitterResponse> action)
		{
			var media_id = options.MediaId;
			var segment_index = options.SegmentIndex;
			 var media = options.Media;
			
			 WithHammockNoResponse(_uploadMediaClient, WebMethod.Post, action, "media/upload", media, FormatAsString, "?command=", "APPEND", "&media_id=", media_id, "&segment_index=", segment_index);
		}

        
		public virtual void UploadMediaFinalize(UploadMediaFinalizeOptions options, Action<UploadMediaResult, TwitterResponse>  action)
		{
			var media_id = options.MediaId;
			
			WithHammock<UploadMediaResult>(_uploadMediaClient, WebMethod.Post, action, "media/upload", FormatAsString, "?command=", "FINALIZE", "&media_id=", media_id);
		}

        
		public virtual void UploadMediaCheckStatus(UploadMediaCheckStatusOptions options, Action<UploadMediaResult, TwitterResponse>  action)
		{
			var media_id = options.MediaId;
			
			WithHammock<UploadMediaResult>(_uploadMediaClient, action, "media/upload", FormatAsString, "?command=", "STATUS", "&media_id=", media_id);
		}

        
		public virtual void Search(SearchOptions options, Action<TwitterSearchResult, TwitterResponse>  action)
		{
			var q = options.Q;
			var geocode = options.Geocode;
			var lang = options.Lang;
			var locale = options.Locale;
			var resultType = options.Resulttype;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			var callback = options.Callback;
			var until = options.Until;
			
			WithHammock<TwitterSearchResult>(_client, action, "search/tweets", FormatAsString, "?q=", q, "&geocode=", geocode, "&lang=", lang, "&locale=", locale, "&result_type=", resultType, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities, "&callback=", callback, "&until=", until);
		}

        
		public virtual void ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var full_text = options.FullText;
			
			WithHammock<IEnumerable<TwitterDirectMessage>>(_client, action, "direct_messages", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&skip_status=", skip_status, "&full_text=", full_text);
		}

        
		public virtual void ListDirectMessagesSent(ListDirectMessagesSentOptions options, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse>  action)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var page = options.Page;
			var include_entities = options.IncludeEntities;
			var full_text = options.FullText;
			
			WithHammock<IEnumerable<TwitterDirectMessage>>(_client, action, "direct_messages/sent", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&page=", page, "&include_entities=", include_entities, "&full_text=", full_text);
		}

        
		public virtual void GetDirectMessage(GetDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action)
		{
			var id = options.Id;
			var full_text = options.FullText;
			
			WithHammock<TwitterDirectMessage>(_client, action, "direct_messages/show", FormatAsString, "?id=", id, "&full_text=", full_text);
		}

        
		public virtual void DeleteDirectMessage(DeleteDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
			
			WithHammock<TwitterDirectMessage>(_client, WebMethod.Post, action, "direct_messages/destroy", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual void SendDirectMessage(SendDirectMessageOptions options, Action<TwitterDirectMessage, TwitterResponse>  action)
		{
			var text = options.Text;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			WithHammock<TwitterDirectMessage>(_client, WebMethod.Post, action, "direct_messages/new", FormatAsString, "?text=", text, "&user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual void ListFriendIdsOf(ListFriendIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "friends/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual void ListFollowerIdsOf(ListFollowerIdsOfOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "followers/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual void ListFriendshipsFor(ListFriendshipsForOptions options, Action<IEnumerable<TwitterFriendshipLookup>, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			WithHammock<IEnumerable<TwitterFriendshipLookup>>(_client, action, "friendships/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual void GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual void GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual void FollowUser(FollowUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var follow = options.Follow;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "friendships/create", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&follow=", follow);
		}

        
		public virtual void UnfollowUser(UnfollowUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "friendships/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual void UpdateFriendship(UpdateFriendshipOptions options, Action<TwitterFriendship, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var device = options.Device;
			var retweets = options.Retweets;
			
			WithHammock<TwitterFriendship>(_client, WebMethod.Post, action, "friendships/update", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&device=", device, "&retweets=", retweets);
		}

        
		public virtual void GetFriendshipInfo(GetFriendshipInfoOptions options, Action<TwitterFriendship, TwitterResponse>  action)
		{
			var source_id = options.SourceId;
			var source_screen_name = options.SourceScreenName;
			var target_id = options.TargetId;
			var target_screen_name = options.TargetScreenName;
			
			WithHammock<TwitterFriendship>(_client, action, "friendships/show", FormatAsString, "?source_id=", source_id, "&source_screen_name=", source_screen_name, "&target_id=", target_id, "&target_screen_name=", target_screen_name);
		}

        
		public virtual void ListFriends(ListFriendsOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
			
			WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "friends/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual void ListFollowers(ListFollowersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
			
			WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "followers/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual void GetAccountSettings(Action<TwitterAccount, TwitterResponse>  action)
		{
			
			WithHammock<TwitterAccount>(_client, action, "account/settings", FormatAsString);
		}

        
		public virtual void GetUserProfile(GetUserProfileOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
			
			WithHammock<TwitterUser>(_client, action, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual void VerifyCredentials(VerifyCredentialsOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
			
			WithHammock<TwitterUser>(_client, action, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}

        
		public virtual void UpdateAccountSettings(UpdateAccountSettingsOptions options, Action<TwitterAccount, TwitterResponse>  action)
		{
			var trend_location_woeid = options.TrendLocationWoeid;
			var sleep_time_enabled = options.SleepTimeEnabled;
			var start_sleep_time = options.StartSleepTime;
			var end_sleep_time = options.EndSleepTime;
			var time_zone = options.TimeZone;
			var lang = options.Lang;
			
			WithHammock<TwitterAccount>(_client, WebMethod.Post, action, "account/settings", FormatAsString, "?trend_location_woeid=", trend_location_woeid, "&sleep_time_enabled=", sleep_time_enabled, "&start_sleep_time=", start_sleep_time, "&end_sleep_time=", end_sleep_time, "&time_zone=", time_zone, "&lang=", lang);
		}

        
		public virtual void UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var device = options.Device;
			var include_entities = options.IncludeEntities;
			
			WithHammock<TwitterUser>(_client, action, "account/update_delivery_device", FormatAsString, "?device=", device, "&include_entities=", include_entities);
		}

        
		public virtual void UpdateProfile(UpdateProfileOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var name = options.Name;
			var url = options.Url;
			var location = options.Location;
			var description = options.Description;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile", FormatAsString, "?name=", name, "&url=", url, "&location=", location, "&description=", description, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var imagePath = options.Imagepath;
			var tile = options.Tile;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var use = options.Use;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile_background_image", FormatAsString, "?image_path=", imagePath, "&tile=", tile, "&include_entities=", include_entities, "&skip_status=", skip_status, "&use=", use);
		}

        
		public virtual void UpdateProfileColors(UpdateProfileColorsOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var profile_background_color = options.ProfileBackgroundColor;
			var profile_link_color = options.ProfileLinkColor;
			var profile_sidebar_border_color = options.ProfileSidebarBorderColor;
			var profile_sidebar_fill_color = options.ProfileSidebarFillColor;
			var profile_text_color = options.ProfileTextColor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?profile_background_color=", profile_background_color, "&profile_link_color=", profile_link_color, "&profile_sidebar_border_color=", profile_sidebar_border_color, "&profile_sidebar_fill_color=", profile_sidebar_fill_color, "&profile_text_color=", profile_text_color, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void UpdateProfileImage(UpdateProfileImageOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var image_path = options.ImagePath;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "account/update_profile_image", FormatAsString, "?image_path=", image_path, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void ListBlockedUsers(ListBlockedUsersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "blocks/list", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&cursor=", cursor);
		}

        
		public virtual void ListBlockedUserIds(ListBlockedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "blocks/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual void BlockUser(BlockUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "blocks/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void UnblockUser(UnblockUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "blocks/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void MuteUser(MuteUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "mutes/users/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual void UnmuteUser(UnmuteUserOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "mutes/users/destroy", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual void ListMutedUserIds(ListMutedUserIdsOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "mutes/users/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual void ListMutedUsers(ListMutedUsersOptions options, Action<TwitterCursorList<long>, TwitterResponse>  action)
		{
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<long>>(_client, action, "mutes/users/list", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual void ListUserProfilesFor(ListUserProfilesForOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			
			WithHammock<IEnumerable<TwitterUser>>(_client, action, "users/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities);
		}

        
		public virtual void GetUserProfileFor(GetUserProfileForOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			
			WithHammock<TwitterUser>(_client, action, "users/show", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities);
		}

        
		public virtual void SearchForUser(SearchForUserOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action)
		{
			var q = options.Q;
			var page = options.Page;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			
			WithHammock<IEnumerable<TwitterUser>>(_client, action, "users/search", FormatAsString, "?q=", q, "&page=", page, "&count=", count, "&include_entities=", include_entities);
		}

        
		public virtual void GetProfileBannerFor(GetProfileBannerForOptions options, Action<ProfileBanners, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			WithHammock<ProfileBanners>(_client, action, "users/profile_banner", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual void ListSuggestedUsers(ListSuggestedUsersOptions options, Action<TwitterUserSuggestions, TwitterResponse>  action)
		{
			var slug = options.Slug;
			var lang = options.Lang;
			
			WithHammock<TwitterUserSuggestions>(_client, action, "/users/suggestions/{slug}", FormatAsString, "?slug=", slug, "&lang=", lang);
		}

        
		public virtual void ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options, Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse>  action)
		{
			var lang = options.Lang;
			
			WithHammock<IEnumerable<TwitterUserSuggestions>>(_client, action, "users/suggestions", FormatAsString, "?lang=", lang);
		}

        
		public virtual void GetSuggestedUserMembers(GetSuggestedUserMembersOptions options, Action<IEnumerable<TwitterUser>, TwitterResponse>  action)
		{
			var slug = options.Slug;
			
			WithHammock<IEnumerable<TwitterUser>>(_client, action, "/users/suggestions/{slug}/members", FormatAsString, "?slug=", slug);
		}

        
		public virtual void ListFavoriteTweets(ListFavoriteTweetsOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "favorites/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities);
		}

        
		public virtual void UnfavoriteTweet(UnfavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			
			WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "favorites/destroy", FormatAsString, "?id=", id);
		}

        
		public virtual void FavoriteTweet(FavoriteTweetOptions options, Action<TwitterStatus, TwitterResponse>  action)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
			
			WithHammock<TwitterStatus>(_client, WebMethod.Post, action, "favorites/create", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual void ListListsFor(ListListsForOptions options, Action<IEnumerable<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			WithHammock<IEnumerable<TwitterList>>(_client, action, "lists/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual void ListOwnedListsFor(ListOwnedListsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<TwitterList>>(_client, action, "lists/ownerships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual void ListTweetsOnList(ListTweetsOnListOptions options, Action<IEnumerable<TwitterStatus>, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var include_rts = options.IncludeRts;
			
			WithHammock<IEnumerable<TwitterStatus>>(_client, action, "lists/statuses", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&include_rts=", include_rts);
		}

        
		public virtual void RemoveListMember(RemoveListMemberOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual void ListListMembershipsFor(ListListMembershipsForOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var filter_to_owned_lists = options.FilterToOwnedLists;
			
			WithHammock<TwitterCursorList<TwitterList>>(_client, action, "lists/memberships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&filter_to_owned_lists=", filter_to_owned_lists);
		}

        
		public virtual void ListListSubscribers(ListListSubscribersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "lists/subscribers", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void FollowList(FollowListOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual void VerifyListSubscription(VerifyListSubscriptionOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, action, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void UnfollowList(UnfollowListOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/subscribers/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual void AddListMembers(AddListMembersOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/members/create_all", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual void VerifyListMembership(VerifyListMembershipOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterUser>(_client, action, "lists/members/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void ListListMembers(ListListMembersOptions options, Action<TwitterCursorList<TwitterUser>, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var count = options.Count;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			WithHammock<TwitterCursorList<TwitterUser>>(_client, action, "lists/members", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&count=", count, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual void AddListMember(AddListMemberOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "lists/members/create", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual void DeleteList(DeleteListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			
			WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/destroy", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual void UpdateList(UpdateListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var mode = options.Mode;
			var name = options.Name;
			var description = options.Description;
			
			WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/update", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&mode=", mode, "&name=", name, "&description=", description);
		}

        
		public virtual void CreateList(CreateListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var list_owner = options.ListOwner;
			var name = options.Name;
			var mode = options.Mode;
			var description = options.Description;
			
			WithHammock<TwitterList>(_client, WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", list_owner, "&name=", name, "&mode=", mode, "&description=", description);
		}

        
		public virtual void GetList(GetListOptions options, Action<TwitterList, TwitterResponse>  action)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			WithHammock<TwitterList>(_client, action, "lists/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual void ListSubscriptions(ListSubscriptionsOptions options, Action<TwitterCursorList<TwitterList>, TwitterResponse>  action)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			
			WithHammock<TwitterCursorList<TwitterList>>(_client, action, "lists/subscriptions", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual void ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse>  action)
		{
			
			WithHammock<IEnumerable<TwitterSavedSearch>>(_client, action, "saved_searches/list", FormatAsString);
		}

        
		public virtual void GetSavedSearch(GetSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action)
		{
			var id = options.Id;
			
			WithHammock<TwitterSavedSearch>(_client, action, "saved_searches/show/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual void CreateSavedSearch(CreateSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action)
		{
			var query = options.Query;
			
			WithHammock<TwitterSavedSearch>(_client, WebMethod.Post, action, "saved_searches/create", FormatAsString, "?query=", query);
		}

        
		public virtual void DeleteSavedSearch(DeleteSavedSearchOptions options, Action<TwitterSavedSearch, TwitterResponse>  action)
		{
			var id = options.Id;
			
			WithHammock<TwitterSavedSearch>(_client, WebMethod.Post, action, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual void GetPlace(GetPlaceOptions options, Action<TwitterPlace, TwitterResponse>  action)
		{
			var place_id = options.PlaceId;
			
			WithHammock<TwitterPlace>(_client, action, "geo/id/{place_id}", FormatAsString, "?place_id=", place_id);
		}

        
		public virtual void ReverseGeocode(ReverseGeocodeOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var accuracy = options.Accuracy;
			var granularity = options.Granularity;
			var max_results = options.MaxResults;
			var callback = options.Callback;
			
			WithHammock<IEnumerable<TwitterPlace>>(_client, action, "geo/reverse_geocode", FormatAsString, "?lat=", lat, "&long=", @long, "&accuracy=", accuracy, "&granularity=", granularity, "&max_results=", max_results, "&callback=", callback);
		}

        
		public virtual void GeoSearch(GeoSearchOptions options, Action<IEnumerable<TwitterPlace>, TwitterResponse>  action)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var query = options.Query;
			var ip = options.Ip;
			var granularity = options.Granularity;
			var accuracy = options.Accuracy;
			var max_results = options.MaxResults;
			var contained_within = options.ContainedWithin;
			var callback = options.Callback;
			
			WithHammock<IEnumerable<TwitterPlace>>(_client, action, "geo/search", FormatAsString, "?lat=", lat, "&long=", @long, "&query=", query, "&ip=", ip, "&granularity=", granularity, "&accuracy=", accuracy, "&max_results=", max_results, "&contained_within=", contained_within, "&callback=", callback);
		}

        
		public virtual void ListLocalTrendsFor(ListLocalTrendsForOptions options, Action<TwitterTrends, TwitterResponse>  action)
		{
			var id = options.Id;
			var exclude = options.Exclude;
			
			WithHammock<TwitterTrends>(_client, action, "trends/place", FormatAsString, "?id=", id, "&exclude=", exclude);
		}

        
		public virtual void ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action)
		{
			
			WithHammock<IEnumerable<WhereOnEarthLocation>>(_client, action, "trends/available", FormatAsString);
		}

        
		public virtual void ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse>  action)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			
			WithHammock<IEnumerable<WhereOnEarthLocation>>(_client, action, "trends/closest", FormatAsString, "?lat=", lat, "&long=", @long);
		}

        
		public virtual void GetRateLimitStatus(GetRateLimitStatusOptions options, Action<TwitterRateLimitStatusSummary, TwitterResponse>  action)
		{
			var resources = options.Resources;
			
			WithHammock<TwitterRateLimitStatusSummary>(_client, action, "application/rate_limit_status", FormatAsString, "?resources=", resources);
		}

        
		public virtual void ReportSpam(ReportSpamOptions options, Action<TwitterUser, TwitterResponse>  action)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			WithHammock<TwitterUser>(_client, WebMethod.Post, action, "users/report_spam", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

		#endregion
#endif	

#if PLATFORM_SUPPORTS_ASYNC_AWAIT
		#region Task Based Async/Await Methods 
        
		public virtual  Task<TwitterAsyncResult<TwitterConfiguration>> GetConfigurationAsync()
		{
			
			return WithHammockTask<TwitterConfiguration>(_client, "help/configuration", FormatAsString);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsMentioningMeAsync(ListTweetsMentioningMeOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "statuses/mentions_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsOnUserTimelineAsync(ListTweetsOnUserTimelineOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var since_id = options.SinceId;
			var count = options.Count;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_rts = options.IncludeRts;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "statuses/user_timeline", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&since_id=", since_id, "&count=", count, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_rts=", include_rts);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsOnHomeTimelineAsync(ListTweetsOnHomeTimelineOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "statuses/home_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListRetweetsOfMyTweetsAsync(ListRetweetsOfMyTweetsOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var include_entities = options.IncludeEntities;
			var include_user_entities = options.IncludeUserEntities;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "statuses/retweets_of_me", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&include_entities=", include_entities, "&include_user_entities=", include_user_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> RetweetsAsync(RetweetsOptions options)
		{
			var id = options.Id;
			var count = options.Count;
			var trim_user = options.TrimUser;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count, "&trim_user=", trim_user);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> GetTweetAsync(GetTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			var include_my_retweet = options.IncludeMyRetweet;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<TwitterStatus>(_client, "statuses/show/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user, "&include_my_retweet=", include_my_retweet, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> DeleteTweetAsync(DeleteTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			
			return WithHammockTask<TwitterStatus>(_client, WebMethod.Post, "statuses/destroy/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> SendTweetAsync(SendTweetOptions options)
		{
			var status = options.Status;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			var trim_user = options.TrimUser;
			var media_ids = options.MediaIds;
			
			return WithHammockTask<TwitterStatus>(_client, WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates, "&trim_user=", trim_user, "&media_ids=", media_ids);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> RetweetAsync(RetweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			
			return WithHammockTask<TwitterStatus>(_client, WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}
        [Obsolete("Twitter has declared this method obsolete; it may cease to function at any time. Check https://dev.twitter.com/docs/api#deprecated for alternatives.")]
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> SendTweetWithMediaAsync(SendTweetWithMediaOptions options)
		{
			var status = options.Status;
			var possibly_sensitive = options.PossiblySensitive;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			 var images = options.Images;
			
			return WithHammockTask<TwitterStatus>(_client, WebMethod.Post, "statuses/update_with_media", images, FormatAsString, "?status=", status, "&possibly_sensitive=", possibly_sensitive, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUploadedMedia>> UploadMediaAsync(UploadMediaOptions options)
		{
			 var media = options.Media;
			
			return WithHammockTask<TwitterUploadedMedia>(_uploadMediaClient, WebMethod.Post, "media/upload", media, FormatAsString);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterChunkedMedia>> UploadMediaInitAsync(UploadMediaInitOptions options)
		{
			var media_type = options.MediaType;
			var media_category = options.MediaCategory;
			var total_bytes = options.TotalBytes;
			
			return WithHammockTask<TwitterChunkedMedia>(_uploadMediaClient, WebMethod.Post, "media/upload", FormatAsString, "?command=", "INIT", "&media_type=", media_type, "&media_category=", media_category, "&total_bytes=", total_bytes);
		}
        
		public virtual  Task UploadMediaAppendAsync(UploadMediaAppendOptions options)
		{
			var media_id = options.MediaId;
			var segment_index = options.SegmentIndex;
			 var media = options.Media;
			
			return  WithHammockNoResponseTask(_uploadMediaClient, WebMethod.Post, "media/upload", media, FormatAsString, "?command=", "APPEND", "&media_id=", media_id, "&segment_index=", segment_index);
		}
        
		public virtual  Task<TwitterAsyncResult<UploadMediaResult>> UploadMediaFinalizeAsync(UploadMediaFinalizeOptions options)
		{
			var media_id = options.MediaId;
			
			return WithHammockTask<UploadMediaResult>(_uploadMediaClient, WebMethod.Post, "media/upload", FormatAsString, "?command=", "FINALIZE", "&media_id=", media_id);
		}
        
		public virtual  Task<TwitterAsyncResult<UploadMediaResult>> UploadMediaCheckStatusAsync(UploadMediaCheckStatusOptions options)
		{
			var media_id = options.MediaId;
			
			return WithHammockTask<UploadMediaResult>(_uploadMediaClient, "media/upload", FormatAsString, "?command=", "STATUS", "&media_id=", media_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterSearchResult>> SearchAsync(SearchOptions options)
		{
			var q = options.Q;
			var geocode = options.Geocode;
			var lang = options.Lang;
			var locale = options.Locale;
			var resultType = options.Resulttype;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			var callback = options.Callback;
			var until = options.Until;
			
			return WithHammockTask<TwitterSearchResult>(_client, "search/tweets", FormatAsString, "?q=", q, "&geocode=", geocode, "&lang=", lang, "&locale=", locale, "&result_type=", resultType, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities, "&callback=", callback, "&until=", until);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesReceivedAsync(ListDirectMessagesReceivedOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var full_text = options.FullText;
			
			return WithHammockTask<IEnumerable<TwitterDirectMessage>>(_client, "direct_messages", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&skip_status=", skip_status, "&full_text=", full_text);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesSentAsync(ListDirectMessagesSentOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var page = options.Page;
			var include_entities = options.IncludeEntities;
			var full_text = options.FullText;
			
			return WithHammockTask<IEnumerable<TwitterDirectMessage>>(_client, "direct_messages/sent", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&page=", page, "&include_entities=", include_entities, "&full_text=", full_text);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterDirectMessage>> GetDirectMessageAsync(GetDirectMessageOptions options)
		{
			var id = options.Id;
			var full_text = options.FullText;
			
			return WithHammockTask<TwitterDirectMessage>(_client, "direct_messages/show", FormatAsString, "?id=", id, "&full_text=", full_text);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterDirectMessage>> DeleteDirectMessageAsync(DeleteDirectMessageOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<TwitterDirectMessage>(_client, WebMethod.Post, "direct_messages/destroy", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterDirectMessage>> SendDirectMessageAsync(SendDirectMessageOptions options)
		{
			var text = options.Text;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			return WithHammockTask<TwitterDirectMessage>(_client, WebMethod.Post, "direct_messages/new", FormatAsString, "?text=", text, "&user_id=", user_id, "&screen_name=", screen_name);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> ListFriendIdsOfAsync(ListFriendIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "friends/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> ListFollowerIdsOfAsync(ListFollowerIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "followers/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterFriendshipLookup>>> ListFriendshipsForAsync(ListFriendshipsForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			return WithHammockTask<IEnumerable<TwitterFriendshipLookup>>(_client, "friendships/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> GetIncomingFriendRequestsAsync(GetIncomingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> GetOutgoingFriendRequestsAsync(GetOutgoingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> FollowUserAsync(FollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var follow = options.Follow;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&follow=", follow);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UnfollowUserAsync(UnfollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "friendships/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterFriendship>> UpdateFriendshipAsync(UpdateFriendshipOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var device = options.Device;
			var retweets = options.Retweets;
			
			return WithHammockTask<TwitterFriendship>(_client, WebMethod.Post, "friendships/update", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&device=", device, "&retweets=", retweets);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterFriendship>> GetFriendshipInfoAsync(GetFriendshipInfoOptions options)
		{
			var source_id = options.SourceId;
			var source_screen_name = options.SourceScreenName;
			var target_id = options.TargetId;
			var target_screen_name = options.TargetScreenName;
			
			return WithHammockTask<TwitterFriendship>(_client, "friendships/show", FormatAsString, "?source_id=", source_id, "&source_screen_name=", source_screen_name, "&target_id=", target_id, "&target_screen_name=", target_screen_name);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListFriendsAsync(ListFriendsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
			
			return WithHammockTask<TwitterCursorList<TwitterUser>>(_client, "friends/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListFollowersAsync(ListFollowersOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
			
			return WithHammockTask<TwitterCursorList<TwitterUser>>(_client, "followers/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterAccount>> GetAccountSettingsAsync()
		{
			
			return WithHammockTask<TwitterAccount>(_client, "account/settings", FormatAsString);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> GetUserProfileAsync(GetUserProfileOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
			
			return WithHammockTask<TwitterUser>(_client, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> VerifyCredentialsAsync(VerifyCredentialsOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var include_email = options.IncludeEmail;
			
			return WithHammockTask<TwitterUser>(_client, "account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&include_email=", include_email);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterAccount>> UpdateAccountSettingsAsync(UpdateAccountSettingsOptions options)
		{
			var trend_location_woeid = options.TrendLocationWoeid;
			var sleep_time_enabled = options.SleepTimeEnabled;
			var start_sleep_time = options.StartSleepTime;
			var end_sleep_time = options.EndSleepTime;
			var time_zone = options.TimeZone;
			var lang = options.Lang;
			
			return WithHammockTask<TwitterAccount>(_client, WebMethod.Post, "account/settings", FormatAsString, "?trend_location_woeid=", trend_location_woeid, "&sleep_time_enabled=", sleep_time_enabled, "&start_sleep_time=", start_sleep_time, "&end_sleep_time=", end_sleep_time, "&time_zone=", time_zone, "&lang=", lang);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UpdateDeliveryDeviceAsync(UpdateDeliveryDeviceOptions options)
		{
			var device = options.Device;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<TwitterUser>(_client, "account/update_delivery_device", FormatAsString, "?device=", device, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UpdateProfileAsync(UpdateProfileOptions options)
		{
			var name = options.Name;
			var url = options.Url;
			var location = options.Location;
			var description = options.Description;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&url=", url, "&location=", location, "&description=", description, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UpdateProfileBackgroundImageAsync(UpdateProfileBackgroundImageOptions options)
		{
			var imagePath = options.Imagepath;
			var tile = options.Tile;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var use = options.Use;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?image_path=", imagePath, "&tile=", tile, "&include_entities=", include_entities, "&skip_status=", skip_status, "&use=", use);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UpdateProfileColorsAsync(UpdateProfileColorsOptions options)
		{
			var profile_background_color = options.ProfileBackgroundColor;
			var profile_link_color = options.ProfileLinkColor;
			var profile_sidebar_border_color = options.ProfileSidebarBorderColor;
			var profile_sidebar_fill_color = options.ProfileSidebarFillColor;
			var profile_text_color = options.ProfileTextColor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "account/update_profile_colors", FormatAsString, "?profile_background_color=", profile_background_color, "&profile_link_color=", profile_link_color, "&profile_sidebar_border_color=", profile_sidebar_border_color, "&profile_sidebar_fill_color=", profile_sidebar_fill_color, "&profile_text_color=", profile_text_color, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UpdateProfileImageAsync(UpdateProfileImageOptions options)
		{
			var image_path = options.ImagePath;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "account/update_profile_image", FormatAsString, "?image_path=", image_path, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListBlockedUsersAsync(ListBlockedUsersOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<TwitterUser>>(_client, "blocks/list", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> ListBlockedUserIdsAsync(ListBlockedUserIdsOptions options)
		{
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "blocks/ids", FormatAsString, "?cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> BlockUserAsync(BlockUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UnblockUserAsync(UnblockUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "blocks/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> MuteUserAsync(MuteUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "mutes/users/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UnmuteUserAsync(UnmuteUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "mutes/users/destroy", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> ListMutedUserIdsAsync(ListMutedUserIdsOptions options)
		{
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "mutes/users/ids", FormatAsString, "?cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<long>>> ListMutedUsersAsync(ListMutedUsersOptions options)
		{
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<long>>(_client, "mutes/users/list", FormatAsString, "?cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterUser>>> ListUserProfilesForAsync(ListUserProfilesForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<IEnumerable<TwitterUser>>(_client, "users/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> GetUserProfileForAsync(GetUserProfileForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<TwitterUser>(_client, "users/show", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterUser>>> SearchForUserAsync(SearchForUserOptions options)
		{
			var q = options.Q;
			var page = options.Page;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<IEnumerable<TwitterUser>>(_client, "users/search", FormatAsString, "?q=", q, "&page=", page, "&count=", count, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<ProfileBanners>> GetProfileBannerForAsync(GetProfileBannerForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			return WithHammockTask<ProfileBanners>(_client, "users/profile_banner", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUserSuggestions>> ListSuggestedUsersAsync(ListSuggestedUsersOptions options)
		{
			var slug = options.Slug;
			var lang = options.Lang;
			
			return WithHammockTask<TwitterUserSuggestions>(_client, "/users/suggestions/{slug}", FormatAsString, "?slug=", slug, "&lang=", lang);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterUserSuggestions>>> ListSuggestedUserCategoriesAsync(ListSuggestedUserCategoriesOptions options)
		{
			var lang = options.Lang;
			
			return WithHammockTask<IEnumerable<TwitterUserSuggestions>>(_client, "users/suggestions", FormatAsString, "?lang=", lang);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterUser>>> GetSuggestedUserMembersAsync(GetSuggestedUserMembersOptions options)
		{
			var slug = options.Slug;
			
			return WithHammockTask<IEnumerable<TwitterUser>>(_client, "/users/suggestions/{slug}/members", FormatAsString, "?slug=", slug);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListFavoriteTweetsAsync(ListFavoriteTweetsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "favorites/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> UnfavoriteTweetAsync(UnfavoriteTweetOptions options)
		{
			var id = options.Id;
			
			return WithHammockTask<TwitterStatus>(_client, WebMethod.Post, "favorites/destroy", FormatAsString, "?id=", id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterStatus>> FavoriteTweetAsync(FavoriteTweetOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
			
			return WithHammockTask<TwitterStatus>(_client, WebMethod.Post, "favorites/create", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterList>>> ListListsForAsync(ListListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			
			return WithHammockTask<IEnumerable<TwitterList>>(_client, "lists/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterList>>> ListOwnedListsForAsync(ListOwnedListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<TwitterList>>(_client, "lists/ownerships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterStatus>>> ListTweetsOnListAsync(ListTweetsOnListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var include_rts = options.IncludeRts;
			
			return WithHammockTask<IEnumerable<TwitterStatus>>(_client, "lists/statuses", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&include_rts=", include_rts);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> RemoveListMemberAsync(RemoveListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterList>>> ListListMembershipsForAsync(ListListMembershipsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var filter_to_owned_lists = options.FilterToOwnedLists;
			
			return WithHammockTask<TwitterCursorList<TwitterList>>(_client, "lists/memberships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&filter_to_owned_lists=", filter_to_owned_lists);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListListSubscribersAsync(ListListSubscribersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterCursorList<TwitterUser>>(_client, "lists/subscribers", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> FollowListAsync(FollowListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> VerifyListSubscriptionAsync(VerifyListSubscriptionOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> UnfollowListAsync(UnfollowListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterList>> AddListMembersAsync(AddListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			return WithHammockTask<TwitterList>(_client, WebMethod.Post, "lists/members/create_all", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> VerifyListMembershipAsync(VerifyListMembershipOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterUser>(_client, "lists/members/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterUser>>> ListListMembersAsync(ListListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var count = options.Count;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			
			return WithHammockTask<TwitterCursorList<TwitterUser>>(_client, "lists/members", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&count=", count, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> AddListMemberAsync(AddListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "lists/members/create", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterList>> DeleteListAsync(DeleteListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			
			return WithHammockTask<TwitterList>(_client, WebMethod.Post, "lists/destroy", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterList>> UpdateListAsync(UpdateListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var mode = options.Mode;
			var name = options.Name;
			var description = options.Description;
			
			return WithHammockTask<TwitterList>(_client, WebMethod.Post, "lists/update", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&mode=", mode, "&name=", name, "&description=", description);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterList>> CreateListAsync(CreateListOptions options)
		{
			var list_owner = options.ListOwner;
			var name = options.Name;
			var mode = options.Mode;
			var description = options.Description;
			
			return WithHammockTask<TwitterList>(_client, WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", list_owner, "&name=", name, "&mode=", mode, "&description=", description);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterList>> GetListAsync(GetListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			
			return WithHammockTask<TwitterList>(_client, "lists/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterCursorList<TwitterList>>> ListSubscriptionsAsync(ListSubscriptionsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
			
			return WithHammockTask<TwitterCursorList<TwitterList>>(_client, "lists/subscriptions", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterSavedSearch>>> ListSavedSearchesAsync()
		{
			
			return WithHammockTask<IEnumerable<TwitterSavedSearch>>(_client, "saved_searches/list", FormatAsString);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterSavedSearch>> GetSavedSearchAsync(GetSavedSearchOptions options)
		{
			var id = options.Id;
			
			return WithHammockTask<TwitterSavedSearch>(_client, "saved_searches/show/{id}", FormatAsString, "?id=", id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterSavedSearch>> CreateSavedSearchAsync(CreateSavedSearchOptions options)
		{
			var query = options.Query;
			
			return WithHammockTask<TwitterSavedSearch>(_client, WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterSavedSearch>> DeleteSavedSearchAsync(DeleteSavedSearchOptions options)
		{
			var id = options.Id;
			
			return WithHammockTask<TwitterSavedSearch>(_client, WebMethod.Post, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterPlace>> GetPlaceAsync(GetPlaceOptions options)
		{
			var place_id = options.PlaceId;
			
			return WithHammockTask<TwitterPlace>(_client, "geo/id/{place_id}", FormatAsString, "?place_id=", place_id);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterPlace>>> ReverseGeocodeAsync(ReverseGeocodeOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var accuracy = options.Accuracy;
			var granularity = options.Granularity;
			var max_results = options.MaxResults;
			var callback = options.Callback;
			
			return WithHammockTask<IEnumerable<TwitterPlace>>(_client, "geo/reverse_geocode", FormatAsString, "?lat=", lat, "&long=", @long, "&accuracy=", accuracy, "&granularity=", granularity, "&max_results=", max_results, "&callback=", callback);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<TwitterPlace>>> GeoSearchAsync(GeoSearchOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var query = options.Query;
			var ip = options.Ip;
			var granularity = options.Granularity;
			var accuracy = options.Accuracy;
			var max_results = options.MaxResults;
			var contained_within = options.ContainedWithin;
			var callback = options.Callback;
			
			return WithHammockTask<IEnumerable<TwitterPlace>>(_client, "geo/search", FormatAsString, "?lat=", lat, "&long=", @long, "&query=", query, "&ip=", ip, "&granularity=", granularity, "&accuracy=", accuracy, "&max_results=", max_results, "&contained_within=", contained_within, "&callback=", callback);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterTrends>> ListLocalTrendsForAsync(ListLocalTrendsForOptions options)
		{
			var id = options.Id;
			var exclude = options.Exclude;
			
			return WithHammockTask<TwitterTrends>(_client, "trends/place", FormatAsString, "?id=", id, "&exclude=", exclude);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<WhereOnEarthLocation>>> ListAvailableTrendsLocationsAsync()
		{
			
			return WithHammockTask<IEnumerable<WhereOnEarthLocation>>(_client, "trends/available", FormatAsString);
		}
        
		public virtual  Task<TwitterAsyncResult<IEnumerable<WhereOnEarthLocation>>> ListClosestTrendsLocationsAsync(ListClosestTrendsLocationsOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			
			return WithHammockTask<IEnumerable<WhereOnEarthLocation>>(_client, "trends/closest", FormatAsString, "?lat=", lat, "&long=", @long);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterRateLimitStatusSummary>> GetRateLimitStatusAsync(GetRateLimitStatusOptions options)
		{
			var resources = options.Resources;
			
			return WithHammockTask<TwitterRateLimitStatusSummary>(_client, "application/rate_limit_status", FormatAsString, "?resources=", resources);
		}
        
		public virtual  Task<TwitterAsyncResult<TwitterUser>> ReportSpamAsync(ReportSpamOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			
			return WithHammockTask<TwitterUser>(_client, WebMethod.Post, "users/report_spam", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}
		#endregion
#endif

	}

	#endregion
}
