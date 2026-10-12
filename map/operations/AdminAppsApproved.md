<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminAppsApproved — operations

Accessor: `client.AdminAppsApproved` · Source: `src/SlackWebApi/Api/AdminAppsApproved.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsApprovedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprovedList(AdminAppsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `team_id` ← `TeamId`, `enterprise_id` ← `EnterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsApprovedListRequest` | `src/SlackWebApi/Requests/AdminAppsApproved/AdminAppsApprovedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

