<!-- Generated file — do not edit; regenerated with the SDK. -->

# TeamProfile — operations

Accessor: `client.TeamProfile` · Source: `Api/TeamProfile.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TeamProfileGet

- **Auth**: `options.SlackAuth`
- **Signature**: `TeamProfileGet(string token, string? visibility, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibility` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `visibility` ← `visibility`
- **Returns**: `TeamProfileGetsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `TeamProfileGetsuccessschema` | `Models/TeamProfileGetsuccessschema.cs` |

