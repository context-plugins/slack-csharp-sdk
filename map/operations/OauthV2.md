<!-- Generated file — do not edit; regenerated with the SDK. -->

# OauthV2 — operations

Accessor: `client.OauthV2` · Source: `Api/OauthV2.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OauthV2Access

- **Signature**: `OauthV2Access(string code, string? clientId, string? clientSecret, string? redirectUri, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `clientId` — nullable, no default → **must pass explicitly**
  - `clientSecret` — nullable, no default → **must pass explicitly**
  - `redirectUri` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `code` ← `code`, `client_id` ← `clientId`, `client_secret` ← `clientSecret`, `redirect_uri` ← `redirectUri`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

