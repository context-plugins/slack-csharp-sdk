<!-- Generated file — do not edit; regenerated with the SDK. -->

# FilesComments — operations

Accessor: `client.FilesComments` · Source: `Api/FilesComments.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FilesCommentsDelete

- **Signature**: `FilesCommentsDelete(ContentType contentType, string? token, string? file, string? id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
  - `id` — nullable, no default → **must pass explicitly**
- **Returns**: `FilesCommentsDeleteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesCommentsDeleteschema` | `Models/FilesCommentsDeleteschema.cs` |

