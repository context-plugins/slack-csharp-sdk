<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeamsAdmins — operations

Accessor: `client.AdminTeamsAdmins` · Source: `Api/AdminTeamsAdmins.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsAdminsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsAdminsList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `team_id` ← `teamId`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

