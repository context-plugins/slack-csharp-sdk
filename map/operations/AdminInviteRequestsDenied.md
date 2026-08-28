<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminInviteRequestsDenied — operations

Accessor: `client.AdminInviteRequestsDenied` · Source: `Api/AdminInviteRequestsDenied.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminInviteRequestsDeniedList

- **Signature**: `AdminInviteRequestsDeniedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `team_id` ← `teamId`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

