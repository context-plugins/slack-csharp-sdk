<!-- Generated file — do not edit; regenerated with the SDK. -->

# TeamProfile — operations

Accessor: `client.TeamProfile` · Source: `src/SlackWebApi/Api/TeamProfile.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

