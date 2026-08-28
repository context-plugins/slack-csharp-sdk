<!-- Generated file — do not edit; regenerated with the SDK. -->

# Files — operations

Accessor: `client.Files` · Source: `Api/Files.cs` · 13 operations

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

### FilesDelete

- **Signature**: `FilesDelete(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
- **Returns**: `FilesDeleteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesDeleteschema` | `Models/FilesDeleteschema.cs` |

### FilesInfo

- **Signature**: `FilesInfo(string? token, string? file, string? count, string? page, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `file` ← `file`, `count` ← `count`, `page` ← `page`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `FilesInfoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesInfoschema` | `Models/FilesInfoschema.cs` |

### FilesList

- **Signature**: `FilesList(string? token, string? user, string? channel, double? tsFrom, double? tsTo, string? types, string? count, string? page, bool? showFilesHiddenByLimit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`token` … `showFilesHiddenByLimit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `user` ← `user`, `channel` ← `channel`, `ts_from` ← `tsFrom`, `ts_to` ← `tsTo`, `types` ← `types`, `count` ← `count`, `page` ← `page`, `show_files_hidden_by_limit` ← `showFilesHiddenByLimit`
- **Returns**: `FilesListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesListschema` | `Models/FilesListschema.cs` |

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

### FilesRevokePublicUrl

- **Signature**: `FilesRevokePublicUrl(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
- **Returns**: `FilesRevokePublicUrLschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesRevokePublicUrLschema` | `Models/FilesRevokePublicUrLschema.cs` |

### FilesSharedPublicUrl

- **Signature**: `FilesSharedPublicUrl(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
- **Returns**: `FilesSharedPublicUrLschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesSharedPublicUrLschema` | `Models/FilesSharedPublicUrLschema.cs` |

### FilesUpload

- **Signature**: `FilesUpload(ContentType contentType, string? token, string? file, string? content, string? filetype, string? filename, string? title, string? initialComment, string? channels, double? threadTs, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`token` … `threadTs`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `FilesUploadschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `FilesUploadschema` | `Models/FilesUploadschema.cs` |

