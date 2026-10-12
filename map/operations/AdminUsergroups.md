<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminUsergroups — operations

Accessor: `client.AdminUsergroups` · Source: `src/SlackWebApi/Api/AdminUsergroups.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminUsergroupsAddChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddChannels(AdminUsergroupsAddChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UsergroupId`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsAddChannelsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsAddTeams

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsAddTeams(AdminUsergroupsAddTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UsergroupId`, `TeamIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsAddTeamsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddTeamsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsListChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsListChannels(AdminUsergroupsListChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UsergroupId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `usergroup_id` ← `UsergroupId`, `team_id` ← `TeamId`, `include_num_members` ← `IncludeNumMembers`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsListChannelsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsListChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsergroupsRemoveChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsergroupsRemoveChannels(AdminUsergroupsRemoveChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `UsergroupId`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsergroupsRemoveChannelsRequest` | `src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsRemoveChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

