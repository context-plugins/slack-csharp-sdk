<!-- Generated file — do not edit; regenerated with the SDK. -->

# Emoji — operations

Accessor: `client.Emoji` · Source: `src/SlackWebApi/Api/Emoji.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EmojiList

- **Auth**: `options.SlackAuth`
- **Signature**: `EmojiList(EmojiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmojiListRequest` | `src/SlackWebApi/Requests/Emoji/EmojiListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

