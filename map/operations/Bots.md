<!-- Generated file — do not edit; regenerated with the SDK. -->

# Bots — operations

Accessor: `client.Bots` · Source: `src/SlackWebApi/Api/Bots.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BotsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `BotsInfo(BotsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `bot` ← `Bot`
- **Returns**: `BotsInfoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BotsInfoRequest` | `src/SlackWebApi/Requests/Bots/BotsInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `BotsInfoschema` | `src/SlackWebApi/Models/BotsInfoschema.cs` |

