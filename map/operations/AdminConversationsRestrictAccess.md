<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminConversationsRestrictAccess — operations

Accessor: `client.AdminConversationsRestrictAccess` · Source: `Api/AdminConversationsRestrictAccess.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminConversationsRestrictAccessAddGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessAddGroup(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessListGroups

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessListGroups(string token, string channelId, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `channel_id` ← `channelId`, `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessRemoveGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessRemoveGroup(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

