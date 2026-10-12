<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeams — operations

Accessor: `client.AdminTeams` · Source: `src/SlackWebApi/Api/AdminTeams.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsCreate(AdminTeamsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamDomain`, `TeamName`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsCreateRequest` | `src/SlackWebApi/Requests/AdminTeams/AdminTeamsCreateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsList(AdminTeamsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsListRequest` | `src/SlackWebApi/Requests/AdminTeams/AdminTeamsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

