<!-- Generated file — do not edit; regenerated with the SDK. -->

# Search — operations

Accessor: `client.Search` · Source: `src/SlackWebApi/Api/Search.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SearchMessages

- **Auth**: `options.SlackAuth`
- **Signature**: `SearchMessages(SearchMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Query`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `query` ← `Query`, `count` ← `Count`, `highlight` ← `Highlight`, `page` ← `Page`, `sort` ← `Sort`, `sort_dir` ← `SortDir`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchMessagesRequest` | `src/SlackWebApi/Requests/Search/SearchMessagesRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

