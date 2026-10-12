<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminConversationsRestrictAccess — operations

Accessor: `client.AdminConversationsRestrictAccess` · Source: `src/SlackWebApi/Api/AdminConversationsRestrictAccess.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminConversationsRestrictAccessAddGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessAddGroup(AdminConversationsRestrictAccessAddGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `GroupId`, `ChannelId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRestrictAccessAddGroupRequest` | `src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessAddGroupRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessListGroups

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessListGroups(AdminConversationsRestrictAccessListGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ChannelId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel_id` ← `ChannelId`, `team_id` ← `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRestrictAccessListGroupsRequest` | `src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessListGroupsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminConversationsRestrictAccessRemoveGroup

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsRestrictAccessRemoveGroup(AdminConversationsRestrictAccessRemoveGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `TeamId`, `GroupId`, `ChannelId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsRestrictAccessRemoveGroupRequest` | `src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessRemoveGroupRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

