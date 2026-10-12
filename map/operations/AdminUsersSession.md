<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminUsersSession — operations

Accessor: `client.AdminUsersSession` · Source: `src/SlackWebApi/Api/AdminUsersSession.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminUsersSessionInvalidate

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSessionInvalidate(AdminUsersSessionInvalidateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `SessionId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSessionInvalidateRequest` | `src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionInvalidateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionReset

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSessionReset(AdminUsersSessionResetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSessionResetRequest` | `src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionResetRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

