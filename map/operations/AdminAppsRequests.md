<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminAppsRequests — operations

Accessor: `client.AdminAppsRequests` · Source: `src/SlackWebApi/Api/AdminAppsRequests.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsRequestsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRequestsList(AdminAppsRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `team_id` ← `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsRequestsListRequest` | `src/SlackWebApi/Requests/AdminAppsRequests/AdminAppsRequestsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

