<!-- Generated file — do not edit; regenerated with the SDK. -->

# Auth — operations

Accessor: `client.Auth` · Source: `Api/Auth.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AuthRevoke

- **Signature**: `AuthRevoke(string token, bool? test, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `test` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `test` ← `test`
- **Returns**: `AuthRevokeschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AuthRevokeschema` | `Models/AuthRevokeschema.cs` |

### AuthTest

- **Signature**: `AuthTest(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AuthTestsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AuthTestsuccessschema` | `Models/AuthTestsuccessschema.cs` |

