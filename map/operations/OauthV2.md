<!-- Generated file — do not edit; regenerated with the SDK. -->

# OauthV2 — operations

Accessor: `client.OauthV2` · Source: `src/SlackWebApi/Api/OauthV2.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

