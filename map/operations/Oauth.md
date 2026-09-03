<!-- Generated file — do not edit; regenerated with the SDK. -->

# Oauth — operations

Accessor: `client.Oauth` · Source: `Api/Oauth.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OauthAccess

- **Auth**: `options.SlackAuth`
- **Signature**: `OauthAccess(string? clientId, string? clientSecret, string? code, string? redirectUri, bool? singleChannel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`clientId` … `singleChannel`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `client_id` ← `clientId`, `client_secret` ← `clientSecret`, `code` ← `code`, `redirect_uri` ← `redirectUri`, `single_channel` ← `singleChannel`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### OauthToken

- **Auth**: `options.SlackAuth`
- **Signature**: `OauthToken(string? clientId, string? clientSecret, string? code, string? redirectUri, bool? singleChannel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`clientId` … `singleChannel`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `client_id` ← `clientId`, `client_secret` ← `clientSecret`, `code` ← `code`, `redirect_uri` ← `redirectUri`, `single_channel` ← `singleChannel`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### OauthV2Access

- **Auth**: `options.SlackAuth`
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

