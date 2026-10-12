<!-- Generated file — do not edit; regenerated with the SDK. -->

# Calls — operations

Accessor: `client.Calls` · Source: `src/SlackWebApi/Api/Calls.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CallsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsAdd(CallsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `ExternalUniqueId`, `JoinUrl`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CallsAddRequest` | `src/SlackWebApi/Requests/Calls/CallsAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### CallsEnd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsEnd(CallsEndRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Id`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CallsEndRequest` | `src/SlackWebApi/Requests/Calls/CallsEndRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### CallsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsInfo(CallsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `id` ← `Id`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CallsInfoRequest` | `src/SlackWebApi/Requests/Calls/CallsInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### CallsParticipantsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsParticipantsAdd(CallsParticipantsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Id`, `Users`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CallsParticipantsAddRequest` | `src/SlackWebApi/Requests/CallsParticipants/CallsParticipantsAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### CallsParticipantsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsParticipantsRemove(CallsParticipantsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Id`, `Users`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CallsParticipantsRemoveRequest` | `src/SlackWebApi/Requests/CallsParticipants/CallsParticipantsRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### CallsUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsUpdate(CallsUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Id`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CallsUpdateRequest` | `src/SlackWebApi/Requests/Calls/CallsUpdateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

