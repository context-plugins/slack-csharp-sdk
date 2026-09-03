<!-- Generated file — do not edit; regenerated with the SDK. -->

# Stars — operations

Accessor: `client.Stars` · Source: `Api/Stars.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### StarsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `StarsAdd(string token, ContentType contentType, string? channel, string? file, string? fileComment, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`channel` … `timestamp`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `StarsAddschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `StarsAddschema` | `Models/StarsAddschema.cs` |

### StarsList

- **Auth**: `options.SlackAuth`
- **Signature**: `StarsList(string? token, string? count, string? page, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`token` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `count` ← `count`, `page` ← `page`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `StarsListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `StarsListschema` | `Models/StarsListschema.cs` |

### StarsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `StarsRemove(string token, ContentType contentType, string? channel, string? file, string? fileComment, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`channel` … `timestamp`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `StarsRemoveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `StarsRemoveschema` | `Models/StarsRemoveschema.cs` |

