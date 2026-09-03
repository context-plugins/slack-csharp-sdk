<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminApps — operations

Accessor: `client.AdminApps` · Source: `Api/AdminApps.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsApprove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsApprove(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `appId` — nullable, no default → **must pass explicitly**
  - `requestId` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminAppsRestrict

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrict(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `appId` — nullable, no default → **must pass explicitly**
  - `requestId` — nullable, no default → **must pass explicitly**
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

