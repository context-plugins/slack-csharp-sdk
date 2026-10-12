<!-- Generated file — do not edit; regenerated with the SDK. -->

# Dnd — operations

Accessor: `client.Dnd` · Source: `src/SlackWebApi/Api/Dnd.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DndEndDnd

- **Auth**: `options.SlackAuth`
- **Signature**: `DndEndDnd(DndEndDndRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `DndEndDndschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DndEndDndRequest` | `src/SlackWebApi/Requests/Dnd/DndEndDndRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `DndEndDndschema` | `src/SlackWebApi/Models/DndEndDndschema.cs` |

### DndEndSnooze

- **Auth**: `options.SlackAuth`
- **Signature**: `DndEndSnooze(DndEndSnoozeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Returns**: `DndEndSnoozeschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DndEndSnoozeRequest` | `src/SlackWebApi/Requests/Dnd/DndEndSnoozeRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `DndEndSnoozeschema` | `src/SlackWebApi/Models/DndEndSnoozeschema.cs` |

### DndInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `DndInfo(DndInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `user` ← `User`
- **Returns**: `DndInfoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DndInfoRequest` | `src/SlackWebApi/Requests/Dnd/DndInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `DndInfoschema` | `src/SlackWebApi/Models/DndInfoschema.cs` |

### DndSetSnooze

- **Auth**: `options.SlackAuth`
- **Signature**: `DndSetSnooze(DndSetSnoozeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`, `Token`, `NumMinutes`
- **Returns**: `DndSetSnoozeschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DndSetSnoozeRequest` | `src/SlackWebApi/Requests/Dnd/DndSetSnoozeRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `DndSetSnoozeschema` | `src/SlackWebApi/Models/DndSetSnoozeschema.cs` |

### DndTeamInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `DndTeamInfo(DndTeamInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `users` ← `Users`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DndTeamInfoRequest` | `src/SlackWebApi/Requests/Dnd/DndTeamInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

