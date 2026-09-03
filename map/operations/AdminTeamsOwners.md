<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeamsOwners — operations

Accessor: `client.AdminTeamsOwners` · Source: `Api/AdminTeamsOwners.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsOwnersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsOwnersList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `team_id` ← `teamId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

