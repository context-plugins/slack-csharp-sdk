<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsEventAuthorizations — operations

Accessor: `client.AppsEventAuthorizations` · Source: `Api/AppsEventAuthorizations.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsEventAuthorizationsList

- **Signature**: `AppsEventAuthorizationsList(string eventContext, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `event_context` ← `eventContext`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

