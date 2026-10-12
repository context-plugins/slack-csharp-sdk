<!-- Generated file — do not edit; regenerated with the SDK. -->

# TeamApi — operations

Accessor: `client.TeamApi` · Source: `src/SlackWebApi/Api/TeamApi.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TeamAccessLogs

- **Auth**: `options.SlackAuth`
- **Signature**: `TeamAccessLogs(TeamAccessLogsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `before` ← `Before`, `count` ← `Count`, `page` ← `Page`
- **Returns**: `TeamAccessLogsschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TeamAccessLogsRequest` | `src/SlackWebApi/Requests/TeamApi/TeamAccessLogsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `TeamAccessLogsschema` | `src/SlackWebApi/Models/TeamAccessLogsschema.cs` |

### TeamBillableInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `TeamBillableInfo(TeamBillableInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `user` ← `User`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TeamBillableInfoRequest` | `src/SlackWebApi/Requests/TeamApi/TeamBillableInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### TeamInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `TeamInfo(TeamInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `team` ← `Team`
- **Returns**: `TeamInfoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TeamInfoRequest` | `src/SlackWebApi/Requests/TeamApi/TeamInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `TeamInfoschema` | `src/SlackWebApi/Models/TeamInfoschema.cs` |

### TeamIntegrationLogs

- **Auth**: `options.SlackAuth`
- **Signature**: `TeamIntegrationLogs(TeamIntegrationLogsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `app_id` ← `AppId`, `change_type` ← `ChangeType`, `count` ← `Count`, `page` ← `Page`, `service_id` ← `ServiceId`, `user` ← `User`
- **Returns**: `TeamIntegrationLogsschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TeamIntegrationLogsRequest` | `src/SlackWebApi/Requests/TeamApi/TeamIntegrationLogsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `TeamIntegrationLogsschema` | `src/SlackWebApi/Models/TeamIntegrationLogsschema.cs` |

### TeamProfileGet

- **Auth**: `options.SlackAuth`
- **Signature**: `TeamProfileGet(TeamProfileGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `visibility` ← `Visibility`
- **Returns**: `TeamProfileGetsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TeamProfileGetRequest` | `src/SlackWebApi/Requests/TeamProfile/TeamProfileGetRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `TeamProfileGetsuccessschema` | `src/SlackWebApi/Models/TeamProfileGetsuccessschema.cs` |

