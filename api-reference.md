# Reference

> Source: [SlackClient](SlackClient.cs)

## Admin

> Source: [Admin](Api/Admin.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprove(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsApprove(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsApprove1(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsApprove1(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprovedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List approved apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsApprovedList(token, limit, cursor, teamId, enterpriseId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsApprovedList1(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List approved apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsApprovedList1(token, limit, cursor, teamId, enterpriseId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRequestsList(string token, int? limit, string? cursor, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List app requests for a team/workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsRequestsList(token, limit, cursor, teamId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsRequestsList1(string token, int? limit, string? cursor, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List app requests for a team/workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsRequestsList1(token, limit, cursor, teamId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrict(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restrict an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsRestrict(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsRestrict1(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restrict an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsRestrict1(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrictedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List restricted apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsRestrictedList(token, limit, cursor, teamId, enterpriseId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsRestrictedList1(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List restricted apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminAppsRestrictedList1(token, limit, cursor, teamId, enterpriseId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsArchiveschema&gt; AdminConversationsArchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Archive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsArchive(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsArchiveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsArchiveschema](Models/AdminConversationsArchiveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsArchiveschema1&gt; AdminConversationsArchive1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Archive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsArchive1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsArchiveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsArchiveschema1](Models/AdminConversationsArchiveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsConvertToPrivateschema&gt; AdminConversationsConvertToPrivate(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert a public channel to a private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsConvertToPrivate(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsConvertToPrivateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsConvertToPrivateschema](Models/AdminConversationsConvertToPrivateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsConvertToPrivateschema1&gt; AdminConversationsConvertToPrivate1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert a public channel to a private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsConvertToPrivate1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsConvertToPrivateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsConvertToPrivateschema1](Models/AdminConversationsConvertToPrivateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsCreateschema&gt; AdminConversationsCreate(string token, ContentType contentType, string name, bool isPrivate, string? description, bool? orgWide, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a public or private channel-based conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsCreate(token,
        contentType,
        name,
        isPrivate,
        description,
        orgWide,
        teamId);
    // TODO: Handle 'response' of type AdminConversationsCreateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>isPrivate</code> | <code>bool</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>orgWide</code> | <code>bool?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsCreateschema](Models/AdminConversationsCreateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsCreateschema1&gt; AdminConversationsCreate1(string token, ContentType contentType, string name, bool isPrivate, string? description, bool? orgWide, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a public or private channel-based conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsCreate1(token,
        contentType,
        name,
        isPrivate,
        description,
        orgWide,
        teamId);
    // TODO: Handle 'response' of type AdminConversationsCreateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>isPrivate</code> | <code>bool</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>orgWide</code> | <code>bool?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsCreateschema1](Models/AdminConversationsCreateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsDeleteschema&gt; AdminConversationsDelete(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsDelete(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsDeleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsDeleteschema](Models/AdminConversationsDeleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsDeleteschema1&gt; AdminConversationsDelete1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsDelete1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsDeleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsDeleteschema1](Models/AdminConversationsDeleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema&gt; AdminConversationsDisconnectShared(string token, ContentType contentType, string channelId, string? leavingTeamIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disconnect a connected channel from one or more workspaces.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsDisconnectShared(token, contentType, channelId, leavingTeamIds);
    // TODO: Handle 'response' of type AdminConversationsRenameschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>leavingTeamIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema](Models/AdminConversationsRenameschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema2&gt; AdminConversationsDisconnectShared1(string token, ContentType contentType, string channelId, string? leavingTeamIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disconnect a connected channel from one or more workspaces.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsDisconnectShared1(token,
        contentType,
        channelId,
        leavingTeamIds);
    // TODO: Handle 'response' of type AdminConversationsRenameschema2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>leavingTeamIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema2](Models/AdminConversationsRenameschema2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsEkmListOriginalConnectedChannelInfo(string token, string? channelIds, string? teamIds, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsEkmListOriginalConnectedChannelInfo(token,
        channelIds,
        teamIds,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelIds</code> | <code>string?</code> | A comma-separated list of channels to filter to. |
| <code>teamIds</code> | <code>string?</code> | A comma-separated list of the workspaces to which the channels you would like returned belong. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsEkmListOriginalConnectedChannelInfo1(string token, string? channelIds, string? teamIds, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsEkmListOriginalConnectedChannelInfo1(token,
        channelIds,
        teamIds,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelIds</code> | <code>string?</code> | A comma-separated list of channels to filter to. |
| <code>teamIds</code> | <code>string?</code> | A comma-separated list of the workspaces to which the channels you would like returned belong. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetConversationPrefsschema&gt; AdminConversationsGetConversationPrefs(string channelId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get conversation preferences for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsGetConversationPrefs(channelId, token, contentType);
    // TODO: Handle 'response' of type AdminConversationsGetConversationPrefsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to get preferences for. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetConversationPrefsschema](Models/AdminConversationsGetConversationPrefsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetConversationPrefsschema1&gt; AdminConversationsGetConversationPrefs1(string channelId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get conversation preferences for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsGetConversationPrefs1(channelId, token, contentType);
    // TODO: Handle 'response' of type AdminConversationsGetConversationPrefsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to get preferences for. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetConversationPrefsschema1](Models/AdminConversationsGetConversationPrefsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetTeamsschema&gt; AdminConversationsGetTeams(string channelId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all the workspaces a given public or private channel is connected to within this Enterprise org.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsGetTeams(channelId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type AdminConversationsGetTeamsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to determine connected workspaces within the organization for. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetTeamsschema](Models/AdminConversationsGetTeamsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetTeamsschema1&gt; AdminConversationsGetTeams1(string channelId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all the workspaces a given public or private channel is connected to within this Enterprise org.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsGetTeams1(channelId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type AdminConversationsGetTeamsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to determine connected workspaces within the organization for. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetTeamsschema1](Models/AdminConversationsGetTeamsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsInviteschema&gt; AdminConversationsInvite(string token, ContentType contentType, string userIds, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsInvite(token, contentType, userIds, channelId);
    // TODO: Handle 'response' of type AdminConversationsInviteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userIds</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsInviteschema](Models/AdminConversationsInviteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsInviteschema1&gt; AdminConversationsInvite1(string token, ContentType contentType, string userIds, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsInvite1(token, contentType, userIds, channelId);
    // TODO: Handle 'response' of type AdminConversationsInviteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userIds</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsInviteschema1](Models/AdminConversationsInviteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema1&gt; AdminConversationsRename(string token, ContentType contentType, string channelId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRename(token, contentType, channelId, name);
    // TODO: Handle 'response' of type AdminConversationsRenameschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema1](Models/AdminConversationsRenameschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema11&gt; AdminConversationsRename1(string token, ContentType contentType, string channelId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRename1(token, contentType, channelId, name);
    // TODO: Handle 'response' of type AdminConversationsRenameschema11
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema11](Models/AdminConversationsRenameschema11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessAddGroup(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an allowlist of IDP groups for accessing a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRestrictAccessAddGroup(contentType,
        token,
        groupId,
        channelId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsRestrictAccessAddGroup1(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an allowlist of IDP groups for accessing a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRestrictAccessAddGroup1(contentType,
        token,
        groupId,
        channelId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessListGroups(string token, string channelId, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all IDP Groups linked to a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRestrictAccessListGroups(token, channelId, teamId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsRestrictAccessListGroups1(string token, string channelId, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all IDP Groups linked to a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRestrictAccessListGroups1(token,
        channelId,
        teamId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessRemoveGroup(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a linked IDP group linked from a private channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRestrictAccessRemoveGroup(contentType,
        token,
        teamId,
        groupId,
        channelId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsRestrictAccessRemoveGroup1(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a linked IDP group linked from a private channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsRestrictAccessRemoveGroup1(contentType,
        token,
        teamId,
        groupId,
        channelId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSearchschema&gt; AdminConversationsSearch(string? teamIds, string? query, int? limit, string? cursor, string? searchChannelTypes, string? sort, string? sortDir, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for public or private channels in an Enterprise organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsSearch(teamIds,
        query,
        limit,
        cursor,
        searchChannelTypes,
        sort,
        sortDir,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsSearchschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamIds</code> | <code>string?</code> | Comma separated string of team IDs, signifying the workspaces to search through. |
| <code>query</code> | <code>string?</code> | Name of the the channel to query by. |
| <code>limit</code> | <code>int?</code> | Maximum number of items to be returned. Must be between 1 - 20 both inclusive. Default is 10. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>searchChannelTypes</code> | <code>string?</code> | The type of channel to include or exclude in the search. For example `private` will search private channels, while `private_exclude` will exclude them. For a full list of types, check the [Types section](#types). |
| <code>sort</code> | <code>string?</code> | Possible values are `relevant` (search ranking based on what we think is closest), `name` (alphabetical), `member_count` (number of users in the channel), and `created` (date channel was created). You can optionally pair this with the `sort_dir` arg to change how it is sorted |
| <code>sortDir</code> | <code>string?</code> | Sort direction. Possible values are `asc` for ascending order like (1, 2, 3) or (a, b, c), and `desc` for descending order like (3, 2, 1) or (c, b, a) |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSearchschema](Models/AdminConversationsSearchschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSearchschema&gt; AdminConversationsSearch1(string? teamIds, string? query, int? limit, string? cursor, string? searchChannelTypes, string? sort, string? sortDir, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for public or private channels in an Enterprise organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsSearch1(teamIds,
        query,
        limit,
        cursor,
        searchChannelTypes,
        sort,
        sortDir,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsSearchschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamIds</code> | <code>string?</code> | Comma separated string of team IDs, signifying the workspaces to search through. |
| <code>query</code> | <code>string?</code> | Name of the the channel to query by. |
| <code>limit</code> | <code>int?</code> | Maximum number of items to be returned. Must be between 1 - 20 both inclusive. Default is 10. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>searchChannelTypes</code> | <code>string?</code> | The type of channel to include or exclude in the search. For example `private` will search private channels, while `private_exclude` will exclude them. For a full list of types, check the [Types section](#types). |
| <code>sort</code> | <code>string?</code> | Possible values are `relevant` (search ranking based on what we think is closest), `name` (alphabetical), `member_count` (number of users in the channel), and `created` (date channel was created). You can optionally pair this with the `sort_dir` arg to change how it is sorted |
| <code>sortDir</code> | <code>string?</code> | Sort direction. Possible values are `asc` for ascending order like (1, 2, 3) or (a, b, c), and `desc` for descending order like (3, 2, 1) or (c, b, a) |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSearchschema](Models/AdminConversationsSearchschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSetConversationPrefsschema&gt; AdminConversationsSetConversationPrefs(string token, ContentType contentType, string channelId, string prefs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the posting permissions for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsSetConversationPrefs(token, contentType, channelId, prefs);
    // TODO: Handle 'response' of type AdminConversationsSetConversationPrefsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>prefs</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSetConversationPrefsschema](Models/AdminConversationsSetConversationPrefsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSetConversationPrefsschema1&gt; AdminConversationsSetConversationPrefs1(string token, ContentType contentType, string channelId, string prefs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the posting permissions for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsSetConversationPrefs1(token, contentType, channelId, prefs);
    // TODO: Handle 'response' of type AdminConversationsSetConversationPrefsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>prefs</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSetConversationPrefsschema1](Models/AdminConversationsSetConversationPrefsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsSetTeams(string token, ContentType contentType, string channelId, string? teamId, string? targetTeamIds, bool? orgChannel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the workspaces in an Enterprise grid org that connect to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsSetTeams(token,
        contentType,
        channelId,
        teamId,
        targetTeamIds,
        orgChannel);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |
| <code>targetTeamIds</code> | <code>string?</code> | - |
| <code>orgChannel</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsSetTeams1(string token, ContentType contentType, string channelId, string? teamId, string? targetTeamIds, bool? orgChannel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the workspaces in an Enterprise grid org that connect to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsSetTeams1(token,
        contentType,
        channelId,
        teamId,
        targetTeamIds,
        orgChannel);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |
| <code>targetTeamIds</code> | <code>string?</code> | - |
| <code>orgChannel</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsUnarchiveschema&gt; AdminConversationsUnarchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unarchive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsUnarchive(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsUnarchiveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsUnarchiveschema](Models/AdminConversationsUnarchiveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsUnarchiveschema1&gt; AdminConversationsUnarchive1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unarchive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminConversationsUnarchive1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsUnarchiveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsUnarchiveschema1](Models/AdminConversationsUnarchiveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAdd(ContentType contentType, string token, string name, string url, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiAdd(contentType, token, name, url);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>url</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiAdd1(ContentType contentType, string token, string name, string url, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiAdd1(contentType, token, name, url);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>url</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAddAlias(ContentType contentType, string token, string name, string aliasFor, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji alias.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiAddAlias(contentType, token, name, aliasFor);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>aliasFor</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiAddAlias1(ContentType contentType, string token, string name, string aliasFor, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji alias.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiAddAlias1(contentType, token, name, aliasFor);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>aliasFor</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List emoji for an Enterprise Grid organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiList(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiList1(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List emoji for an Enterprise Grid organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiList1(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRemove(ContentType contentType, string token, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove an emoji across an Enterprise Grid organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiRemove(contentType, token, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiRemove1(ContentType contentType, string token, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove an emoji across an Enterprise Grid organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiRemove1(contentType, token, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRename(ContentType contentType, string token, string name, string newName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiRename(contentType, token, name, newName);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>newName</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiRename1(ContentType contentType, string token, string name, string newName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminEmojiRename1(contentType, token, name, newName);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>newName</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprove(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsApprove(token, contentType, inviteRequestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsApprove1(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsApprove1(token, contentType, inviteRequestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprovedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all approved workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsApprovedList(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsApprovedList1(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all approved workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsApprovedList1(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeniedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all denied workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsDeniedList(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous api response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000 both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsDeniedList1(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all denied workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsDeniedList1(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous api response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000 both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeny(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deny a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsDeny(token, contentType, inviteRequestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsDeny1(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deny a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsDeny1(token, contentType, inviteRequestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all pending workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsList(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsList1(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all pending workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminInviteRequestsList1(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsAdminsList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the admins on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsAdminsList(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsAdminsList1(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the admins on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsAdminsList1(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsCreate(string token, ContentType contentType, string teamDomain, string teamName, string? teamDescription, string? teamDiscoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Enterprise team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsCreate(token,
        contentType,
        teamDomain,
        teamName,
        teamDescription,
        teamDiscoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamDomain</code> | <code>string</code> | - |
| <code>teamName</code> | <code>string</code> | - |
| <code>teamDescription</code> | <code>string?</code> | - |
| <code>teamDiscoverability</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsCreate1(string token, ContentType contentType, string teamDomain, string teamName, string? teamDescription, string? teamDiscoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Enterprise team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsCreate1(token,
        contentType,
        teamDomain,
        teamName,
        teamDescription,
        teamDiscoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamDomain</code> | <code>string</code> | - |
| <code>teamName</code> | <code>string</code> | - |
| <code>teamDescription</code> | <code>string?</code> | - |
| <code>teamDiscoverability</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsList(int? limit, string? cursor, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all teams on an Enterprise organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsList(limit, cursor, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 100 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsList1(int? limit, string? cursor, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all teams on an Enterprise organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsList1(limit, cursor, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 100 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsOwnersList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the owners on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsOwnersList(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsOwnersList1(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the owners on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsOwnersList1(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsInfo(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch information about settings in a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsInfo(teamId, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsInfo1(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch information about settings in a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsInfo1(teamId, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDefaultChannels(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the default channels of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetDefaultChannels(contentType, token, teamId, channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetDefaultChannels1(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the default channels of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetDefaultChannels1(contentType, token, teamId, channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDescription(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the description of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetDescription(token, contentType, teamId, description);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>description</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetDescription1(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the description of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetDescription1(token, contentType, teamId, description);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>description</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDiscoverability(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An API method that allows admins to set the discoverability of a given workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetDiscoverability(token, contentType, teamId, discoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>discoverability</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetDiscoverability1(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An API method that allows admins to set the discoverability of a given workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetDiscoverability1(token,
        contentType,
        teamId,
        discoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>discoverability</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetIcon(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the icon of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetIcon(contentType, token, imageUrl, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>imageUrl</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetIcon1(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the icon of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetIcon1(contentType, token, imageUrl, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>imageUrl</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetName(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the name of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetName(token, contentType, teamId, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetName1(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the name of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminTeamsSettingsSetName1(token, contentType, teamId, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddChannels(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add one or more default channels to an IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsAddChannels(token, contentType, usergroupId, channelIds, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsAddChannels1(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add one or more default channels to an IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsAddChannels1(token, contentType, usergroupId, channelIds, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddTeams(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Associate one or more default workspaces with an organization-wide IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsAddTeams(token, contentType, usergroupId, teamIds, autoProvision);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>teamIds</code> | <code>string</code> | - |
| <code>autoProvision</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsAddTeams1(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Associate one or more default workspaces with an organization-wide IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsAddTeams1(token, contentType, usergroupId, teamIds, autoProvision);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>teamIds</code> | <code>string</code> | - |
| <code>autoProvision</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsListChannels(string usergroupId, string? teamId, bool? includeNumMembers, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the channels linked to an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsListChannels(usergroupId,
        teamId,
        includeNumMembers,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>usergroupId</code> | <code>string</code> | ID of the IDP group to list default channels for. |
| <code>teamId</code> | <code>string?</code> | ID of the the workspace. |
| <code>includeNumMembers</code> | <code>bool?</code> | Flag to include or exclude the count of members per channel. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsListChannels1(string usergroupId, string? teamId, bool? includeNumMembers, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the channels linked to an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsListChannels1(usergroupId,
        teamId,
        includeNumMembers,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>usergroupId</code> | <code>string</code> | ID of the IDP group to list default channels for. |
| <code>teamId</code> | <code>string?</code> | ID of the the workspace. |
| <code>includeNumMembers</code> | <code>bool?</code> | Flag to include or exclude the count of members per channel. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsRemoveChannels(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove one or more default channels from an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsRemoveChannels(token, contentType, usergroupId, channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsRemoveChannels1(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove one or more default channels from an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsergroupsRemoveChannels1(token, contentType, usergroupId, channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersAssign(string token, ContentType contentType, string teamId, string userId, bool? isRestricted, bool? isUltraRestricted, string? channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an Enterprise user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersAssign(token,
        contentType,
        teamId,
        userId,
        isRestricted,
        isUltraRestricted,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>channelIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersAssign1(string token, ContentType contentType, string teamId, string userId, bool? isRestricted, bool? isUltraRestricted, string? channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an Enterprise user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersAssign1(token,
        contentType,
        teamId,
        userId,
        isRestricted,
        isUltraRestricted,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>channelIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersInvite(string token, ContentType contentType, string teamId, string email, string channelIds, string? customMessage, string? realName, bool? resend, bool? isRestricted, bool? isUltraRestricted, string? guestExpirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersInvite(token,
        contentType,
        teamId,
        email,
        channelIds,
        customMessage,
        realName,
        resend,
        isRestricted,
        isUltraRestricted,
        guestExpirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>email</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>customMessage</code> | <code>string?</code> | - |
| <code>realName</code> | <code>string?</code> | - |
| <code>resend</code> | <code>bool?</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>guestExpirationTs</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersInvite1(string token, ContentType contentType, string teamId, string email, string channelIds, string? customMessage, string? realName, bool? resend, bool? isRestricted, bool? isUltraRestricted, string? guestExpirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersInvite1(token,
        contentType,
        teamId,
        email,
        channelIds,
        customMessage,
        realName,
        resend,
        isRestricted,
        isUltraRestricted,
        guestExpirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>email</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>customMessage</code> | <code>string?</code> | - |
| <code>realName</code> | <code>string?</code> | - |
| <code>resend</code> | <code>bool?</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>guestExpirationTs</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersList(string teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List users on a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersList(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | The ID (`T1234`) of the workspace. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>limit</code> | <code>int?</code> | Limit for how many users to be retrieved per page |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersList1(string teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List users on a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersList1(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | The ID (`T1234`) of the workspace. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>limit</code> | <code>int?</code> | Limit for how many users to be retrieved per page |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersRemove(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a user from a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersRemove(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersRemove1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a user from a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersRemove1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionInvalidate(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invalidate a single session for a user by session_id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSessionInvalidate(token, contentType, teamId, sessionId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>sessionId</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSessionInvalidate1(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invalidate a single session for a user by session_id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSessionInvalidate1(token, contentType, teamId, sessionId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>sessionId</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionReset(string token, ContentType contentType, string userId, bool? mobileOnly, bool? webOnly, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Wipes all valid sessions on all devices for a given user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSessionReset(token, contentType, userId, mobileOnly, webOnly);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>mobileOnly</code> | <code>bool?</code> | - |
| <code>webOnly</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSessionReset1(string token, ContentType contentType, string userId, bool? mobileOnly, bool? webOnly, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Wipes all valid sessions on all devices for a given user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSessionReset1(token, contentType, userId, mobileOnly, webOnly);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>mobileOnly</code> | <code>bool?</code> | - |
| <code>webOnly</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetAdmin(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or owner to be an admin user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetAdmin(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetAdmin1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or owner to be an admin user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetAdmin1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetExpiration(string token, ContentType contentType, string teamId, string userId, int expirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an expiration for a guest user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetExpiration(token, contentType, teamId, userId, expirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>expirationTs</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetExpiration1(string token, ContentType contentType, string teamId, string userId, int expirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an expiration for a guest user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetExpiration1(token, contentType, teamId, userId, expirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>expirationTs</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetOwner(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or admin user to be a workspace owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetOwner(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetOwner1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or admin user to be a workspace owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetOwner1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetRegular(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest user, admin user, or owner to be a regular user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetRegular(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetRegular1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest user, admin user, or owner to be a regular user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminUsersSetRegular1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminApps

> Source: [AdminApps](Api/AdminApps.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprove(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminApps.AdminAppsApprove(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsApprove1(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminApps.AdminAppsApprove1(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrict(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restrict an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminApps.AdminAppsRestrict(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsRestrict1(string token, ContentType contentType, string? appId, string? requestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restrict an app for installation on a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminApps.AdminAppsRestrict1(token, contentType, appId, requestId, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>appId</code> | <code>string?</code> | - |
| <code>requestId</code> | <code>string?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminAppsApproved

> Source: [AdminAppsApproved](Api/AdminAppsApproved.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprovedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List approved apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminAppsApproved.AdminAppsApprovedList(token,
        limit,
        cursor,
        teamId,
        enterpriseId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsApprovedList1(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List approved apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminAppsApproved.AdminAppsApprovedList1(token,
        limit,
        cursor,
        teamId,
        enterpriseId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminAppsRequests

> Source: [AdminAppsRequests](Api/AdminAppsRequests.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRequestsList(string token, int? limit, string? cursor, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List app requests for a team/workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminAppsRequests.AdminAppsRequestsList(token, limit, cursor, teamId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsRequestsList1(string token, int? limit, string? cursor, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List app requests for a team/workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminAppsRequests.AdminAppsRequestsList1(token, limit, cursor, teamId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminAppsRestricted

> Source: [AdminAppsRestricted](Api/AdminAppsRestricted.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrictedList(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List restricted apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminAppsRestricted.AdminAppsRestrictedList(token,
        limit,
        cursor,
        teamId,
        enterpriseId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminAppsRestrictedList1(string token, int? limit, string? cursor, string? teamId, string? enterpriseId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List restricted apps for an org or workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminAppsRestricted.AdminAppsRestrictedList1(token,
        limit,
        cursor,
        teamId,
        enterpriseId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.apps:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>teamId</code> | <code>string?</code> | - |
| <code>enterpriseId</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminConversations

> Source: [AdminConversations](Api/AdminConversations.cs)

<details>
<summary><code>Task&lt;AdminConversationsArchiveschema&gt; AdminConversationsArchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Archive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsArchive(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsArchiveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsArchiveschema](Models/AdminConversationsArchiveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsArchiveschema1&gt; AdminConversationsArchive1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Archive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsArchive1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsArchiveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsArchiveschema1](Models/AdminConversationsArchiveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsConvertToPrivateschema&gt; AdminConversationsConvertToPrivate(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert a public channel to a private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsConvertToPrivate(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsConvertToPrivateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsConvertToPrivateschema](Models/AdminConversationsConvertToPrivateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsConvertToPrivateschema1&gt; AdminConversationsConvertToPrivate1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert a public channel to a private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsConvertToPrivate1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsConvertToPrivateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsConvertToPrivateschema1](Models/AdminConversationsConvertToPrivateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsCreateschema&gt; AdminConversationsCreate(string token, ContentType contentType, string name, bool isPrivate, string? description, bool? orgWide, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a public or private channel-based conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsCreate(token,
        contentType,
        name,
        isPrivate,
        description,
        orgWide,
        teamId);
    // TODO: Handle 'response' of type AdminConversationsCreateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>isPrivate</code> | <code>bool</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>orgWide</code> | <code>bool?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsCreateschema](Models/AdminConversationsCreateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsCreateschema1&gt; AdminConversationsCreate1(string token, ContentType contentType, string name, bool isPrivate, string? description, bool? orgWide, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a public or private channel-based conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsCreate1(token,
        contentType,
        name,
        isPrivate,
        description,
        orgWide,
        teamId);
    // TODO: Handle 'response' of type AdminConversationsCreateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>isPrivate</code> | <code>bool</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>orgWide</code> | <code>bool?</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsCreateschema1](Models/AdminConversationsCreateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsDeleteschema&gt; AdminConversationsDelete(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsDelete(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsDeleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsDeleteschema](Models/AdminConversationsDeleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsDeleteschema1&gt; AdminConversationsDelete1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsDelete1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsDeleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsDeleteschema1](Models/AdminConversationsDeleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema&gt; AdminConversationsDisconnectShared(string token, ContentType contentType, string channelId, string? leavingTeamIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disconnect a connected channel from one or more workspaces.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsDisconnectShared(token,
        contentType,
        channelId,
        leavingTeamIds);
    // TODO: Handle 'response' of type AdminConversationsRenameschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>leavingTeamIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema](Models/AdminConversationsRenameschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema2&gt; AdminConversationsDisconnectShared1(string token, ContentType contentType, string channelId, string? leavingTeamIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disconnect a connected channel from one or more workspaces.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsDisconnectShared1(token,
        contentType,
        channelId,
        leavingTeamIds);
    // TODO: Handle 'response' of type AdminConversationsRenameschema2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>leavingTeamIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema2](Models/AdminConversationsRenameschema2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetConversationPrefsschema&gt; AdminConversationsGetConversationPrefs(string channelId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get conversation preferences for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsGetConversationPrefs(channelId,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsGetConversationPrefsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to get preferences for. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetConversationPrefsschema](Models/AdminConversationsGetConversationPrefsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetConversationPrefsschema1&gt; AdminConversationsGetConversationPrefs1(string channelId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get conversation preferences for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsGetConversationPrefs1(channelId,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsGetConversationPrefsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to get preferences for. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetConversationPrefsschema1](Models/AdminConversationsGetConversationPrefsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetTeamsschema&gt; AdminConversationsGetTeams(string channelId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all the workspaces a given public or private channel is connected to within this Enterprise org.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsGetTeams(channelId,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsGetTeamsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to determine connected workspaces within the organization for. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetTeamsschema](Models/AdminConversationsGetTeamsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetTeamsschema1&gt; AdminConversationsGetTeams1(string channelId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all the workspaces a given public or private channel is connected to within this Enterprise org.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsGetTeams1(channelId,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsGetTeamsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>string</code> | The channel to determine connected workspaces within the organization for. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetTeamsschema1](Models/AdminConversationsGetTeamsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsInviteschema&gt; AdminConversationsInvite(string token, ContentType contentType, string userIds, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsInvite(token, contentType, userIds, channelId);
    // TODO: Handle 'response' of type AdminConversationsInviteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userIds</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsInviteschema](Models/AdminConversationsInviteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsInviteschema1&gt; AdminConversationsInvite1(string token, ContentType contentType, string userIds, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsInvite1(token, contentType, userIds, channelId);
    // TODO: Handle 'response' of type AdminConversationsInviteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userIds</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsInviteschema1](Models/AdminConversationsInviteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema1&gt; AdminConversationsRename(string token, ContentType contentType, string channelId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsRename(token, contentType, channelId, name);
    // TODO: Handle 'response' of type AdminConversationsRenameschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema1](Models/AdminConversationsRenameschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema11&gt; AdminConversationsRename1(string token, ContentType contentType, string channelId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsRename1(token, contentType, channelId, name);
    // TODO: Handle 'response' of type AdminConversationsRenameschema11
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema11](Models/AdminConversationsRenameschema11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSearchschema&gt; AdminConversationsSearch(string? teamIds, string? query, int? limit, string? cursor, string? searchChannelTypes, string? sort, string? sortDir, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for public or private channels in an Enterprise organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsSearch(teamIds,
        query,
        limit,
        cursor,
        searchChannelTypes,
        sort,
        sortDir,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsSearchschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamIds</code> | <code>string?</code> | Comma separated string of team IDs, signifying the workspaces to search through. |
| <code>query</code> | <code>string?</code> | Name of the the channel to query by. |
| <code>limit</code> | <code>int?</code> | Maximum number of items to be returned. Must be between 1 - 20 both inclusive. Default is 10. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>searchChannelTypes</code> | <code>string?</code> | The type of channel to include or exclude in the search. For example `private` will search private channels, while `private_exclude` will exclude them. For a full list of types, check the [Types section](#types). |
| <code>sort</code> | <code>string?</code> | Possible values are `relevant` (search ranking based on what we think is closest), `name` (alphabetical), `member_count` (number of users in the channel), and `created` (date channel was created). You can optionally pair this with the `sort_dir` arg to change how it is sorted |
| <code>sortDir</code> | <code>string?</code> | Sort direction. Possible values are `asc` for ascending order like (1, 2, 3) or (a, b, c), and `desc` for descending order like (3, 2, 1) or (c, b, a) |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSearchschema](Models/AdminConversationsSearchschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSearchschema&gt; AdminConversationsSearch1(string? teamIds, string? query, int? limit, string? cursor, string? searchChannelTypes, string? sort, string? sortDir, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for public or private channels in an Enterprise organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsSearch1(teamIds,
        query,
        limit,
        cursor,
        searchChannelTypes,
        sort,
        sortDir,
        token,
        contentType);
    // TODO: Handle 'response' of type AdminConversationsSearchschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamIds</code> | <code>string?</code> | Comma separated string of team IDs, signifying the workspaces to search through. |
| <code>query</code> | <code>string?</code> | Name of the the channel to query by. |
| <code>limit</code> | <code>int?</code> | Maximum number of items to be returned. Must be between 1 - 20 both inclusive. Default is 10. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>searchChannelTypes</code> | <code>string?</code> | The type of channel to include or exclude in the search. For example `private` will search private channels, while `private_exclude` will exclude them. For a full list of types, check the [Types section](#types). |
| <code>sort</code> | <code>string?</code> | Possible values are `relevant` (search ranking based on what we think is closest), `name` (alphabetical), `member_count` (number of users in the channel), and `created` (date channel was created). You can optionally pair this with the `sort_dir` arg to change how it is sorted |
| <code>sortDir</code> | <code>string?</code> | Sort direction. Possible values are `asc` for ascending order like (1, 2, 3) or (a, b, c), and `desc` for descending order like (3, 2, 1) or (c, b, a) |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSearchschema](Models/AdminConversationsSearchschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSetConversationPrefsschema&gt; AdminConversationsSetConversationPrefs(string token, ContentType contentType, string channelId, string prefs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the posting permissions for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsSetConversationPrefs(token,
        contentType,
        channelId,
        prefs);
    // TODO: Handle 'response' of type AdminConversationsSetConversationPrefsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>prefs</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSetConversationPrefsschema](Models/AdminConversationsSetConversationPrefsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSetConversationPrefsschema1&gt; AdminConversationsSetConversationPrefs1(string token, ContentType contentType, string channelId, string prefs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the posting permissions for a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsSetConversationPrefs1(token,
        contentType,
        channelId,
        prefs);
    // TODO: Handle 'response' of type AdminConversationsSetConversationPrefsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>prefs</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSetConversationPrefsschema1](Models/AdminConversationsSetConversationPrefsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsSetTeams(string token, ContentType contentType, string channelId, string? teamId, string? targetTeamIds, bool? orgChannel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the workspaces in an Enterprise grid org that connect to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsSetTeams(token,
        contentType,
        channelId,
        teamId,
        targetTeamIds,
        orgChannel);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |
| <code>targetTeamIds</code> | <code>string?</code> | - |
| <code>orgChannel</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsSetTeams1(string token, ContentType contentType, string channelId, string? teamId, string? targetTeamIds, bool? orgChannel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the workspaces in an Enterprise grid org that connect to a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsSetTeams1(token,
        contentType,
        channelId,
        teamId,
        targetTeamIds,
        orgChannel);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |
| <code>targetTeamIds</code> | <code>string?</code> | - |
| <code>orgChannel</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsUnarchiveschema&gt; AdminConversationsUnarchive(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unarchive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsUnarchive(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsUnarchiveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsUnarchiveschema](Models/AdminConversationsUnarchiveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsUnarchiveschema1&gt; AdminConversationsUnarchive1(string token, ContentType contentType, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unarchive a public or private channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversations.AdminConversationsUnarchive1(token, contentType, channelId);
    // TODO: Handle 'response' of type AdminConversationsUnarchiveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsUnarchiveschema1](Models/AdminConversationsUnarchiveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminConversationsEkm

> Source: [AdminConversationsEkm](Api/AdminConversationsEkm.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsEkmListOriginalConnectedChannelInfo(string token, string? channelIds, string? teamIds, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsEkm.AdminConversationsEkmListOriginalConnectedChannelInfo(token,
        channelIds,
        teamIds,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelIds</code> | <code>string?</code> | A comma-separated list of channels to filter to. |
| <code>teamIds</code> | <code>string?</code> | A comma-separated list of the workspaces to which the channels you would like returned belong. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsEkmListOriginalConnectedChannelInfo1(string token, string? channelIds, string? teamIds, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsEkm.AdminConversationsEkmListOriginalConnectedChannelInfo1(token,
        channelIds,
        teamIds,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelIds</code> | <code>string?</code> | A comma-separated list of channels to filter to. |
| <code>teamIds</code> | <code>string?</code> | A comma-separated list of the workspaces to which the channels you would like returned belong. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminConversationsRestrictAccess

> Source: [AdminConversationsRestrictAccess](Api/AdminConversationsRestrictAccess.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessAddGroup(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an allowlist of IDP groups for accessing a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessAddGroup(contentType,
        token,
        groupId,
        channelId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsRestrictAccessAddGroup1(ContentType contentType, string token, string groupId, string channelId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an allowlist of IDP groups for accessing a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessAddGroup1(contentType,
        token,
        groupId,
        channelId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessListGroups(string token, string channelId, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all IDP Groups linked to a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessListGroups(token,
        channelId,
        teamId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsRestrictAccessListGroups1(string token, string channelId, string? teamId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all IDP Groups linked to a channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessListGroups1(token,
        channelId,
        teamId,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.conversations:read` |
| <code>channelId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessRemoveGroup(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a linked IDP group linked from a private channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessRemoveGroup(contentType,
        token,
        teamId,
        groupId,
        channelId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminConversationsRestrictAccessRemoveGroup1(ContentType contentType, string token, string teamId, string groupId, string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a linked IDP group linked from a private channel

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessRemoveGroup1(contentType,
        token,
        teamId,
        groupId,
        channelId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>groupId</code> | <code>string</code> | - |
| <code>channelId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminEmoji

> Source: [AdminEmoji](Api/AdminEmoji.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAdd(ContentType contentType, string token, string name, string url, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiAdd(contentType, token, name, url);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>url</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiAdd1(ContentType contentType, string token, string name, string url, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiAdd1(contentType, token, name, url);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>url</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAddAlias(ContentType contentType, string token, string name, string aliasFor, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji alias.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiAddAlias(contentType, token, name, aliasFor);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>aliasFor</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiAddAlias1(ContentType contentType, string token, string name, string aliasFor, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an emoji alias.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiAddAlias1(contentType, token, name, aliasFor);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>aliasFor</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List emoji for an Enterprise Grid organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiList(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiList1(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List emoji for an Enterprise Grid organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiList1(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRemove(ContentType contentType, string token, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove an emoji across an Enterprise Grid organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiRemove(contentType, token, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiRemove1(ContentType contentType, string token, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove an emoji across an Enterprise Grid organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiRemove1(contentType, token, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRename(ContentType contentType, string token, string name, string newName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiRename(contentType, token, name, newName);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>newName</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminEmojiRename1(ContentType contentType, string token, string name, string newName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rename an emoji.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminEmoji.AdminEmojiRename1(contentType, token, name, newName);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>newName</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminInviteRequests

> Source: [AdminInviteRequests](Api/AdminInviteRequests.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprove(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequests.AdminInviteRequestsApprove(token,
        contentType,
        inviteRequestId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsApprove1(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequests.AdminInviteRequestsApprove1(token,
        contentType,
        inviteRequestId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeny(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deny a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequests.AdminInviteRequestsDeny(token,
        contentType,
        inviteRequestId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsDeny1(string token, ContentType contentType, string inviteRequestId, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deny a workspace invite request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequests.AdminInviteRequestsDeny1(token,
        contentType,
        inviteRequestId,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>inviteRequestId</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all pending workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequests.AdminInviteRequestsList(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsList1(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all pending workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequests.AdminInviteRequestsList1(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminInviteRequestsApproved

> Source: [AdminInviteRequestsApproved](Api/AdminInviteRequestsApproved.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprovedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all approved workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequestsApproved.AdminInviteRequestsApprovedList(teamId,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsApprovedList1(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all approved workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequestsApproved.AdminInviteRequestsApprovedList1(teamId,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous API response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminInviteRequestsDenied

> Source: [AdminInviteRequestsDenied](Api/AdminInviteRequestsDenied.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeniedList(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all denied workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequestsDenied.AdminInviteRequestsDeniedList(teamId,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous api response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000 both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminInviteRequestsDeniedList1(string? teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all denied workspace invite requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminInviteRequestsDenied.AdminInviteRequestsDeniedList1(teamId,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string?</code> | ID for the workspace where the invite requests were made. |
| <code>cursor</code> | <code>string?</code> | Value of the `next_cursor` field sent as part of the previous api response |
| <code>limit</code> | <code>int?</code> | The number of results that will be returned by the API on each invocation. Must be between 1 - 1000 both inclusive |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.invites:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeams

> Source: [AdminTeams](Api/AdminTeams.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsCreate(string token, ContentType contentType, string teamDomain, string teamName, string? teamDescription, string? teamDiscoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Enterprise team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeams.AdminTeamsCreate(token,
        contentType,
        teamDomain,
        teamName,
        teamDescription,
        teamDiscoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamDomain</code> | <code>string</code> | - |
| <code>teamName</code> | <code>string</code> | - |
| <code>teamDescription</code> | <code>string?</code> | - |
| <code>teamDiscoverability</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsCreate1(string token, ContentType contentType, string teamDomain, string teamName, string? teamDescription, string? teamDiscoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Enterprise team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeams.AdminTeamsCreate1(token,
        contentType,
        teamDomain,
        teamName,
        teamDescription,
        teamDiscoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamDomain</code> | <code>string</code> | - |
| <code>teamName</code> | <code>string</code> | - |
| <code>teamDescription</code> | <code>string?</code> | - |
| <code>teamDiscoverability</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsList(int? limit, string? cursor, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all teams on an Enterprise organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeams.AdminTeamsList(limit, cursor, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 100 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsList1(int? limit, string? cursor, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all teams on an Enterprise organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeams.AdminTeamsList1(limit, cursor, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 100 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeamsAdmins

> Source: [AdminTeamsAdmins](Api/AdminTeamsAdmins.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsAdminsList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the admins on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsAdmins.AdminTeamsAdminsList(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsAdminsList1(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the admins on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsAdmins.AdminTeamsAdminsList1(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeamsOwners

> Source: [AdminTeamsOwners](Api/AdminTeamsOwners.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsOwnersList(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the owners on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsOwners.AdminTeamsOwnersList(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsOwnersList1(string token, string teamId, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all of the owners on a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsOwners.AdminTeamsOwnersList1(token, teamId, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>teamId</code> | <code>string</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Must be between 1 - 1000 both inclusive. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeamsSettings

> Source: [AdminTeamsSettings](Api/AdminTeamsSettings.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsInfo(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch information about settings in a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsInfo(teamId, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsInfo1(string teamId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch information about settings in a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsInfo1(teamId, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDefaultChannels(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the default channels of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDefaultChannels(contentType,
        token,
        teamId,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetDefaultChannels1(ContentType contentType, string token, string teamId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the default channels of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDefaultChannels1(contentType,
        token,
        teamId,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDescription(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the description of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDescription(token,
        contentType,
        teamId,
        description);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>description</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetDescription1(string token, ContentType contentType, string teamId, string description, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the description of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDescription1(token,
        contentType,
        teamId,
        description);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>description</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDiscoverability(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An API method that allows admins to set the discoverability of a given workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDiscoverability(token,
        contentType,
        teamId,
        discoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>discoverability</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetDiscoverability1(string token, ContentType contentType, string teamId, string discoverability, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An API method that allows admins to set the discoverability of a given workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDiscoverability1(token,
        contentType,
        teamId,
        discoverability);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>discoverability</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetIcon(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the icon of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetIcon(contentType, token, imageUrl, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>imageUrl</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetIcon1(ContentType contentType, string token, string imageUrl, string teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the icon of a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetIcon1(contentType, token, imageUrl, teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>imageUrl</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetName(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the name of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetName(token, contentType, teamId, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminTeamsSettingsSetName1(string token, ContentType contentType, string teamId, string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the name of a given workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetName1(token, contentType, teamId, name);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminUsergroups

> Source: [AdminUsergroups](Api/AdminUsergroups.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddChannels(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add one or more default channels to an IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsAddChannels(token,
        contentType,
        usergroupId,
        channelIds,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsAddChannels1(string token, ContentType contentType, string usergroupId, string channelIds, string? teamId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add one or more default channels to an IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsAddChannels1(token,
        contentType,
        usergroupId,
        channelIds,
        teamId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>teamId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddTeams(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Associate one or more default workspaces with an organization-wide IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsAddTeams(token,
        contentType,
        usergroupId,
        teamIds,
        autoProvision);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>teamIds</code> | <code>string</code> | - |
| <code>autoProvision</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsAddTeams1(string token, ContentType contentType, string usergroupId, string teamIds, bool? autoProvision, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Associate one or more default workspaces with an organization-wide IDP group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsAddTeams1(token,
        contentType,
        usergroupId,
        teamIds,
        autoProvision);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.teams:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>teamIds</code> | <code>string</code> | - |
| <code>autoProvision</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsListChannels(string usergroupId, string? teamId, bool? includeNumMembers, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the channels linked to an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsListChannels(usergroupId,
        teamId,
        includeNumMembers,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>usergroupId</code> | <code>string</code> | ID of the IDP group to list default channels for. |
| <code>teamId</code> | <code>string?</code> | ID of the the workspace. |
| <code>includeNumMembers</code> | <code>bool?</code> | Flag to include or exclude the count of members per channel. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsListChannels1(string usergroupId, string? teamId, bool? includeNumMembers, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the channels linked to an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsListChannels1(usergroupId,
        teamId,
        includeNumMembers,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>usergroupId</code> | <code>string</code> | ID of the IDP group to list default channels for. |
| <code>teamId</code> | <code>string?</code> | ID of the the workspace. |
| <code>includeNumMembers</code> | <code>bool?</code> | Flag to include or exclude the count of members per channel. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsRemoveChannels(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove one or more default channels from an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsRemoveChannels(token,
        contentType,
        usergroupId,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsergroupsRemoveChannels1(string token, ContentType contentType, string usergroupId, string channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove one or more default channels from an org-level IDP group (user group).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsergroups.AdminUsergroupsRemoveChannels1(token,
        contentType,
        usergroupId,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroupId</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminUsers

> Source: [AdminUsers](Api/AdminUsers.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersAssign(string token, ContentType contentType, string teamId, string userId, bool? isRestricted, bool? isUltraRestricted, string? channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an Enterprise user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersAssign(token,
        contentType,
        teamId,
        userId,
        isRestricted,
        isUltraRestricted,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>channelIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersAssign1(string token, ContentType contentType, string teamId, string userId, bool? isRestricted, bool? isUltraRestricted, string? channelIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add an Enterprise user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersAssign1(token,
        contentType,
        teamId,
        userId,
        isRestricted,
        isUltraRestricted,
        channelIds);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>channelIds</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersInvite(string token, ContentType contentType, string teamId, string email, string channelIds, string? customMessage, string? realName, bool? resend, bool? isRestricted, bool? isUltraRestricted, string? guestExpirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersInvite(token,
        contentType,
        teamId,
        email,
        channelIds,
        customMessage,
        realName,
        resend,
        isRestricted,
        isUltraRestricted,
        guestExpirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>email</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>customMessage</code> | <code>string?</code> | - |
| <code>realName</code> | <code>string?</code> | - |
| <code>resend</code> | <code>bool?</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>guestExpirationTs</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersInvite1(string token, ContentType contentType, string teamId, string email, string channelIds, string? customMessage, string? realName, bool? resend, bool? isRestricted, bool? isUltraRestricted, string? guestExpirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invite a user to a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersInvite1(token,
        contentType,
        teamId,
        email,
        channelIds,
        customMessage,
        realName,
        resend,
        isRestricted,
        isUltraRestricted,
        guestExpirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>email</code> | <code>string</code> | - |
| <code>channelIds</code> | <code>string</code> | - |
| <code>customMessage</code> | <code>string?</code> | - |
| <code>realName</code> | <code>string?</code> | - |
| <code>resend</code> | <code>bool?</code> | - |
| <code>isRestricted</code> | <code>bool?</code> | - |
| <code>isUltraRestricted</code> | <code>bool?</code> | - |
| <code>guestExpirationTs</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersList(string teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List users on a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersList(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | The ID (`T1234`) of the workspace. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>limit</code> | <code>int?</code> | Limit for how many users to be retrieved per page |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersList1(string teamId, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List users on a workspace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersList1(teamId, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamId</code> | <code>string</code> | The ID (`T1234`) of the workspace. |
| <code>cursor</code> | <code>string?</code> | Set `cursor` to `next_cursor` returned by the previous call to list items in the next page. |
| <code>limit</code> | <code>int?</code> | Limit for how many users to be retrieved per page |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersRemove(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a user from a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersRemove(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersRemove1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a user from a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersRemove1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetAdmin(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or owner to be an admin user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetAdmin(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetAdmin1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or owner to be an admin user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetAdmin1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetExpiration(string token, ContentType contentType, string teamId, string userId, int expirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an expiration for a guest user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetExpiration(token, contentType, teamId, userId, expirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>expirationTs</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetExpiration1(string token, ContentType contentType, string teamId, string userId, int expirationTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an expiration for a guest user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetExpiration1(token, contentType, teamId, userId, expirationTs);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>expirationTs</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetOwner(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or admin user to be a workspace owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetOwner(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetOwner1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest, regular user, or admin user to be a workspace owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetOwner1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetRegular(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest user, admin user, or owner to be a regular user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetRegular(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSetRegular1(string token, ContentType contentType, string teamId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set an existing guest user, admin user, or owner to be a regular user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsers.AdminUsersSetRegular1(token, contentType, teamId, userId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminUsersSession

> Source: [AdminUsersSession](Api/AdminUsersSession.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionInvalidate(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invalidate a single session for a user by session_id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsersSession.AdminUsersSessionInvalidate(token, contentType, teamId, sessionId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>sessionId</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSessionInvalidate1(string token, ContentType contentType, string teamId, int sessionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invalidate a single session for a user by session_id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsersSession.AdminUsersSessionInvalidate1(token, contentType, teamId, sessionId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>teamId</code> | <code>string</code> | - |
| <code>sessionId</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionReset(string token, ContentType contentType, string userId, bool? mobileOnly, bool? webOnly, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Wipes all valid sessions on all devices for a given user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsersSession.AdminUsersSessionReset(token,
        contentType,
        userId,
        mobileOnly,
        webOnly);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>mobileOnly</code> | <code>bool?</code> | - |
| <code>webOnly</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AdminUsersSessionReset1(string token, ContentType contentType, string userId, bool? mobileOnly, bool? webOnly, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Wipes all valid sessions on all devices for a given user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminUsersSession.AdminUsersSessionReset1(token,
        contentType,
        userId,
        mobileOnly,
        webOnly);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin.users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>userId</code> | <code>string</code> | - |
| <code>mobileOnly</code> | <code>bool?</code> | - |
| <code>webOnly</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiApi

> Source: [ApiApi](Api/ApiApi.cs)

<details>
<summary><code>Task&lt;ApiTestsuccessschema&gt; ApiTest(string? error, string? foo, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks API calling code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiApi.ApiTest(error, foo, contentType);
    // TODO: Handle 'response' of type ApiTestsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>error</code> | <code>string?</code> | Error response to return |
| <code>foo</code> | <code>string?</code> | example property to return |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiTestsuccessschema](Models/ApiTestsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiTestsuccessschema1&gt; ApiTest1(string? error, string? foo, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks API calling code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiApi.ApiTest1(error, foo, contentType);
    // TODO: Handle 'response' of type ApiTestsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>error</code> | <code>string?</code> | Error response to return |
| <code>foo</code> | <code>string?</code> | example property to return |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiTestsuccessschema1](Models/ApiTestsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Apps

> Source: [Apps](Api/Apps.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsEventAuthorizationsList(string eventContext, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsEventAuthorizationsList(eventContext, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>eventContext</code> | <code>string</code> | - |
| <code>cursor</code> | <code>string?</code> | - |
| <code>limit</code> | <code>int?</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `authorizations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AppsEventAuthorizationsList1(string eventContext, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsEventAuthorizationsList1(eventContext, cursor, limit, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>eventContext</code> | <code>string</code> | - |
| <code>cursor</code> | <code>string?</code> | - |
| <code>limit</code> | <code>int?</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `authorizations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsInfoschema&gt; AppsPermissionsInfo(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of permissions this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsInfo(token, contentType);
    // TODO: Handle 'response' of type AppsPermissionsInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsInfoschema](Models/AppsPermissionsInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsInfoschema1&gt; AppsPermissionsInfo1(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of permissions this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsInfo1(token, contentType);
    // TODO: Handle 'response' of type AppsPermissionsInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsInfoschema1](Models/AppsPermissionsInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsRequestschema&gt; AppsPermissionsRequest(string token, string scopes, string triggerId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows an app to request additional scopes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsRequest(token, scopes, triggerId, contentType);
    // TODO: Handle 'response' of type AppsPermissionsRequestschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the permissions API |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsRequestschema](Models/AppsPermissionsRequestschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsRequestschema1&gt; AppsPermissionsRequest1(string token, string scopes, string triggerId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows an app to request additional scopes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsRequest1(token, scopes, triggerId, contentType);
    // TODO: Handle 'response' of type AppsPermissionsRequestschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the permissions API |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsRequestschema1](Models/AppsPermissionsRequestschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsResourcesListsuccessschema&gt; AppsPermissionsResourcesList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of resource grants this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsResourcesList(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type AppsPermissionsResourcesListsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsResourcesListsuccessschema](Models/AppsPermissionsResourcesListsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsResourcesListsuccessschema1&gt; AppsPermissionsResourcesList1(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of resource grants this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsResourcesList1(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type AppsPermissionsResourcesListsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsResourcesListsuccessschema1](Models/AppsPermissionsResourcesListsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiPermissionsScopesListsuccessschema&gt; AppsPermissionsScopesList(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsScopesList(token, contentType);
    // TODO: Handle 'response' of type ApiPermissionsScopesListsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiPermissionsScopesListsuccessschema](Models/ApiPermissionsScopesListsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiPermissionsScopesListsuccessschema1&gt; AppsPermissionsScopesList1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsScopesList1(token, contentType);
    // TODO: Handle 'response' of type ApiPermissionsScopesListsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiPermissionsScopesListsuccessschema1](Models/ApiPermissionsScopesListsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of user grants and corresponding scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsUsersList(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AppsPermissionsUsersList1(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of user grants and corresponding scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsUsersList1(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersRequest(string token, string scopes, string triggerId, string user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables an app to trigger a permissions modal to grant an app access to a user access scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsUsersRequest(token, scopes, triggerId, user, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of user scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the request |
| <code>user</code> | <code>string</code> | The user this scope is being requested for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AppsPermissionsUsersRequest1(string token, string scopes, string triggerId, string user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables an app to trigger a permissions modal to grant an app access to a user access scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsPermissionsUsersRequest1(token, scopes, triggerId, user, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of user scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the request |
| <code>user</code> | <code>string</code> | The user this scope is being requested for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsUninstallschema&gt; AppsUninstall(string? token, string? clientId, string? clientSecret, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uninstalls your app from a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsUninstall(token, clientId, clientSecret, contentType);
    // TODO: Handle 'response' of type AppsUninstallschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsUninstallschema](Models/AppsUninstallschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsUninstallschema1&gt; AppsUninstall1(string? token, string? clientId, string? clientSecret, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uninstalls your app from a workspace.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Apps.AppsUninstall1(token, clientId, clientSecret, contentType);
    // TODO: Handle 'response' of type AppsUninstallschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsUninstallschema1](Models/AppsUninstallschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsEventAuthorizations

> Source: [AppsEventAuthorizations](Api/AppsEventAuthorizations.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsEventAuthorizationsList(string eventContext, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsEventAuthorizations.AppsEventAuthorizationsList(eventContext,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>eventContext</code> | <code>string</code> | - |
| <code>cursor</code> | <code>string?</code> | - |
| <code>limit</code> | <code>int?</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `authorizations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AppsEventAuthorizationsList1(string eventContext, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsEventAuthorizations.AppsEventAuthorizationsList1(eventContext,
        cursor,
        limit,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>eventContext</code> | <code>string</code> | - |
| <code>cursor</code> | <code>string?</code> | - |
| <code>limit</code> | <code>int?</code> | - |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `authorizations:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissions

> Source: [AppsPermissions](Api/AppsPermissions.cs)

<details>
<summary><code>Task&lt;AppsPermissionsInfoschema&gt; AppsPermissionsInfo(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of permissions this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissions.AppsPermissionsInfo(token, contentType);
    // TODO: Handle 'response' of type AppsPermissionsInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsInfoschema](Models/AppsPermissionsInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsInfoschema1&gt; AppsPermissionsInfo1(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of permissions this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissions.AppsPermissionsInfo1(token, contentType);
    // TODO: Handle 'response' of type AppsPermissionsInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsInfoschema1](Models/AppsPermissionsInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsRequestschema&gt; AppsPermissionsRequest(string token, string scopes, string triggerId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows an app to request additional scopes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissions.AppsPermissionsRequest(token, scopes, triggerId, contentType);
    // TODO: Handle 'response' of type AppsPermissionsRequestschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the permissions API |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsRequestschema](Models/AppsPermissionsRequestschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsRequestschema1&gt; AppsPermissionsRequest1(string token, string scopes, string triggerId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows an app to request additional scopes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissions.AppsPermissionsRequest1(token, scopes, triggerId, contentType);
    // TODO: Handle 'response' of type AppsPermissionsRequestschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the permissions API |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsRequestschema1](Models/AppsPermissionsRequestschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissionsResources

> Source: [AppsPermissionsResources](Api/AppsPermissionsResources.cs)

<details>
<summary><code>Task&lt;AppsPermissionsResourcesListsuccessschema&gt; AppsPermissionsResourcesList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of resource grants this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsResources.AppsPermissionsResourcesList(token,
        cursor,
        limit,
        contentType);
    // TODO: Handle 'response' of type AppsPermissionsResourcesListsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsResourcesListsuccessschema](Models/AppsPermissionsResourcesListsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsResourcesListsuccessschema1&gt; AppsPermissionsResourcesList1(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of resource grants this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsResources.AppsPermissionsResourcesList1(token,
        cursor,
        limit,
        contentType);
    // TODO: Handle 'response' of type AppsPermissionsResourcesListsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsResourcesListsuccessschema1](Models/AppsPermissionsResourcesListsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissionsScopes

> Source: [AppsPermissionsScopes](Api/AppsPermissionsScopes.cs)

<details>
<summary><code>Task&lt;ApiPermissionsScopesListsuccessschema&gt; AppsPermissionsScopesList(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsScopes.AppsPermissionsScopesList(token, contentType);
    // TODO: Handle 'response' of type ApiPermissionsScopesListsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiPermissionsScopesListsuccessschema](Models/ApiPermissionsScopesListsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiPermissionsScopesListsuccessschema1&gt; AppsPermissionsScopesList1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsScopes.AppsPermissionsScopesList1(token, contentType);
    // TODO: Handle 'response' of type ApiPermissionsScopesListsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiPermissionsScopesListsuccessschema1](Models/ApiPermissionsScopesListsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissionsUsers

> Source: [AppsPermissionsUsers](Api/AppsPermissionsUsers.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of user grants and corresponding scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsUsers.AppsPermissionsUsersList(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AppsPermissionsUsersList1(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of user grants and corresponding scopes this app has on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsUsers.AppsPermissionsUsersList1(token, cursor, limit, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersRequest(string token, string scopes, string triggerId, string user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables an app to trigger a permissions modal to grant an app access to a user access scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsUsers.AppsPermissionsUsersRequest(token,
        scopes,
        triggerId,
        user,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of user scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the request |
| <code>user</code> | <code>string</code> | The user this scope is being requested for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; AppsPermissionsUsersRequest1(string token, string scopes, string triggerId, string user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables an app to trigger a permissions modal to grant an app access to a user access scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppsPermissionsUsers.AppsPermissionsUsersRequest1(token,
        scopes,
        triggerId,
        user,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>scopes</code> | <code>string</code> | A comma separated list of user scopes to request for |
| <code>triggerId</code> | <code>string</code> | Token used to trigger the request |
| <code>user</code> | <code>string</code> | The user this scope is being requested for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Auth

> Source: [Auth](Api/Auth.cs)

<details>
<summary><code>Task&lt;AuthRevokeschema&gt; AuthRevoke(string token, bool? test, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes a token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Auth.AuthRevoke(token, test, contentType);
    // TODO: Handle 'response' of type AuthRevokeschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>test</code> | <code>bool?</code> | Setting this parameter to `1` triggers a _testing mode_ where the specified token will not actually be revoked. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthRevokeschema](Models/AuthRevokeschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthRevokeschema1&gt; AuthRevoke1(string token, bool? test, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes a token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Auth.AuthRevoke1(token, test, contentType);
    // TODO: Handle 'response' of type AuthRevokeschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>test</code> | <code>bool?</code> | Setting this parameter to `1` triggers a _testing mode_ where the specified token will not actually be revoked. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthRevokeschema1](Models/AuthRevokeschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTestsuccessschema&gt; AuthTest(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks authentication & identity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Auth.AuthTest(token, contentType);
    // TODO: Handle 'response' of type AuthTestsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTestsuccessschema](Models/AuthTestsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTestsuccessschema1&gt; AuthTest1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks authentication & identity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Auth.AuthTest1(token, contentType);
    // TODO: Handle 'response' of type AuthTestsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTestsuccessschema1](Models/AuthTestsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Bots

> Source: [Bots](Api/Bots.cs)

<details>
<summary><code>Task&lt;BotsInfoschema&gt; BotsInfo(string token, string? bot, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a bot user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bots.BotsInfo(token, bot, contentType);
    // TODO: Handle 'response' of type BotsInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read` |
| <code>bot</code> | <code>string?</code> | Bot user to get info on |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BotsInfoschema](Models/BotsInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BotsInfoschema1&gt; BotsInfo1(string token, string? bot, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a bot user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bots.BotsInfo1(token, bot, contentType);
    // TODO: Handle 'response' of type BotsInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read` |
| <code>bot</code> | <code>string?</code> | Bot user to get info on |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BotsInfoschema1](Models/BotsInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Calls

> Source: [Calls](Api/Calls.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsAdd(string token, ContentType contentType, string externalUniqueId, string joinUrl, string? externalDisplayId, string? desktopAppJoinUrl, int? dateStart, string? title, string? createdBy, string? users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a new Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsAdd(token,
        contentType,
        externalUniqueId,
        joinUrl,
        externalDisplayId,
        desktopAppJoinUrl,
        dateStart,
        title,
        createdBy,
        users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>externalUniqueId</code> | <code>string</code> | - |
| <code>joinUrl</code> | <code>string</code> | - |
| <code>externalDisplayId</code> | <code>string?</code> | - |
| <code>desktopAppJoinUrl</code> | <code>string?</code> | - |
| <code>dateStart</code> | <code>int?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>createdBy</code> | <code>string?</code> | - |
| <code>users</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsAdd1(string token, ContentType contentType, string externalUniqueId, string joinUrl, string? externalDisplayId, string? desktopAppJoinUrl, int? dateStart, string? title, string? createdBy, string? users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a new Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsAdd1(token,
        contentType,
        externalUniqueId,
        joinUrl,
        externalDisplayId,
        desktopAppJoinUrl,
        dateStart,
        title,
        createdBy,
        users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>externalUniqueId</code> | <code>string</code> | - |
| <code>joinUrl</code> | <code>string</code> | - |
| <code>externalDisplayId</code> | <code>string?</code> | - |
| <code>desktopAppJoinUrl</code> | <code>string?</code> | - |
| <code>dateStart</code> | <code>int?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>createdBy</code> | <code>string?</code> | - |
| <code>users</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsEnd(string token, ContentType contentType, string id, int? duration, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsEnd(token, contentType, id, duration);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>duration</code> | <code>int?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsEnd1(string token, ContentType contentType, string id, int? duration, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsEnd1(token, contentType, id, duration);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>duration</code> | <code>int?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsInfo(string id, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsInfo(id, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | `id` of the Call returned by the [`calls.add`](/methods/calls.add) method. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsInfo1(string id, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsInfo1(id, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | `id` of the Call returned by the [`calls.add`](/methods/calls.add) method. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsAdd(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers new participants added to a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsParticipantsAdd(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsParticipantsAdd1(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers new participants added to a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsParticipantsAdd1(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsRemove(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers participants removed from a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsParticipantsRemove(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsParticipantsRemove1(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers participants removed from a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsParticipantsRemove1(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsUpdate(string token, ContentType contentType, string id, string? title, string? joinUrl, string? desktopAppJoinUrl, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates information about a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsUpdate(token, contentType, id, title, joinUrl, desktopAppJoinUrl);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>joinUrl</code> | <code>string?</code> | - |
| <code>desktopAppJoinUrl</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsUpdate1(string token, ContentType contentType, string id, string? title, string? joinUrl, string? desktopAppJoinUrl, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates information about a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Calls.CallsUpdate1(token, contentType, id, title, joinUrl, desktopAppJoinUrl);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>joinUrl</code> | <code>string?</code> | - |
| <code>desktopAppJoinUrl</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CallsParticipants

> Source: [CallsParticipants](Api/CallsParticipants.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsAdd(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers new participants added to a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CallsParticipants.CallsParticipantsAdd(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsParticipantsAdd1(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers new participants added to a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CallsParticipants.CallsParticipantsAdd1(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsRemove(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers participants removed from a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CallsParticipants.CallsParticipantsRemove(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; CallsParticipantsRemove1(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers participants removed from a Call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CallsParticipants.CallsParticipantsRemove1(token, contentType, id, users);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `calls:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>id</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Chat

> Source: [Chat](Api/Chat.cs)

<details>
<summary><code>Task&lt;ChatDeletesuccessschema&gt; ChatDelete(ContentType contentType, string? token, double? ts, string? channel, bool? asUser, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatDelete(contentType, token, ts, channel, asUser);
    // TODO: Handle 'response' of type ChatDeletesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `chat:write` |
| <code>ts</code> | <code>double?</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatDeletesuccessschema](Models/ChatDeletesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatDeletesuccessschema1&gt; ChatDelete1(ContentType contentType, string? token, double? ts, string? channel, bool? asUser, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatDelete1(contentType, token, ts, channel, asUser);
    // TODO: Handle 'response' of type ChatDeletesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `chat:write` |
| <code>ts</code> | <code>double?</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatDeletesuccessschema1](Models/ChatDeletesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatDeleteScheduledMessageschema&gt; ChatDeleteScheduledMessage(string token, ContentType contentType, string channel, string scheduledMessageId, bool? asUser, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a pending scheduled message from the queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatDeleteScheduledMessage(token,
        contentType,
        channel,
        scheduledMessageId,
        asUser);
    // TODO: Handle 'response' of type ChatDeleteScheduledMessageschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>scheduledMessageId</code> | <code>string</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatDeleteScheduledMessageschema](Models/ChatDeleteScheduledMessageschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatDeleteScheduledMessageschema1&gt; ChatDeleteScheduledMessage1(string token, ContentType contentType, string channel, string scheduledMessageId, bool? asUser, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a pending scheduled message from the queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatDeleteScheduledMessage1(token,
        contentType,
        channel,
        scheduledMessageId,
        asUser);
    // TODO: Handle 'response' of type ChatDeleteScheduledMessageschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>scheduledMessageId</code> | <code>string</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatDeleteScheduledMessageschema1](Models/ChatDeleteScheduledMessageschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatGetPermalinksuccessschema&gt; ChatGetPermalink(string token, string channel, string messageTs, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a permalink URL for a specific extant message

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatGetPermalink(token, channel, messageTs, contentType);
    // TODO: Handle 'response' of type ChatGetPermalinksuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>channel</code> | <code>string</code> | The ID of the conversation or channel containing the message |
| <code>messageTs</code> | <code>string</code> | A message's `ts` value, uniquely identifying it within a channel |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatGetPermalinksuccessschema](Models/ChatGetPermalinksuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatGetPermalinksuccessschema1&gt; ChatGetPermalink1(string token, string channel, string messageTs, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a permalink URL for a specific extant message

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatGetPermalink1(token, channel, messageTs, contentType);
    // TODO: Handle 'response' of type ChatGetPermalinksuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>channel</code> | <code>string</code> | The ID of the conversation or channel containing the message |
| <code>messageTs</code> | <code>string</code> | A message's `ts` value, uniquely identifying it within a channel |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatGetPermalinksuccessschema1](Models/ChatGetPermalinksuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatMeMessageschema&gt; ChatMeMessage(ContentType contentType, string? token, string? channel, string? text, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Share a me message into a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatMeMessage(contentType, token, channel, text);
    // TODO: Handle 'response' of type ChatMeMessageschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `chat:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatMeMessageschema](Models/ChatMeMessageschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatMeMessageschema1&gt; ChatMeMessage1(ContentType contentType, string? token, string? channel, string? text, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Share a me message into a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatMeMessage1(contentType, token, channel, text);
    // TODO: Handle 'response' of type ChatMeMessageschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `chat:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatMeMessageschema1](Models/ChatMeMessageschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatPostEphemeralsuccessschema&gt; ChatPostEphemeral(string token, ContentType contentType, string channel, string user, bool? asUser, string? attachments, string? blocks, string? iconEmoji, string? iconUrl, bool? linkNames, string? parse, string? text, string? threadTs, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends an ephemeral message to a user in a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatPostEphemeral(token,
        contentType,
        channel,
        user,
        asUser,
        attachments,
        blocks,
        iconEmoji,
        iconUrl,
        linkNames,
        parse,
        text,
        threadTs,
        username);
    // TODO: Handle 'response' of type ChatPostEphemeralsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>user</code> | <code>string</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>iconEmoji</code> | <code>string?</code> | - |
| <code>iconUrl</code> | <code>string?</code> | - |
| <code>linkNames</code> | <code>bool?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |
| <code>threadTs</code> | <code>string?</code> | - |
| <code>username</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatPostEphemeralsuccessschema](Models/ChatPostEphemeralsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatPostEphemeralsuccessschema1&gt; ChatPostEphemeral1(string token, ContentType contentType, string channel, string user, bool? asUser, string? attachments, string? blocks, string? iconEmoji, string? iconUrl, bool? linkNames, string? parse, string? text, string? threadTs, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends an ephemeral message to a user in a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatPostEphemeral1(token,
        contentType,
        channel,
        user,
        asUser,
        attachments,
        blocks,
        iconEmoji,
        iconUrl,
        linkNames,
        parse,
        text,
        threadTs,
        username);
    // TODO: Handle 'response' of type ChatPostEphemeralsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>user</code> | <code>string</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>iconEmoji</code> | <code>string?</code> | - |
| <code>iconUrl</code> | <code>string?</code> | - |
| <code>linkNames</code> | <code>bool?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |
| <code>threadTs</code> | <code>string?</code> | - |
| <code>username</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatPostEphemeralsuccessschema1](Models/ChatPostEphemeralsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatPostMessagesuccessschema&gt; ChatPostMessage(string token, ContentType contentType, string channel, string? asUser, string? attachments, string? blocks, string? iconEmoji, string? iconUrl, bool? linkNames, bool? mrkdwn, string? parse, bool? replyBroadcast, string? text, string? threadTs, bool? unfurlLinks, bool? unfurlMedia, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a message to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatPostMessage(token,
        contentType,
        channel,
        asUser,
        attachments,
        blocks,
        iconEmoji,
        iconUrl,
        linkNames,
        mrkdwn,
        parse,
        replyBroadcast,
        text,
        threadTs,
        unfurlLinks,
        unfurlMedia,
        username);
    // TODO: Handle 'response' of type ChatPostMessagesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>asUser</code> | <code>string?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>iconEmoji</code> | <code>string?</code> | - |
| <code>iconUrl</code> | <code>string?</code> | - |
| <code>linkNames</code> | <code>bool?</code> | - |
| <code>mrkdwn</code> | <code>bool?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>replyBroadcast</code> | <code>bool?</code> | - |
| <code>text</code> | <code>string?</code> | - |
| <code>threadTs</code> | <code>string?</code> | - |
| <code>unfurlLinks</code> | <code>bool?</code> | - |
| <code>unfurlMedia</code> | <code>bool?</code> | - |
| <code>username</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatPostMessagesuccessschema](Models/ChatPostMessagesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatPostMessagesuccessschema1&gt; ChatPostMessage1(string token, ContentType contentType, string channel, string? asUser, string? attachments, string? blocks, string? iconEmoji, string? iconUrl, bool? linkNames, bool? mrkdwn, string? parse, bool? replyBroadcast, string? text, string? threadTs, bool? unfurlLinks, bool? unfurlMedia, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a message to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatPostMessage1(token,
        contentType,
        channel,
        asUser,
        attachments,
        blocks,
        iconEmoji,
        iconUrl,
        linkNames,
        mrkdwn,
        parse,
        replyBroadcast,
        text,
        threadTs,
        unfurlLinks,
        unfurlMedia,
        username);
    // TODO: Handle 'response' of type ChatPostMessagesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>asUser</code> | <code>string?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>iconEmoji</code> | <code>string?</code> | - |
| <code>iconUrl</code> | <code>string?</code> | - |
| <code>linkNames</code> | <code>bool?</code> | - |
| <code>mrkdwn</code> | <code>bool?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>replyBroadcast</code> | <code>bool?</code> | - |
| <code>text</code> | <code>string?</code> | - |
| <code>threadTs</code> | <code>string?</code> | - |
| <code>unfurlLinks</code> | <code>bool?</code> | - |
| <code>unfurlMedia</code> | <code>bool?</code> | - |
| <code>username</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatPostMessagesuccessschema1](Models/ChatPostMessagesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduleMessagesuccessschema&gt; ChatScheduleMessage(ContentType contentType, string? token, string? channel, string? text, string? postAt, string? parse, bool? asUser, bool? linkNames, string? attachments, string? blocks, bool? unfurlLinks, bool? unfurlMedia, double? threadTs, bool? replyBroadcast, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a message to be sent to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatScheduleMessage(contentType,
        token,
        channel,
        text,
        postAt,
        parse,
        asUser,
        linkNames,
        attachments,
        blocks,
        unfurlLinks,
        unfurlMedia,
        threadTs,
        replyBroadcast);
    // TODO: Handle 'response' of type ChatScheduleMessagesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `chat:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |
| <code>postAt</code> | <code>string?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |
| <code>linkNames</code> | <code>bool?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>unfurlLinks</code> | <code>bool?</code> | - |
| <code>unfurlMedia</code> | <code>bool?</code> | - |
| <code>threadTs</code> | <code>double?</code> | - |
| <code>replyBroadcast</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduleMessagesuccessschema](Models/ChatScheduleMessagesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduleMessagesuccessschema1&gt; ChatScheduleMessage1(ContentType contentType, string? token, string? channel, string? text, string? postAt, string? parse, bool? asUser, bool? linkNames, string? attachments, string? blocks, bool? unfurlLinks, bool? unfurlMedia, double? threadTs, bool? replyBroadcast, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a message to be sent to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatScheduleMessage1(contentType,
        token,
        channel,
        text,
        postAt,
        parse,
        asUser,
        linkNames,
        attachments,
        blocks,
        unfurlLinks,
        unfurlMedia,
        threadTs,
        replyBroadcast);
    // TODO: Handle 'response' of type ChatScheduleMessagesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `chat:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |
| <code>postAt</code> | <code>string?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>asUser</code> | <code>bool?</code> | - |
| <code>linkNames</code> | <code>bool?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>unfurlLinks</code> | <code>bool?</code> | - |
| <code>unfurlMedia</code> | <code>bool?</code> | - |
| <code>threadTs</code> | <code>double?</code> | - |
| <code>replyBroadcast</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduleMessagesuccessschema1](Models/ChatScheduleMessagesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduledMessagesListschema&gt; ChatScheduledMessagesList(string? channel, double? latest, double? oldest, int? limit, string? cursor, ContentType contentType, string? token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of scheduled messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatScheduledMessagesList(channel,
        latest,
        oldest,
        limit,
        cursor,
        contentType,
        token);
    // TODO: Handle 'response' of type ChatScheduledMessagesListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channel</code> | <code>string?</code> | The channel of the scheduled messages |
| <code>latest</code> | <code>double?</code> | A UNIX timestamp of the latest value in the time range |
| <code>oldest</code> | <code>double?</code> | A UNIX timestamp of the oldest value in the time range |
| <code>limit</code> | <code>int?</code> | Maximum number of original entries to return. |
| <code>cursor</code> | <code>string?</code> | For pagination purposes, this is the `cursor` value returned from a previous call to `chat.scheduledmessages.list` indicating where you want to start this call from. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduledMessagesListschema](Models/ChatScheduledMessagesListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduledMessagesListschema1&gt; ChatScheduledMessagesList1(string? channel, double? latest, double? oldest, int? limit, string? cursor, ContentType contentType, string? token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of scheduled messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatScheduledMessagesList1(channel,
        latest,
        oldest,
        limit,
        cursor,
        contentType,
        token);
    // TODO: Handle 'response' of type ChatScheduledMessagesListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channel</code> | <code>string?</code> | The channel of the scheduled messages |
| <code>latest</code> | <code>double?</code> | A UNIX timestamp of the latest value in the time range |
| <code>oldest</code> | <code>double?</code> | A UNIX timestamp of the oldest value in the time range |
| <code>limit</code> | <code>int?</code> | Maximum number of original entries to return. |
| <code>cursor</code> | <code>string?</code> | For pagination purposes, this is the `cursor` value returned from a previous call to `chat.scheduledmessages.list` indicating where you want to start this call from. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduledMessagesListschema1](Models/ChatScheduledMessagesListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatUnfurlsuccessschema&gt; ChatUnfurl(string token, ContentType contentType, string channel, string ts, string? unfurls, string? userAuthMessage, bool? userAuthRequired, string? userAuthUrl, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provide custom unfurl behavior for user-posted URLs

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatUnfurl(token,
        contentType,
        channel,
        ts,
        unfurls,
        userAuthMessage,
        userAuthRequired,
        userAuthUrl);
    // TODO: Handle 'response' of type ChatUnfurlsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `links:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>ts</code> | <code>string</code> | - |
| <code>unfurls</code> | <code>string?</code> | - |
| <code>userAuthMessage</code> | <code>string?</code> | - |
| <code>userAuthRequired</code> | <code>bool?</code> | - |
| <code>userAuthUrl</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatUnfurlsuccessschema](Models/ChatUnfurlsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatUnfurlsuccessschema1&gt; ChatUnfurl1(string token, ContentType contentType, string channel, string ts, string? unfurls, string? userAuthMessage, bool? userAuthRequired, string? userAuthUrl, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provide custom unfurl behavior for user-posted URLs

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatUnfurl1(token,
        contentType,
        channel,
        ts,
        unfurls,
        userAuthMessage,
        userAuthRequired,
        userAuthUrl);
    // TODO: Handle 'response' of type ChatUnfurlsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `links:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>ts</code> | <code>string</code> | - |
| <code>unfurls</code> | <code>string?</code> | - |
| <code>userAuthMessage</code> | <code>string?</code> | - |
| <code>userAuthRequired</code> | <code>bool?</code> | - |
| <code>userAuthUrl</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatUnfurlsuccessschema1](Models/ChatUnfurlsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatUpdatesuccessschema&gt; ChatUpdate(string token, ContentType contentType, string channel, string ts, string? asUser, string? attachments, string? blocks, string? linkNames, string? parse, string? text, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatUpdate(token,
        contentType,
        channel,
        ts,
        asUser,
        attachments,
        blocks,
        linkNames,
        parse,
        text);
    // TODO: Handle 'response' of type ChatUpdatesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>ts</code> | <code>string</code> | - |
| <code>asUser</code> | <code>string?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>linkNames</code> | <code>string?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatUpdatesuccessschema](Models/ChatUpdatesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatUpdatesuccessschema1&gt; ChatUpdate1(string token, ContentType contentType, string channel, string ts, string? asUser, string? attachments, string? blocks, string? linkNames, string? parse, string? text, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatUpdate1(token,
        contentType,
        channel,
        ts,
        asUser,
        attachments,
        blocks,
        linkNames,
        parse,
        text);
    // TODO: Handle 'response' of type ChatUpdatesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `chat:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>ts</code> | <code>string</code> | - |
| <code>asUser</code> | <code>string?</code> | - |
| <code>attachments</code> | <code>string?</code> | - |
| <code>blocks</code> | <code>string?</code> | - |
| <code>linkNames</code> | <code>string?</code> | - |
| <code>parse</code> | <code>string?</code> | - |
| <code>text</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatUpdatesuccessschema1](Models/ChatUpdatesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChatScheduledMessages

> Source: [ChatScheduledMessages](Api/ChatScheduledMessages.cs)

<details>
<summary><code>Task&lt;ChatScheduledMessagesListschema&gt; ChatScheduledMessagesList(string? channel, double? latest, double? oldest, int? limit, string? cursor, ContentType contentType, string? token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of scheduled messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChatScheduledMessages.ChatScheduledMessagesList(channel,
        latest,
        oldest,
        limit,
        cursor,
        contentType,
        token);
    // TODO: Handle 'response' of type ChatScheduledMessagesListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channel</code> | <code>string?</code> | The channel of the scheduled messages |
| <code>latest</code> | <code>double?</code> | A UNIX timestamp of the latest value in the time range |
| <code>oldest</code> | <code>double?</code> | A UNIX timestamp of the oldest value in the time range |
| <code>limit</code> | <code>int?</code> | Maximum number of original entries to return. |
| <code>cursor</code> | <code>string?</code> | For pagination purposes, this is the `cursor` value returned from a previous call to `chat.scheduledmessages.list` indicating where you want to start this call from. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduledMessagesListschema](Models/ChatScheduledMessagesListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduledMessagesListschema1&gt; ChatScheduledMessagesList1(string? channel, double? latest, double? oldest, int? limit, string? cursor, ContentType contentType, string? token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of scheduled messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChatScheduledMessages.ChatScheduledMessagesList1(channel,
        latest,
        oldest,
        limit,
        cursor,
        contentType,
        token);
    // TODO: Handle 'response' of type ChatScheduledMessagesListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channel</code> | <code>string?</code> | The channel of the scheduled messages |
| <code>latest</code> | <code>double?</code> | A UNIX timestamp of the latest value in the time range |
| <code>oldest</code> | <code>double?</code> | A UNIX timestamp of the oldest value in the time range |
| <code>limit</code> | <code>int?</code> | Maximum number of original entries to return. |
| <code>cursor</code> | <code>string?</code> | For pagination purposes, this is the `cursor` value returned from a previous call to `chat.scheduledmessages.list` indicating where you want to start this call from. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `none` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduledMessagesListschema1](Models/ChatScheduledMessagesListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Conversations

> Source: [Conversations](Api/Conversations.cs)

<details>
<summary><code>Task&lt;ConversationsArchivesuccessschema&gt; ConversationsArchive(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Archives a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsArchive(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsArchivesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsArchivesuccessschema](Models/ConversationsArchivesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsArchivesuccessschema1&gt; ConversationsArchive1(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Archives a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsArchive1(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsArchivesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsArchivesuccessschema1](Models/ConversationsArchivesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsClosesuccessschema&gt; ConversationsClose(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes a direct message or multi-person direct message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsClose(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsClosesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsClosesuccessschema](Models/ConversationsClosesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsClosesuccessschema1&gt; ConversationsClose1(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes a direct message or multi-person direct message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsClose1(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsClosesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsClosesuccessschema1](Models/ConversationsClosesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsCreatesuccessschema&gt; ConversationsCreate(ContentType contentType, string? token, string? name, bool? isPrivate, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a public or private channel-based conversation

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsCreate(contentType, token, name, isPrivate);
    // TODO: Handle 'response' of type ConversationsCreatesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>name</code> | <code>string?</code> | - |
| <code>isPrivate</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsCreatesuccessschema](Models/ConversationsCreatesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsCreatesuccessschema1&gt; ConversationsCreate1(ContentType contentType, string? token, string? name, bool? isPrivate, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a public or private channel-based conversation

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsCreate1(contentType, token, name, isPrivate);
    // TODO: Handle 'response' of type ConversationsCreatesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>name</code> | <code>string?</code> | - |
| <code>isPrivate</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsCreatesuccessschema1](Models/ConversationsCreatesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsHistorysuccessschema&gt; ConversationsHistory(string? token, string? channel, double? latest, double? oldest, bool? inclusive, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetches a conversation's history of messages and events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsHistory(token,
        channel,
        latest,
        oldest,
        inclusive,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type ConversationsHistorysuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:history` |
| <code>channel</code> | <code>string?</code> | Conversation ID to fetch history for. |
| <code>latest</code> | <code>double?</code> | End of time range of messages to include in results. |
| <code>oldest</code> | <code>double?</code> | Start of time range of messages to include in results. |
| <code>inclusive</code> | <code>bool?</code> | Include messages with latest or oldest timestamp in results only when either timestamp is specified. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsHistorysuccessschema](Models/ConversationsHistorysuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsHistorysuccessschema1&gt; ConversationsHistory1(string? token, string? channel, double? latest, double? oldest, bool? inclusive, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetches a conversation's history of messages and events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsHistory1(token,
        channel,
        latest,
        oldest,
        inclusive,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type ConversationsHistorysuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:history` |
| <code>channel</code> | <code>string?</code> | Conversation ID to fetch history for. |
| <code>latest</code> | <code>double?</code> | End of time range of messages to include in results. |
| <code>oldest</code> | <code>double?</code> | Start of time range of messages to include in results. |
| <code>inclusive</code> | <code>bool?</code> | Include messages with latest or oldest timestamp in results only when either timestamp is specified. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsHistorysuccessschema1](Models/ConversationsHistorysuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsInfosuccessschema&gt; ConversationsInfo(string? token, string? channel, bool? includeLocale, bool? includeNumMembers, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsInfo(token,
        channel,
        includeLocale,
        includeNumMembers,
        contentType);
    // TODO: Handle 'response' of type ConversationsInfosuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>channel</code> | <code>string?</code> | Conversation ID to learn more about |
| <code>includeLocale</code> | <code>bool?</code> | Set this to `true` to receive the locale for this conversation. Defaults to `false` |
| <code>includeNumMembers</code> | <code>bool?</code> | Set to `true` to include the member count for the specified conversation. Defaults to `false` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsInfosuccessschema](Models/ConversationsInfosuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsInfosuccessschema1&gt; ConversationsInfo1(string? token, string? channel, bool? includeLocale, bool? includeNumMembers, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsInfo1(token,
        channel,
        includeLocale,
        includeNumMembers,
        contentType);
    // TODO: Handle 'response' of type ConversationsInfosuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>channel</code> | <code>string?</code> | Conversation ID to learn more about |
| <code>includeLocale</code> | <code>bool?</code> | Set this to `true` to receive the locale for this conversation. Defaults to `false` |
| <code>includeNumMembers</code> | <code>bool?</code> | Set to `true` to include the member count for the specified conversation. Defaults to `false` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsInfosuccessschema1](Models/ConversationsInfosuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsInviteerrorschema&gt; ConversationsInvite(ContentType contentType, string? token, string? channel, string? users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invites users to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsInvite(contentType, token, channel, users);
    // TODO: Handle 'response' of type ConversationsInviteerrorschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>users</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsInviteerrorschema](Models/ConversationsInviteerrorschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsInviteerrorschema1&gt; ConversationsInvite1(ContentType contentType, string? token, string? channel, string? users, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invites users to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsInvite1(contentType, token, channel, users);
    // TODO: Handle 'response' of type ConversationsInviteerrorschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>users</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsInviteerrorschema1](Models/ConversationsInviteerrorschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsJoinsuccessschema&gt; ConversationsJoin(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Joins an existing conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsJoin(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsJoinsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `channels:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsJoinsuccessschema](Models/ConversationsJoinsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsJoinsuccessschema1&gt; ConversationsJoin1(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Joins an existing conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsJoin1(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsJoinsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `channels:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsJoinsuccessschema1](Models/ConversationsJoinsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsKicksuccessschema&gt; ConversationsKick(ContentType contentType, string? token, string? channel, string? user, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a user from a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsKick(contentType, token, channel, user);
    // TODO: Handle 'response' of type ConversationsKicksuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>user</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsKicksuccessschema](Models/ConversationsKicksuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsKicksuccessschema1&gt; ConversationsKick1(ContentType contentType, string? token, string? channel, string? user, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a user from a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsKick1(contentType, token, channel, user);
    // TODO: Handle 'response' of type ConversationsKicksuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>user</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsKicksuccessschema1](Models/ConversationsKicksuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsLeavesuccessschema&gt; ConversationsLeave(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Leaves a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsLeave(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsLeavesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsLeavesuccessschema](Models/ConversationsLeavesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsLeavesuccessschema1&gt; ConversationsLeave1(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Leaves a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsLeave1(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsLeavesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsLeavesuccessschema1](Models/ConversationsLeavesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsListsuccessschema&gt; ConversationsList(string? token, bool? excludeArchived, string? types, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all channels in a Slack team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsList(token,
        excludeArchived,
        types,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type ConversationsListsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>excludeArchived</code> | <code>bool?</code> | Set to `true` to exclude archived channels from the list |
| <code>types</code> | <code>string?</code> | Mix and match channel types by providing a comma-separated list of any combination of `public_channel`, `private_channel`, `mpim`, `im` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsListsuccessschema](Models/ConversationsListsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsListsuccessschema1&gt; ConversationsList1(string? token, bool? excludeArchived, string? types, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all channels in a Slack team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsList1(token,
        excludeArchived,
        types,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type ConversationsListsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>excludeArchived</code> | <code>bool?</code> | Set to `true` to exclude archived channels from the list |
| <code>types</code> | <code>string?</code> | Mix and match channel types by providing a comma-separated list of any combination of `public_channel`, `private_channel`, `mpim`, `im` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsListsuccessschema1](Models/ConversationsListsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsMarksuccessschema&gt; ConversationsMark(ContentType contentType, string? token, string? channel, double? ts, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the read cursor in a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsMark(contentType, token, channel, ts);
    // TODO: Handle 'response' of type ConversationsMarksuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>ts</code> | <code>double?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsMarksuccessschema](Models/ConversationsMarksuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsMarksuccessschema1&gt; ConversationsMark1(ContentType contentType, string? token, string? channel, double? ts, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the read cursor in a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsMark1(contentType, token, channel, ts);
    // TODO: Handle 'response' of type ConversationsMarksuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>ts</code> | <code>double?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsMarksuccessschema1](Models/ConversationsMarksuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsMemberssuccessschema&gt; ConversationsMembers(string? token, string? channel, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve members of a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsMembers(token, channel, limit, cursor, contentType);
    // TODO: Handle 'response' of type ConversationsMemberssuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>channel</code> | <code>string?</code> | ID of the conversation to retrieve members for |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsMemberssuccessschema](Models/ConversationsMemberssuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsMemberssuccessschema1&gt; ConversationsMembers1(string? token, string? channel, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve members of a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsMembers1(token, channel, limit, cursor, contentType);
    // TODO: Handle 'response' of type ConversationsMemberssuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>channel</code> | <code>string?</code> | ID of the conversation to retrieve members for |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsMemberssuccessschema1](Models/ConversationsMemberssuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsOpensuccessschema&gt; ConversationsOpen(ContentType contentType, string? token, string? channel, string? users, bool? returnIm, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Opens or resumes a direct message or multi-person direct message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsOpen(contentType, token, channel, users, returnIm);
    // TODO: Handle 'response' of type ConversationsOpensuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>users</code> | <code>string?</code> | - |
| <code>returnIm</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsOpensuccessschema](Models/ConversationsOpensuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsOpensuccessschema1&gt; ConversationsOpen1(ContentType contentType, string? token, string? channel, string? users, bool? returnIm, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Opens or resumes a direct message or multi-person direct message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsOpen1(contentType, token, channel, users, returnIm);
    // TODO: Handle 'response' of type ConversationsOpensuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>users</code> | <code>string?</code> | - |
| <code>returnIm</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsOpensuccessschema1](Models/ConversationsOpensuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsRenamesuccessschema&gt; ConversationsRename(ContentType contentType, string? token, string? channel, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Renames a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsRename(contentType, token, channel, name);
    // TODO: Handle 'response' of type ConversationsRenamesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>name</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsRenamesuccessschema](Models/ConversationsRenamesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsRenamesuccessschema1&gt; ConversationsRename1(ContentType contentType, string? token, string? channel, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Renames a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsRename1(contentType, token, channel, name);
    // TODO: Handle 'response' of type ConversationsRenamesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>name</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsRenamesuccessschema1](Models/ConversationsRenamesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsRepliessuccessschema&gt; ConversationsReplies(string? token, string? channel, double? ts, double? latest, double? oldest, bool? inclusive, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a thread of messages posted to a conversation

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsReplies(token,
        channel,
        ts,
        latest,
        oldest,
        inclusive,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type ConversationsRepliessuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:history` |
| <code>channel</code> | <code>string?</code> | Conversation ID to fetch thread from. |
| <code>ts</code> | <code>double?</code> | Unique identifier of a thread's parent message. `ts` must be the timestamp of an existing message with 0 or more replies. If there are no replies then just the single message referenced by `ts` will return - it is just an ordinary, unthreaded message. |
| <code>latest</code> | <code>double?</code> | End of time range of messages to include in results. |
| <code>oldest</code> | <code>double?</code> | Start of time range of messages to include in results. |
| <code>inclusive</code> | <code>bool?</code> | Include messages with latest or oldest timestamp in results only when either timestamp is specified. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsRepliessuccessschema](Models/ConversationsRepliessuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsRepliessuccessschema1&gt; ConversationsReplies1(string? token, string? channel, double? ts, double? latest, double? oldest, bool? inclusive, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a thread of messages posted to a conversation

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsReplies1(token,
        channel,
        ts,
        latest,
        oldest,
        inclusive,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type ConversationsRepliessuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:history` |
| <code>channel</code> | <code>string?</code> | Conversation ID to fetch thread from. |
| <code>ts</code> | <code>double?</code> | Unique identifier of a thread's parent message. `ts` must be the timestamp of an existing message with 0 or more replies. If there are no replies then just the single message referenced by `ts` will return - it is just an ordinary, unthreaded message. |
| <code>latest</code> | <code>double?</code> | End of time range of messages to include in results. |
| <code>oldest</code> | <code>double?</code> | Start of time range of messages to include in results. |
| <code>inclusive</code> | <code>bool?</code> | Include messages with latest or oldest timestamp in results only when either timestamp is specified. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsRepliessuccessschema1](Models/ConversationsRepliessuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsSetPurposesuccessschema&gt; ConversationsSetPurpose(ContentType contentType, string? token, string? channel, string? purpose, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the purpose for a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsSetPurpose(contentType, token, channel, purpose);
    // TODO: Handle 'response' of type ConversationsSetPurposesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>purpose</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsSetPurposesuccessschema](Models/ConversationsSetPurposesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsSetPurposesuccessschema1&gt; ConversationsSetPurpose1(ContentType contentType, string? token, string? channel, string? purpose, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the purpose for a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsSetPurpose1(contentType, token, channel, purpose);
    // TODO: Handle 'response' of type ConversationsSetPurposesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>purpose</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsSetPurposesuccessschema1](Models/ConversationsSetPurposesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsSetTopicsuccessschema&gt; ConversationsSetTopic(ContentType contentType, string? token, string? channel, string? topic, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the topic for a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsSetTopic(contentType, token, channel, topic);
    // TODO: Handle 'response' of type ConversationsSetTopicsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>topic</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsSetTopicsuccessschema](Models/ConversationsSetTopicsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsSetTopicsuccessschema1&gt; ConversationsSetTopic1(ContentType contentType, string? token, string? channel, string? topic, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the topic for a conversation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsSetTopic1(contentType, token, channel, topic);
    // TODO: Handle 'response' of type ConversationsSetTopicsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |
| <code>topic</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsSetTopicsuccessschema1](Models/ConversationsSetTopicsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsUnarchivesuccessschema&gt; ConversationsUnarchive(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reverses conversation archival.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsUnarchive(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsUnarchivesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsUnarchivesuccessschema](Models/ConversationsUnarchivesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsUnarchivesuccessschema1&gt; ConversationsUnarchive1(ContentType contentType, string? token, string? channel, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reverses conversation archival.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Conversations.ConversationsUnarchive1(contentType, token, channel);
    // TODO: Handle 'response' of type ConversationsUnarchivesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:write` |
| <code>channel</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsUnarchivesuccessschema1](Models/ConversationsUnarchivesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Dialog

> Source: [Dialog](Api/Dialog.cs)

<details>
<summary><code>Task&lt;DialogOpenschema&gt; DialogOpen(string dialog, string triggerId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Open a dialog with a user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dialog.DialogOpen(dialog, triggerId, token, contentType);
    // TODO: Handle 'response' of type DialogOpenschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>dialog</code> | <code>string</code> | The dialog definition. This must be a JSON-encoded string. |
| <code>triggerId</code> | <code>string</code> | Exchange a trigger to post to the user. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DialogOpenschema](Models/DialogOpenschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DialogOpenschema1&gt; DialogOpen1(string dialog, string triggerId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Open a dialog with a user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dialog.DialogOpen1(dialog, triggerId, token, contentType);
    // TODO: Handle 'response' of type DialogOpenschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>dialog</code> | <code>string</code> | The dialog definition. This must be a JSON-encoded string. |
| <code>triggerId</code> | <code>string</code> | Exchange a trigger to post to the user. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DialogOpenschema1](Models/DialogOpenschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Dnd

> Source: [Dnd](Api/Dnd.cs)

<details>
<summary><code>Task&lt;DndEndDndschema&gt; DndEndDnd(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends the current user's Do Not Disturb session immediately.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndEndDnd(token, contentType);
    // TODO: Handle 'response' of type DndEndDndschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `dnd:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndEndDndschema](Models/DndEndDndschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndEndDndschema1&gt; DndEndDnd1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends the current user's Do Not Disturb session immediately.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndEndDnd1(token, contentType);
    // TODO: Handle 'response' of type DndEndDndschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `dnd:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndEndDndschema1](Models/DndEndDndschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndEndSnoozeschema&gt; DndEndSnooze(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends the current user's snooze mode immediately.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndEndSnooze(token, contentType);
    // TODO: Handle 'response' of type DndEndSnoozeschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `dnd:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndEndSnoozeschema](Models/DndEndSnoozeschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndEndSnoozeschema1&gt; DndEndSnooze1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends the current user's snooze mode immediately.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndEndSnooze1(token, contentType);
    // TODO: Handle 'response' of type DndEndSnoozeschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `dnd:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndEndSnoozeschema1](Models/DndEndSnoozeschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndInfoschema&gt; DndInfo(string? token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a user's current Do Not Disturb status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndInfo(token, user, contentType);
    // TODO: Handle 'response' of type DndInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `dnd:read` |
| <code>user</code> | <code>string?</code> | User to fetch status for (defaults to current user) |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndInfoschema](Models/DndInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndInfoschema1&gt; DndInfo1(string? token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a user's current Do Not Disturb status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndInfo1(token, user, contentType);
    // TODO: Handle 'response' of type DndInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `dnd:read` |
| <code>user</code> | <code>string?</code> | User to fetch status for (defaults to current user) |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndInfoschema1](Models/DndInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndSetSnoozeschema&gt; DndSetSnooze(ContentType contentType, string token, string numMinutes, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Turns on Do Not Disturb mode for the current user, or changes its duration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndSetSnooze(contentType, token, numMinutes);
    // TODO: Handle 'response' of type DndSetSnoozeschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>numMinutes</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndSetSnoozeschema](Models/DndSetSnoozeschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndSetSnoozeschema1&gt; DndSetSnooze1(ContentType contentType, string token, string numMinutes, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Turns on Do Not Disturb mode for the current user, or changes its duration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndSetSnooze1(contentType, token, numMinutes);
    // TODO: Handle 'response' of type DndSetSnoozeschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>numMinutes</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndSetSnoozeschema1](Models/DndSetSnoozeschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; DndTeamInfo(string? token, string? users, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the Do Not Disturb status for up to 50 users on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndTeamInfo(token, users, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `dnd:read` |
| <code>users</code> | <code>string?</code> | Comma-separated list of users to fetch Do Not Disturb status for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; DndTeamInfo1(string? token, string? users, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the Do Not Disturb status for up to 50 users on a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Dnd.DndTeamInfo1(token, users, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `dnd:read` |
| <code>users</code> | <code>string?</code> | Comma-separated list of users to fetch Do Not Disturb status for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Emoji

> Source: [Emoji](Api/Emoji.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; EmojiList(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists custom emoji for a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Emoji.EmojiList(token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `emoji:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; EmojiList1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists custom emoji for a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Emoji.EmojiList1(token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `emoji:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Files

> Source: [Files](Api/Files.cs)

<details>
<summary><code>Task&lt;FilesCommentsDeleteschema&gt; FilesCommentsDelete(ContentType contentType, string? token, string? file, string? id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing comment on a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesCommentsDelete(contentType, token, file, id);
    // TODO: Handle 'response' of type FilesCommentsDeleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |
| <code>id</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesCommentsDeleteschema](Models/FilesCommentsDeleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesCommentsDeleteschema1&gt; FilesCommentsDelete1(ContentType contentType, string? token, string? file, string? id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing comment on a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesCommentsDelete1(contentType, token, file, id);
    // TODO: Handle 'response' of type FilesCommentsDeleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |
| <code>id</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesCommentsDeleteschema1](Models/FilesCommentsDeleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesDeleteschema&gt; FilesDelete(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesDelete(contentType, token, file);
    // TODO: Handle 'response' of type FilesDeleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesDeleteschema](Models/FilesDeleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesDeleteschema1&gt; FilesDelete1(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesDelete1(contentType, token, file);
    // TODO: Handle 'response' of type FilesDeleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesDeleteschema1](Models/FilesDeleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesInfoschema&gt; FilesInfo(string? token, string? file, string? count, string? page, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesInfo(token, file, count, page, limit, cursor, contentType);
    // TODO: Handle 'response' of type FilesInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:read` |
| <code>file</code> | <code>string?</code> | Specify a file by providing its ID. |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Parameter for pagination. File comments are paginated for a single file. Set `cursor` equal to the `next_cursor` attribute returned by the previous request's `response_metadata`. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection of comments. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesInfoschema](Models/FilesInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesInfoschema1&gt; FilesInfo1(string? token, string? file, string? count, string? page, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesInfo1(token, file, count, page, limit, cursor, contentType);
    // TODO: Handle 'response' of type FilesInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:read` |
| <code>file</code> | <code>string?</code> | Specify a file by providing its ID. |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. |
| <code>cursor</code> | <code>string?</code> | Parameter for pagination. File comments are paginated for a single file. Set `cursor` equal to the `next_cursor` attribute returned by the previous request's `response_metadata`. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection of comments. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesInfoschema1](Models/FilesInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesListschema&gt; FilesList(string? token, string? user, string? channel, double? tsFrom, double? tsTo, string? types, string? count, string? page, bool? showFilesHiddenByLimit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List for a team, in a channel, or from a user with applied filters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesList(token,
        user,
        channel,
        tsFrom,
        tsTo,
        types,
        count,
        page,
        showFilesHiddenByLimit,
        contentType);
    // TODO: Handle 'response' of type FilesListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:read` |
| <code>user</code> | <code>string?</code> | Filter files created by a single user. |
| <code>channel</code> | <code>string?</code> | Filter files appearing in a specific channel, indicated by its ID. |
| <code>tsFrom</code> | <code>double?</code> | Filter files created after this timestamp (inclusive). |
| <code>tsTo</code> | <code>double?</code> | Filter files created before this timestamp (inclusive). |
| <code>types</code> | <code>string?</code> | Filter files by type ([see below](#file_types)). You can pass multiple values in the types argument, like `types=spaces,snippets`.The default value is `all`, which does not filter the list. |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>showFilesHiddenByLimit</code> | <code>bool?</code> | Show truncated file info for files hidden due to being too old, and the team who owns the file being over the file limit. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesListschema](Models/FilesListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesListschema1&gt; FilesList1(string? token, string? user, string? channel, double? tsFrom, double? tsTo, string? types, string? count, string? page, bool? showFilesHiddenByLimit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List for a team, in a channel, or from a user with applied filters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesList1(token,
        user,
        channel,
        tsFrom,
        tsTo,
        types,
        count,
        page,
        showFilesHiddenByLimit,
        contentType);
    // TODO: Handle 'response' of type FilesListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:read` |
| <code>user</code> | <code>string?</code> | Filter files created by a single user. |
| <code>channel</code> | <code>string?</code> | Filter files appearing in a specific channel, indicated by its ID. |
| <code>tsFrom</code> | <code>double?</code> | Filter files created after this timestamp (inclusive). |
| <code>tsTo</code> | <code>double?</code> | Filter files created before this timestamp (inclusive). |
| <code>types</code> | <code>string?</code> | Filter files by type ([see below](#file_types)). You can pass multiple values in the types argument, like `types=spaces,snippets`.The default value is `all`, which does not filter the list. |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>showFilesHiddenByLimit</code> | <code>bool?</code> | Show truncated file info for files hidden due to being too old, and the team who owns the file being over the file limit. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesListschema1](Models/FilesListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteAdd(ContentType contentType, string? token, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a file from a remote service

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteAdd(contentType,
        token,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteAdd1(ContentType contentType, string? token, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a file from a remote service

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteAdd1(contentType,
        token,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteInfo(string? token, string? file, string? externalId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteInfo(token, file, externalId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>file</code> | <code>string?</code> | Specify a file by providing its ID. |
| <code>externalId</code> | <code>string?</code> | Creator defined GUID for the file. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteInfo1(string? token, string? file, string? externalId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteInfo1(token, file, externalId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>file</code> | <code>string?</code> | Specify a file by providing its ID. |
| <code>externalId</code> | <code>string?</code> | Creator defined GUID for the file. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteList(string? token, string? channel, double? tsFrom, double? tsTo, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteList(token, channel, tsFrom, tsTo, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>channel</code> | <code>string?</code> | Filter files appearing in a specific channel, indicated by its ID. |
| <code>tsFrom</code> | <code>double?</code> | Filter files created after this timestamp (inclusive). |
| <code>tsTo</code> | <code>double?</code> | Filter files created before this timestamp (inclusive). |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteList1(string? token, string? channel, double? tsFrom, double? tsTo, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteList1(token, channel, tsFrom, tsTo, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>channel</code> | <code>string?</code> | Filter files appearing in a specific channel, indicated by its ID. |
| <code>tsFrom</code> | <code>double?</code> | Filter files created after this timestamp (inclusive). |
| <code>tsTo</code> | <code>double?</code> | Filter files created before this timestamp (inclusive). |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteRemove(ContentType contentType, string? token, string? file, string? externalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteRemove(contentType, token, file, externalId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteRemove1(ContentType contentType, string? token, string? file, string? externalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteRemove1(contentType, token, file, externalId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteShare(string? token, string? file, string? externalId, string? channels, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Share a remote file into a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteShare(token, file, externalId, channels, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:share` |
| <code>file</code> | <code>string?</code> | Specify a file registered with Slack by providing its ID. Either this field or `external_id` or both are required. |
| <code>externalId</code> | <code>string?</code> | The globally unique identifier (GUID) for the file, as set by the app registering the file with Slack.  Either this field or `file` or both are required. |
| <code>channels</code> | <code>string?</code> | Comma-separated list of channel IDs where the file will be shared. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteShare1(string? token, string? file, string? externalId, string? channels, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Share a remote file into a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteShare1(token, file, externalId, channels, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:share` |
| <code>file</code> | <code>string?</code> | Specify a file registered with Slack by providing its ID. Either this field or `external_id` or both are required. |
| <code>externalId</code> | <code>string?</code> | The globally unique identifier (GUID) for the file, as set by the app registering the file with Slack.  Either this field or `file` or both are required. |
| <code>channels</code> | <code>string?</code> | Comma-separated list of channel IDs where the file will be shared. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteUpdate(ContentType contentType, string? token, string? file, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteUpdate(contentType,
        token,
        file,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteUpdate1(ContentType contentType, string? token, string? file, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRemoteUpdate1(contentType,
        token,
        file,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesRevokePublicUrlschema&gt; FilesRevokePublicUrl(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes public/external sharing access for a file

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRevokePublicUrl(contentType, token, file);
    // TODO: Handle 'response' of type FilesRevokePublicUrlschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesRevokePublicUrlschema](Models/FilesRevokePublicUrlschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesRevokePublicUrlschema1&gt; FilesRevokePublicUrl1(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes public/external sharing access for a file

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesRevokePublicUrl1(contentType, token, file);
    // TODO: Handle 'response' of type FilesRevokePublicUrlschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesRevokePublicUrlschema1](Models/FilesRevokePublicUrlschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesSharedPublicUrlschema&gt; FilesSharedPublicUrl(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables a file for public/external sharing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesSharedPublicUrl(contentType, token, file);
    // TODO: Handle 'response' of type FilesSharedPublicUrlschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesSharedPublicUrlschema](Models/FilesSharedPublicUrlschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesSharedPublicUrlschema1&gt; FilesSharedPublicUrl1(ContentType contentType, string? token, string? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables a file for public/external sharing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesSharedPublicUrl1(contentType, token, file);
    // TODO: Handle 'response' of type FilesSharedPublicUrlschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesSharedPublicUrlschema1](Models/FilesSharedPublicUrlschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesUploadschema&gt; FilesUpload(ContentType contentType, string? token, string? file, string? content, string? filetype, string? filename, string? title, string? initialComment, string? channels, double? threadTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads or creates a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesUpload(contentType,
        token,
        file,
        content,
        filetype,
        filename,
        title,
        initialComment,
        channels,
        threadTs);
    // TODO: Handle 'response' of type FilesUploadschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>content</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>filename</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>initialComment</code> | <code>string?</code> | - |
| <code>channels</code> | <code>string?</code> | - |
| <code>threadTs</code> | <code>double?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesUploadschema](Models/FilesUploadschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesUploadschema1&gt; FilesUpload1(ContentType contentType, string? token, string? file, string? content, string? filetype, string? filename, string? title, string? initialComment, string? channels, double? threadTs, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads or creates a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.FilesUpload1(contentType,
        token,
        file,
        content,
        filetype,
        filename,
        title,
        initialComment,
        channels,
        threadTs);
    // TODO: Handle 'response' of type FilesUploadschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>content</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>filename</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>initialComment</code> | <code>string?</code> | - |
| <code>channels</code> | <code>string?</code> | - |
| <code>threadTs</code> | <code>double?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesUploadschema1](Models/FilesUploadschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FilesComments

> Source: [FilesComments](Api/FilesComments.cs)

<details>
<summary><code>Task&lt;FilesCommentsDeleteschema&gt; FilesCommentsDelete(ContentType contentType, string? token, string? file, string? id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing comment on a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesComments.FilesCommentsDelete(contentType, token, file, id);
    // TODO: Handle 'response' of type FilesCommentsDeleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |
| <code>id</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesCommentsDeleteschema](Models/FilesCommentsDeleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesCommentsDeleteschema1&gt; FilesCommentsDelete1(ContentType contentType, string? token, string? file, string? id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing comment on a file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesComments.FilesCommentsDelete1(contentType, token, file, id);
    // TODO: Handle 'response' of type FilesCommentsDeleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `files:write:user` |
| <code>file</code> | <code>string?</code> | - |
| <code>id</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesCommentsDeleteschema1](Models/FilesCommentsDeleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FilesRemote

> Source: [FilesRemote](Api/FilesRemote.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteAdd(ContentType contentType, string? token, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a file from a remote service

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteAdd(contentType,
        token,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteAdd1(ContentType contentType, string? token, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a file from a remote service

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteAdd1(contentType,
        token,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteInfo(string? token, string? file, string? externalId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteInfo(token, file, externalId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>file</code> | <code>string?</code> | Specify a file by providing its ID. |
| <code>externalId</code> | <code>string?</code> | Creator defined GUID for the file. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteInfo1(string? token, string? file, string? externalId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteInfo1(token, file, externalId, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>file</code> | <code>string?</code> | Specify a file by providing its ID. |
| <code>externalId</code> | <code>string?</code> | Creator defined GUID for the file. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteList(string? token, string? channel, double? tsFrom, double? tsTo, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteList(token, channel, tsFrom, tsTo, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>channel</code> | <code>string?</code> | Filter files appearing in a specific channel, indicated by its ID. |
| <code>tsFrom</code> | <code>double?</code> | Filter files created after this timestamp (inclusive). |
| <code>tsTo</code> | <code>double?</code> | Filter files created before this timestamp (inclusive). |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteList1(string? token, string? channel, double? tsFrom, double? tsTo, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a remote file added to Slack

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteList1(token, channel, tsFrom, tsTo, limit, cursor, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:read` |
| <code>channel</code> | <code>string?</code> | Filter files appearing in a specific channel, indicated by its ID. |
| <code>tsFrom</code> | <code>double?</code> | Filter files created after this timestamp (inclusive). |
| <code>tsTo</code> | <code>double?</code> | Filter files created before this timestamp (inclusive). |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteRemove(ContentType contentType, string? token, string? file, string? externalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteRemove(contentType, token, file, externalId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteRemove1(ContentType contentType, string? token, string? file, string? externalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteRemove1(contentType, token, file, externalId);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteShare(string? token, string? file, string? externalId, string? channels, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Share a remote file into a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteShare(token, file, externalId, channels, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:share` |
| <code>file</code> | <code>string?</code> | Specify a file registered with Slack by providing its ID. Either this field or `external_id` or both are required. |
| <code>externalId</code> | <code>string?</code> | The globally unique identifier (GUID) for the file, as set by the app registering the file with Slack.  Either this field or `file` or both are required. |
| <code>channels</code> | <code>string?</code> | Comma-separated list of channel IDs where the file will be shared. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteShare1(string? token, string? file, string? externalId, string? channels, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Share a remote file into a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteShare1(token, file, externalId, channels, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `remote_files:share` |
| <code>file</code> | <code>string?</code> | Specify a file registered with Slack by providing its ID. Either this field or `external_id` or both are required. |
| <code>externalId</code> | <code>string?</code> | The globally unique identifier (GUID) for the file, as set by the app registering the file with Slack.  Either this field or `file` or both are required. |
| <code>channels</code> | <code>string?</code> | Comma-separated list of channel IDs where the file will be shared. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteUpdate(ContentType contentType, string? token, string? file, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteUpdate(contentType,
        token,
        file,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; FilesRemoteUpdate1(ContentType contentType, string? token, string? file, string? externalId, string? title, string? filetype, string? externalUrl, string? previewImage, string? indexableFileContents, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FilesRemote.FilesRemoteUpdate1(contentType,
        token,
        file,
        externalId,
        title,
        filetype,
        externalUrl,
        previewImage,
        indexableFileContents);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>externalId</code> | <code>string?</code> | - |
| <code>title</code> | <code>string?</code> | - |
| <code>filetype</code> | <code>string?</code> | - |
| <code>externalUrl</code> | <code>string?</code> | - |
| <code>previewImage</code> | <code>string?</code> | - |
| <code>indexableFileContents</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Migration

> Source: [Migration](Api/Migration.cs)

<details>
<summary><code>Task&lt;MigrationExchangesuccessschema&gt; MigrationExchange(string token, string users, string? teamId, bool? toOld, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For Enterprise Grid workspaces, map local user IDs to global user IDs

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Migration.MigrationExchange(token, users, teamId, toOld, contentType);
    // TODO: Handle 'response' of type MigrationExchangesuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `tokens.basic` |
| <code>users</code> | <code>string</code> | A comma-separated list of user ids, up to 400 per request |
| <code>teamId</code> | <code>string?</code> | Specify team_id starts with `T` in case of Org Token |
| <code>toOld</code> | <code>bool?</code> | Specify `true` to convert `W` global user IDs to workspace-specific `U` IDs. Defaults to `false`. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MigrationExchangesuccessschema](Models/MigrationExchangesuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MigrationExchangesuccessschema1&gt; MigrationExchange1(string token, string users, string? teamId, bool? toOld, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For Enterprise Grid workspaces, map local user IDs to global user IDs

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Migration.MigrationExchange1(token, users, teamId, toOld, contentType);
    // TODO: Handle 'response' of type MigrationExchangesuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `tokens.basic` |
| <code>users</code> | <code>string</code> | A comma-separated list of user ids, up to 400 per request |
| <code>teamId</code> | <code>string?</code> | Specify team_id starts with `T` in case of Org Token |
| <code>toOld</code> | <code>bool?</code> | Specify `true` to convert `W` global user IDs to workspace-specific `U` IDs. Defaults to `false`. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MigrationExchangesuccessschema1](Models/MigrationExchangesuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Oauth

> Source: [Oauth](Api/Oauth.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthAccess(string? clientId, string? clientSecret, string? code, string? redirectUri, bool? singleChannel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for an access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.OauthAccess(clientId,
        clientSecret,
        code,
        redirectUri,
        singleChannel,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>code</code> | <code>string?</code> | The `code` param returned via the OAuth callback. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>singleChannel</code> | <code>bool?</code> | Request the user to add your app only to a single channel. Only valid with a [legacy workspace app](https://api.slack.com/legacy-workspace-apps). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; OauthAccess1(string? clientId, string? clientSecret, string? code, string? redirectUri, bool? singleChannel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for an access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.OauthAccess1(clientId,
        clientSecret,
        code,
        redirectUri,
        singleChannel,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>code</code> | <code>string?</code> | The `code` param returned via the OAuth callback. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>singleChannel</code> | <code>bool?</code> | Request the user to add your app only to a single channel. Only valid with a [legacy workspace app](https://api.slack.com/legacy-workspace-apps). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthToken(string? clientId, string? clientSecret, string? code, string? redirectUri, bool? singleChannel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for a workspace token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.OauthToken(clientId, clientSecret, code, redirectUri, singleChannel, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>code</code> | <code>string?</code> | The `code` param returned via the OAuth callback. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>singleChannel</code> | <code>bool?</code> | Request the user to add your app only to a single channel. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; OauthToken1(string? clientId, string? clientSecret, string? code, string? redirectUri, bool? singleChannel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for a workspace token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.OauthToken1(clientId,
        clientSecret,
        code,
        redirectUri,
        singleChannel,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>code</code> | <code>string?</code> | The `code` param returned via the OAuth callback. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>singleChannel</code> | <code>bool?</code> | Request the user to add your app only to a single channel. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthV2Access(string code, string? clientId, string? clientSecret, string? redirectUri, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for an access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.OauthV2Access(code, clientId, clientSecret, redirectUri, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | The `code` param returned via the OAuth callback. |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; OauthV2Access1(string code, string? clientId, string? clientSecret, string? redirectUri, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for an access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.OauthV2Access1(code, clientId, clientSecret, redirectUri, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | The `code` param returned via the OAuth callback. |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OauthV2

> Source: [OauthV2](Api/OauthV2.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthV2Access(string code, string? clientId, string? clientSecret, string? redirectUri, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for an access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OauthV2.OauthV2Access(code, clientId, clientSecret, redirectUri, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | The `code` param returned via the OAuth callback. |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; OauthV2Access1(string code, string? clientId, string? clientSecret, string? redirectUri, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchanges a temporary OAuth verifier code for an access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OauthV2.OauthV2Access1(code, clientId, clientSecret, redirectUri, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | The `code` param returned via the OAuth callback. |
| <code>clientId</code> | <code>string?</code> | Issued when you created your application. |
| <code>clientSecret</code> | <code>string?</code> | Issued when you created your application. |
| <code>redirectUri</code> | <code>string?</code> | This must match the originally submitted URI (if one was sent). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pins

> Source: [Pins](Api/Pins.cs)

<details>
<summary><code>Task&lt;PinsAddschema&gt; PinsAdd(string token, ContentType contentType, string channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pins an item to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pins.PinsAdd(token, contentType, channel, timestamp);
    // TODO: Handle 'response' of type PinsAddschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `pins:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinsAddschema](Models/PinsAddschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinsAddschema1&gt; PinsAdd1(string token, ContentType contentType, string channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pins an item to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pins.PinsAdd1(token, contentType, channel, timestamp);
    // TODO: Handle 'response' of type PinsAddschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `pins:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinsAddschema1](Models/PinsAddschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PinsList(string token, string channel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists items pinned to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pins.PinsList(token, channel, contentType);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `pins:read` |
| <code>channel</code> | <code>string</code> | Channel to get pinned items for. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PinsList1(string token, string channel, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists items pinned to a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pins.PinsList1(token, channel, contentType);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `pins:read` |
| <code>channel</code> | <code>string</code> | Channel to get pinned items for. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinsRemoveschema&gt; PinsRemove(string token, ContentType contentType, string channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Un-pins an item from a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pins.PinsRemove(token, contentType, channel, timestamp);
    // TODO: Handle 'response' of type PinsRemoveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `pins:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinsRemoveschema](Models/PinsRemoveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinsRemoveschema1&gt; PinsRemove1(string token, ContentType contentType, string channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Un-pins an item from a channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pins.PinsRemove1(token, contentType, channel, timestamp);
    // TODO: Handle 'response' of type PinsRemoveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `pins:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinsRemoveschema1](Models/PinsRemoveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reactions

> Source: [Reactions](Api/Reactions.cs)

<details>
<summary><code>Task&lt;ReactionsAddschema&gt; ReactionsAdd(string token, ContentType contentType, string channel, string name, string timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a reaction to an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsAdd(token, contentType, channel, name, timestamp);
    // TODO: Handle 'response' of type ReactionsAddschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsAddschema](Models/ReactionsAddschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsAddschema1&gt; ReactionsAdd1(string token, ContentType contentType, string channel, string name, string timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a reaction to an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsAdd1(token, contentType, channel, name, timestamp);
    // TODO: Handle 'response' of type ReactionsAddschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>timestamp</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsAddschema1](Models/ReactionsAddschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; ReactionsGet(string token, string? channel, string? file, string? fileComment, bool? full, string? timestamp, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets reactions for an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsGet(token, channel, file, fileComment, full, timestamp, contentType);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:read` |
| <code>channel</code> | <code>string?</code> | Channel where the message to get reactions for was posted. |
| <code>file</code> | <code>string?</code> | File to get reactions for. |
| <code>fileComment</code> | <code>string?</code> | File comment to get reactions for. |
| <code>full</code> | <code>bool?</code> | If true always return the complete reaction list. |
| <code>timestamp</code> | <code>string?</code> | Timestamp of the message to get reactions for. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; ReactionsGet1(string token, string? channel, string? file, string? fileComment, bool? full, string? timestamp, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets reactions for an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsGet1(token,
        channel,
        file,
        fileComment,
        full,
        timestamp,
        contentType);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:read` |
| <code>channel</code> | <code>string?</code> | Channel where the message to get reactions for was posted. |
| <code>file</code> | <code>string?</code> | File to get reactions for. |
| <code>fileComment</code> | <code>string?</code> | File comment to get reactions for. |
| <code>full</code> | <code>bool?</code> | If true always return the complete reaction list. |
| <code>timestamp</code> | <code>string?</code> | Timestamp of the message to get reactions for. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsListschema&gt; ReactionsList(string token, string? user, bool? full, int? count, int? page, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists reactions made by a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsList(token, user, full, count, page, cursor, limit, contentType);
    // TODO: Handle 'response' of type ReactionsListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:read` |
| <code>user</code> | <code>string?</code> | Show reactions made by this user. Defaults to the authed user. |
| <code>full</code> | <code>bool?</code> | If true always return the complete reaction list. |
| <code>count</code> | <code>int?</code> | - |
| <code>page</code> | <code>int?</code> | - |
| <code>cursor</code> | <code>string?</code> | Parameter for pagination. Set `cursor` equal to the `next_cursor` attribute returned by the previous request's `response_metadata`. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsListschema](Models/ReactionsListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsListschema1&gt; ReactionsList1(string token, string? user, bool? full, int? count, int? page, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists reactions made by a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsList1(token, user, full, count, page, cursor, limit, contentType);
    // TODO: Handle 'response' of type ReactionsListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:read` |
| <code>user</code> | <code>string?</code> | Show reactions made by this user. Defaults to the authed user. |
| <code>full</code> | <code>bool?</code> | If true always return the complete reaction list. |
| <code>count</code> | <code>int?</code> | - |
| <code>page</code> | <code>int?</code> | - |
| <code>cursor</code> | <code>string?</code> | Parameter for pagination. Set `cursor` equal to the `next_cursor` attribute returned by the previous request's `response_metadata`. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsListschema1](Models/ReactionsListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsRemoveschema&gt; ReactionsRemove(string token, ContentType contentType, string name, string? file, string? fileComment, string? channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a reaction from an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsRemove(token,
        contentType,
        name,
        file,
        fileComment,
        channel,
        timestamp);
    // TODO: Handle 'response' of type ReactionsRemoveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>fileComment</code> | <code>string?</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsRemoveschema](Models/ReactionsRemoveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsRemoveschema1&gt; ReactionsRemove1(string token, ContentType contentType, string name, string? file, string? fileComment, string? channel, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a reaction from an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reactions.ReactionsRemove1(token,
        contentType,
        name,
        file,
        fileComment,
        channel,
        timestamp);
    // TODO: Handle 'response' of type ReactionsRemoveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reactions:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>fileComment</code> | <code>string?</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsRemoveschema1](Models/ReactionsRemoveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reminders

> Source: [Reminders](Api/Reminders.cs)

<details>
<summary><code>Task&lt;RemindersAddschema&gt; RemindersAdd(string token, ContentType contentType, string text, string time, string? user, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a reminder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersAdd(token, contentType, text, time, user);
    // TODO: Handle 'response' of type RemindersAddschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reminders:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>text</code> | <code>string</code> | - |
| <code>time</code> | <code>string</code> | - |
| <code>user</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersAddschema](Models/RemindersAddschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersAddschema1&gt; RemindersAdd1(string token, ContentType contentType, string text, string time, string? user, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a reminder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersAdd1(token, contentType, text, time, user);
    // TODO: Handle 'response' of type RemindersAddschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `reminders:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>text</code> | <code>string</code> | - |
| <code>time</code> | <code>string</code> | - |
| <code>user</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersAddschema1](Models/RemindersAddschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersCompleteschema&gt; RemindersComplete(ContentType contentType, string? token, string? reminder, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Marks a reminder as complete.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersComplete(contentType, token, reminder);
    // TODO: Handle 'response' of type RemindersCompleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:write` |
| <code>reminder</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersCompleteschema](Models/RemindersCompleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersCompleteschema1&gt; RemindersComplete1(ContentType contentType, string? token, string? reminder, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Marks a reminder as complete.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersComplete1(contentType, token, reminder);
    // TODO: Handle 'response' of type RemindersCompleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:write` |
| <code>reminder</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersCompleteschema1](Models/RemindersCompleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersDeleteschema&gt; RemindersDelete(ContentType contentType, string? token, string? reminder, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a reminder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersDelete(contentType, token, reminder);
    // TODO: Handle 'response' of type RemindersDeleteschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:write` |
| <code>reminder</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersDeleteschema](Models/RemindersDeleteschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersDeleteschema1&gt; RemindersDelete1(ContentType contentType, string? token, string? reminder, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a reminder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersDelete1(contentType, token, reminder);
    // TODO: Handle 'response' of type RemindersDeleteschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:write` |
| <code>reminder</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersDeleteschema1](Models/RemindersDeleteschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersInfoschema&gt; RemindersInfo(string? token, string? reminder, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a reminder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersInfo(token, reminder, contentType);
    // TODO: Handle 'response' of type RemindersInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:read` |
| <code>reminder</code> | <code>string?</code> | The ID of the reminder |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersInfoschema](Models/RemindersInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersInfoschema1&gt; RemindersInfo1(string? token, string? reminder, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a reminder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersInfo1(token, reminder, contentType);
    // TODO: Handle 'response' of type RemindersInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:read` |
| <code>reminder</code> | <code>string?</code> | The ID of the reminder |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersInfoschema1](Models/RemindersInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersListschema&gt; RemindersList(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all reminders created by or for a given user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersList(token, contentType);
    // TODO: Handle 'response' of type RemindersListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersListschema](Models/RemindersListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersListschema1&gt; RemindersList1(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all reminders created by or for a given user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reminders.RemindersList1(token, contentType);
    // TODO: Handle 'response' of type RemindersListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `reminders:read` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersListschema1](Models/RemindersListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rtm

> Source: [Rtm](Api/Rtm.cs)

<details>
<summary><code>Task&lt;RtmConnectschema&gt; RtmConnect(string token, bool? batchPresenceAware, bool? presenceSub, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts a Real Time Messaging session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rtm.RtmConnect(token, batchPresenceAware, presenceSub, contentType);
    // TODO: Handle 'response' of type RtmConnectschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `rtm:stream` |
| <code>batchPresenceAware</code> | <code>bool?</code> | Batch presence deliveries via subscription. Enabling changes the shape of `presence_change` events. |
| <code>presenceSub</code> | <code>bool?</code> | Only deliver presence events when requested by subscription |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RtmConnectschema](Models/RtmConnectschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RtmConnectschema1&gt; RtmConnect1(string token, bool? batchPresenceAware, bool? presenceSub, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts a Real Time Messaging session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rtm.RtmConnect1(token, batchPresenceAware, presenceSub, contentType);
    // TODO: Handle 'response' of type RtmConnectschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `rtm:stream` |
| <code>batchPresenceAware</code> | <code>bool?</code> | Batch presence deliveries via subscription. Enabling changes the shape of `presence_change` events. |
| <code>presenceSub</code> | <code>bool?</code> | Only deliver presence events when requested by subscription |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RtmConnectschema1](Models/RtmConnectschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Search

> Source: [Search](Api/Search.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; SearchMessages(string token, string query, int? count, bool? highlight, int? page, string? sort, string? sortDir, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for messages matching a query.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Search.SearchMessages(token, query, count, highlight, page, sort, sortDir, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `search:read` |
| <code>query</code> | <code>string</code> | Search query. |
| <code>count</code> | <code>int?</code> | Pass the number of results you want per "page". Maximum of `100`. |
| <code>highlight</code> | <code>bool?</code> | Pass a value of `true` to enable query highlight markers (see below). |
| <code>page</code> | <code>int?</code> | - |
| <code>sort</code> | <code>string?</code> | Return matches sorted by either `score` or `timestamp`. |
| <code>sortDir</code> | <code>string?</code> | Change sort direction to ascending (`asc`) or descending (`desc`). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; SearchMessages1(string token, string query, int? count, bool? highlight, int? page, string? sort, string? sortDir, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for messages matching a query.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Search.SearchMessages1(token,
        query,
        count,
        highlight,
        page,
        sort,
        sortDir,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `search:read` |
| <code>query</code> | <code>string</code> | Search query. |
| <code>count</code> | <code>int?</code> | Pass the number of results you want per "page". Maximum of `100`. |
| <code>highlight</code> | <code>bool?</code> | Pass a value of `true` to enable query highlight markers (see below). |
| <code>page</code> | <code>int?</code> | - |
| <code>sort</code> | <code>string?</code> | Return matches sorted by either `score` or `timestamp`. |
| <code>sortDir</code> | <code>string?</code> | Change sort direction to ascending (`asc`) or descending (`desc`). |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Stars

> Source: [Stars](Api/Stars.cs)

<details>
<summary><code>Task&lt;StarsAddschema&gt; StarsAdd(string token, ContentType contentType, string? channel, string? file, string? fileComment, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a star to an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Stars.StarsAdd(token, contentType, channel, file, fileComment, timestamp);
    // TODO: Handle 'response' of type StarsAddschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `stars:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>fileComment</code> | <code>string?</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsAddschema](Models/StarsAddschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsAddschema1&gt; StarsAdd1(string token, ContentType contentType, string? channel, string? file, string? fileComment, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a star to an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Stars.StarsAdd1(token, contentType, channel, file, fileComment, timestamp);
    // TODO: Handle 'response' of type StarsAddschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `stars:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>fileComment</code> | <code>string?</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsAddschema1](Models/StarsAddschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsListschema&gt; StarsList(string? token, string? count, string? page, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists stars for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Stars.StarsList(token, count, page, cursor, limit, contentType);
    // TODO: Handle 'response' of type StarsListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `stars:read` |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>cursor</code> | <code>string?</code> | Parameter for pagination. Set `cursor` equal to the `next_cursor` attribute returned by the previous request's `response_metadata`. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsListschema](Models/StarsListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsListschema1&gt; StarsList1(string? token, string? count, string? page, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists stars for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Stars.StarsList1(token, count, page, cursor, limit, contentType);
    // TODO: Handle 'response' of type StarsListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `stars:read` |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>cursor</code> | <code>string?</code> | Parameter for pagination. Set `cursor` equal to the `next_cursor` attribute returned by the previous request's `response_metadata`. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection. |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsListschema1](Models/StarsListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsRemoveschema&gt; StarsRemove(string token, ContentType contentType, string? channel, string? file, string? fileComment, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a star from an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Stars.StarsRemove(token, contentType, channel, file, fileComment, timestamp);
    // TODO: Handle 'response' of type StarsRemoveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `stars:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>fileComment</code> | <code>string?</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsRemoveschema](Models/StarsRemoveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsRemoveschema1&gt; StarsRemove1(string token, ContentType contentType, string? channel, string? file, string? fileComment, string? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a star from an item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Stars.StarsRemove1(token, contentType, channel, file, fileComment, timestamp);
    // TODO: Handle 'response' of type StarsRemoveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `stars:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>channel</code> | <code>string?</code> | - |
| <code>file</code> | <code>string?</code> | - |
| <code>fileComment</code> | <code>string?</code> | - |
| <code>timestamp</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsRemoveschema1](Models/StarsRemoveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamApi

> Source: [TeamApi](Api/TeamApi.cs)

<details>
<summary><code>Task&lt;TeamAccessLogsschema&gt; TeamAccessLogs(string token, string? before, string? count, string? page, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets the access logs for the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamAccessLogs(token, before, count, page, contentType);
    // TODO: Handle 'response' of type TeamAccessLogsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin` |
| <code>before</code> | <code>string?</code> | End of time range of logs to include in results (inclusive). |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamAccessLogsschema](Models/TeamAccessLogsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamAccessLogsschema1&gt; TeamAccessLogs1(string token, string? before, string? count, string? page, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets the access logs for the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamAccessLogs1(token, before, count, page, contentType);
    // TODO: Handle 'response' of type TeamAccessLogsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin` |
| <code>before</code> | <code>string?</code> | End of time range of logs to include in results (inclusive). |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamAccessLogsschema1](Models/TeamAccessLogsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; TeamBillableInfo(string token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets billable users information for the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamBillableInfo(token, user, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin` |
| <code>user</code> | <code>string?</code> | A user to retrieve the billable information for. Defaults to all users. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; TeamBillableInfo1(string token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets billable users information for the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamBillableInfo1(token, user, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin` |
| <code>user</code> | <code>string?</code> | A user to retrieve the billable information for. Defaults to all users. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamInfoschema&gt; TeamInfo(string token, string? team, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamInfo(token, team, contentType);
    // TODO: Handle 'response' of type TeamInfoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `team:read` |
| <code>team</code> | <code>string?</code> | Team to get info on, if omitted, will return information about the current team. Will only return team that the authenticated token is allowed to see through external shared channels |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamInfoschema](Models/TeamInfoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamInfoschema1&gt; TeamInfo1(string token, string? team, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamInfo1(token, team, contentType);
    // TODO: Handle 'response' of type TeamInfoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `team:read` |
| <code>team</code> | <code>string?</code> | Team to get info on, if omitted, will return information about the current team. Will only return team that the authenticated token is allowed to see through external shared channels |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamInfoschema1](Models/TeamInfoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamIntegrationLogsschema&gt; TeamIntegrationLogs(string token, string? appId, string? changeType, string? count, string? page, string? serviceId, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets the integration logs for the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamIntegrationLogs(token,
        appId,
        changeType,
        count,
        page,
        serviceId,
        user,
        contentType);
    // TODO: Handle 'response' of type TeamIntegrationLogsschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin` |
| <code>appId</code> | <code>string?</code> | Filter logs to this Slack app. Defaults to all logs. |
| <code>changeType</code> | <code>string?</code> | Filter logs with this change type. Defaults to all logs. |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>serviceId</code> | <code>string?</code> | Filter logs to this service. Defaults to all logs. |
| <code>user</code> | <code>string?</code> | Filter logs generated by this user’s actions. Defaults to all logs. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamIntegrationLogsschema](Models/TeamIntegrationLogsschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamIntegrationLogsschema1&gt; TeamIntegrationLogs1(string token, string? appId, string? changeType, string? count, string? page, string? serviceId, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets the integration logs for the current team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamIntegrationLogs1(token,
        appId,
        changeType,
        count,
        page,
        serviceId,
        user,
        contentType);
    // TODO: Handle 'response' of type TeamIntegrationLogsschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `admin` |
| <code>appId</code> | <code>string?</code> | Filter logs to this Slack app. Defaults to all logs. |
| <code>changeType</code> | <code>string?</code> | Filter logs with this change type. Defaults to all logs. |
| <code>count</code> | <code>string?</code> | - |
| <code>page</code> | <code>string?</code> | - |
| <code>serviceId</code> | <code>string?</code> | Filter logs to this service. Defaults to all logs. |
| <code>user</code> | <code>string?</code> | Filter logs generated by this user’s actions. Defaults to all logs. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamIntegrationLogsschema1](Models/TeamIntegrationLogsschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamProfileGetsuccessschema&gt; TeamProfileGet(string token, string? visibility, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a team's profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamProfileGet(token, visibility, contentType);
    // TODO: Handle 'response' of type TeamProfileGetsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>visibility</code> | <code>string?</code> | Filter by visibility. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamProfileGetsuccessschema](Models/TeamProfileGetsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamProfileGetsuccessschema1&gt; TeamProfileGet1(string token, string? visibility, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a team's profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamApi.TeamProfileGet1(token, visibility, contentType);
    // TODO: Handle 'response' of type TeamProfileGetsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>visibility</code> | <code>string?</code> | Filter by visibility. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamProfileGetsuccessschema1](Models/TeamProfileGetsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamProfile

> Source: [TeamProfile](Api/TeamProfile.cs)

<details>
<summary><code>Task&lt;TeamProfileGetsuccessschema&gt; TeamProfileGet(string token, string? visibility, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a team's profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamProfile.TeamProfileGet(token, visibility, contentType);
    // TODO: Handle 'response' of type TeamProfileGetsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>visibility</code> | <code>string?</code> | Filter by visibility. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamProfileGetsuccessschema](Models/TeamProfileGetsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamProfileGetsuccessschema1&gt; TeamProfileGet1(string token, string? visibility, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a team's profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamProfile.TeamProfileGet1(token, visibility, contentType);
    // TODO: Handle 'response' of type TeamProfileGetsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>visibility</code> | <code>string?</code> | Filter by visibility. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamProfileGetsuccessschema1](Models/TeamProfileGetsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Usergroups

> Source: [Usergroups](Api/Usergroups.cs)

<details>
<summary><code>Task&lt;UsergroupsCreateschema&gt; UsergroupsCreate(string token, ContentType contentType, string name, string? channels, string? description, string? handle, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsCreate(token,
        contentType,
        name,
        channels,
        description,
        handle,
        includeCount);
    // TODO: Handle 'response' of type UsergroupsCreateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>channels</code> | <code>string?</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>handle</code> | <code>string?</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsCreateschema](Models/UsergroupsCreateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsCreateschema1&gt; UsergroupsCreate1(string token, ContentType contentType, string name, string? channels, string? description, string? handle, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsCreate1(token,
        contentType,
        name,
        channels,
        description,
        handle,
        includeCount);
    // TODO: Handle 'response' of type UsergroupsCreateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string</code> | - |
| <code>channels</code> | <code>string?</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>handle</code> | <code>string?</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsCreateschema1](Models/UsergroupsCreateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsDisableschema&gt; UsergroupsDisable(string token, ContentType contentType, string usergroup, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable an existing User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsDisable(token, contentType, usergroup, includeCount);
    // TODO: Handle 'response' of type UsergroupsDisableschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsDisableschema](Models/UsergroupsDisableschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsDisableschema1&gt; UsergroupsDisable1(string token, ContentType contentType, string usergroup, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable an existing User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsDisable1(token, contentType, usergroup, includeCount);
    // TODO: Handle 'response' of type UsergroupsDisableschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsDisableschema1](Models/UsergroupsDisableschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsEnableschema&gt; UsergroupsEnable(string token, ContentType contentType, string usergroup, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsEnable(token, contentType, usergroup, includeCount);
    // TODO: Handle 'response' of type UsergroupsEnableschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsEnableschema](Models/UsergroupsEnableschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsEnableschema1&gt; UsergroupsEnable1(string token, ContentType contentType, string usergroup, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsEnable1(token, contentType, usergroup, includeCount);
    // TODO: Handle 'response' of type UsergroupsEnableschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsEnableschema1](Models/UsergroupsEnableschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsListschema&gt; UsergroupsList(string token, bool? includeUsers, bool? includeCount, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all User Groups for a team

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsList(token,
        includeUsers,
        includeCount,
        includeDisabled,
        contentType);
    // TODO: Handle 'response' of type UsergroupsListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:read` |
| <code>includeUsers</code> | <code>bool?</code> | Include the list of users for each User Group. |
| <code>includeCount</code> | <code>bool?</code> | Include the number of users in each User Group. |
| <code>includeDisabled</code> | <code>bool?</code> | Include disabled User Groups. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsListschema](Models/UsergroupsListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsListschema1&gt; UsergroupsList1(string token, bool? includeUsers, bool? includeCount, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all User Groups for a team

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsList1(token,
        includeUsers,
        includeCount,
        includeDisabled,
        contentType);
    // TODO: Handle 'response' of type UsergroupsListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:read` |
| <code>includeUsers</code> | <code>bool?</code> | Include the list of users for each User Group. |
| <code>includeCount</code> | <code>bool?</code> | Include the number of users in each User Group. |
| <code>includeDisabled</code> | <code>bool?</code> | Include disabled User Groups. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsListschema1](Models/UsergroupsListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUpdateschema&gt; UsergroupsUpdate(string token, ContentType contentType, string usergroup, string? handle, string? description, string? channels, bool? includeCount, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsUpdate(token,
        contentType,
        usergroup,
        handle,
        description,
        channels,
        includeCount,
        name);
    // TODO: Handle 'response' of type UsergroupsUpdateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>handle</code> | <code>string?</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>channels</code> | <code>string?</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |
| <code>name</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUpdateschema](Models/UsergroupsUpdateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUpdateschema1&gt; UsergroupsUpdate1(string token, ContentType contentType, string usergroup, string? handle, string? description, string? channels, bool? includeCount, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsUpdate1(token,
        contentType,
        usergroup,
        handle,
        description,
        channels,
        includeCount,
        name);
    // TODO: Handle 'response' of type UsergroupsUpdateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>handle</code> | <code>string?</code> | - |
| <code>description</code> | <code>string?</code> | - |
| <code>channels</code> | <code>string?</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |
| <code>name</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUpdateschema1](Models/UsergroupsUpdateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersListschema&gt; UsergroupsUsersList(string token, string usergroup, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all users in a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsUsersList(token, usergroup, includeDisabled, contentType);
    // TODO: Handle 'response' of type UsergroupsUsersListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:read` |
| <code>usergroup</code> | <code>string</code> | The encoded ID of the User Group to update. |
| <code>includeDisabled</code> | <code>bool?</code> | Allow results that involve disabled User Groups. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersListschema](Models/UsergroupsUsersListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersListschema1&gt; UsergroupsUsersList1(string token, string usergroup, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all users in a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsUsersList1(token, usergroup, includeDisabled, contentType);
    // TODO: Handle 'response' of type UsergroupsUsersListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:read` |
| <code>usergroup</code> | <code>string</code> | The encoded ID of the User Group to update. |
| <code>includeDisabled</code> | <code>bool?</code> | Allow results that involve disabled User Groups. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersListschema1](Models/UsergroupsUsersListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersUpdateschema&gt; UsergroupsUsersUpdate(string token, ContentType contentType, string usergroup, string users, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the list of users for a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsUsersUpdate(token, contentType, usergroup, users, includeCount);
    // TODO: Handle 'response' of type UsergroupsUsersUpdateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersUpdateschema](Models/UsergroupsUsersUpdateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersUpdateschema1&gt; UsergroupsUsersUpdate1(string token, ContentType contentType, string usergroup, string users, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the list of users for a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Usergroups.UsergroupsUsersUpdate1(token, contentType, usergroup, users, includeCount);
    // TODO: Handle 'response' of type UsergroupsUsersUpdateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersUpdateschema1](Models/UsergroupsUsersUpdateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsergroupsUsers

> Source: [UsergroupsUsers](Api/UsergroupsUsers.cs)

<details>
<summary><code>Task&lt;UsergroupsUsersListschema&gt; UsergroupsUsersList(string token, string usergroup, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all users in a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsergroupsUsers.UsergroupsUsersList(token, usergroup, includeDisabled, contentType);
    // TODO: Handle 'response' of type UsergroupsUsersListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:read` |
| <code>usergroup</code> | <code>string</code> | The encoded ID of the User Group to update. |
| <code>includeDisabled</code> | <code>bool?</code> | Allow results that involve disabled User Groups. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersListschema](Models/UsergroupsUsersListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersListschema1&gt; UsergroupsUsersList1(string token, string usergroup, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all users in a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsergroupsUsers.UsergroupsUsersList1(token, usergroup, includeDisabled, contentType);
    // TODO: Handle 'response' of type UsergroupsUsersListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:read` |
| <code>usergroup</code> | <code>string</code> | The encoded ID of the User Group to update. |
| <code>includeDisabled</code> | <code>bool?</code> | Allow results that involve disabled User Groups. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersListschema1](Models/UsergroupsUsersListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersUpdateschema&gt; UsergroupsUsersUpdate(string token, ContentType contentType, string usergroup, string users, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the list of users for a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsergroupsUsers.UsergroupsUsersUpdate(token,
        contentType,
        usergroup,
        users,
        includeCount);
    // TODO: Handle 'response' of type UsergroupsUsersUpdateschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersUpdateschema](Models/UsergroupsUsersUpdateschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersUpdateschema1&gt; UsergroupsUsersUpdate1(string token, ContentType contentType, string usergroup, string users, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the list of users for a User Group

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsergroupsUsers.UsergroupsUsersUpdate1(token,
        contentType,
        usergroup,
        users,
        includeCount);
    // TODO: Handle 'response' of type UsergroupsUsersUpdateschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `usergroups:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>usergroup</code> | <code>string</code> | - |
| <code>users</code> | <code>string</code> | - |
| <code>includeCount</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersUpdateschema1](Models/UsergroupsUsersUpdateschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Users

> Source: [Users](Api/Users.cs)

<details>
<summary><code>Task&lt;UsersConversationssuccessschema&gt; UsersConversations(string? token, string? user, string? types, bool? excludeArchived, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List conversations the calling user may access.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersConversations(token,
        user,
        types,
        excludeArchived,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type UsersConversationssuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>user</code> | <code>string?</code> | Browse conversations by a specific user ID's membership. Non-public channels are restricted to those where the calling user shares membership. |
| <code>types</code> | <code>string?</code> | Mix and match channel types by providing a comma-separated list of any combination of `public_channel`, `private_channel`, `mpim`, `im` |
| <code>excludeArchived</code> | <code>bool?</code> | Set to `true` to exclude archived channels from the list |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersConversationssuccessschema](Models/UsersConversationssuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersConversationssuccessschema1&gt; UsersConversations1(string? token, string? user, string? types, bool? excludeArchived, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List conversations the calling user may access.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersConversations1(token,
        user,
        types,
        excludeArchived,
        limit,
        cursor,
        contentType);
    // TODO: Handle 'response' of type UsersConversationssuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `conversations:read` |
| <code>user</code> | <code>string?</code> | Browse conversations by a specific user ID's membership. Non-public channels are restricted to those where the calling user shares membership. |
| <code>types</code> | <code>string?</code> | Mix and match channel types by providing a comma-separated list of any combination of `public_channel`, `private_channel`, `mpim`, `im` |
| <code>excludeArchived</code> | <code>bool?</code> | Set to `true` to exclude archived channels from the list |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersConversationssuccessschema1](Models/UsersConversationssuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersDeletePhotoschema&gt; UsersDeletePhoto(ContentType contentType, string token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete the user profile photo

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersDeletePhoto(contentType, token);
    // TODO: Handle 'response' of type UsersDeletePhotoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersDeletePhotoschema](Models/UsersDeletePhotoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersDeletePhotoschema1&gt; UsersDeletePhoto1(ContentType contentType, string token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete the user profile photo

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersDeletePhoto1(contentType, token);
    // TODO: Handle 'response' of type UsersDeletePhotoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersDeletePhotoschema1](Models/UsersDeletePhotoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApimethodusersGetPresence&gt; UsersGetPresence(string token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets user presence information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersGetPresence(token, user, contentType);
    // TODO: Handle 'response' of type ApimethodusersGetPresence
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read` |
| <code>user</code> | <code>string?</code> | User to get presence info on. Defaults to the authed user. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApimethodusersGetPresence](Models/ApimethodusersGetPresence.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApimethodusersGetPresence1&gt; UsersGetPresence1(string token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets user presence information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersGetPresence1(token, user, contentType);
    // TODO: Handle 'response' of type ApimethodusersGetPresence1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read` |
| <code>user</code> | <code>string?</code> | User to get presence info on. Defaults to the authed user. |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApimethodusersGetPresence1](Models/ApimethodusersGetPresence1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; UsersIdentity(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a user's identity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersIdentity(token, contentType);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `identity.basic` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; UsersIdentity1(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a user's identity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersIdentity1(token, contentType);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `identity.basic` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersInfosuccessschema&gt; UsersInfo(string token, bool? includeLocale, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersInfo(token, includeLocale, user, contentType);
    // TODO: Handle 'response' of type UsersInfosuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read` |
| <code>includeLocale</code> | <code>bool?</code> | Set this to `true` to receive the locale for this user. Defaults to `false` |
| <code>user</code> | <code>string?</code> | User to get info on |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersInfosuccessschema](Models/UsersInfosuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersInfosuccessschema1&gt; UsersInfo1(string token, bool? includeLocale, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets information about a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersInfo1(token, includeLocale, user, contentType);
    // TODO: Handle 'response' of type UsersInfosuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read` |
| <code>includeLocale</code> | <code>bool?</code> | Set this to `true` to receive the locale for this user. Defaults to `false` |
| <code>user</code> | <code>string?</code> | User to get info on |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersInfosuccessschema1](Models/UsersInfosuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersListschema&gt; UsersList(string? token, int? limit, string? cursor, bool? includeLocale, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all users in a Slack team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersList(token, limit, cursor, includeLocale, contentType);
    // TODO: Handle 'response' of type UsersListschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `users:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. Providing no `limit` value will result in Slack attempting to deliver you the entire result set. If the collection is too large you may experience `limit_required` or HTTP 500 errors. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>includeLocale</code> | <code>bool?</code> | Set this to `true` to receive the locale for users. Defaults to `false` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersListschema](Models/UsersListschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersListschema1&gt; UsersList1(string? token, int? limit, string? cursor, bool? includeLocale, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all users in a Slack team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersList1(token, limit, cursor, includeLocale, contentType);
    // TODO: Handle 'response' of type UsersListschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string?</code> | Authentication token. Requires scope: `users:read` |
| <code>limit</code> | <code>int?</code> | The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. Providing no `limit` value will result in Slack attempting to deliver you the entire result set. If the collection is too large you may experience `limit_required` or HTTP 500 errors. |
| <code>cursor</code> | <code>string?</code> | Paginate through collections of data by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request's `response_metadata`. Default value fetches the first "page" of the collection. |
| <code>includeLocale</code> | <code>bool?</code> | Set this to `true` to receive the locale for users. Defaults to `false` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersListschema1](Models/UsersListschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersLookupByEmailsuccessschema&gt; UsersLookupByEmail(string token, string email, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Find a user with an email address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersLookupByEmail(token, email, contentType);
    // TODO: Handle 'response' of type UsersLookupByEmailsuccessschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read.email` |
| <code>email</code> | <code>string</code> | An email address belonging to a user in the workspace |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersLookupByEmailsuccessschema](Models/UsersLookupByEmailsuccessschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersLookupByEmailsuccessschema1&gt; UsersLookupByEmail1(string token, string email, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Find a user with an email address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersLookupByEmail1(token, email, contentType);
    // TODO: Handle 'response' of type UsersLookupByEmailsuccessschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:read.email` |
| <code>email</code> | <code>string</code> | An email address belonging to a user in the workspace |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersLookupByEmailsuccessschema1](Models/UsersLookupByEmailsuccessschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileGetschema&gt; UsersProfileGet(string token, bool? includeLabels, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a user's profile information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersProfileGet(token, includeLabels, user, contentType);
    // TODO: Handle 'response' of type UsersProfileGetschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>includeLabels</code> | <code>bool?</code> | Include labels for each ID in custom profile fields |
| <code>user</code> | <code>string?</code> | User to retrieve profile info for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileGetschema](Models/UsersProfileGetschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileGetschema1&gt; UsersProfileGet1(string token, bool? includeLabels, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a user's profile information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersProfileGet1(token, includeLabels, user, contentType);
    // TODO: Handle 'response' of type UsersProfileGetschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>includeLabels</code> | <code>bool?</code> | Include labels for each ID in custom profile fields |
| <code>user</code> | <code>string?</code> | User to retrieve profile info for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileGetschema1](Models/UsersProfileGetschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileSetschema&gt; UsersProfileSet(string token, ContentType contentType, string? name, string? profile, string? user, string? value, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the profile information for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersProfileSet(token, contentType, name, profile, user, value);
    // TODO: Handle 'response' of type UsersProfileSetschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string?</code> | - |
| <code>profile</code> | <code>string?</code> | - |
| <code>user</code> | <code>string?</code> | - |
| <code>value</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileSetschema](Models/UsersProfileSetschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileSetschema1&gt; UsersProfileSet1(string token, ContentType contentType, string? name, string? profile, string? user, string? value, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the profile information for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersProfileSet1(token, contentType, name, profile, user, value);
    // TODO: Handle 'response' of type UsersProfileSetschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string?</code> | - |
| <code>profile</code> | <code>string?</code> | - |
| <code>user</code> | <code>string?</code> | - |
| <code>value</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileSetschema1](Models/UsersProfileSetschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetActiveschema&gt; UsersSetActive(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Marked a user as active. Deprecated and non-functional.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersSetActive(token, contentType);
    // TODO: Handle 'response' of type UsersSetActiveschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetActiveschema](Models/UsersSetActiveschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetActiveschema1&gt; UsersSetActive1(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Marked a user as active. Deprecated and non-functional.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersSetActive1(token, contentType);
    // TODO: Handle 'response' of type UsersSetActiveschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetActiveschema1](Models/UsersSetActiveschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetPhotoschema&gt; UsersSetPhoto(ContentType contentType, string token, string? cropW, string? cropX, string? cropY, string? image, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the user profile photo

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersSetPhoto(contentType, token, cropW, cropX, cropY, image);
    // TODO: Handle 'response' of type UsersSetPhotoschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>cropW</code> | <code>string?</code> | - |
| <code>cropX</code> | <code>string?</code> | - |
| <code>cropY</code> | <code>string?</code> | - |
| <code>image</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetPhotoschema](Models/UsersSetPhotoschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetPhotoschema1&gt; UsersSetPhoto1(ContentType contentType, string token, string? cropW, string? cropX, string? cropY, string? image, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the user profile photo

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersSetPhoto1(contentType, token, cropW, cropX, cropY, image);
    // TODO: Handle 'response' of type UsersSetPhotoschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>token</code> | <code>string</code> | - |
| <code>cropW</code> | <code>string?</code> | - |
| <code>cropX</code> | <code>string?</code> | - |
| <code>cropY</code> | <code>string?</code> | - |
| <code>image</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetPhotoschema1](Models/UsersSetPhotoschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetPresenceschema&gt; UsersSetPresence(string token, ContentType contentType, string presence, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Manually sets user presence.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersSetPresence(token, contentType, presence);
    // TODO: Handle 'response' of type UsersSetPresenceschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>presence</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetPresenceschema](Models/UsersSetPresenceschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetPresenceschema1&gt; UsersSetPresence1(string token, ContentType contentType, string presence, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Manually sets user presence.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UsersSetPresence1(token, contentType, presence);
    // TODO: Handle 'response' of type UsersSetPresenceschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>presence</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetPresenceschema1](Models/UsersSetPresenceschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersProfile

> Source: [UsersProfile](Api/UsersProfile.cs)

<details>
<summary><code>Task&lt;UsersProfileGetschema&gt; UsersProfileGet(string token, bool? includeLabels, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a user's profile information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersProfile.UsersProfileGet(token, includeLabels, user, contentType);
    // TODO: Handle 'response' of type UsersProfileGetschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>includeLabels</code> | <code>bool?</code> | Include labels for each ID in custom profile fields |
| <code>user</code> | <code>string?</code> | User to retrieve profile info for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileGetschema](Models/UsersProfileGetschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileGetschema1&gt; UsersProfileGet1(string token, bool? includeLabels, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a user's profile information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersProfile.UsersProfileGet1(token, includeLabels, user, contentType);
    // TODO: Handle 'response' of type UsersProfileGetschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:read` |
| <code>includeLabels</code> | <code>bool?</code> | Include labels for each ID in custom profile fields |
| <code>user</code> | <code>string?</code> | User to retrieve profile info for |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileGetschema1](Models/UsersProfileGetschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileSetschema&gt; UsersProfileSet(string token, ContentType contentType, string? name, string? profile, string? user, string? value, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the profile information for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersProfile.UsersProfileSet(token, contentType, name, profile, user, value);
    // TODO: Handle 'response' of type UsersProfileSetschema
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string?</code> | - |
| <code>profile</code> | <code>string?</code> | - |
| <code>user</code> | <code>string?</code> | - |
| <code>value</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileSetschema](Models/UsersProfileSetschema.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileSetschema1&gt; UsersProfileSet1(string token, ContentType contentType, string? name, string? profile, string? user, string? value, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the profile information for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersProfile.UsersProfileSet1(token, contentType, name, profile, user, value);
    // TODO: Handle 'response' of type UsersProfileSetschema1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `users.profile:write` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |
| <code>name</code> | <code>string?</code> | - |
| <code>profile</code> | <code>string?</code> | - |
| <code>user</code> | <code>string?</code> | - |
| <code>value</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileSetschema1](Models/UsersProfileSetschema1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Views

> Source: [Views](Api/Views.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsOpen(string triggerId, string view, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Open a view for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsOpen(triggerId, view, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | Exchange a trigger to post to the user. |
| <code>view</code> | <code>string</code> | A [view payload](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; ViewsOpen1(string triggerId, string view, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Open a view for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsOpen1(triggerId, view, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | Exchange a trigger to post to the user. |
| <code>view</code> | <code>string</code> | A [view payload](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsPublish(string userId, string view, string? hash, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Publish a static view for a User.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsPublish(userId, view, hash, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>string</code> | `id` of the user you want publish a view to. |
| <code>view</code> | <code>string</code> | A [view payload](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>hash</code> | <code>string?</code> | A string that represents view state to protect against possible race conditions. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; ViewsPublish1(string userId, string view, string? hash, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Publish a static view for a User.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsPublish1(userId, view, hash, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>string</code> | `id` of the user you want publish a view to. |
| <code>view</code> | <code>string</code> | A [view payload](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>hash</code> | <code>string?</code> | A string that represents view state to protect against possible race conditions. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsPush(string triggerId, string view, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Push a view onto the stack of a root view.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsPush(triggerId, view, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | Exchange a trigger to post to the user. |
| <code>view</code> | <code>string</code> | A [view payload](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; ViewsPush1(string triggerId, string view, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Push a view onto the stack of a root view.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsPush1(triggerId, view, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | Exchange a trigger to post to the user. |
| <code>view</code> | <code>string</code> | A [view payload](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsUpdate(string? viewId, string? externalId, string? view, string? hash, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing view.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsUpdate(viewId, externalId, view, hash, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>viewId</code> | <code>string?</code> | A unique identifier of the view to be updated. Either `view_id` or `external_id` is required. |
| <code>externalId</code> | <code>string?</code> | A unique identifier of the view set by the developer. Must be unique for all views on a team. Max length of 255 characters. Either `view_id` or `external_id` is required. |
| <code>view</code> | <code>string?</code> | A [view object](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>hash</code> | <code>string?</code> | A string that represents view state to protect against possible race conditions. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; ViewsUpdate1(string? viewId, string? externalId, string? view, string? hash, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing view.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Views.ViewsUpdate1(viewId, externalId, view, hash, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>viewId</code> | <code>string?</code> | A unique identifier of the view to be updated. Either `view_id` or `external_id` is required. |
| <code>externalId</code> | <code>string?</code> | A unique identifier of the view set by the developer. Must be unique for all views on a team. Max length of 255 characters. Either `view_id` or `external_id` is required. |
| <code>view</code> | <code>string?</code> | A [view object](/reference/surfaces/views). This must be a JSON-encoded string. |
| <code>hash</code> | <code>string?</code> | A string that represents view state to protect against possible race conditions. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `none` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Workflows

> Source: [Workflows](Api/Workflows.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; WorkflowsStepCompleted(string workflowStepExecuteId, string? outputs, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Indicate that an app's step in a workflow completed execution.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Workflows.WorkflowsStepCompleted(workflowStepExecuteId, outputs, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workflowStepExecuteId</code> | <code>string</code> | Context identifier that maps to the correct workflow step execution. |
| <code>outputs</code> | <code>string?</code> | Key-value object of outputs from your step. Keys of this object reflect the configured `key` properties of your [`outputs`](/reference/workflows/workflow_step#output) array from your `workflow_step` object. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `workflow.steps:execute` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; WorkflowsStepCompleted1(string workflowStepExecuteId, string? outputs, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Indicate that an app's step in a workflow completed execution.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Workflows.WorkflowsStepCompleted1(workflowStepExecuteId, outputs, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workflowStepExecuteId</code> | <code>string</code> | Context identifier that maps to the correct workflow step execution. |
| <code>outputs</code> | <code>string?</code> | Key-value object of outputs from your step. Keys of this object reflect the configured `key` properties of your [`outputs`](/reference/workflows/workflow_step#output) array from your `workflow_step` object. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `workflow.steps:execute` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; WorkflowsStepFailed(string workflowStepExecuteId, string error, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Indicate that an app's step in a workflow failed to execute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Workflows.WorkflowsStepFailed(workflowStepExecuteId, error, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workflowStepExecuteId</code> | <code>string</code> | Context identifier that maps to the correct workflow step execution. |
| <code>error</code> | <code>string</code> | A JSON-based object with a `message` property that should contain a human readable error message. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `workflow.steps:execute` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; WorkflowsStepFailed1(string workflowStepExecuteId, string error, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Indicate that an app's step in a workflow failed to execute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Workflows.WorkflowsStepFailed1(workflowStepExecuteId, error, token, contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workflowStepExecuteId</code> | <code>string</code> | Context identifier that maps to the correct workflow step execution. |
| <code>error</code> | <code>string</code> | A JSON-based object with a `message` property that should contain a human readable error message. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `workflow.steps:execute` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; WorkflowsUpdateStep(string workflowStepEditId, string? inputs, string? outputs, string? stepName, string? stepImageUrl, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the configuration for a workflow extension step.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Workflows.WorkflowsUpdateStep(workflowStepEditId,
        inputs,
        outputs,
        stepName,
        stepImageUrl,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workflowStepEditId</code> | <code>string</code> | A context identifier provided with `view_submission` payloads used to call back to `workflows.updateStep`. |
| <code>inputs</code> | <code>string?</code> | A JSON key-value map of inputs required from a user during configuration. This is the data your app expects to receive when the workflow step starts. **Please note**: the embedded variable format is set and replaced by the workflow system. You cannot create custom variables that will be replaced at runtime. [Read more about variables in workflow steps here](/workflows/steps#variables). |
| <code>outputs</code> | <code>string?</code> | An JSON array of output objects used during step execution. This is the data your app agrees to provide when your workflow step was executed. |
| <code>stepName</code> | <code>string?</code> | An optional field that can be used to override the step name that is shown in the Workflow Builder. |
| <code>stepImageUrl</code> | <code>string?</code> | An optional field that can be used to override app image that is shown in the Workflow Builder. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `workflow.steps:execute` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate1&gt; WorkflowsUpdateStep1(string workflowStepEditId, string? inputs, string? outputs, string? stepName, string? stepImageUrl, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the configuration for a workflow extension step.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Workflows.WorkflowsUpdateStep1(workflowStepEditId,
        inputs,
        outputs,
        stepName,
        stepImageUrl,
        token,
        contentType);
    // TODO: Handle 'response' of type Defaultsuccesstemplate1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workflowStepEditId</code> | <code>string</code> | A context identifier provided with `view_submission` payloads used to call back to `workflows.updateStep`. |
| <code>inputs</code> | <code>string?</code> | A JSON key-value map of inputs required from a user during configuration. This is the data your app expects to receive when the workflow step starts. **Please note**: the embedded variable format is set and replaced by the workflow system. You cannot create custom variables that will be replaced at runtime. [Read more about variables in workflow steps here](/workflows/steps#variables). |
| <code>outputs</code> | <code>string?</code> | An JSON array of output objects used during step execution. This is the data your app agrees to provide when your workflow step was executed. |
| <code>stepName</code> | <code>string?</code> | An optional field that can be used to override the step name that is shown in the Workflow Builder. |
| <code>stepImageUrl</code> | <code>string?</code> | An optional field that can be used to override app image that is shown in the Workflow Builder. |
| <code>token</code> | <code>string</code> | Authentication token. Requires scope: `workflow.steps:execute` |
| <code>contentType</code> | <code>[ContentType](Models/Enums/ContentType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate1](Models/Defaultsuccesstemplate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

