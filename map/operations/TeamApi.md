<!-- Generated file — do not edit; regenerated with the SDK. -->

# TeamApi — operations

Accessor: `client.TeamApi` · Source: `Api/TeamApi.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TeamAccessLogs

- **Signature**: `TeamAccessLogs(string token, string? before, string? count, string? page, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `before` — nullable, no default → **must pass explicitly**
  - `count` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `before` ← `before`, `count` ← `count`, `page` ← `page`
- **Returns**: `TeamAccessLogsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `TeamAccessLogsschema` | `Models/TeamAccessLogsschema.cs` |

### TeamBillableInfo

- **Signature**: `TeamBillableInfo(string token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `user` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `user` ← `user`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### TeamInfo

- **Signature**: `TeamInfo(string token, string? team, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `team` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `team` ← `team`
- **Returns**: `TeamInfoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `TeamInfoschema` | `Models/TeamInfoschema.cs` |

### TeamIntegrationLogs

- **Signature**: `TeamIntegrationLogs(string token, string? appId, string? changeType, string? count, string? page, string? serviceId, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`appId` … `user`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `app_id` ← `appId`, `change_type` ← `changeType`, `count` ← `count`, `page` ← `page`, `service_id` ← `serviceId`, `user` ← `user`
- **Returns**: `TeamIntegrationLogsschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `TeamIntegrationLogsschema` | `Models/TeamIntegrationLogsschema.cs` |

### TeamProfileGet

- **Signature**: `TeamProfileGet(string token, string? visibility, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `visibility` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `visibility` ← `visibility`
- **Returns**: `TeamProfileGetsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `TeamProfileGetsuccessschema` | `Models/TeamProfileGetsuccessschema.cs` |

