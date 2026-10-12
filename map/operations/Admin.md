<!-- Generated file — do not edit; regenerated with the SDK. -->

# Admin — operations

Accessor: `client.Admin` · Source: `src/SlackWebApi/Api/Admin.cs` · 56 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprove(AdminAppsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsApproveRequest` | `src/SlackWebApi/Requests/AdminApps/AdminAppsApproveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminAppsApprovedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprovedList(AdminAppsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `team_id` ← `TeamId`, `enterprise_id` ← `EnterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsApprovedListRequest` | `src/SlackWebApi/Requests/AdminAppsApproved/AdminAppsApprovedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminAppsRequestsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRequestsList(AdminAppsRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `team_id` ← `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsRequestsListRequest` | `src/SlackWebApi/Requests/AdminAppsRequests/AdminAppsRequestsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminAppsRestrict

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrict(AdminAppsRestrictRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsRestrictRequest` | `src/SlackWebApi/Requests/AdminApps/AdminAppsRestrictRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminAppsRestrictedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrictedList(AdminAppsRestrictedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `team_id` ← `TeamId`, `enterprise_id` ← `EnterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsRestrictedListRequest` | `src/SlackWebApi/Requests/AdminAppsRestricted/AdminAppsRestrictedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsArchive

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsArchive(AdminConversationsArchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`
- **Returns**: `AdminConversationsArchiveschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsArchiveRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsArchiveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsArchiveschema` | `src/SlackWebApi/Models/AdminConversationsArchiveschema.cs` |

### AdminConversationsConvertToPrivate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsConvertToPrivate(AdminConversationsConvertToPrivateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`
- **Returns**: `AdminConversationsConvertToPrivateschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsConvertToPrivateRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsConvertToPrivateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsConvertToPrivateschema` | `src/SlackWebApi/Models/AdminConversationsConvertToPrivateschema.cs` |

### AdminConversationsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsCreate(AdminConversationsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Name`, `IsPrivate`
- **Returns**: `AdminConversationsCreateschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsCreateRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsCreateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsCreateschema` | `src/SlackWebApi/Models/AdminConversationsCreateschema.cs` |

### AdminConversationsDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsDelete(AdminConversationsDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`
- **Returns**: `AdminConversationsDeleteschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsDeleteRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsDeleteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsDeleteschema` | `src/SlackWebApi/Models/AdminConversationsDeleteschema.cs` |

### AdminConversationsDisconnectShared

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsDisconnectShared(AdminConversationsDisconnectSharedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`
- **Returns**: `AdminConversationsRenameschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsDisconnectSharedRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsDisconnectSharedRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsRenameschema` | `src/SlackWebApi/Models/AdminConversationsRenameschema.cs` |

### AdminConversationsEkmListOriginalConnectedChannelInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsEkmListOriginalConnectedChannelInfo(AdminConversationsEkmListOriginalConnectedChannelInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel_ids` ← `ChannelIds`, `team_ids` ← `TeamIds`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsEkmListOriginalConnectedChannelInfoRequest` | `src/SlackWebApi/Requests/AdminConversationsEkm/AdminConversationsEkmListOriginalConnectedChannelInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsGetConversationPrefs

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsGetConversationPrefs(AdminConversationsGetConversationPrefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ChannelId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `channel_id` ← `ChannelId`
- **Returns**: `AdminConversationsGetConversationPrefsschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsGetConversationPrefsRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsGetConversationPrefsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsGetConversationPrefsschema` | `src/SlackWebApi/Models/AdminConversationsGetConversationPrefsschema.cs` |

### AdminConversationsGetTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsGetTeams(AdminConversationsGetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ChannelId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `channel_id` ← `ChannelId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `AdminConversationsGetTeamsschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsGetTeamsRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsGetTeamsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsGetTeamsschema` | `src/SlackWebApi/Models/AdminConversationsGetTeamsschema.cs` |

### AdminConversationsInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsInvite(AdminConversationsInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UserIds`, `ChannelId`
- **Returns**: `AdminConversationsInviteschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsInviteRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsInviteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsInviteschema` | `src/SlackWebApi/Models/AdminConversationsInviteschema.cs` |

### AdminConversationsRename

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRename(AdminConversationsRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`, `Name`
- **Returns**: `AdminConversationsRenameschema1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRenameRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsRenameRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsRenameschema1` | `src/SlackWebApi/Models/AdminConversationsRenameschema1.cs` |

### AdminConversationsRestrictAccessAddGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessAddGroup(AdminConversationsRestrictAccessAddGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `GroupId`, `ChannelId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRestrictAccessAddGroupRequest` | `src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessAddGroupRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessListGroups

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessListGroups(AdminConversationsRestrictAccessListGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ChannelId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel_id` ← `ChannelId`, `team_id` ← `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRestrictAccessListGroupsRequest` | `src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessListGroupsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessRemoveGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessRemoveGroup(AdminConversationsRestrictAccessRemoveGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `TeamId`, `GroupId`, `ChannelId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRestrictAccessRemoveGroupRequest` | `src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessRemoveGroupRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsSearch

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsSearch(AdminConversationsSearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_ids` ← `TeamIds`, `query` ← `Query`, `limit` ← `Limit`, `cursor` ← `Cursor`, `search_channel_types` ← `SearchChannelTypes`, `sort` ← `Sort`, `sort_dir` ← `SortDir`
- **Returns**: `AdminConversationsSearchschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsSearchRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsSearchRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsSearchschema` | `src/SlackWebApi/Models/AdminConversationsSearchschema.cs` |

### AdminConversationsSetConversationPrefs

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsSetConversationPrefs(AdminConversationsSetConversationPrefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`, `Prefs`
- **Returns**: `AdminConversationsSetConversationPrefsschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsSetConversationPrefsRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsSetConversationPrefsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsSetConversationPrefsschema` | `src/SlackWebApi/Models/AdminConversationsSetConversationPrefsschema.cs` |

### AdminConversationsSetTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsSetTeams(AdminConversationsSetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsSetTeamsRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsSetTeamsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsUnarchive

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsUnarchive(AdminConversationsUnarchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ChannelId`
- **Returns**: `AdminConversationsUnarchiveschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsUnarchiveRequest` | `src/SlackWebApi/Requests/AdminConversations/AdminConversationsUnarchiveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AdminConversationsUnarchiveschema` | `src/SlackWebApi/Models/AdminConversationsUnarchiveschema.cs` |

### AdminEmojiAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiAdd(AdminEmojiAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`, `Url`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiAddRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiAddAlias

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiAddAlias(AdminEmojiAddAliasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`, `AliasFor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiAddAliasRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddAliasRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiList(AdminEmojiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiListRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiRemove(AdminEmojiRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiRemoveRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRename

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiRename(AdminEmojiRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`, `NewName`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiRenameRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRenameRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsApprove(AdminInviteRequestsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `InviteRequestId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsApproveRequest` | `src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsApproveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsApprovedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsApprovedList(AdminInviteRequestsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsApprovedListRequest` | `src/SlackWebApi/Requests/AdminInviteRequestsApproved/AdminInviteRequestsApprovedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsDeniedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsDeniedList(AdminInviteRequestsDeniedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsDeniedListRequest` | `src/SlackWebApi/Requests/AdminInviteRequestsDenied/AdminInviteRequestsDeniedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsDeny

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsDeny(AdminInviteRequestsDenyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `InviteRequestId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsDenyRequest` | `src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsDenyRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsList(AdminInviteRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsListRequest` | `src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsAdminsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsAdminsList(AdminTeamsAdminsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `TeamId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `team_id` ← `TeamId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsAdminsListRequest` | `src/SlackWebApi/Requests/AdminTeamsAdmins/AdminTeamsAdminsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsCreate(AdminTeamsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamDomain`, `TeamName`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsCreateRequest` | `src/SlackWebApi/Requests/AdminTeams/AdminTeamsCreateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsList(AdminTeamsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsListRequest` | `src/SlackWebApi/Requests/AdminTeams/AdminTeamsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsOwnersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsOwnersList(AdminTeamsOwnersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `TeamId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `team_id` ← `TeamId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsOwnersListRequest` | `src/SlackWebApi/Requests/AdminTeamsOwners/AdminTeamsOwnersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsInfo(AdminTeamsSettingsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsInfoRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDefaultChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDefaultChannels(AdminTeamsSettingsSetDefaultChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `TeamId`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetDefaultChannelsRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDefaultChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDescription

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDescription(AdminTeamsSettingsSetDescriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Description`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetDescriptionRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDescriptionRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDiscoverability

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDiscoverability(AdminTeamsSettingsSetDiscoverabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Discoverability`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetDiscoverabilityRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDiscoverabilityRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetIcon

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetIcon(AdminTeamsSettingsSetIconRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `ImageUrl`, `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetIconRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetIconRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetName

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetName(AdminTeamsSettingsSetNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Name`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetNameRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetNameRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddChannels(AdminUsergroupsAddChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UsergroupId`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsAddChannelsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddTeams(AdminUsergroupsAddTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UsergroupId`, `TeamIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsAddTeamsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddTeamsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsListChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsListChannels(AdminUsergroupsListChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UsergroupId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `usergroup_id` ← `UsergroupId`, `team_id` ← `TeamId`, `include_num_members` ← `IncludeNumMembers`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsListChannelsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsListChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsRemoveChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsRemoveChannels(AdminUsergroupsRemoveChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UsergroupId`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsRemoveChannelsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsRemoveChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersAssign

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersAssign(AdminUsersAssignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersAssignRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersAssignRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersInvite(AdminUsersInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Email`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersInviteRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersInviteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersList(AdminUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersListRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersRemove(AdminUsersRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersRemoveRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionInvalidate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSessionInvalidate(AdminUsersSessionInvalidateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `SessionId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSessionInvalidateRequest` | `src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionInvalidateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionReset

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSessionReset(AdminUsersSessionResetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSessionResetRequest` | `src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionResetRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetAdmin

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetAdmin(AdminUsersSetAdminRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetAdminRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetAdminRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetExpiration

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetExpiration(AdminUsersSetExpirationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`, `ExpirationTs`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetExpirationRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetExpirationRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetOwner

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetOwner(AdminUsersSetOwnerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetOwnerRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetOwnerRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetRegular

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetRegular(AdminUsersSetRegularRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetRegularRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetRegularRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

