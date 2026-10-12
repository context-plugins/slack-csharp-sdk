<!-- Generated file — do not edit; regenerated with the SDK. -->

# Chat — operations

Accessor: `client.Chat` · Source: `src/SlackWebApi/Api/Chat.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChatDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatDelete(ChatDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ChatDeletesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatDeleteRequest` | `src/SlackWebApi/Requests/Chat/ChatDeleteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatDeletesuccessschema` | `src/SlackWebApi/Models/ChatDeletesuccessschema.cs` |

### ChatDeleteScheduledMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatDeleteScheduledMessage(ChatDeleteScheduledMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`, `ScheduledMessageId`
- **Returns**: `ChatDeleteScheduledMessageschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatDeleteScheduledMessageRequest` | `src/SlackWebApi/Requests/Chat/ChatDeleteScheduledMessageRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatDeleteScheduledMessageschema` | `src/SlackWebApi/Models/ChatDeleteScheduledMessageschema.cs` |

### ChatGetPermalink

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatGetPermalink(ChatGetPermalinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Channel`, `MessageTs`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `message_ts` ← `MessageTs`
- **Returns**: `ChatGetPermalinksuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatGetPermalinkRequest` | `src/SlackWebApi/Requests/Chat/ChatGetPermalinkRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatGetPermalinksuccessschema` | `src/SlackWebApi/Models/ChatGetPermalinksuccessschema.cs` |

### ChatMeMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatMeMessage(ChatMeMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ChatMeMessageschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatMeMessageRequest` | `src/SlackWebApi/Requests/Chat/ChatMeMessageRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatMeMessageschema` | `src/SlackWebApi/Models/ChatMeMessageschema.cs` |

### ChatPostEphemeral

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatPostEphemeral(ChatPostEphemeralRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`, `User`
- **Returns**: `ChatPostEphemeralsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatPostEphemeralRequest` | `src/SlackWebApi/Requests/Chat/ChatPostEphemeralRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatPostEphemeralsuccessschema` | `src/SlackWebApi/Models/ChatPostEphemeralsuccessschema.cs` |

### ChatPostMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatPostMessage(ChatPostMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`
- **Returns**: `ChatPostMessagesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatPostMessageRequest` | `src/SlackWebApi/Requests/Chat/ChatPostMessageRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatPostMessagesuccessschema` | `src/SlackWebApi/Models/ChatPostMessagesuccessschema.cs` |

### ChatScheduleMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatScheduleMessage(ChatScheduleMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `ChatScheduleMessagesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatScheduleMessageRequest` | `src/SlackWebApi/Requests/Chat/ChatScheduleMessageRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatScheduleMessagesuccessschema` | `src/SlackWebApi/Models/ChatScheduleMessagesuccessschema.cs` |

### ChatScheduledMessagesList

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatScheduledMessagesList(ChatScheduledMessagesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `channel` ← `Channel`, `latest` ← `Latest`, `oldest` ← `Oldest`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ChatScheduledMessagesListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatScheduledMessagesListRequest` | `src/SlackWebApi/Requests/ChatScheduledMessages/ChatScheduledMessagesListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatScheduledMessagesListschema` | `src/SlackWebApi/Models/ChatScheduledMessagesListschema.cs` |

### ChatUnfurl

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatUnfurl(ChatUnfurlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`, `Ts`
- **Returns**: `ChatUnfurlsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatUnfurlRequest` | `src/SlackWebApi/Requests/Chat/ChatUnfurlRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatUnfurlsuccessschema` | `src/SlackWebApi/Models/ChatUnfurlsuccessschema.cs` |

### ChatUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatUpdate(ChatUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`, `Ts`
- **Returns**: `ChatUpdatesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChatUpdateRequest` | `src/SlackWebApi/Requests/Chat/ChatUpdateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ChatUpdatesuccessschema` | `src/SlackWebApi/Models/ChatUpdatesuccessschema.cs` |

