<!-- Generated file — do not edit; regenerated with the SDK. -->

# Conversations — operations

Accessor: `client.Conversations` · Source: `src/SlackWebApi/Api/Conversations.cs` · 18 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ConversationsArchive

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsArchive(ConversationsArchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsArchivesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsArchiveRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsArchiveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsArchivesuccessschema` | `src/SlackWebApi/Models/ConversationsArchivesuccessschema.cs` |

### ConversationsClose

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsClose(ConversationsCloseRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsClosesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsCloseRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsCloseRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsClosesuccessschema` | `src/SlackWebApi/Models/ConversationsClosesuccessschema.cs` |

### ConversationsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsCreate(ConversationsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsCreatesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsCreateRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsCreateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsCreatesuccessschema` | `src/SlackWebApi/Models/ConversationsCreatesuccessschema.cs` |

### ConversationsHistory

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsHistory(ConversationsHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `latest` ← `Latest`, `oldest` ← `Oldest`, `inclusive` ← `Inclusive`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ConversationsHistorysuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsHistoryRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsHistoryRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsHistorysuccessschema` | `src/SlackWebApi/Models/ConversationsHistorysuccessschema.cs` |

### ConversationsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsInfo(ConversationsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `include_locale` ← `IncludeLocale`, `include_num_members` ← `IncludeNumMembers`
- **Returns**: `ConversationsInfosuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsInfoRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsInfosuccessschema` | `src/SlackWebApi/Models/ConversationsInfosuccessschema.cs` |

### ConversationsInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsInvite(ConversationsInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsInviteerrorschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsInviteRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsInviteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsInviteerrorschema` | `src/SlackWebApi/Models/ConversationsInviteerrorschema.cs` |

### ConversationsJoin

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsJoin(ConversationsJoinRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsJoinsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsJoinRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsJoinRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsJoinsuccessschema` | `src/SlackWebApi/Models/ConversationsJoinsuccessschema.cs` |

### ConversationsKick

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsKick(ConversationsKickRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsKicksuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsKickRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsKickRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsKicksuccessschema` | `src/SlackWebApi/Models/ConversationsKicksuccessschema.cs` |

### ConversationsLeave

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsLeave(ConversationsLeaveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsLeavesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsLeaveRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsLeaveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsLeavesuccessschema` | `src/SlackWebApi/Models/ConversationsLeavesuccessschema.cs` |

### ConversationsList

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsList(ConversationsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `exclude_archived` ← `ExcludeArchived`, `types` ← `Types`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ConversationsListsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsListRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsListsuccessschema` | `src/SlackWebApi/Models/ConversationsListsuccessschema.cs` |

### ConversationsMark

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsMark(ConversationsMarkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsMarksuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsMarkRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsMarkRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsMarksuccessschema` | `src/SlackWebApi/Models/ConversationsMarksuccessschema.cs` |

### ConversationsMembers

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsMembers(ConversationsMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ConversationsMemberssuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsMembersRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsMembersRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsMemberssuccessschema` | `src/SlackWebApi/Models/ConversationsMemberssuccessschema.cs` |

### ConversationsOpen

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsOpen(ConversationsOpenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsOpensuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsOpenRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsOpenRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsOpensuccessschema` | `src/SlackWebApi/Models/ConversationsOpensuccessschema.cs` |

### ConversationsRename

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsRename(ConversationsRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsRenamesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsRenameRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsRenameRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsRenamesuccessschema` | `src/SlackWebApi/Models/ConversationsRenamesuccessschema.cs` |

### ConversationsReplies

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsReplies(ConversationsRepliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `ts` ← `Ts`, `latest` ← `Latest`, `oldest` ← `Oldest`, `inclusive` ← `Inclusive`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ConversationsRepliessuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsRepliesRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsRepliesRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsRepliessuccessschema` | `src/SlackWebApi/Models/ConversationsRepliessuccessschema.cs` |

### ConversationsSetPurpose

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsSetPurpose(ConversationsSetPurposeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsSetPurposesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsSetPurposeRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsSetPurposeRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsSetPurposesuccessschema` | `src/SlackWebApi/Models/ConversationsSetPurposesuccessschema.cs` |

### ConversationsSetTopic

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsSetTopic(ConversationsSetTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsSetTopicsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsSetTopicRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsSetTopicRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsSetTopicsuccessschema` | `src/SlackWebApi/Models/ConversationsSetTopicsuccessschema.cs` |

### ConversationsUnarchive

- **Auth**: `options.SlackAuth`
- **Signature**: `ConversationsUnarchive(ConversationsUnarchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ConversationsUnarchivesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConversationsUnarchiveRequest` | `src/SlackWebApi/Requests/Conversations/ConversationsUnarchiveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ConversationsUnarchivesuccessschema` | `src/SlackWebApi/Models/ConversationsUnarchivesuccessschema.cs` |

