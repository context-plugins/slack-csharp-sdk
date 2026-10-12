<!-- Generated file — do not edit; regenerated with the SDK. -->

# CallsParticipants — operations

Accessor: `client.CallsParticipants` · Source: `src/SlackWebApi/Api/CallsParticipants.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

