<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChatScheduledMessages — operations

Accessor: `client.ChatScheduledMessages` · Source: `src/SlackWebApi/Api/ChatScheduledMessages.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

