<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeamsAdmins — operations

Accessor: `client.AdminTeamsAdmins` · Source: `src/SlackWebApi/Api/AdminTeamsAdmins.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsAdminsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsAdminsList(AdminTeamsAdminsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `TeamId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `team_id` ← `TeamId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsAdminsListRequest` | `src/SlackWebApi/Requests/AdminTeamsAdmins/AdminTeamsAdminsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

