<!-- Generated file — do not edit; regenerated with the SDK. -->

# Bots — operations

Accessor: `client.Bots` · Source: `Api/Bots.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BotsInfo

- **Signature**: `BotsInfo(string token, string? bot, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `bot` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `bot` ← `bot`
- **Returns**: `BotsInfoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `BotsInfoschema` | `Models/BotsInfoschema.cs` |

