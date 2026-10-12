<!-- Generated file — do not edit; regenerated with the SDK. -->

# Files — operations

Accessor: `client.Files` · Source: `src/SlackWebApi/Api/Files.cs` · 13 operations

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

### FilesDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesDelete(FilesDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `FilesDeleteschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesDeleteRequest` | `src/SlackWebApi/Requests/Files/FilesDeleteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesDeleteschema` | `src/SlackWebApi/Models/FilesDeleteschema.cs` |

### FilesInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesInfo(FilesInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `file` ← `File`, `count` ← `Count`, `page` ← `Page`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `FilesInfoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesInfoRequest` | `src/SlackWebApi/Requests/Files/FilesInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesInfoschema` | `src/SlackWebApi/Models/FilesInfoschema.cs` |

### FilesList

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesList(FilesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `user` ← `User`, `channel` ← `Channel`, `ts_from` ← `TsFrom`, `ts_to` ← `TsTo`, `types` ← `Types`, `count` ← `Count`, `page` ← `Page`, `show_files_hidden_by_limit` ← `ShowFilesHiddenByLimit`
- **Returns**: `FilesListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesListRequest` | `src/SlackWebApi/Requests/Files/FilesListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesListschema` | `src/SlackWebApi/Models/FilesListschema.cs` |

### FilesRemoteAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRemoteAdd(FilesRemoteAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRemoteAddRequest` | `src/SlackWebApi/Requests/FilesRemote/FilesRemoteAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### FilesRemoteInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRemoteInfo(FilesRemoteInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `file` ← `File`, `external_id` ← `ExternalId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRemoteInfoRequest` | `src/SlackWebApi/Requests/FilesRemote/FilesRemoteInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### FilesRemoteList

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRemoteList(FilesRemoteListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `ts_from` ← `TsFrom`, `ts_to` ← `TsTo`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRemoteListRequest` | `src/SlackWebApi/Requests/FilesRemote/FilesRemoteListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### FilesRemoteRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRemoteRemove(FilesRemoteRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRemoteRemoveRequest` | `src/SlackWebApi/Requests/FilesRemote/FilesRemoteRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### FilesRemoteShare

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRemoteShare(FilesRemoteShareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `file` ← `File`, `external_id` ← `ExternalId`, `channels` ← `Channels`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRemoteShareRequest` | `src/SlackWebApi/Requests/FilesRemote/FilesRemoteShareRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### FilesRemoteUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRemoteUpdate(FilesRemoteUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRemoteUpdateRequest` | `src/SlackWebApi/Requests/FilesRemote/FilesRemoteUpdateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### FilesRevokePublicUrl

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesRevokePublicUrl(FilesRevokePublicUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `FilesRevokePublicUrLschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesRevokePublicUrlRequest` | `src/SlackWebApi/Requests/Files/FilesRevokePublicUrlRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesRevokePublicUrLschema` | `src/SlackWebApi/Models/FilesRevokePublicUrLschema.cs` |

### FilesSharedPublicUrl

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesSharedPublicUrl(FilesSharedPublicUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `FilesSharedPublicUrLschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesSharedPublicUrlRequest` | `src/SlackWebApi/Requests/Files/FilesSharedPublicUrlRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesSharedPublicUrLschema` | `src/SlackWebApi/Models/FilesSharedPublicUrLschema.cs` |

### FilesUpload

- **Auth**: `options.SlackAuth`
- **Signature**: `FilesUpload(FilesUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `FilesUploadschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FilesUploadRequest` | `src/SlackWebApi/Requests/Files/FilesUploadRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `FilesUploadschema` | `src/SlackWebApi/Models/FilesUploadschema.cs` |

