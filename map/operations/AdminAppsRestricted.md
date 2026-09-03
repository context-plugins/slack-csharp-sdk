<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminAppsRestricted — operations

Accessor: `client.AdminAppsRestricted` · Source: `Api/AdminAppsRestricted.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminAppsRestrictedList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminAppsRestrictedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`limit` … `enterpriseId`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `limit` ← `limit`, `cursor` ← `cursor`, `team_id` ← `teamId`, `enterprise_id` ← `enterpriseId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

