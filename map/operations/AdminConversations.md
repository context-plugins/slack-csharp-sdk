<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminConversations — operations

Accessor: `client.AdminConversations` · Source: `src/SlackWebApi/Api/AdminConversations.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

