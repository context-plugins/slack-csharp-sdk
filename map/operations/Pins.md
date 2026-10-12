<!-- Generated file — do not edit; regenerated with the SDK. -->

# Pins — operations

Accessor: `client.Pins` · Source: `src/SlackWebApi/Api/Pins.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PinsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `PinsAdd(PinsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`
- **Returns**: `PinsAddschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PinsAddRequest` | `src/SlackWebApi/Requests/Pins/PinsAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `PinsAddschema` | `src/SlackWebApi/Models/PinsAddschema.cs` |

### PinsList

- **Auth**: `options.SlackAuth`
- **Signature**: `PinsList(PinsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Channel`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel` ← `Channel`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PinsListRequest` | `src/SlackWebApi/Requests/Pins/PinsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |

### PinsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `PinsRemove(PinsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Channel`
- **Returns**: `PinsRemoveschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PinsRemoveRequest` | `src/SlackWebApi/Requests/Pins/PinsRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `PinsRemoveschema` | `src/SlackWebApi/Models/PinsRemoveschema.cs` |

