<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminUsersSession — operations

Accessor: `client.AdminUsersSession` · Source: `Api/AdminUsersSession.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminUsersSessionInvalidate

- **Signature**: `AdminUsersSessionInvalidate(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsersSessionReset

- **Signature**: `AdminUsersSessionReset(string token, ContentType contentType, string userId, bool? mobileOnly, bool? webOnly, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `mobileOnly` — nullable, no default → **must pass explicitly**
  - `webOnly` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

