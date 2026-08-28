<!-- Generated file — do not edit; regenerated with the SDK. -->

# Pins — operations

Accessor: `client.Pins` · Source: `Api/Pins.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PinsAdd

- **Signature**: `PinsAdd(string token, ContentType contentType, string channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `timestamp` — nullable, no default → **must pass explicitly**
- **Returns**: `PinsAddschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `PinsAddschema` | `Models/PinsAddschema.cs` |

### PinsList

- **Signature**: `PinsList(string token, string channel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`, `channel` ← `channel`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |

### PinsRemove

- **Signature**: `PinsRemove(string token, ContentType contentType, string channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `timestamp` — nullable, no default → **must pass explicitly**
- **Returns**: `PinsRemoveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `PinsRemoveschema` | `Models/PinsRemoveschema.cs` |

