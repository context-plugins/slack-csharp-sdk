<!-- Generated file — do not edit; regenerated with the SDK. -->

# FilesRemote — operations

Accessor: `client.FilesRemote` · Source: `src/SlackWebApi/Api/FilesRemote.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

