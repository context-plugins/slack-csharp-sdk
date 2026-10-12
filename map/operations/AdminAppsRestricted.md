<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminAppsRestricted — operations

Accessor: `client.AdminAppsRestricted` · Source: `src/SlackWebApi/Api/AdminAppsRestricted.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsRestrictedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrictedList(AdminAppsRestrictedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `team_id` ← `TeamId`, `enterprise_id` ← `EnterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsRestrictedListRequest` | `src/SlackWebApi/Requests/AdminAppsRestricted/AdminAppsRestrictedListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

