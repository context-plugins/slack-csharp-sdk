<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeams — operations

Accessor: `client.AdminTeams` · Source: `Api/AdminTeams.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsCreate

- **Signature**: `AdminTeamsCreate(string token, ContentType contentType, string teamDomain, string teamName, string? teamDescription, string? teamDiscoverability, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamDescription` — nullable, no default → **must pass explicitly**
  - `teamDiscoverability` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsList

- **Signature**: `AdminTeamsList(int? limit, string? cursor, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `limit` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

