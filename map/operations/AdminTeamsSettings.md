<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminTeamsSettings — operations

Accessor: `client.AdminTeamsSettings` · Source: `src/SlackWebApi/Api/AdminTeamsSettings.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminTeamsSettingsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsInfo(AdminTeamsSettingsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsInfoRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDefaultChannels

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDefaultChannels(AdminTeamsSettingsSetDefaultChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `TeamId`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetDefaultChannelsRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDefaultChannelsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDescription

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDescription(AdminTeamsSettingsSetDescriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Description`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetDescriptionRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDescriptionRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetDiscoverability

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetDiscoverability(AdminTeamsSettingsSetDiscoverabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Discoverability`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetDiscoverabilityRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDiscoverabilityRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetIcon

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetIcon(AdminTeamsSettingsSetIconRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `ImageUrl`, `TeamId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetIconRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetIconRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminTeamsSettingsSetName

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminTeamsSettingsSetName(AdminTeamsSettingsSetNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Name`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminTeamsSettingsSetNameRequest` | `src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetNameRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

