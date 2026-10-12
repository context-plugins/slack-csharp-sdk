<!-- Generated file — do not edit; regenerated with the SDK. -->

# Users — operations

Accessor: `client.Users` · Source: `src/SlackWebApi/Api/Users.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsersConversations

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersConversations(UsersConversationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `user` ← `User`, `types` ← `Types`, `exclude_archived` ← `ExcludeArchived`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `UsersConversationssuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersConversationsRequest` | `src/SlackWebApi/Requests/Users/UsersConversationsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersConversationssuccessschema` | `src/SlackWebApi/Models/UsersConversationssuccessschema.cs` |

### UsersDeletePhoto

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersDeletePhoto(UsersDeletePhotoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`
- **Returns**: `UsersDeletePhotoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersDeletePhotoRequest` | `src/SlackWebApi/Requests/Users/UsersDeletePhotoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersDeletePhotoschema` | `src/SlackWebApi/Models/UsersDeletePhotoschema.cs` |

### UsersGetPresence

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersGetPresence(UsersGetPresenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `user` ← `User`
- **Returns**: `ApImethodusersGetPresence`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersGetPresenceRequest` | `src/SlackWebApi/Requests/Users/UsersGetPresenceRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ApImethodusersGetPresence` | `src/SlackWebApi/Models/ApImethodusersGetPresence.cs` |

### UsersIdentity

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersIdentity(UsersIdentityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersIdentityRequest` | `src/SlackWebApi/Requests/Users/UsersIdentityRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |

### UsersInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersInfo(UsersInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `include_locale` ← `IncludeLocale`, `user` ← `User`
- **Returns**: `UsersInfosuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersInfoRequest` | `src/SlackWebApi/Requests/Users/UsersInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersInfosuccessschema` | `src/SlackWebApi/Models/UsersInfosuccessschema.cs` |

### UsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersList(UsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `limit` ← `Limit`, `cursor` ← `Cursor`, `include_locale` ← `IncludeLocale`
- **Returns**: `UsersListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersListRequest` | `src/SlackWebApi/Requests/Users/UsersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersListschema` | `src/SlackWebApi/Models/UsersListschema.cs` |

### UsersLookupByEmail

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersLookupByEmail(UsersLookupByEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Email`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `email` ← `Email`
- **Returns**: `UsersLookupByEmailsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersLookupByEmailRequest` | `src/SlackWebApi/Requests/Users/UsersLookupByEmailRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersLookupByEmailsuccessschema` | `src/SlackWebApi/Models/UsersLookupByEmailsuccessschema.cs` |

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

### UsersSetActive

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersSetActive(UsersSetActiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `UsersSetActiveschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersSetActiveRequest` | `src/SlackWebApi/Requests/Users/UsersSetActiveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersSetActiveschema` | `src/SlackWebApi/Models/UsersSetActiveschema.cs` |

### UsersSetPhoto

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersSetPhoto(UsersSetPhotoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`
- **Returns**: `UsersSetPhotoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersSetPhotoRequest` | `src/SlackWebApi/Requests/Users/UsersSetPhotoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersSetPhotoschema` | `src/SlackWebApi/Models/UsersSetPhotoschema.cs` |

### UsersSetPresence

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersSetPresence(UsersSetPresenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Presence`
- **Returns**: `UsersSetPresenceschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersSetPresenceRequest` | `src/SlackWebApi/Requests/Users/UsersSetPresenceRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsersSetPresenceschema` | `src/SlackWebApi/Models/UsersSetPresenceschema.cs` |

