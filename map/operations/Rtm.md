<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rtm — operations

Accessor: `client.Rtm` · Source: `Api/Rtm.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RtmConnect

- **Auth**: `options.SlackAuth`
- **Signature**: `RtmConnect(string token, bool? batchPresenceAware, bool? presenceSub, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `batchPresenceAware` — nullable, no default → **must pass explicitly**
  - `presenceSub` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `batch_presence_aware` ← `batchPresenceAware`, `presence_sub` ← `presenceSub`
- **Returns**: `RtmConnectschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `RtmConnectschema` | `Models/RtmConnectschema.cs` |

