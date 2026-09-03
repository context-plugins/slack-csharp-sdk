<!-- Generated file — do not edit; regenerated with the SDK. -->

# Conversations — operations

Accessor: `client.Conversations` · Source: `Api/Conversations.cs` · 18 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ConversationsArchive

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsArchive(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsArchivesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsArchivesuccessschema` | `Models/ConversationsArchivesuccessschema.cs` |

### ConversationsClose

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsClose(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsClosesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsClosesuccessschema` | `Models/ConversationsClosesuccessschema.cs` |

### ConversationsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsCreate(ContentType contentType, string? token, string? name, bool? isPrivate, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `name` — nullable, no default → **must pass explicitly**
  - `isPrivate` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsCreatesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsCreatesuccessschema` | `Models/ConversationsCreatesuccessschema.cs` |

### ConversationsHistory

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsHistory(string? token, string? channel, double? latest, double? oldest, bool? inclusive, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `latest` ← `latest`, `oldest` ← `oldest`, `inclusive` ← `inclusive`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ConversationsHistorysuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsHistorysuccessschema` | `Models/ConversationsHistorysuccessschema.cs` |

### ConversationsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsInfo(string? token, string? channel, bool? includeLocale, bool? includeNumMembers, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`token` … `includeNumMembers`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `include_locale` ← `includeLocale`, `include_num_members` ← `includeNumMembers`
- **Returns**: `ConversationsInfosuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsInfosuccessschema` | `Models/ConversationsInfosuccessschema.cs` |

### ConversationsInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsInvite(ContentType contentType, string? token, string? channel, string? users, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `users` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsInviteerrorschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsInviteerrorschema` | `Models/ConversationsInviteerrorschema.cs` |

### ConversationsJoin

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsJoin(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsJoinsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsJoinsuccessschema` | `Models/ConversationsJoinsuccessschema.cs` |

### ConversationsKick

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsKick(ContentType contentType, string? token, string? channel, string? user, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `user` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsKicksuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsKicksuccessschema` | `Models/ConversationsKicksuccessschema.cs` |

### ConversationsLeave

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsLeave(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsLeavesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsLeavesuccessschema` | `Models/ConversationsLeavesuccessschema.cs` |

### ConversationsList

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsList(string? token, bool? excludeArchived, string? types, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `exclude_archived` ← `excludeArchived`, `types` ← `types`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ConversationsListsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsListsuccessschema` | `Models/ConversationsListsuccessschema.cs` |

### ConversationsMark

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsMark(ContentType contentType, string? token, string? channel, double? ts, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `ts` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsMarksuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsMarksuccessschema` | `Models/ConversationsMarksuccessschema.cs` |

### ConversationsMembers

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsMembers(string? token, string? channel, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ConversationsMemberssuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsMemberssuccessschema` | `Models/ConversationsMemberssuccessschema.cs` |

### ConversationsOpen

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsOpen(ContentType contentType, string? token, string? channel, string? users, bool? returnIm, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`token` … `returnIm`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ConversationsOpensuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsOpensuccessschema` | `Models/ConversationsOpensuccessschema.cs` |

### ConversationsRename

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsRename(ContentType contentType, string? token, string? channel, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `name` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsRenamesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsRenamesuccessschema` | `Models/ConversationsRenamesuccessschema.cs` |

### ConversationsReplies

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsReplies(string? token, string? channel, double? ts, double? latest, double? oldest, bool? inclusive, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `ts` ← `ts`, `latest` ← `latest`, `oldest` ← `oldest`, `inclusive` ← `inclusive`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ConversationsRepliessuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsRepliessuccessschema` | `Models/ConversationsRepliessuccessschema.cs` |

### ConversationsSetPurpose

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsSetPurpose(ContentType contentType, string? token, string? channel, string? purpose, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `purpose` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsSetPurposesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsSetPurposesuccessschema` | `Models/ConversationsSetPurposesuccessschema.cs` |

### ConversationsSetTopic

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsSetTopic(ContentType contentType, string? token, string? channel, string? topic, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `topic` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsSetTopicsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsSetTopicsuccessschema` | `Models/ConversationsSetTopicsuccessschema.cs` |

### ConversationsUnarchive

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsUnarchive(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
- **Returns**: `ConversationsUnarchivesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ConversationsUnarchivesuccessschema` | `Models/ConversationsUnarchivesuccessschema.cs` |

