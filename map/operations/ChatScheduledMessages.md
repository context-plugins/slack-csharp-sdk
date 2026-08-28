<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChatScheduledMessages — operations

Accessor: `client.ChatScheduledMessages` · Source: `Api/ChatScheduledMessages.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChatScheduledMessagesList

- **Signature**: `ChatScheduledMessagesList(string? channel, double? latest, double? oldest, int? limit, string? cursor, ContentType contentType, string? token, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`channel` … `token`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `channel` ← `channel`, `latest` ← `latest`, `oldest` ← `oldest`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ChatScheduledMessagesListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatScheduledMessagesListschema` | `Models/ChatScheduledMessagesListschema.cs` |

