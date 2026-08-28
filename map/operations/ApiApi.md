<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiApi — operations

Accessor: `client.ApiApi` · Source: `Api/ApiApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ApiTest

- **Signature**: `ApiTest(string? error, string? foo, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `error` — nullable, no default → **must pass explicitly**
  - `foo` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `error` ← `error`, `foo` ← `foo`
- **Returns**: `ApiTestsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ApiTestsuccessschema` | `Models/ApiTestsuccessschema.cs` |

