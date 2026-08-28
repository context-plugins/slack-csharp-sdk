<!-- Generated file — do not edit; regenerated with the SDK. -->

# Admin — operations

Accessor: `client.Admin` · Source: `Api/Admin.cs` · 56 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsApprove

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

- **Signature**: `AdminConversationsArchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsArchiveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsArchiveschema` | `Models/AdminConversationsArchiveschema.cs` |

### AdminConversationsConvertToPrivate

- **Signature**: `AdminConversationsConvertToPrivate(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsConvertToPrivateschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsConvertToPrivateschema` | `Models/AdminConversationsConvertToPrivateschema.cs` |

### AdminConversationsCreate

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

- **Signature**: `AdminConversationsDelete(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsDeleteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsDeleteschema` | `Models/AdminConversationsDeleteschema.cs` |

### AdminConversationsDisconnectShared

- **Signature**: `AdminConversationsDisconnectShared(string token, ContentType contentType, string channelId, string? leavingTeamIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `leavingTeamIds` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminConversationsRenameschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsRenameschema` | `Models/AdminConversationsRenameschema.cs` |

### AdminConversationsEkmListOriginalConnectedChannelInfo

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

- **Signature**: `AdminConversationsGetConversationPrefs(string channelId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `channel_id` ← `channelId`
- **Returns**: `AdminConversationsGetConversationPrefsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsGetConversationPrefsschema` | `Models/AdminConversationsGetConversationPrefsschema.cs` |

### AdminConversationsGetTeams

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

- **Signature**: `AdminConversationsInvite(string token, ContentType contentType, string userIds, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsInviteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsInviteschema` | `Models/AdminConversationsInviteschema.cs` |

### AdminConversationsRename

- **Signature**: `AdminConversationsRename(string token, ContentType contentType, string channelId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsRenameschema1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsRenameschema1` | `Models/AdminConversationsRenameschema1.cs` |

### AdminConversationsRestrictAccessAddGroup

- **Signature**: `AdminConversationsRestrictAccessAddGroup(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessListGroups

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

- **Signature**: `AdminConversationsRestrictAccessRemoveGroup(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsSearch

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

- **Signature**: `AdminConversationsSetConversationPrefs(string token, ContentType contentType, string channelId, string prefs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsSetConversationPrefsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsSetConversationPrefsschema` | `Models/AdminConversationsSetConversationPrefsschema.cs` |

### AdminConversationsSetTeams

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

- **Signature**: `AdminConversationsUnarchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminConversationsUnarchiveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AdminConversationsUnarchiveschema` | `Models/AdminConversationsUnarchiveschema.cs` |

### AdminEmojiAdd

- **Signature**: `AdminEmojiAdd(ContentType contentType, string token, string name, string url, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiAddAlias

- **Signature**: `AdminEmojiAddAlias(ContentType contentType, string token, string name, string aliasFor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiList

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

- **Signature**: `AdminEmojiRemove(ContentType contentType, string token, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRename

- **Signature**: `AdminEmojiRename(ContentType contentType, string token, string name, string newName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsApprove

- **Signature**: `AdminInviteRequestsApprove(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsApprovedList

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

- **Signature**: `AdminInviteRequestsDeny(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsList

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

- **Signature**: `AdminTeamsSettingsInfo(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDefaultChannels

- **Signature**: `AdminTeamsSettingsSetDefaultChannels(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDescription

- **Signature**: `AdminTeamsSettingsSetDescription(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDiscoverability

- **Signature**: `AdminTeamsSettingsSetDiscoverability(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetIcon

- **Signature**: `AdminTeamsSettingsSetIcon(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetName

- **Signature**: `AdminTeamsSettingsSetName(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddChannels

- **Signature**: `AdminUsergroupsAddChannels(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddTeams

- **Signature**: `AdminUsergroupsAddTeams(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `autoProvision` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsListChannels

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

- **Signature**: `AdminUsergroupsRemoveChannels(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersAssign

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

- **Signature**: `AdminUsersInvite(string token, ContentType contentType, string teamId, string email, string channelIds, string? customMessage, string? realName, bool? resend, bool? isRestricted, bool? isUltraRestricted, string? guestExpirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`customMessage` … `guestExpirationTs`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersList

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

- **Signature**: `AdminUsersRemove(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionInvalidate

- **Signature**: `AdminUsersSessionInvalidate(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionReset

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

- **Signature**: `AdminUsersSetAdmin(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetExpiration

- **Signature**: `AdminUsersSetExpiration(string token, ContentType contentType, string teamId, string userId, int expirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetOwner

- **Signature**: `AdminUsersSetOwner(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetRegular

- **Signature**: `AdminUsersSetRegular(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

