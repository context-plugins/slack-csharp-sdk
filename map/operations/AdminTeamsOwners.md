<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeamsOwners — operations

Accessor: `client.AdminTeamsOwners` · Source: `src/SlackWebApi/Api/AdminTeamsOwners.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsOwnersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsOwnersList(AdminTeamsOwnersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `TeamId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `team_id` ← `TeamId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsOwnersListRequest` | `src/SlackWebApi/Requests/AdminTeamsOwners/AdminTeamsOwnersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

