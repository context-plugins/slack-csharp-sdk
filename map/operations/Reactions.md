<!-- Generated file — do not edit; regenerated with the SDK. -->

# Reactions — operations

Accessor: `client.Reactions` · Source: `src/SlackWebApi/Api/Reactions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ReactionsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `ReactionsAdd(ReactionsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`, `Name`, `Timestamp`
- **Returns**: `ReactionsAddschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReactionsAddRequest` | `src/SlackWebApi/Requests/Reactions/ReactionsAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ReactionsAddschema` | `src/SlackWebApi/Models/ReactionsAddschema.cs` |

### ReactionsGet

- **Auth**: `options.SlackAuth`
- **Signature**: `ReactionsGet(ReactionsGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`, `file` ← `File`, `file_comment` ← `FileComment`, `full` ← `Full`, `timestamp` ← `Timestamp`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReactionsGetRequest` | `src/SlackWebApi/Requests/Reactions/ReactionsGetRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |

### ReactionsList

- **Auth**: `options.SlackAuth`
- **Signature**: `ReactionsList(ReactionsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `user` ← `User`, `full` ← `Full`, `count` ← `Count`, `page` ← `Page`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ReactionsListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReactionsListRequest` | `src/SlackWebApi/Requests/Reactions/ReactionsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ReactionsListschema` | `src/SlackWebApi/Models/ReactionsListschema.cs` |

### ReactionsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `ReactionsRemove(ReactionsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Name`
- **Returns**: `ReactionsRemoveschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReactionsRemoveRequest` | `src/SlackWebApi/Requests/Reactions/ReactionsRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ReactionsRemoveschema` | `src/SlackWebApi/Models/ReactionsRemoveschema.cs` |

