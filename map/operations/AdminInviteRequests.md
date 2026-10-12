<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminInviteRequests — operations

Accessor: `client.AdminInviteRequests` · Source: `src/SlackWebApi/Api/AdminInviteRequests.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminInviteRequestsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsApprove(AdminInviteRequestsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `InviteRequestId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsApproveRequest` | `src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsApproveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsDeny

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsDeny(AdminInviteRequestsDenyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `InviteRequestId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsDenyRequest` | `src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsDenyRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminInviteRequestsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsList(AdminInviteRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsListRequest` | `src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

