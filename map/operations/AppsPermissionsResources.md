<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissionsResources — operations

Accessor: `client.AppsPermissionsResources` · Source: `src/SlackWebApi/Api/AppsPermissionsResources.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsPermissionsResourcesList

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsResourcesList(AppsPermissionsResourcesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `AppsPermissionsResourcesListsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsResourcesListRequest` | `src/SlackWebApi/Requests/AppsPermissionsResources/AppsPermissionsResourcesListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AppsPermissionsResourcesListsuccessschema` | `src/SlackWebApi/Models/AppsPermissionsResourcesListsuccessschema.cs` |

