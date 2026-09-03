<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminConversationsEkm — operations

Accessor: `client.AdminConversationsEkm` · Source: `Api/AdminConversationsEkm.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminConversationsEkmListOriginalConnectedChannelInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminConversationsEkmListOriginalConnectedChannelInfo(string token, string? channelIds, string? teamIds, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`channelIds` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `channel_ids` ← `channelIds`, `team_ids` ← `teamIds`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

