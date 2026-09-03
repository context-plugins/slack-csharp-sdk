<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminUsergroups — operations

Accessor: `client.AdminUsergroups` · Source: `Api/AdminUsergroups.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminUsergroupsAddChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddChannels(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddTeams(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `autoProvision` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsListChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsListChannels(string usergroupId, string? teamId, bool? includeNumMembers, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `includeNumMembers` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `usergroup_id` ← `usergroupId`, `team_id` ← `teamId`, `include_num_members` ← `includeNumMembers`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsRemoveChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsRemoveChannels(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

