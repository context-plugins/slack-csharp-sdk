<!-- Generated file — do not edit; regenerated with the SDK. -->

# Stars — operations

Accessor: `client.Stars` · Source: `src/SlackWebApi/Api/Stars.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### StarsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `StarsAdd(StarsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `StarsAddschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StarsAddRequest` | `src/SlackWebApi/Requests/Stars/StarsAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `StarsAddschema` | `src/SlackWebApi/Models/StarsAddschema.cs` |

### StarsList

- **Auth**: `options.SlackAuth`
- **Signature**: `StarsList(StarsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `count` ← `Count`, `page` ← `Page`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `StarsListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StarsListRequest` | `src/SlackWebApi/Requests/Stars/StarsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `StarsListschema` | `src/SlackWebApi/Models/StarsListschema.cs` |

### StarsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `StarsRemove(StarsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `StarsRemoveschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StarsRemoveRequest` | `src/SlackWebApi/Requests/Stars/StarsRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `StarsRemoveschema` | `src/SlackWebApi/Models/StarsRemoveschema.cs` |

