<!-- Generated file — do not edit; regenerated with the SDK. -->

# Reactions — operations

Accessor: `client.Reactions` · Source: `Api/Reactions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ReactionsAdd

- **Signature**: `ReactionsAdd(string token, ContentType contentType, string channel, string name, string timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ReactionsAddschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ReactionsAddschema` | `Models/ReactionsAddschema.cs` |

### ReactionsGet

- **Signature**: `ReactionsGet(string token, string? channel, string? file, string? fileComment, bool? full, string? timestamp, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`channel` … `timestamp`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `file` ← `file`, `file_comment` ← `fileComment`, `full` ← `full`, `timestamp` ← `timestamp`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |

### ReactionsList

- **Signature**: `ReactionsList(string token, string? user, bool? full, int? count, int? page, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`user` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `user` ← `user`, `full` ← `full`, `count` ← `count`, `page` ← `page`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ReactionsListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ReactionsListschema` | `Models/ReactionsListschema.cs` |

### ReactionsRemove

- **Signature**: `ReactionsRemove(string token, ContentType contentType, string name, string? file, string? fileComment, string? channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`file` … `timestamp`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `ReactionsRemoveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ReactionsRemoveschema` | `Models/ReactionsRemoveschema.cs` |

