<!-- Generated file — do not edit; regenerated with the SDK. -->

# Views — operations

Accessor: `client.Views` · Source: `src/SlackWebApi/Api/Views.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ViewsOpen

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsOpen(ViewsOpenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`, `View`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `trigger_id` ← `TriggerId`, `view` ← `View`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ViewsOpenRequest` | `src/SlackWebApi/Requests/Views/ViewsOpenRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### ViewsPublish

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsPublish(ViewsPublishRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UserId`, `View`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `user_id` ← `UserId`, `view` ← `View`, `hash` ← `Hash`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ViewsPublishRequest` | `src/SlackWebApi/Requests/Views/ViewsPublishRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### ViewsPush

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsPush(ViewsPushRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`, `View`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `trigger_id` ← `TriggerId`, `view` ← `View`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ViewsPushRequest` | `src/SlackWebApi/Requests/Views/ViewsPushRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### ViewsUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsUpdate(ViewsUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `view_id` ← `ViewId`, `external_id` ← `ExternalId`, `view` ← `View`, `hash` ← `Hash`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ViewsUpdateRequest` | `src/SlackWebApi/Requests/Views/ViewsUpdateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

