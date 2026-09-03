<!-- Generated file — do not edit; regenerated with the SDK. -->

# Migration — operations

Accessor: `client.Migration` · Source: `Api/Migration.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### MigrationExchange

- **Auth**: `options.SlackAuth`
- **Signature**: `MigrationExchange(string token, string users, string? teamId, bool? toOld, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `teamId` — nullable, no default → **must pass explicitly**
  - `toOld` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `users` ← `users`, `team_id` ← `teamId`, `to_old` ← `toOld`
- **Returns**: `MigrationExchangesuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `MigrationExchangesuccessschema` | `Models/MigrationExchangesuccessschema.cs` |

