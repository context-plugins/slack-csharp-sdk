<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersProfile — operations

Accessor: `client.UsersProfile` · Source: `Api/UsersProfile.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsersProfileGet

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersProfileGet(string token, bool? includeLabels, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeLabels` — nullable, no default → **must pass explicitly**
  - `user` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `include_labels` ← `includeLabels`, `user` ← `user`
- **Returns**: `UsersProfileGetschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersProfileGetschema` | `Models/UsersProfileGetschema.cs` |

### UsersProfileSet

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersProfileSet(string token, ContentType contentType, string? name, string? profile, string? user, string? value, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`name` … `value`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `UsersProfileSetschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersProfileSetschema` | `Models/UsersProfileSetschema.cs` |

