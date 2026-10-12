<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersProfile — operations

Accessor: `client.UsersProfile` · Source: `src/SlackWebApi/Api/UsersProfile.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsersProfileGet

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersProfileGet(UsersProfileGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `include_labels` ← `IncludeLabels`, `user` ← `User`
- **Returns**: `UsersProfileGetschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersProfileGetRequest` | `src/SlackWebApi/Requests/UsersProfile/UsersProfileGetRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersProfileGetschema` | `src/SlackWebApi/Models/UsersProfileGetschema.cs` |

### UsersProfileSet

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersProfileSet(UsersProfileSetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `UsersProfileSetschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersProfileSetRequest` | `src/SlackWebApi/Requests/UsersProfile/UsersProfileSetRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersProfileSetschema` | `src/SlackWebApi/Models/UsersProfileSetschema.cs` |

