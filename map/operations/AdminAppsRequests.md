<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminAppsRequests — operations

Accessor: `client.AdminAppsRequests` · Source: `Api/AdminAppsRequests.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsRequestsList

- **Signature**: `AdminAppsRequestsList(string token, int? limit, string? cursor, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `limit` ← `limit`, `cursor` ← `cursor`, `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

