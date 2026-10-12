<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminConversationsEkm — operations

Accessor: `client.AdminConversationsEkm` · Source: `src/SlackWebApi/Api/AdminConversationsEkm.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminConversationsEkmListOriginalConnectedChannelInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsEkmListOriginalConnectedChannelInfo(AdminConversationsEkmListOriginalConnectedChannelInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `channel_ids` ← `ChannelIds`, `team_ids` ← `TeamIds`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminConversationsEkmListOriginalConnectedChannelInfoRequest` | `src/SlackWebApi/Requests/AdminConversationsEkm/AdminConversationsEkmListOriginalConnectedChannelInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

