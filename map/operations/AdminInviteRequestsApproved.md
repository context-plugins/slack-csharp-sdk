<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminInviteRequestsApproved — operations

Accessor: `client.AdminInviteRequestsApproved` · Source: `src/SlackWebApi/Api/AdminInviteRequestsApproved.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminInviteRequestsApprovedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsApprovedList(AdminInviteRequestsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsApprovedListRequest` | `src/SlackWebApi/Requests/AdminInviteRequestsApproved/AdminInviteRequestsApprovedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

