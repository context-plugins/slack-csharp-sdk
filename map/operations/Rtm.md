<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rtm — operations

Accessor: `client.Rtm` · Source: `src/SlackWebApi/Api/Rtm.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RtmConnect

- **Auth**: `options.SlackAuth`
- **Signature**: `RtmConnect(RtmConnectRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `batch_presence_aware` ← `BatchPresenceAware`, `presence_sub` ← `PresenceSub`
- **Returns**: `RtmConnectschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RtmConnectRequest` | `src/SlackWebApi/Requests/Rtm/RtmConnectRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `RtmConnectschema` | `src/SlackWebApi/Models/RtmConnectschema.cs` |

