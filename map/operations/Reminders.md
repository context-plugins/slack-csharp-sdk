<!-- Generated file — do not edit; regenerated with the SDK. -->

# Reminders — operations

Accessor: `client.Reminders` · Source: `src/SlackWebApi/Api/Reminders.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RemindersAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersAdd(RemindersAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Text`, `Time`
- **Returns**: `RemindersAddschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemindersAddRequest` | `src/SlackWebApi/Requests/Reminders/RemindersAddRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `RemindersAddschema` | `src/SlackWebApi/Models/RemindersAddschema.cs` |

### RemindersComplete

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersComplete(RemindersCompleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `RemindersCompleteschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemindersCompleteRequest` | `src/SlackWebApi/Requests/Reminders/RemindersCompleteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `RemindersCompleteschema` | `src/SlackWebApi/Models/RemindersCompleteschema.cs` |

### RemindersDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersDelete(RemindersDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Returns**: `RemindersDeleteschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemindersDeleteRequest` | `src/SlackWebApi/Requests/Reminders/RemindersDeleteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `RemindersDeleteschema` | `src/SlackWebApi/Models/RemindersDeleteschema.cs` |

### RemindersInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersInfo(RemindersInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `reminder` ← `Reminder`
- **Returns**: `RemindersInfoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemindersInfoRequest` | `src/SlackWebApi/Requests/Reminders/RemindersInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `RemindersInfoschema` | `src/SlackWebApi/Models/RemindersInfoschema.cs` |

### RemindersList

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersList(RemindersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `RemindersListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemindersListRequest` | `src/SlackWebApi/Requests/Reminders/RemindersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `RemindersListschema` | `src/SlackWebApi/Models/RemindersListschema.cs` |

