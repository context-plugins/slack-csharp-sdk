<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminEmoji — operations

Accessor: `client.AdminEmoji` · Source: `src/SlackWebApi/Api/AdminEmoji.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminEmojiAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiAdd(AdminEmojiAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`, `Url`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiAddRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiAddAlias

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiAddAlias(AdminEmojiAddAliasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`, `AliasFor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiAddAliasRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddAliasRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiList(AdminEmojiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiListRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiRemove(AdminEmojiRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiRemoveRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminEmojiRename

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminEmojiRename(AdminEmojiRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `Name`, `NewName`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminEmojiRenameRequest` | `src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRenameRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

