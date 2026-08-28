<!-- Generated file — do not edit; regenerated with the SDK. -->

# FilesRemote — operations

Accessor: `client.FilesRemote` · Source: `Api/FilesRemote.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FilesRemoteAdd

- **Signature**: `FilesRemoteAdd(ContentType contentType, string? token, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`token` … `indexableFileContents`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### FilesRemoteInfo

- **Signature**: `FilesRemoteInfo(string? token, string? file, string? externalId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
  - `externalId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `file` ← `file`, `external_id` ← `externalId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### FilesRemoteList

- **Signature**: `FilesRemoteList(string? token, string? channel, double? tsFrom, double? tsTo, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`, `ts_from` ← `tsFrom`, `ts_to` ← `tsTo`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### FilesRemoteRemove

- **Signature**: `FilesRemoteRemove(ContentType contentType, string? token, string? file, string? externalId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
  - `externalId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### FilesRemoteShare

- **Signature**: `FilesRemoteShare(string? token, string? file, string? externalId, string? channels, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`token` … `channels`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `file` ← `file`, `external_id` ← `externalId`, `channels` ← `channels`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### FilesRemoteUpdate

- **Signature**: `FilesRemoteUpdate(ContentType contentType, string? token, string? file, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`token` … `indexableFileContents`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

