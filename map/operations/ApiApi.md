<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiApi — operations

Accessor: `client.ApiApi` · Source: `src/SlackWebApi/Api/ApiApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ApiTest

- **Auth**: `options.SlackAuth`
- **Signature**: `ApiTest(ApiTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `error` ← `Error`, `foo` ← `Foo`
- **Returns**: `ApiTestsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiTestRequest` | `src/SlackWebApi/Requests/ApiApi/ApiTestRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ApiTestsuccessschema` | `src/SlackWebApi/Models/ApiTestsuccessschema.cs` |

