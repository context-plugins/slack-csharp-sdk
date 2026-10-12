<!-- Generated file — do not edit; regenerated with the SDK. -->

# FilesComments — operations

Accessor: `client.FilesComments` · Source: `src/SlackWebApi/Api/FilesComments.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FilesCommentsDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesCommentsDelete(FilesCommentsDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `FilesCommentsDeleteschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesCommentsDeleteRequest` | `src/SlackWebApi/Requests/FilesComments/FilesCommentsDeleteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesCommentsDeleteschema` | `src/SlackWebApi/Models/FilesCommentsDeleteschema.cs` |

