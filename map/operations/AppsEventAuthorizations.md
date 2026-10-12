<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsEventAuthorizations — operations

Accessor: `client.AppsEventAuthorizations` · Source: `src/SlackWebApi/Api/AppsEventAuthorizations.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsEventAuthorizationsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsEventAuthorizationsList(AppsEventAuthorizationsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EventContext`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `event_context` ← `EventContext`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsEventAuthorizationsListRequest` | `src/SlackWebApi/Requests/AppsEventAuthorizations/AppsEventAuthorizationsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

