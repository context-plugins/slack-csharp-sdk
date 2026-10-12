<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminInviteRequestsDenied — operations

Accessor: `client.AdminInviteRequestsDenied` · Source: `src/SlackWebApi/Api/AdminInviteRequestsDenied.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminInviteRequestsDeniedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminInviteRequestsDeniedList(AdminInviteRequestsDeniedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminInviteRequestsDeniedListRequest` | `src/SlackWebApi/Requests/AdminInviteRequestsDenied/AdminInviteRequestsDeniedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

