<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminConversations — operations

Accessor: `client.AdminConversations` · Source: `Api/AdminConversations.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

