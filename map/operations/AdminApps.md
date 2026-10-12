<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminApps — operations

Accessor: `client.AdminApps` · Source: `src/SlackWebApi/Api/AdminApps.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprove(AdminAppsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsApproveRequest` | `src/SlackWebApi/Requests/AdminApps/AdminAppsApproveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminAppsRestrict

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrict(AdminAppsRestrictRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminAppsRestrictRequest` | `src/SlackWebApi/Requests/AdminApps/AdminAppsRestrictRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

