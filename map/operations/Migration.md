<!-- Generated file — do not edit; regenerated with the SDK. -->

# Migration — operations

Accessor: `client.Migration` · Source: `src/SlackWebApi/Api/Migration.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### MigrationExchange

- **Auth**: `options.SlackAuth`
- **Signature**: `MigrationExchange(MigrationExchangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Users`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `users` ← `Users`, `team_id` ← `TeamId`, `to_old` ← `ToOld`
- **Returns**: `MigrationExchangesuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MigrationExchangeRequest` | `src/SlackWebApi/Requests/Migration/MigrationExchangeRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `MigrationExchangesuccessschema` | `src/SlackWebApi/Models/MigrationExchangesuccessschema.cs` |

