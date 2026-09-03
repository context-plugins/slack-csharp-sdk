<!-- Generated file — do not edit; regenerated with the SDK. -->

# Admin — operations

Accessor: `client.Admin` · Source: `Api/Admin.cs` · 56 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprove(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `appId` — nullable, no default → **must pass explicitly**
  - `requestId` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminAppsApprovedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprovedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`limit` … `enterpriseId`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `limit` ← `limit`, `cursor` ← `cursor`, `team_id` ← `teamId`, `enterprise_id` ← `enterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminAppsRequestsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRequestsList(string token, int? limit, string? cursor, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `limit` ← `limit`, `cursor` ← `cursor`, `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminAppsRestrict

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrict(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `appId` — nullable, no default → **must pass explicitly**
  - `requestId` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminAppsRestrictedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrictedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`limit` … `enterpriseId`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `limit` ← `limit`, `cursor` ← `cursor`, `team_id` ← `teamId`, `enterprise_id` ← `enterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsArchive

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsArchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsArchiveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsArchiveschema` | `Models/AdminConversationsArchiveschema.cs` |

### AdminConversationsConvertToPrivate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsConvertToPrivate(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsConvertToPrivateschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsConvertToPrivateschema` | `Models/AdminConversationsConvertToPrivateschema.cs` |

### AdminConversationsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsCreate(string token, ContentType contentType, string name, bool isPrivate, string? description, bool? orgWide, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `description` — nullable, no default → **must pass explicitly**
  - `orgWide` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminConversationsCreateschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsCreateschema` | `Models/AdminConversationsCreateschema.cs` |

### AdminConversationsDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsDelete(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsDeleteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsDeleteschema` | `Models/AdminConversationsDeleteschema.cs` |

### AdminConversationsDisconnectShared

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsDisconnectShared(string token, ContentType contentType, string channelId, string? leavingTeamIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `leavingTeamIds` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminConversationsRenameschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsRenameschema` | `Models/AdminConversationsRenameschema.cs` |

### AdminConversationsEkmListOriginalConnectedChannelInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsEkmListOriginalConnectedChannelInfo(string token, string? channelIds, string? teamIds, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`channelIds` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel_ids` ← `channelIds`, `team_ids` ← `teamIds`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsGetConversationPrefs

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsGetConversationPrefs(string channelId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `channel_id` ← `channelId`
- **Returns**: `AdminConversationsGetConversationPrefsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsGetConversationPrefsschema` | `Models/AdminConversationsGetConversationPrefsschema.cs` |

### AdminConversationsGetTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsGetTeams(string channelId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `channel_id` ← `channelId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `AdminConversationsGetTeamsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsGetTeamsschema` | `Models/AdminConversationsGetTeamsschema.cs` |

### AdminConversationsInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsInvite(string token, ContentType contentType, string userIds, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsInviteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsInviteschema` | `Models/AdminConversationsInviteschema.cs` |

### AdminConversationsRename

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRename(string token, ContentType contentType, string channelId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsRenameschema1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsRenameschema1` | `Models/AdminConversationsRenameschema1.cs` |

### AdminConversationsRestrictAccessAddGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessAddGroup(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessListGroups

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessListGroups(string token, string channelId, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `channel_id` ← `channelId`, `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessRemoveGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessRemoveGroup(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsSearch

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsSearch(string? teamIds, string? query, int? limit, string? cursor, string? searchChannelTypes, string? sort, string? sortDir, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`teamIds` … `sortDir`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `team_ids` ← `teamIds`, `query` ← `query`, `limit` ← `limit`, `cursor` ← `cursor`, `search_channel_types` ← `searchChannelTypes`, `sort` ← `sort`, `sort_dir` ← `sortDir`
- **Returns**: `AdminConversationsSearchschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsSearchschema` | `Models/AdminConversationsSearchschema.cs` |

### AdminConversationsSetConversationPrefs

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsSetConversationPrefs(string token, ContentType contentType, string channelId, string prefs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsSetConversationPrefsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsSetConversationPrefsschema` | `Models/AdminConversationsSetConversationPrefsschema.cs` |

### AdminConversationsSetTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsSetTeams(string token, ContentType contentType, string channelId, string? teamId, string? targetTeamIds, bool? orgChannel, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `targetTeamIds` — nullable, no default → **must pass explicitly**
  - `orgChannel` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsUnarchive

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsUnarchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsUnarchiveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsUnarchiveschema` | `Models/AdminConversationsUnarchiveschema.cs` |

### AdminEmojiAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiAdd(ContentType contentType, string token, string name, string url, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiAddAlias

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiAddAlias(ContentType contentType, string token, string name, string aliasFor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiRemove(ContentType contentType, string token, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRename

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiRename(ContentType contentType, string token, string name, string newName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsApprove(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsApprovedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsApprovedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `team_id` ← `teamId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsDeniedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsDeniedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `team_id` ← `teamId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsDeny

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsDeny(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `team_id` ← `teamId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsAdminsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsAdminsList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `team_id` ← `teamId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsCreate(string token, ContentType contentType, string teamDomain, string teamName, string? teamDescription, string? teamDiscoverability, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamDescription` — nullable, no default → **must pass explicitly**
  - `teamDiscoverability` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsList(int? limit, string? cursor, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsOwnersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsOwnersList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `team_id` ← `teamId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsInfo(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDefaultChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDefaultChannels(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDescription

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDescription(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDiscoverability

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDiscoverability(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetIcon

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetIcon(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetName

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetName(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddChannels(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddTeams(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `autoProvision` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsListChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsListChannels(string usergroupId, string? teamId, bool? includeNumMembers, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `includeNumMembers` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `usergroup_id` ← `usergroupId`, `team_id` ← `teamId`, `include_num_members` ← `includeNumMembers`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsRemoveChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsRemoveChannels(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersAssign

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersAssign(string token, ContentType contentType, string teamId, string userId, bool? isRestricted, bool? isUltraRestricted, string? channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `isRestricted` — nullable, no default → **must pass explicitly**
  - `isUltraRestricted` — nullable, no default → **must pass explicitly**
  - `channelIds` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersInvite(string token, ContentType contentType, string teamId, string email, string channelIds, string? customMessage, string? realName, bool? resend, bool? isRestricted, bool? isUltraRestricted, string? guestExpirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`customMessage` … `guestExpirationTs`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersList(string teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `team_id` ← `teamId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersRemove(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionInvalidate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSessionInvalidate(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionReset

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSessionReset(string token, ContentType contentType, string userId, bool? mobileOnly, bool? webOnly, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `mobileOnly` — nullable, no default → **must pass explicitly**
  - `webOnly` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetAdmin

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetAdmin(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetExpiration

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetExpiration(string token, ContentType contentType, string teamId, string userId, int expirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetOwner

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetOwner(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetRegular

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetRegular(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

