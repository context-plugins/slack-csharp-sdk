<!-- Generated file — do not edit; regenerated with the SDK. -->

# Oauth — operations

Accessor: `client.Oauth` · Source: `src/SlackWebApi/Api/Oauth.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OauthAccess

- **Auth**: `options.SlackAuth`
- **Signature**: `OauthAccess(OauthAccessRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `client_id` ← `ClientId`, `client_secret` ← `ClientSecret`, `code` ← `Code`, `redirect_uri` ← `RedirectUri`, `single_channel` ← `SingleChannel`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OauthAccessRequest` | `src/SlackWebApi/Requests/Oauth/OauthAccessRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### OauthToken

- **Auth**: `options.SlackAuth`
- **Signature**: `OauthToken(OauthTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `client_id` ← `ClientId`, `client_secret` ← `ClientSecret`, `code` ← `Code`, `redirect_uri` ← `RedirectUri`, `single_channel` ← `SingleChannel`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OauthTokenRequest` | `src/SlackWebApi/Requests/Oauth/OauthTokenRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### OauthV2Access

- **Auth**: `options.SlackAuth`
- **Signature**: `OauthV2Access(OauthV2AccessRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Code`, `ContentType`
- **Query params (wire ← C#)**: `code` ← `Code`, `client_id` ← `ClientId`, `client_secret` ← `ClientSecret`, `redirect_uri` ← `RedirectUri`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OauthV2AccessRequest` | `src/SlackWebApi/Requests/OauthV2/OauthV2AccessRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

