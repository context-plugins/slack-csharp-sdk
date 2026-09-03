<!-- Generated file — do not edit; regenerated with the SDK. -->

# CallsParticipants — operations

Accessor: `client.CallsParticipants` · Source: `Api/CallsParticipants.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CallsParticipantsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsParticipantsAdd(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### CallsParticipantsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsParticipantsRemove(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

