<!-- Generated file — do not edit; regenerated with the SDK. -->

# Auth — operations

Accessor: `client.Auth` · Source: `src/SlackWebApi/Api/Auth.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AuthRevoke

- **Auth**: `options.SlackAuth`
- **Signature**: `AuthRevoke(AuthRevokeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `test` ← `Test`
- **Returns**: `AuthRevokeschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthRevokeRequest` | `src/SlackWebApi/Requests/Auth/AuthRevokeRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AuthRevokeschema` | `src/SlackWebApi/Models/AuthRevokeschema.cs` |

### AuthTest

- **Auth**: `options.SlackAuth`
- **Signature**: `AuthTest(AuthTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `AuthTestsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthTestRequest` | `src/SlackWebApi/Requests/Auth/AuthTestRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AuthTestsuccessschema` | `src/SlackWebApi/Models/AuthTestsuccessschema.cs` |

