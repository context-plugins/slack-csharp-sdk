<!-- Generated file — do not edit; regenerated with the SDK. -->

# Chat — operations

Accessor: `client.Chat` · Source: `Api/Chat.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChatDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatDelete(ContentType contentType, string? token, double? ts, string? channel, bool? asUser, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`token` … `asUser`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ChatDeletesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatDeletesuccessschema` | `Models/ChatDeletesuccessschema.cs` |

### ChatDeleteScheduledMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatDeleteScheduledMessage(string token, ContentType contentType, string channel, string scheduledMessageId, bool? asUser, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asUser` — nullable, no default → **must pass explicitly**
- **Returns**: `ChatDeleteScheduledMessageschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatDeleteScheduledMessageschema` | `Models/ChatDeleteScheduledMessageschema.cs` |

### ChatGetPermalink

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatGetPermalink(string token, string channel, string messageTs, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `message_ts` ← `messageTs`
- **Returns**: `ChatGetPermalinksuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatGetPermalinksuccessschema` | `Models/ChatGetPermalinksuccessschema.cs` |

### ChatMeMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatMeMessage(ContentType contentType, string? token, string? channel, string? text, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `channel` — nullable, no default → **must pass explicitly**
  - `text` — nullable, no default → **must pass explicitly**
- **Returns**: `ChatMeMessageschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatMeMessageschema` | `Models/ChatMeMessageschema.cs` |

### ChatPostEphemeral

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatPostEphemeral(string token, ContentType contentType, string channel, string user, bool? asUser, string? attachments, string? blocks, string? iconEmoji, string? iconUrl, bool? linkNames, string? parse, string? text, string? threadTs, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`asUser` … `username`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ChatPostEphemeralsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatPostEphemeralsuccessschema` | `Models/ChatPostEphemeralsuccessschema.cs` |

### ChatPostMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatPostMessage(string token, ContentType contentType, string channel, string? asUser, string? attachments, string? blocks, string? iconEmoji, string? iconUrl, bool? linkNames, bool? mrkdwn, string? parse, bool? replyBroadcast, string? text, string? threadTs, bool? unfurlLinks, bool? unfurlMedia, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 14 params (`asUser` … `username`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ChatPostMessagesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatPostMessagesuccessschema` | `Models/ChatPostMessagesuccessschema.cs` |

### ChatScheduleMessage

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatScheduleMessage(ContentType contentType, string? token, string? channel, string? text, string? postAt, string? parse, bool? asUser, bool? linkNames, string? attachments, string? blocks, bool? unfurlLinks, bool? unfurlMedia, double? threadTs, bool? replyBroadcast, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 13 params (`token` … `replyBroadcast`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ChatScheduleMessagesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatScheduleMessagesuccessschema` | `Models/ChatScheduleMessagesuccessschema.cs` |

### ChatScheduledMessagesList

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatScheduledMessagesList(string? channel, double? latest, double? oldest, int? limit, string? cursor, ContentType contentType, string? token, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`channel` … `token`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `channel` ← `channel`, `latest` ← `latest`, `oldest` ← `oldest`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ChatScheduledMessagesListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatScheduledMessagesListschema` | `Models/ChatScheduledMessagesListschema.cs` |

### ChatUnfurl

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatUnfurl(string token, ContentType contentType, string channel, string ts, string? unfurls, string? userAuthMessage, bool? userAuthRequired, string? userAuthUrl, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`unfurls` … `userAuthUrl`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ChatUnfurlsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatUnfurlsuccessschema` | `Models/ChatUnfurlsuccessschema.cs` |

### ChatUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `ChatUpdate(string token, ContentType contentType, string channel, string ts, string? asUser, string? attachments, string? blocks, string? linkNames, string? parse, string? text, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`asUser` … `text`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ChatUpdatesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ChatUpdatesuccessschema` | `Models/ChatUpdatesuccessschema.cs` |

