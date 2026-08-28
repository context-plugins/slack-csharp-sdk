<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeamsSettings — operations

Accessor: `client.AdminTeamsSettings` · Source: `Api/AdminTeamsSettings.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsSettingsInfo

- **Signature**: `AdminTeamsSettingsInfo(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `team_id` ← `teamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDefaultChannels

- **Signature**: `AdminTeamsSettingsSetDefaultChannels(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDescription

- **Signature**: `AdminTeamsSettingsSetDescription(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDiscoverability

- **Signature**: `AdminTeamsSettingsSetDiscoverability(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetIcon

- **Signature**: `AdminTeamsSettingsSetIcon(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetName

- **Signature**: `AdminTeamsSettingsSetName(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

