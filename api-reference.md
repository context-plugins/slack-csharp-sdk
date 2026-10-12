# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [SlackWebApiClient](src/SlackWebApi/SlackWebApiClient.cs)

## Admin

> Source: [Admin](src/SlackWebApi/Api/Admin.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprove(AdminAppsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminAppsApprove(new AdminAppsApproveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsApproveRequest](src/SlackWebApi/Requests/AdminApps/AdminAppsApproveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprovedList(AdminAppsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminAppsApprovedList(new AdminAppsApprovedListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsApprovedListRequest](src/SlackWebApi/Requests/AdminAppsApproved/AdminAppsApprovedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRequestsList(AdminAppsRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminAppsRequestsList(new AdminAppsRequestsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsRequestsListRequest](src/SlackWebApi/Requests/AdminAppsRequests/AdminAppsRequestsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrict(AdminAppsRestrictRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminAppsRestrict(new AdminAppsRestrictRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsRestrictRequest](src/SlackWebApi/Requests/AdminApps/AdminAppsRestrictRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrictedList(AdminAppsRestrictedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminAppsRestrictedList(new AdminAppsRestrictedListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsRestrictedListRequest](src/SlackWebApi/Requests/AdminAppsRestricted/AdminAppsRestrictedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsArchiveschema&gt; AdminConversationsArchive(AdminConversationsArchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsArchive(new AdminConversationsArchiveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsArchiveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsArchiveRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsArchiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsArchiveschema](src/SlackWebApi/Models/AdminConversationsArchiveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsConvertToPrivateschema&gt; AdminConversationsConvertToPrivate(AdminConversationsConvertToPrivateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsConvertToPrivate(new AdminConversationsConvertToPrivateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsConvertToPrivateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsConvertToPrivateRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsConvertToPrivateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsConvertToPrivateschema](src/SlackWebApi/Models/AdminConversationsConvertToPrivateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsCreateschema&gt; AdminConversationsCreate(AdminConversationsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsCreate(new AdminConversationsCreateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Name = "some example string",
        IsPrivate = true,
    });
    // TODO: Handle 'response' of type AdminConversationsCreateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsCreateRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsCreateschema](src/SlackWebApi/Models/AdminConversationsCreateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsDeleteschema&gt; AdminConversationsDelete(AdminConversationsDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsDelete(new AdminConversationsDeleteRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsDeleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsDeleteRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsDeleteschema](src/SlackWebApi/Models/AdminConversationsDeleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema&gt; AdminConversationsDisconnectShared(AdminConversationsDisconnectSharedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsDisconnectShared(new AdminConversationsDisconnectSharedRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsRenameschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsDisconnectSharedRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsDisconnectSharedRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema](src/SlackWebApi/Models/AdminConversationsRenameschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsEkmListOriginalConnectedChannelInfo(AdminConversationsEkmListOriginalConnectedChannelInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsEkmListOriginalConnectedChannelInfo(
        new AdminConversationsEkmListOriginalConnectedChannelInfoRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsEkmListOriginalConnectedChannelInfoRequest](src/SlackWebApi/Requests/AdminConversationsEkm/AdminConversationsEkmListOriginalConnectedChannelInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetConversationPrefsschema&gt; AdminConversationsGetConversationPrefs(AdminConversationsGetConversationPrefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsGetConversationPrefs(
        new AdminConversationsGetConversationPrefsRequest
        {
            ChannelId = "some example string",
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type AdminConversationsGetConversationPrefsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsGetConversationPrefsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsGetConversationPrefsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetConversationPrefsschema](src/SlackWebApi/Models/AdminConversationsGetConversationPrefsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetTeamsschema&gt; AdminConversationsGetTeams(AdminConversationsGetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsGetTeams(new AdminConversationsGetTeamsRequest
    {
        ChannelId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AdminConversationsGetTeamsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsGetTeamsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsGetTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetTeamsschema](src/SlackWebApi/Models/AdminConversationsGetTeamsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsInviteschema&gt; AdminConversationsInvite(AdminConversationsInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsInvite(new AdminConversationsInviteRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UserIds = "some example string",
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsInviteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsInviteRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsInviteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsInviteschema](src/SlackWebApi/Models/AdminConversationsInviteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema1&gt; AdminConversationsRename(AdminConversationsRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsRename(new AdminConversationsRenameRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
        Name = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsRenameschema1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRenameRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsRenameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema1](src/SlackWebApi/Models/AdminConversationsRenameschema1.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessAddGroup(AdminConversationsRestrictAccessAddGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsRestrictAccessAddGroup(
        new AdminConversationsRestrictAccessAddGroupRequest
        {
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            Token = "some example string",
            GroupId = "some example string",
            ChannelId = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRestrictAccessAddGroupRequest](src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessAddGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessListGroups(AdminConversationsRestrictAccessListGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsRestrictAccessListGroups(
        new AdminConversationsRestrictAccessListGroupsRequest
        {
            Token = "some example string",
            ChannelId = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRestrictAccessListGroupsRequest](src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessListGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessRemoveGroup(AdminConversationsRestrictAccessRemoveGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsRestrictAccessRemoveGroup(
        new AdminConversationsRestrictAccessRemoveGroupRequest
        {
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            Token = "some example string",
            TeamId = "some example string",
            GroupId = "some example string",
            ChannelId = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRestrictAccessRemoveGroupRequest](src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessRemoveGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSearchschema&gt; AdminConversationsSearch(AdminConversationsSearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsSearch(new AdminConversationsSearchRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AdminConversationsSearchschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsSearchRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsSearchRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSearchschema](src/SlackWebApi/Models/AdminConversationsSearchschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSetConversationPrefsschema&gt; AdminConversationsSetConversationPrefs(AdminConversationsSetConversationPrefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsSetConversationPrefs(
        new AdminConversationsSetConversationPrefsRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            ChannelId = "some example string",
            Prefs = "some example string",
        });
    // TODO: Handle 'response' of type AdminConversationsSetConversationPrefsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsSetConversationPrefsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsSetConversationPrefsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSetConversationPrefsschema](src/SlackWebApi/Models/AdminConversationsSetConversationPrefsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsSetTeams(AdminConversationsSetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsSetTeams(new AdminConversationsSetTeamsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsSetTeamsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsSetTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsUnarchiveschema&gt; AdminConversationsUnarchive(AdminConversationsUnarchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminConversationsUnarchive(new AdminConversationsUnarchiveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsUnarchiveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsUnarchiveRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsUnarchiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsUnarchiveschema](src/SlackWebApi/Models/AdminConversationsUnarchiveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAdd(AdminEmojiAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminEmojiAdd(new AdminEmojiAddRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
        Url = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiAddRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAddAlias(AdminEmojiAddAliasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminEmojiAddAlias(new AdminEmojiAddAliasRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
        AliasFor = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiAddAliasRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddAliasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiList(AdminEmojiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminEmojiList(new AdminEmojiListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiListRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRemove(AdminEmojiRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminEmojiRemove(new AdminEmojiRemoveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiRemoveRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRename(AdminEmojiRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminEmojiRename(new AdminEmojiRenameRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
        NewName = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiRenameRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRenameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprove(AdminInviteRequestsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminInviteRequestsApprove(new AdminInviteRequestsApproveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        InviteRequestId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsApproveRequest](src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsApproveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprovedList(AdminInviteRequestsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminInviteRequestsApprovedList(new AdminInviteRequestsApprovedListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsApprovedListRequest](src/SlackWebApi/Requests/AdminInviteRequestsApproved/AdminInviteRequestsApprovedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeniedList(AdminInviteRequestsDeniedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminInviteRequestsDeniedList(new AdminInviteRequestsDeniedListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsDeniedListRequest](src/SlackWebApi/Requests/AdminInviteRequestsDenied/AdminInviteRequestsDeniedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeny(AdminInviteRequestsDenyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminInviteRequestsDeny(new AdminInviteRequestsDenyRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        InviteRequestId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsDenyRequest](src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsDenyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsList(AdminInviteRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminInviteRequestsList(new AdminInviteRequestsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsListRequest](src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsAdminsList(AdminTeamsAdminsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsAdminsList(new AdminTeamsAdminsListRequest
    {
        Token = "some example string",
        TeamId = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsAdminsListRequest](src/SlackWebApi/Requests/AdminTeamsAdmins/AdminTeamsAdminsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsCreate(AdminTeamsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsCreate(new AdminTeamsCreateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamDomain = "some example string",
        TeamName = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsCreateRequest](src/SlackWebApi/Requests/AdminTeams/AdminTeamsCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsList(AdminTeamsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsList(new AdminTeamsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsListRequest](src/SlackWebApi/Requests/AdminTeams/AdminTeamsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsOwnersList(AdminTeamsOwnersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsOwnersList(new AdminTeamsOwnersListRequest
    {
        Token = "some example string",
        TeamId = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsOwnersListRequest](src/SlackWebApi/Requests/AdminTeamsOwners/AdminTeamsOwnersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsInfo(AdminTeamsSettingsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsSettingsInfo(new AdminTeamsSettingsInfoRequest
    {
        TeamId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsInfoRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDefaultChannels(AdminTeamsSettingsSetDefaultChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsSettingsSetDefaultChannels(
        new AdminTeamsSettingsSetDefaultChannelsRequest
        {
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            Token = "some example string",
            TeamId = "some example string",
            ChannelIds = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetDefaultChannelsRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDefaultChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDescription(AdminTeamsSettingsSetDescriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsSettingsSetDescription(new AdminTeamsSettingsSetDescriptionRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        Description = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetDescriptionRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDescriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDiscoverability(AdminTeamsSettingsSetDiscoverabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsSettingsSetDiscoverability(
        new AdminTeamsSettingsSetDiscoverabilityRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            TeamId = "some example string",
            Discoverability = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetDiscoverabilityRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDiscoverabilityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetIcon(AdminTeamsSettingsSetIconRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsSettingsSetIcon(new AdminTeamsSettingsSetIconRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        ImageUrl = "some example string",
        TeamId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetIconRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetIconRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetName(AdminTeamsSettingsSetNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminTeamsSettingsSetName(new AdminTeamsSettingsSetNameRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetNameRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddChannels(AdminUsergroupsAddChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsergroupsAddChannels(new AdminUsergroupsAddChannelsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UsergroupId = "some example string",
        ChannelIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsAddChannelsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddTeams(AdminUsergroupsAddTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsergroupsAddTeams(new AdminUsergroupsAddTeamsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UsergroupId = "some example string",
        TeamIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsAddTeamsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsListChannels(AdminUsergroupsListChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsergroupsListChannels(new AdminUsergroupsListChannelsRequest
    {
        UsergroupId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsListChannelsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsListChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsRemoveChannels(AdminUsergroupsRemoveChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsergroupsRemoveChannels(new AdminUsergroupsRemoveChannelsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UsergroupId = "some example string",
        ChannelIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsRemoveChannelsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsRemoveChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersAssign(AdminUsersAssignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersAssign(new AdminUsersAssignRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersAssignRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersAssignRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersInvite(AdminUsersInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersInvite(new AdminUsersInviteRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        Email = "some example string",
        ChannelIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersInviteRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersInviteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersList(AdminUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersList(new AdminUsersListRequest
    {
        TeamId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersListRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersRemove(AdminUsersRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersRemove(new AdminUsersRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersRemoveRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionInvalidate(AdminUsersSessionInvalidateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersSessionInvalidate(new AdminUsersSessionInvalidateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        SessionId = 1,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSessionInvalidateRequest](src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionInvalidateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionReset(AdminUsersSessionResetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersSessionReset(new AdminUsersSessionResetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSessionResetRequest](src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionResetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetAdmin(AdminUsersSetAdminRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersSetAdmin(new AdminUsersSetAdminRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetAdminRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetAdminRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetExpiration(AdminUsersSetExpirationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersSetExpiration(new AdminUsersSetExpirationRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
        ExpirationTs = 1,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetExpirationRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetExpirationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetOwner(AdminUsersSetOwnerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersSetOwner(new AdminUsersSetOwnerRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetOwnerRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetOwnerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetRegular(AdminUsersSetRegularRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Admin.AdminUsersSetRegular(new AdminUsersSetRegularRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetRegularRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetRegularRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminApps

> Source: [AdminApps](src/SlackWebApi/Api/AdminApps.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprove(AdminAppsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminApps.AdminAppsApprove(new AdminAppsApproveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsApproveRequest](src/SlackWebApi/Requests/AdminApps/AdminAppsApproveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrict(AdminAppsRestrictRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminApps.AdminAppsRestrict(new AdminAppsRestrictRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsRestrictRequest](src/SlackWebApi/Requests/AdminApps/AdminAppsRestrictRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminAppsApproved

> Source: [AdminAppsApproved](src/SlackWebApi/Api/AdminAppsApproved.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsApprovedList(AdminAppsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminAppsApproved.AdminAppsApprovedList(new AdminAppsApprovedListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsApprovedListRequest](src/SlackWebApi/Requests/AdminAppsApproved/AdminAppsApprovedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminAppsRequests

> Source: [AdminAppsRequests](src/SlackWebApi/Api/AdminAppsRequests.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRequestsList(AdminAppsRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminAppsRequests.AdminAppsRequestsList(new AdminAppsRequestsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsRequestsListRequest](src/SlackWebApi/Requests/AdminAppsRequests/AdminAppsRequestsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminAppsRestricted

> Source: [AdminAppsRestricted](src/SlackWebApi/Api/AdminAppsRestricted.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminAppsRestrictedList(AdminAppsRestrictedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminAppsRestricted.AdminAppsRestrictedList(new AdminAppsRestrictedListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminAppsRestrictedListRequest](src/SlackWebApi/Requests/AdminAppsRestricted/AdminAppsRestrictedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminConversations

> Source: [AdminConversations](src/SlackWebApi/Api/AdminConversations.cs)

<details>
<summary><code>Task&lt;AdminConversationsArchiveschema&gt; AdminConversationsArchive(AdminConversationsArchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsArchive(new AdminConversationsArchiveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsArchiveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsArchiveRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsArchiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsArchiveschema](src/SlackWebApi/Models/AdminConversationsArchiveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsConvertToPrivateschema&gt; AdminConversationsConvertToPrivate(AdminConversationsConvertToPrivateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsConvertToPrivate(
        new AdminConversationsConvertToPrivateRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            ChannelId = "some example string",
        });
    // TODO: Handle 'response' of type AdminConversationsConvertToPrivateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsConvertToPrivateRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsConvertToPrivateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsConvertToPrivateschema](src/SlackWebApi/Models/AdminConversationsConvertToPrivateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsCreateschema&gt; AdminConversationsCreate(AdminConversationsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsCreate(new AdminConversationsCreateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Name = "some example string",
        IsPrivate = true,
    });
    // TODO: Handle 'response' of type AdminConversationsCreateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsCreateRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsCreateschema](src/SlackWebApi/Models/AdminConversationsCreateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsDeleteschema&gt; AdminConversationsDelete(AdminConversationsDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsDelete(new AdminConversationsDeleteRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsDeleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsDeleteRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsDeleteschema](src/SlackWebApi/Models/AdminConversationsDeleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema&gt; AdminConversationsDisconnectShared(AdminConversationsDisconnectSharedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsDisconnectShared(
        new AdminConversationsDisconnectSharedRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            ChannelId = "some example string",
        });
    // TODO: Handle 'response' of type AdminConversationsRenameschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsDisconnectSharedRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsDisconnectSharedRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema](src/SlackWebApi/Models/AdminConversationsRenameschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetConversationPrefsschema&gt; AdminConversationsGetConversationPrefs(AdminConversationsGetConversationPrefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsGetConversationPrefs(
        new AdminConversationsGetConversationPrefsRequest
        {
            ChannelId = "some example string",
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type AdminConversationsGetConversationPrefsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsGetConversationPrefsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsGetConversationPrefsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetConversationPrefsschema](src/SlackWebApi/Models/AdminConversationsGetConversationPrefsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsGetTeamsschema&gt; AdminConversationsGetTeams(AdminConversationsGetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsGetTeams(new AdminConversationsGetTeamsRequest
    {
        ChannelId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AdminConversationsGetTeamsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsGetTeamsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsGetTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsGetTeamsschema](src/SlackWebApi/Models/AdminConversationsGetTeamsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsInviteschema&gt; AdminConversationsInvite(AdminConversationsInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsInvite(new AdminConversationsInviteRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UserIds = "some example string",
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsInviteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsInviteRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsInviteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsInviteschema](src/SlackWebApi/Models/AdminConversationsInviteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsRenameschema1&gt; AdminConversationsRename(AdminConversationsRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsRename(new AdminConversationsRenameRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
        Name = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsRenameschema1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRenameRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsRenameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsRenameschema1](src/SlackWebApi/Models/AdminConversationsRenameschema1.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSearchschema&gt; AdminConversationsSearch(AdminConversationsSearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsSearch(new AdminConversationsSearchRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AdminConversationsSearchschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsSearchRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsSearchRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSearchschema](src/SlackWebApi/Models/AdminConversationsSearchschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsSetConversationPrefsschema&gt; AdminConversationsSetConversationPrefs(AdminConversationsSetConversationPrefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsSetConversationPrefs(
        new AdminConversationsSetConversationPrefsRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            ChannelId = "some example string",
            Prefs = "some example string",
        });
    // TODO: Handle 'response' of type AdminConversationsSetConversationPrefsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsSetConversationPrefsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsSetConversationPrefsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsSetConversationPrefsschema](src/SlackWebApi/Models/AdminConversationsSetConversationPrefsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsSetTeams(AdminConversationsSetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsSetTeams(new AdminConversationsSetTeamsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsSetTeamsRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsSetTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminConversationsUnarchiveschema&gt; AdminConversationsUnarchive(AdminConversationsUnarchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversations.AdminConversationsUnarchive(new AdminConversationsUnarchiveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type AdminConversationsUnarchiveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsUnarchiveRequest](src/SlackWebApi/Requests/AdminConversations/AdminConversationsUnarchiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminConversationsUnarchiveschema](src/SlackWebApi/Models/AdminConversationsUnarchiveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminConversationsEkm

> Source: [AdminConversationsEkm](src/SlackWebApi/Api/AdminConversationsEkm.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsEkmListOriginalConnectedChannelInfo(AdminConversationsEkmListOriginalConnectedChannelInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversationsEkm.AdminConversationsEkmListOriginalConnectedChannelInfo(
        new AdminConversationsEkmListOriginalConnectedChannelInfoRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsEkmListOriginalConnectedChannelInfoRequest](src/SlackWebApi/Requests/AdminConversationsEkm/AdminConversationsEkmListOriginalConnectedChannelInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminConversationsRestrictAccess

> Source: [AdminConversationsRestrictAccess](src/SlackWebApi/Api/AdminConversationsRestrictAccess.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessAddGroup(AdminConversationsRestrictAccessAddGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessAddGroup(
        new AdminConversationsRestrictAccessAddGroupRequest
        {
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            Token = "some example string",
            GroupId = "some example string",
            ChannelId = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRestrictAccessAddGroupRequest](src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessAddGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessListGroups(AdminConversationsRestrictAccessListGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessListGroups(
        new AdminConversationsRestrictAccessListGroupsRequest
        {
            Token = "some example string",
            ChannelId = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRestrictAccessListGroupsRequest](src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessListGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminConversationsRestrictAccessRemoveGroup(AdminConversationsRestrictAccessRemoveGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminConversationsRestrictAccess.AdminConversationsRestrictAccessRemoveGroup(
        new AdminConversationsRestrictAccessRemoveGroupRequest
        {
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            Token = "some example string",
            TeamId = "some example string",
            GroupId = "some example string",
            ChannelId = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminConversationsRestrictAccessRemoveGroupRequest](src/SlackWebApi/Requests/AdminConversationsRestrictAccess/AdminConversationsRestrictAccessRemoveGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminEmoji

> Source: [AdminEmoji](src/SlackWebApi/Api/AdminEmoji.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAdd(AdminEmojiAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminEmoji.AdminEmojiAdd(new AdminEmojiAddRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
        Url = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiAddRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiAddAlias(AdminEmojiAddAliasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminEmoji.AdminEmojiAddAlias(new AdminEmojiAddAliasRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
        AliasFor = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiAddAliasRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiAddAliasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiList(AdminEmojiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminEmoji.AdminEmojiList(new AdminEmojiListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiListRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRemove(AdminEmojiRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminEmoji.AdminEmojiRemove(new AdminEmojiRemoveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiRemoveRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminEmojiRename(AdminEmojiRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminEmoji.AdminEmojiRename(new AdminEmojiRenameRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        Name = "some example string",
        NewName = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminEmojiRenameRequest](src/SlackWebApi/Requests/AdminEmoji/AdminEmojiRenameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminInviteRequests

> Source: [AdminInviteRequests](src/SlackWebApi/Api/AdminInviteRequests.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprove(AdminInviteRequestsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminInviteRequests.AdminInviteRequestsApprove(new AdminInviteRequestsApproveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        InviteRequestId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsApproveRequest](src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsApproveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeny(AdminInviteRequestsDenyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminInviteRequests.AdminInviteRequestsDeny(new AdminInviteRequestsDenyRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        InviteRequestId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsDenyRequest](src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsDenyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsList(AdminInviteRequestsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminInviteRequests.AdminInviteRequestsList(new AdminInviteRequestsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsListRequest](src/SlackWebApi/Requests/AdminInviteRequests/AdminInviteRequestsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminInviteRequestsApproved

> Source: [AdminInviteRequestsApproved](src/SlackWebApi/Api/AdminInviteRequestsApproved.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsApprovedList(AdminInviteRequestsApprovedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminInviteRequestsApproved.AdminInviteRequestsApprovedList(
        new AdminInviteRequestsApprovedListRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsApprovedListRequest](src/SlackWebApi/Requests/AdminInviteRequestsApproved/AdminInviteRequestsApprovedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminInviteRequestsDenied

> Source: [AdminInviteRequestsDenied](src/SlackWebApi/Api/AdminInviteRequestsDenied.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminInviteRequestsDeniedList(AdminInviteRequestsDeniedListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminInviteRequestsDenied.AdminInviteRequestsDeniedList(
        new AdminInviteRequestsDeniedListRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminInviteRequestsDeniedListRequest](src/SlackWebApi/Requests/AdminInviteRequestsDenied/AdminInviteRequestsDeniedListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeams

> Source: [AdminTeams](src/SlackWebApi/Api/AdminTeams.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsCreate(AdminTeamsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeams.AdminTeamsCreate(new AdminTeamsCreateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamDomain = "some example string",
        TeamName = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsCreateRequest](src/SlackWebApi/Requests/AdminTeams/AdminTeamsCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsList(AdminTeamsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeams.AdminTeamsList(new AdminTeamsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsListRequest](src/SlackWebApi/Requests/AdminTeams/AdminTeamsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeamsAdmins

> Source: [AdminTeamsAdmins](src/SlackWebApi/Api/AdminTeamsAdmins.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsAdminsList(AdminTeamsAdminsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsAdmins.AdminTeamsAdminsList(new AdminTeamsAdminsListRequest
    {
        Token = "some example string",
        TeamId = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsAdminsListRequest](src/SlackWebApi/Requests/AdminTeamsAdmins/AdminTeamsAdminsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeamsOwners

> Source: [AdminTeamsOwners](src/SlackWebApi/Api/AdminTeamsOwners.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsOwnersList(AdminTeamsOwnersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsOwners.AdminTeamsOwnersList(new AdminTeamsOwnersListRequest
    {
        Token = "some example string",
        TeamId = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsOwnersListRequest](src/SlackWebApi/Requests/AdminTeamsOwners/AdminTeamsOwnersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminTeamsSettings

> Source: [AdminTeamsSettings](src/SlackWebApi/Api/AdminTeamsSettings.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsInfo(AdminTeamsSettingsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsInfo(new AdminTeamsSettingsInfoRequest
    {
        TeamId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsInfoRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDefaultChannels(AdminTeamsSettingsSetDefaultChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDefaultChannels(
        new AdminTeamsSettingsSetDefaultChannelsRequest
        {
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            Token = "some example string",
            TeamId = "some example string",
            ChannelIds = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetDefaultChannelsRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDefaultChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDescription(AdminTeamsSettingsSetDescriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDescription(
        new AdminTeamsSettingsSetDescriptionRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            TeamId = "some example string",
            Description = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetDescriptionRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDescriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetDiscoverability(AdminTeamsSettingsSetDiscoverabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetDiscoverability(
        new AdminTeamsSettingsSetDiscoverabilityRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
            TeamId = "some example string",
            Discoverability = "some example string",
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetDiscoverabilityRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetDiscoverabilityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetIcon(AdminTeamsSettingsSetIconRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetIcon(new AdminTeamsSettingsSetIconRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        ImageUrl = "some example string",
        TeamId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetIconRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetIconRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminTeamsSettingsSetName(AdminTeamsSettingsSetNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminTeamsSettings.AdminTeamsSettingsSetName(new AdminTeamsSettingsSetNameRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminTeamsSettingsSetNameRequest](src/SlackWebApi/Requests/AdminTeamsSettings/AdminTeamsSettingsSetNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminUsergroups

> Source: [AdminUsergroups](src/SlackWebApi/Api/AdminUsergroups.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddChannels(AdminUsergroupsAddChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsergroups.AdminUsergroupsAddChannels(new AdminUsergroupsAddChannelsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UsergroupId = "some example string",
        ChannelIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsAddChannelsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsAddTeams(AdminUsergroupsAddTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsergroups.AdminUsergroupsAddTeams(new AdminUsergroupsAddTeamsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UsergroupId = "some example string",
        TeamIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsAddTeamsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsAddTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsListChannels(AdminUsergroupsListChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsergroups.AdminUsergroupsListChannels(new AdminUsergroupsListChannelsRequest
    {
        UsergroupId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsListChannelsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsListChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsergroupsRemoveChannels(AdminUsergroupsRemoveChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsergroups.AdminUsergroupsRemoveChannels(new AdminUsergroupsRemoveChannelsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UsergroupId = "some example string",
        ChannelIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsergroupsRemoveChannelsRequest](src/SlackWebApi/Requests/AdminUsergroups/AdminUsergroupsRemoveChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminUsers

> Source: [AdminUsers](src/SlackWebApi/Api/AdminUsers.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersAssign(AdminUsersAssignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersAssign(new AdminUsersAssignRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersAssignRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersAssignRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersInvite(AdminUsersInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersInvite(new AdminUsersInviteRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        Email = "some example string",
        ChannelIds = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersInviteRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersInviteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersList(AdminUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersList(new AdminUsersListRequest
    {
        TeamId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersListRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersRemove(AdminUsersRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersRemove(new AdminUsersRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersRemoveRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetAdmin(AdminUsersSetAdminRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersSetAdmin(new AdminUsersSetAdminRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetAdminRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetAdminRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetExpiration(AdminUsersSetExpirationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersSetExpiration(new AdminUsersSetExpirationRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
        ExpirationTs = 1,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetExpirationRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetExpirationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetOwner(AdminUsersSetOwnerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersSetOwner(new AdminUsersSetOwnerRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetOwnerRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetOwnerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSetRegular(AdminUsersSetRegularRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsers.AdminUsersSetRegular(new AdminUsersSetRegularRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSetRegularRequest](src/SlackWebApi/Requests/AdminUsers/AdminUsersSetRegularRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AdminUsersSession

> Source: [AdminUsersSession](src/SlackWebApi/Api/AdminUsersSession.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionInvalidate(AdminUsersSessionInvalidateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsersSession.AdminUsersSessionInvalidate(new AdminUsersSessionInvalidateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        TeamId = "some example string",
        SessionId = 1,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSessionInvalidateRequest](src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionInvalidateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AdminUsersSessionReset(AdminUsersSessionResetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AdminUsersSession.AdminUsersSessionReset(new AdminUsersSessionResetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminUsersSessionResetRequest](src/SlackWebApi/Requests/AdminUsersSession/AdminUsersSessionResetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiApi

> Source: [ApiApi](src/SlackWebApi/Api/ApiApi.cs)

<details>
<summary><code>Task&lt;ApiTestsuccessschema&gt; ApiTest(ApiTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ApiApi.ApiTest(new ApiTestRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ApiTestsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApiTestRequest](src/SlackWebApi/Requests/ApiApi/ApiTestRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiTestsuccessschema](src/SlackWebApi/Models/ApiTestsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Apps

> Source: [Apps](src/SlackWebApi/Api/Apps.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsEventAuthorizationsList(AppsEventAuthorizationsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsEventAuthorizationsList(new AppsEventAuthorizationsListRequest
    {
        EventContext = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsEventAuthorizationsListRequest](src/SlackWebApi/Requests/AppsEventAuthorizations/AppsEventAuthorizationsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsInfoschema&gt; AppsPermissionsInfo(AppsPermissionsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsPermissionsInfo(new AppsPermissionsInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AppsPermissionsInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsInfoRequest](src/SlackWebApi/Requests/AppsPermissions/AppsPermissionsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsInfoschema](src/SlackWebApi/Models/AppsPermissionsInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsRequestschema&gt; AppsPermissionsRequest(AppsPermissionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsPermissionsRequest(new AppsPermissionsRequest
    {
        Token = "some example string",
        Scopes = "some example string",
        TriggerId = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AppsPermissionsRequestschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsRequest](src/SlackWebApi/Requests/AppsPermissions/AppsPermissionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsRequestschema](src/SlackWebApi/Models/AppsPermissionsRequestschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsResourcesListsuccessschema&gt; AppsPermissionsResourcesList(AppsPermissionsResourcesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsPermissionsResourcesList(new AppsPermissionsResourcesListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AppsPermissionsResourcesListsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsResourcesListRequest](src/SlackWebApi/Requests/AppsPermissionsResources/AppsPermissionsResourcesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsResourcesListsuccessschema](src/SlackWebApi/Models/AppsPermissionsResourcesListsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiPermissionsScopesListsuccessschema&gt; AppsPermissionsScopesList(AppsPermissionsScopesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsPermissionsScopesList(new AppsPermissionsScopesListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ApiPermissionsScopesListsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsScopesListRequest](src/SlackWebApi/Requests/AppsPermissionsScopes/AppsPermissionsScopesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiPermissionsScopesListsuccessschema](src/SlackWebApi/Models/ApiPermissionsScopesListsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersList(AppsPermissionsUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsPermissionsUsersList(new AppsPermissionsUsersListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsUsersListRequest](src/SlackWebApi/Requests/AppsPermissionsUsers/AppsPermissionsUsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersRequest(AppsPermissionsUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsPermissionsUsersRequest(new AppsPermissionsUsersRequest
    {
        Token = "some example string",
        Scopes = "some example string",
        TriggerId = "some example string",
        User = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsUsersRequest](src/SlackWebApi/Requests/AppsPermissionsUsers/AppsPermissionsUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsUninstallschema&gt; AppsUninstall(AppsUninstallRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Apps.AppsUninstall(new AppsUninstallRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AppsUninstallschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsUninstallRequest](src/SlackWebApi/Requests/Apps/AppsUninstallRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsUninstallschema](src/SlackWebApi/Models/AppsUninstallschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsEventAuthorizations

> Source: [AppsEventAuthorizations](src/SlackWebApi/Api/AppsEventAuthorizations.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsEventAuthorizationsList(AppsEventAuthorizationsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsEventAuthorizations.AppsEventAuthorizationsList(
        new AppsEventAuthorizationsListRequest
        {
            EventContext = "some example string",
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsEventAuthorizationsListRequest](src/SlackWebApi/Requests/AppsEventAuthorizations/AppsEventAuthorizationsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissions

> Source: [AppsPermissions](src/SlackWebApi/Api/AppsPermissions.cs)

<details>
<summary><code>Task&lt;AppsPermissionsInfoschema&gt; AppsPermissionsInfo(AppsPermissionsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsPermissions.AppsPermissionsInfo(new AppsPermissionsInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AppsPermissionsInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsInfoRequest](src/SlackWebApi/Requests/AppsPermissions/AppsPermissionsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsInfoschema](src/SlackWebApi/Models/AppsPermissionsInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppsPermissionsRequestschema&gt; AppsPermissionsRequest(AppsPermissionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsPermissions.AppsPermissionsRequest(new AppsPermissionsRequest
    {
        Token = "some example string",
        Scopes = "some example string",
        TriggerId = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AppsPermissionsRequestschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsRequest](src/SlackWebApi/Requests/AppsPermissions/AppsPermissionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsRequestschema](src/SlackWebApi/Models/AppsPermissionsRequestschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissionsResources

> Source: [AppsPermissionsResources](src/SlackWebApi/Api/AppsPermissionsResources.cs)

<details>
<summary><code>Task&lt;AppsPermissionsResourcesListsuccessschema&gt; AppsPermissionsResourcesList(AppsPermissionsResourcesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsPermissionsResources.AppsPermissionsResourcesList(
        new AppsPermissionsResourcesListRequest
        {
            Token = "some example string",
            ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        });
    // TODO: Handle 'response' of type AppsPermissionsResourcesListsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsResourcesListRequest](src/SlackWebApi/Requests/AppsPermissionsResources/AppsPermissionsResourcesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppsPermissionsResourcesListsuccessschema](src/SlackWebApi/Models/AppsPermissionsResourcesListsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissionsScopes

> Source: [AppsPermissionsScopes](src/SlackWebApi/Api/AppsPermissionsScopes.cs)

<details>
<summary><code>Task&lt;ApiPermissionsScopesListsuccessschema&gt; AppsPermissionsScopesList(AppsPermissionsScopesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsPermissionsScopes.AppsPermissionsScopesList(new AppsPermissionsScopesListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ApiPermissionsScopesListsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsScopesListRequest](src/SlackWebApi/Requests/AppsPermissionsScopes/AppsPermissionsScopesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiPermissionsScopesListsuccessschema](src/SlackWebApi/Models/ApiPermissionsScopesListsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppsPermissionsUsers

> Source: [AppsPermissionsUsers](src/SlackWebApi/Api/AppsPermissionsUsers.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersList(AppsPermissionsUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsPermissionsUsers.AppsPermissionsUsersList(new AppsPermissionsUsersListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsUsersListRequest](src/SlackWebApi/Requests/AppsPermissionsUsers/AppsPermissionsUsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; AppsPermissionsUsersRequest(AppsPermissionsUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AppsPermissionsUsers.AppsPermissionsUsersRequest(new AppsPermissionsUsersRequest
    {
        Token = "some example string",
        Scopes = "some example string",
        TriggerId = "some example string",
        User = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AppsPermissionsUsersRequest](src/SlackWebApi/Requests/AppsPermissionsUsers/AppsPermissionsUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Auth

> Source: [Auth](src/SlackWebApi/Api/Auth.cs)

<details>
<summary><code>Task&lt;AuthRevokeschema&gt; AuthRevoke(AuthRevokeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Auth.AuthRevoke(new AuthRevokeRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AuthRevokeschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AuthRevokeRequest](src/SlackWebApi/Requests/Auth/AuthRevokeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthRevokeschema](src/SlackWebApi/Models/AuthRevokeschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTestsuccessschema&gt; AuthTest(AuthTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Auth.AuthTest(new AuthTestRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type AuthTestsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AuthTestRequest](src/SlackWebApi/Requests/Auth/AuthTestRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTestsuccessschema](src/SlackWebApi/Models/AuthTestsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Bots

> Source: [Bots](src/SlackWebApi/Api/Bots.cs)

<details>
<summary><code>Task&lt;BotsInfoschema&gt; BotsInfo(BotsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Bots.BotsInfo(new BotsInfoRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type BotsInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BotsInfoRequest](src/SlackWebApi/Requests/Bots/BotsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BotsInfoschema](src/SlackWebApi/Models/BotsInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Calls

> Source: [Calls](src/SlackWebApi/Api/Calls.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsAdd(CallsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Calls.CallsAdd(new CallsAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        ExternalUniqueId = "some example string",
        JoinUrl = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsAddRequest](src/SlackWebApi/Requests/Calls/CallsAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsEnd(CallsEndRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Calls.CallsEnd(new CallsEndRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Id = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsEndRequest](src/SlackWebApi/Requests/Calls/CallsEndRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsInfo(CallsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Calls.CallsInfo(new CallsInfoRequest
    {
        Id = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsInfoRequest](src/SlackWebApi/Requests/Calls/CallsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsAdd(CallsParticipantsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Calls.CallsParticipantsAdd(new CallsParticipantsAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Id = "some example string",
        Users = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsParticipantsAddRequest](src/SlackWebApi/Requests/CallsParticipants/CallsParticipantsAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsRemove(CallsParticipantsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Calls.CallsParticipantsRemove(new CallsParticipantsRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Id = "some example string",
        Users = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsParticipantsRemoveRequest](src/SlackWebApi/Requests/CallsParticipants/CallsParticipantsRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsUpdate(CallsUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Calls.CallsUpdate(new CallsUpdateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Id = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsUpdateRequest](src/SlackWebApi/Requests/Calls/CallsUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CallsParticipants

> Source: [CallsParticipants](src/SlackWebApi/Api/CallsParticipants.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsAdd(CallsParticipantsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CallsParticipants.CallsParticipantsAdd(new CallsParticipantsAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Id = "some example string",
        Users = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsParticipantsAddRequest](src/SlackWebApi/Requests/CallsParticipants/CallsParticipantsAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; CallsParticipantsRemove(CallsParticipantsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.CallsParticipants.CallsParticipantsRemove(new CallsParticipantsRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Id = "some example string",
        Users = "some example string",
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CallsParticipantsRemoveRequest](src/SlackWebApi/Requests/CallsParticipants/CallsParticipantsRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Chat

> Source: [Chat](src/SlackWebApi/Api/Chat.cs)

<details>
<summary><code>Task&lt;ChatDeletesuccessschema&gt; ChatDelete(ChatDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatDelete(new ChatDeleteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ChatDeletesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatDeleteRequest](src/SlackWebApi/Requests/Chat/ChatDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatDeletesuccessschema](src/SlackWebApi/Models/ChatDeletesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatDeleteScheduledMessageschema&gt; ChatDeleteScheduledMessage(ChatDeleteScheduledMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatDeleteScheduledMessage(new ChatDeleteScheduledMessageRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
        ScheduledMessageId = "some example string",
    });
    // TODO: Handle 'response' of type ChatDeleteScheduledMessageschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatDeleteScheduledMessageRequest](src/SlackWebApi/Requests/Chat/ChatDeleteScheduledMessageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatDeleteScheduledMessageschema](src/SlackWebApi/Models/ChatDeleteScheduledMessageschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatGetPermalinksuccessschema&gt; ChatGetPermalink(ChatGetPermalinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatGetPermalink(new ChatGetPermalinkRequest
    {
        Token = "some example string",
        Channel = "some example string",
        MessageTs = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ChatGetPermalinksuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatGetPermalinkRequest](src/SlackWebApi/Requests/Chat/ChatGetPermalinkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatGetPermalinksuccessschema](src/SlackWebApi/Models/ChatGetPermalinksuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatMeMessageschema&gt; ChatMeMessage(ChatMeMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatMeMessage(new ChatMeMessageRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ChatMeMessageschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatMeMessageRequest](src/SlackWebApi/Requests/Chat/ChatMeMessageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatMeMessageschema](src/SlackWebApi/Models/ChatMeMessageschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatPostEphemeralsuccessschema&gt; ChatPostEphemeral(ChatPostEphemeralRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatPostEphemeral(new ChatPostEphemeralRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
        User = "some example string",
    });
    // TODO: Handle 'response' of type ChatPostEphemeralsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatPostEphemeralRequest](src/SlackWebApi/Requests/Chat/ChatPostEphemeralRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatPostEphemeralsuccessschema](src/SlackWebApi/Models/ChatPostEphemeralsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatPostMessagesuccessschema&gt; ChatPostMessage(ChatPostMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatPostMessage(new ChatPostMessageRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
    });
    // TODO: Handle 'response' of type ChatPostMessagesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatPostMessageRequest](src/SlackWebApi/Requests/Chat/ChatPostMessageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatPostMessagesuccessschema](src/SlackWebApi/Models/ChatPostMessagesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduleMessagesuccessschema&gt; ChatScheduleMessage(ChatScheduleMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatScheduleMessage(new ChatScheduleMessageRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ChatScheduleMessagesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatScheduleMessageRequest](src/SlackWebApi/Requests/Chat/ChatScheduleMessageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduleMessagesuccessschema](src/SlackWebApi/Models/ChatScheduleMessagesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatScheduledMessagesListschema&gt; ChatScheduledMessagesList(ChatScheduledMessagesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatScheduledMessagesList(new ChatScheduledMessagesListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ChatScheduledMessagesListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatScheduledMessagesListRequest](src/SlackWebApi/Requests/ChatScheduledMessages/ChatScheduledMessagesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduledMessagesListschema](src/SlackWebApi/Models/ChatScheduledMessagesListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatUnfurlsuccessschema&gt; ChatUnfurl(ChatUnfurlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatUnfurl(new ChatUnfurlRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
        Ts = "some example string",
    });
    // TODO: Handle 'response' of type ChatUnfurlsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatUnfurlRequest](src/SlackWebApi/Requests/Chat/ChatUnfurlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatUnfurlsuccessschema](src/SlackWebApi/Models/ChatUnfurlsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChatUpdatesuccessschema&gt; ChatUpdate(ChatUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Chat.ChatUpdate(new ChatUpdateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
        Ts = "some example string",
    });
    // TODO: Handle 'response' of type ChatUpdatesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatUpdateRequest](src/SlackWebApi/Requests/Chat/ChatUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatUpdatesuccessschema](src/SlackWebApi/Models/ChatUpdatesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChatScheduledMessages

> Source: [ChatScheduledMessages](src/SlackWebApi/Api/ChatScheduledMessages.cs)

<details>
<summary><code>Task&lt;ChatScheduledMessagesListschema&gt; ChatScheduledMessagesList(ChatScheduledMessagesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ChatScheduledMessages.ChatScheduledMessagesList(new ChatScheduledMessagesListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ChatScheduledMessagesListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatScheduledMessagesListRequest](src/SlackWebApi/Requests/ChatScheduledMessages/ChatScheduledMessagesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatScheduledMessagesListschema](src/SlackWebApi/Models/ChatScheduledMessagesListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Conversations

> Source: [Conversations](src/SlackWebApi/Api/Conversations.cs)

<details>
<summary><code>Task&lt;ConversationsArchivesuccessschema&gt; ConversationsArchive(ConversationsArchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsArchive(new ConversationsArchiveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsArchivesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsArchiveRequest](src/SlackWebApi/Requests/Conversations/ConversationsArchiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsArchivesuccessschema](src/SlackWebApi/Models/ConversationsArchivesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsClosesuccessschema&gt; ConversationsClose(ConversationsCloseRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsClose(new ConversationsCloseRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsClosesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsCloseRequest](src/SlackWebApi/Requests/Conversations/ConversationsCloseRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsClosesuccessschema](src/SlackWebApi/Models/ConversationsClosesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsCreatesuccessschema&gt; ConversationsCreate(ConversationsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsCreate(new ConversationsCreateRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsCreatesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsCreateRequest](src/SlackWebApi/Requests/Conversations/ConversationsCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsCreatesuccessschema](src/SlackWebApi/Models/ConversationsCreatesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsHistorysuccessschema&gt; ConversationsHistory(ConversationsHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsHistory(new ConversationsHistoryRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsHistorysuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsHistoryRequest](src/SlackWebApi/Requests/Conversations/ConversationsHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsHistorysuccessschema](src/SlackWebApi/Models/ConversationsHistorysuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsInfosuccessschema&gt; ConversationsInfo(ConversationsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsInfo(new ConversationsInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsInfosuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsInfoRequest](src/SlackWebApi/Requests/Conversations/ConversationsInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsInfosuccessschema](src/SlackWebApi/Models/ConversationsInfosuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsInviteerrorschema&gt; ConversationsInvite(ConversationsInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsInvite(new ConversationsInviteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsInviteerrorschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsInviteRequest](src/SlackWebApi/Requests/Conversations/ConversationsInviteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsInviteerrorschema](src/SlackWebApi/Models/ConversationsInviteerrorschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsJoinsuccessschema&gt; ConversationsJoin(ConversationsJoinRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsJoin(new ConversationsJoinRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsJoinsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsJoinRequest](src/SlackWebApi/Requests/Conversations/ConversationsJoinRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsJoinsuccessschema](src/SlackWebApi/Models/ConversationsJoinsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsKicksuccessschema&gt; ConversationsKick(ConversationsKickRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsKick(new ConversationsKickRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsKicksuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsKickRequest](src/SlackWebApi/Requests/Conversations/ConversationsKickRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsKicksuccessschema](src/SlackWebApi/Models/ConversationsKicksuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsLeavesuccessschema&gt; ConversationsLeave(ConversationsLeaveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsLeave(new ConversationsLeaveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsLeavesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsLeaveRequest](src/SlackWebApi/Requests/Conversations/ConversationsLeaveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsLeavesuccessschema](src/SlackWebApi/Models/ConversationsLeavesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsListsuccessschema&gt; ConversationsList(ConversationsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsList(new ConversationsListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsListsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsListRequest](src/SlackWebApi/Requests/Conversations/ConversationsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsListsuccessschema](src/SlackWebApi/Models/ConversationsListsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsMarksuccessschema&gt; ConversationsMark(ConversationsMarkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsMark(new ConversationsMarkRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsMarksuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsMarkRequest](src/SlackWebApi/Requests/Conversations/ConversationsMarkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsMarksuccessschema](src/SlackWebApi/Models/ConversationsMarksuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsMemberssuccessschema&gt; ConversationsMembers(ConversationsMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsMembers(new ConversationsMembersRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsMemberssuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsMembersRequest](src/SlackWebApi/Requests/Conversations/ConversationsMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsMemberssuccessschema](src/SlackWebApi/Models/ConversationsMemberssuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsOpensuccessschema&gt; ConversationsOpen(ConversationsOpenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsOpen(new ConversationsOpenRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsOpensuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsOpenRequest](src/SlackWebApi/Requests/Conversations/ConversationsOpenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsOpensuccessschema](src/SlackWebApi/Models/ConversationsOpensuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsRenamesuccessschema&gt; ConversationsRename(ConversationsRenameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsRename(new ConversationsRenameRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsRenamesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsRenameRequest](src/SlackWebApi/Requests/Conversations/ConversationsRenameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsRenamesuccessschema](src/SlackWebApi/Models/ConversationsRenamesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsRepliessuccessschema&gt; ConversationsReplies(ConversationsRepliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsReplies(new ConversationsRepliesRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsRepliessuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsRepliesRequest](src/SlackWebApi/Requests/Conversations/ConversationsRepliesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsRepliessuccessschema](src/SlackWebApi/Models/ConversationsRepliessuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsSetPurposesuccessschema&gt; ConversationsSetPurpose(ConversationsSetPurposeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsSetPurpose(new ConversationsSetPurposeRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsSetPurposesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsSetPurposeRequest](src/SlackWebApi/Requests/Conversations/ConversationsSetPurposeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsSetPurposesuccessschema](src/SlackWebApi/Models/ConversationsSetPurposesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsSetTopicsuccessschema&gt; ConversationsSetTopic(ConversationsSetTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsSetTopic(new ConversationsSetTopicRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsSetTopicsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsSetTopicRequest](src/SlackWebApi/Requests/Conversations/ConversationsSetTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsSetTopicsuccessschema](src/SlackWebApi/Models/ConversationsSetTopicsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConversationsUnarchivesuccessschema&gt; ConversationsUnarchive(ConversationsUnarchiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Conversations.ConversationsUnarchive(new ConversationsUnarchiveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ConversationsUnarchivesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConversationsUnarchiveRequest](src/SlackWebApi/Requests/Conversations/ConversationsUnarchiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConversationsUnarchivesuccessschema](src/SlackWebApi/Models/ConversationsUnarchivesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Dialog

> Source: [Dialog](src/SlackWebApi/Api/Dialog.cs)

<details>
<summary><code>Task&lt;DialogOpenschema&gt; DialogOpen(DialogOpenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Dialog.DialogOpen(new DialogOpenRequest
    {
        Dialog = "some example string",
        TriggerId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type DialogOpenschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DialogOpenRequest](src/SlackWebApi/Requests/Dialog/DialogOpenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DialogOpenschema](src/SlackWebApi/Models/DialogOpenschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Dnd

> Source: [Dnd](src/SlackWebApi/Api/Dnd.cs)

<details>
<summary><code>Task&lt;DndEndDndschema&gt; DndEndDnd(DndEndDndRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Dnd.DndEndDnd(new DndEndDndRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type DndEndDndschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DndEndDndRequest](src/SlackWebApi/Requests/Dnd/DndEndDndRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndEndDndschema](src/SlackWebApi/Models/DndEndDndschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndEndSnoozeschema&gt; DndEndSnooze(DndEndSnoozeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Dnd.DndEndSnooze(new DndEndSnoozeRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type DndEndSnoozeschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DndEndSnoozeRequest](src/SlackWebApi/Requests/Dnd/DndEndSnoozeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndEndSnoozeschema](src/SlackWebApi/Models/DndEndSnoozeschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndInfoschema&gt; DndInfo(DndInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Dnd.DndInfo(new DndInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type DndInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DndInfoRequest](src/SlackWebApi/Requests/Dnd/DndInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndInfoschema](src/SlackWebApi/Models/DndInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DndSetSnoozeschema&gt; DndSetSnooze(DndSetSnoozeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Dnd.DndSetSnooze(new DndSetSnoozeRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
        NumMinutes = "some example string",
    });
    // TODO: Handle 'response' of type DndSetSnoozeschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DndSetSnoozeRequest](src/SlackWebApi/Requests/Dnd/DndSetSnoozeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DndSetSnoozeschema](src/SlackWebApi/Models/DndSetSnoozeschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; DndTeamInfo(DndTeamInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Dnd.DndTeamInfo(new DndTeamInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DndTeamInfoRequest](src/SlackWebApi/Requests/Dnd/DndTeamInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Emoji

> Source: [Emoji](src/SlackWebApi/Api/Emoji.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; EmojiList(EmojiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Emoji.EmojiList(new EmojiListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmojiListRequest](src/SlackWebApi/Requests/Emoji/EmojiListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Files

> Source: [Files](src/SlackWebApi/Api/Files.cs)

<details>
<summary><code>Task&lt;FilesCommentsDeleteschema&gt; FilesCommentsDelete(FilesCommentsDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesCommentsDelete(new FilesCommentsDeleteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesCommentsDeleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesCommentsDeleteRequest](src/SlackWebApi/Requests/FilesComments/FilesCommentsDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesCommentsDeleteschema](src/SlackWebApi/Models/FilesCommentsDeleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesDeleteschema&gt; FilesDelete(FilesDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesDelete(new FilesDeleteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesDeleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesDeleteRequest](src/SlackWebApi/Requests/Files/FilesDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesDeleteschema](src/SlackWebApi/Models/FilesDeleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesInfoschema&gt; FilesInfo(FilesInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesInfo(new FilesInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesInfoRequest](src/SlackWebApi/Requests/Files/FilesInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesInfoschema](src/SlackWebApi/Models/FilesInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesListschema&gt; FilesList(FilesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesList(new FilesListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesListRequest](src/SlackWebApi/Requests/Files/FilesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesListschema](src/SlackWebApi/Models/FilesListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteAdd(FilesRemoteAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRemoteAdd(new FilesRemoteAddRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteAddRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteInfo(FilesRemoteInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRemoteInfo(new FilesRemoteInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteInfoRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteList(FilesRemoteListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRemoteList(new FilesRemoteListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteListRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteRemove(FilesRemoteRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRemoteRemove(new FilesRemoteRemoveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteRemoveRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteShare(FilesRemoteShareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRemoteShare(new FilesRemoteShareRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteShareRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteShareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteUpdate(FilesRemoteUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRemoteUpdate(new FilesRemoteUpdateRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteUpdateRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesRevokePublicUrLschema&gt; FilesRevokePublicUrl(FilesRevokePublicUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesRevokePublicUrl(new FilesRevokePublicUrlRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesRevokePublicUrLschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRevokePublicUrlRequest](src/SlackWebApi/Requests/Files/FilesRevokePublicUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesRevokePublicUrLschema](src/SlackWebApi/Models/FilesRevokePublicUrLschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesSharedPublicUrLschema&gt; FilesSharedPublicUrl(FilesSharedPublicUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesSharedPublicUrl(new FilesSharedPublicUrlRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesSharedPublicUrLschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesSharedPublicUrlRequest](src/SlackWebApi/Requests/Files/FilesSharedPublicUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesSharedPublicUrLschema](src/SlackWebApi/Models/FilesSharedPublicUrLschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FilesUploadschema&gt; FilesUpload(FilesUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Files.FilesUpload(new FilesUploadRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesUploadschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesUploadRequest](src/SlackWebApi/Requests/Files/FilesUploadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesUploadschema](src/SlackWebApi/Models/FilesUploadschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FilesComments

> Source: [FilesComments](src/SlackWebApi/Api/FilesComments.cs)

<details>
<summary><code>Task&lt;FilesCommentsDeleteschema&gt; FilesCommentsDelete(FilesCommentsDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesComments.FilesCommentsDelete(new FilesCommentsDeleteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type FilesCommentsDeleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesCommentsDeleteRequest](src/SlackWebApi/Requests/FilesComments/FilesCommentsDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FilesCommentsDeleteschema](src/SlackWebApi/Models/FilesCommentsDeleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FilesRemote

> Source: [FilesRemote](src/SlackWebApi/Api/FilesRemote.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteAdd(FilesRemoteAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesRemote.FilesRemoteAdd(new FilesRemoteAddRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteAddRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteInfo(FilesRemoteInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesRemote.FilesRemoteInfo(new FilesRemoteInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteInfoRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteList(FilesRemoteListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesRemote.FilesRemoteList(new FilesRemoteListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteListRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteRemove(FilesRemoteRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesRemote.FilesRemoteRemove(new FilesRemoteRemoveRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteRemoveRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteShare(FilesRemoteShareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesRemote.FilesRemoteShare(new FilesRemoteShareRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteShareRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteShareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; FilesRemoteUpdate(FilesRemoteUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.FilesRemote.FilesRemoteUpdate(new FilesRemoteUpdateRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FilesRemoteUpdateRequest](src/SlackWebApi/Requests/FilesRemote/FilesRemoteUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Migration

> Source: [Migration](src/SlackWebApi/Api/Migration.cs)

<details>
<summary><code>Task&lt;MigrationExchangesuccessschema&gt; MigrationExchange(MigrationExchangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Migration.MigrationExchange(new MigrationExchangeRequest
    {
        Token = "some example string",
        Users = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type MigrationExchangesuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MigrationExchangeRequest](src/SlackWebApi/Requests/Migration/MigrationExchangeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MigrationExchangesuccessschema](src/SlackWebApi/Models/MigrationExchangesuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Oauth

> Source: [Oauth](src/SlackWebApi/Api/Oauth.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthAccess(OauthAccessRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Oauth.OauthAccess(new OauthAccessRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthAccessRequest](src/SlackWebApi/Requests/Oauth/OauthAccessRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthToken(OauthTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Oauth.OauthToken(new OauthTokenRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthTokenRequest](src/SlackWebApi/Requests/Oauth/OauthTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthV2Access(OauthV2AccessRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Oauth.OauthV2Access(new OauthV2AccessRequest
    {
        Code = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthV2AccessRequest](src/SlackWebApi/Requests/OauthV2/OauthV2AccessRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OauthV2

> Source: [OauthV2](src/SlackWebApi/Api/OauthV2.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; OauthV2Access(OauthV2AccessRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.OauthV2.OauthV2Access(new OauthV2AccessRequest
    {
        Code = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthV2AccessRequest](src/SlackWebApi/Requests/OauthV2/OauthV2AccessRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pins

> Source: [Pins](src/SlackWebApi/Api/Pins.cs)

<details>
<summary><code>Task&lt;PinsAddschema&gt; PinsAdd(PinsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Pins.PinsAdd(new PinsAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
    });
    // TODO: Handle 'response' of type PinsAddschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PinsAddRequest](src/SlackWebApi/Requests/Pins/PinsAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinsAddschema](src/SlackWebApi/Models/PinsAddschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; PinsList(PinsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Pins.PinsList(new PinsListRequest
    {
        Token = "some example string",
        Channel = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PinsListRequest](src/SlackWebApi/Requests/Pins/PinsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinsRemoveschema&gt; PinsRemove(PinsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Pins.PinsRemove(new PinsRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
    });
    // TODO: Handle 'response' of type PinsRemoveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PinsRemoveRequest](src/SlackWebApi/Requests/Pins/PinsRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinsRemoveschema](src/SlackWebApi/Models/PinsRemoveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reactions

> Source: [Reactions](src/SlackWebApi/Api/Reactions.cs)

<details>
<summary><code>Task&lt;ReactionsAddschema&gt; ReactionsAdd(ReactionsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reactions.ReactionsAdd(new ReactionsAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Channel = "some example string",
        Name = "some example string",
        Timestamp = "some example string",
    });
    // TODO: Handle 'response' of type ReactionsAddschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReactionsAddRequest](src/SlackWebApi/Requests/Reactions/ReactionsAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsAddschema](src/SlackWebApi/Models/ReactionsAddschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; ReactionsGet(ReactionsGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reactions.ReactionsGet(new ReactionsGetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReactionsGetRequest](src/SlackWebApi/Requests/Reactions/ReactionsGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsListschema&gt; ReactionsList(ReactionsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reactions.ReactionsList(new ReactionsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ReactionsListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReactionsListRequest](src/SlackWebApi/Requests/Reactions/ReactionsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsListschema](src/SlackWebApi/Models/ReactionsListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReactionsRemoveschema&gt; ReactionsRemove(ReactionsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reactions.ReactionsRemove(new ReactionsRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Name = "some example string",
    });
    // TODO: Handle 'response' of type ReactionsRemoveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReactionsRemoveRequest](src/SlackWebApi/Requests/Reactions/ReactionsRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReactionsRemoveschema](src/SlackWebApi/Models/ReactionsRemoveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reminders

> Source: [Reminders](src/SlackWebApi/Api/Reminders.cs)

<details>
<summary><code>Task&lt;RemindersAddschema&gt; RemindersAdd(RemindersAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reminders.RemindersAdd(new RemindersAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Text = "some example string",
        Time = "some example string",
    });
    // TODO: Handle 'response' of type RemindersAddschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemindersAddRequest](src/SlackWebApi/Requests/Reminders/RemindersAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersAddschema](src/SlackWebApi/Models/RemindersAddschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersCompleteschema&gt; RemindersComplete(RemindersCompleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reminders.RemindersComplete(new RemindersCompleteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type RemindersCompleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemindersCompleteRequest](src/SlackWebApi/Requests/Reminders/RemindersCompleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersCompleteschema](src/SlackWebApi/Models/RemindersCompleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersDeleteschema&gt; RemindersDelete(RemindersDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reminders.RemindersDelete(new RemindersDeleteRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type RemindersDeleteschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemindersDeleteRequest](src/SlackWebApi/Requests/Reminders/RemindersDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersDeleteschema](src/SlackWebApi/Models/RemindersDeleteschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersInfoschema&gt; RemindersInfo(RemindersInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reminders.RemindersInfo(new RemindersInfoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type RemindersInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemindersInfoRequest](src/SlackWebApi/Requests/Reminders/RemindersInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersInfoschema](src/SlackWebApi/Models/RemindersInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemindersListschema&gt; RemindersList(RemindersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Reminders.RemindersList(new RemindersListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type RemindersListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemindersListRequest](src/SlackWebApi/Requests/Reminders/RemindersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemindersListschema](src/SlackWebApi/Models/RemindersListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rtm

> Source: [Rtm](src/SlackWebApi/Api/Rtm.cs)

<details>
<summary><code>Task&lt;RtmConnectschema&gt; RtmConnect(RtmConnectRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Rtm.RtmConnect(new RtmConnectRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type RtmConnectschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RtmConnectRequest](src/SlackWebApi/Requests/Rtm/RtmConnectRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RtmConnectschema](src/SlackWebApi/Models/RtmConnectschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Search

> Source: [Search](src/SlackWebApi/Api/Search.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; SearchMessages(SearchMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Search.SearchMessages(new SearchMessagesRequest
    {
        Token = "some example string",
        Query = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchMessagesRequest](src/SlackWebApi/Requests/Search/SearchMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Stars

> Source: [Stars](src/SlackWebApi/Api/Stars.cs)

<details>
<summary><code>Task&lt;StarsAddschema&gt; StarsAdd(StarsAddRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Stars.StarsAdd(new StarsAddRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type StarsAddschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StarsAddRequest](src/SlackWebApi/Requests/Stars/StarsAddRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsAddschema](src/SlackWebApi/Models/StarsAddschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsListschema&gt; StarsList(StarsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Stars.StarsList(new StarsListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type StarsListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StarsListRequest](src/SlackWebApi/Requests/Stars/StarsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsListschema](src/SlackWebApi/Models/StarsListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StarsRemoveschema&gt; StarsRemove(StarsRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Stars.StarsRemove(new StarsRemoveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type StarsRemoveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StarsRemoveRequest](src/SlackWebApi/Requests/Stars/StarsRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StarsRemoveschema](src/SlackWebApi/Models/StarsRemoveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamApi

> Source: [TeamApi](src/SlackWebApi/Api/TeamApi.cs)

<details>
<summary><code>Task&lt;TeamAccessLogsschema&gt; TeamAccessLogs(TeamAccessLogsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TeamApi.TeamAccessLogs(new TeamAccessLogsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type TeamAccessLogsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamAccessLogsRequest](src/SlackWebApi/Requests/TeamApi/TeamAccessLogsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamAccessLogsschema](src/SlackWebApi/Models/TeamAccessLogsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; TeamBillableInfo(TeamBillableInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TeamApi.TeamBillableInfo(new TeamBillableInfoRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamBillableInfoRequest](src/SlackWebApi/Requests/TeamApi/TeamBillableInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamInfoschema&gt; TeamInfo(TeamInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TeamApi.TeamInfo(new TeamInfoRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type TeamInfoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamInfoRequest](src/SlackWebApi/Requests/TeamApi/TeamInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamInfoschema](src/SlackWebApi/Models/TeamInfoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamIntegrationLogsschema&gt; TeamIntegrationLogs(TeamIntegrationLogsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TeamApi.TeamIntegrationLogs(new TeamIntegrationLogsRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type TeamIntegrationLogsschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamIntegrationLogsRequest](src/SlackWebApi/Requests/TeamApi/TeamIntegrationLogsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamIntegrationLogsschema](src/SlackWebApi/Models/TeamIntegrationLogsschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamProfileGetsuccessschema&gt; TeamProfileGet(TeamProfileGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TeamApi.TeamProfileGet(new TeamProfileGetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type TeamProfileGetsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamProfileGetRequest](src/SlackWebApi/Requests/TeamProfile/TeamProfileGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamProfileGetsuccessschema](src/SlackWebApi/Models/TeamProfileGetsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamProfile

> Source: [TeamProfile](src/SlackWebApi/Api/TeamProfile.cs)

<details>
<summary><code>Task&lt;TeamProfileGetsuccessschema&gt; TeamProfileGet(TeamProfileGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.TeamProfile.TeamProfileGet(new TeamProfileGetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type TeamProfileGetsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamProfileGetRequest](src/SlackWebApi/Requests/TeamProfile/TeamProfileGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamProfileGetsuccessschema](src/SlackWebApi/Models/TeamProfileGetsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Usergroups

> Source: [Usergroups](src/SlackWebApi/Api/Usergroups.cs)

<details>
<summary><code>Task&lt;UsergroupsCreateschema&gt; UsergroupsCreate(UsergroupsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsCreate(new UsergroupsCreateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Name = "some example string",
    });
    // TODO: Handle 'response' of type UsergroupsCreateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsCreateRequest](src/SlackWebApi/Requests/Usergroups/UsergroupsCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsCreateschema](src/SlackWebApi/Models/UsergroupsCreateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsDisableschema&gt; UsergroupsDisable(UsergroupsDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsDisable(new UsergroupsDisableRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Usergroup = "some example string",
    });
    // TODO: Handle 'response' of type UsergroupsDisableschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsDisableRequest](src/SlackWebApi/Requests/Usergroups/UsergroupsDisableRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsDisableschema](src/SlackWebApi/Models/UsergroupsDisableschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsEnableschema&gt; UsergroupsEnable(UsergroupsEnableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsEnable(new UsergroupsEnableRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Usergroup = "some example string",
    });
    // TODO: Handle 'response' of type UsergroupsEnableschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsEnableRequest](src/SlackWebApi/Requests/Usergroups/UsergroupsEnableRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsEnableschema](src/SlackWebApi/Models/UsergroupsEnableschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsListschema&gt; UsergroupsList(UsergroupsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsList(new UsergroupsListRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsergroupsListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsListRequest](src/SlackWebApi/Requests/Usergroups/UsergroupsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsListschema](src/SlackWebApi/Models/UsergroupsListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUpdateschema&gt; UsergroupsUpdate(UsergroupsUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsUpdate(new UsergroupsUpdateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Usergroup = "some example string",
    });
    // TODO: Handle 'response' of type UsergroupsUpdateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsUpdateRequest](src/SlackWebApi/Requests/Usergroups/UsergroupsUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUpdateschema](src/SlackWebApi/Models/UsergroupsUpdateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersListschema&gt; UsergroupsUsersList(UsergroupsUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsUsersList(new UsergroupsUsersListRequest
    {
        Token = "some example string",
        Usergroup = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsergroupsUsersListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsUsersListRequest](src/SlackWebApi/Requests/UsergroupsUsers/UsergroupsUsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersListschema](src/SlackWebApi/Models/UsergroupsUsersListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersUpdateschema&gt; UsergroupsUsersUpdate(UsergroupsUsersUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Usergroups.UsergroupsUsersUpdate(new UsergroupsUsersUpdateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Usergroup = "some example string",
        Users = "some example string",
    });
    // TODO: Handle 'response' of type UsergroupsUsersUpdateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsUsersUpdateRequest](src/SlackWebApi/Requests/UsergroupsUsers/UsergroupsUsersUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersUpdateschema](src/SlackWebApi/Models/UsergroupsUsersUpdateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsergroupsUsers

> Source: [UsergroupsUsers](src/SlackWebApi/Api/UsergroupsUsers.cs)

<details>
<summary><code>Task&lt;UsergroupsUsersListschema&gt; UsergroupsUsersList(UsergroupsUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.UsergroupsUsers.UsergroupsUsersList(new UsergroupsUsersListRequest
    {
        Token = "some example string",
        Usergroup = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsergroupsUsersListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsUsersListRequest](src/SlackWebApi/Requests/UsergroupsUsers/UsergroupsUsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersListschema](src/SlackWebApi/Models/UsergroupsUsersListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsergroupsUsersUpdateschema&gt; UsergroupsUsersUpdate(UsergroupsUsersUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.UsergroupsUsers.UsergroupsUsersUpdate(new UsergroupsUsersUpdateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Usergroup = "some example string",
        Users = "some example string",
    });
    // TODO: Handle 'response' of type UsergroupsUsersUpdateschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsergroupsUsersUpdateRequest](src/SlackWebApi/Requests/UsergroupsUsers/UsergroupsUsersUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsergroupsUsersUpdateschema](src/SlackWebApi/Models/UsergroupsUsersUpdateschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Users

> Source: [Users](src/SlackWebApi/Api/Users.cs)

<details>
<summary><code>Task&lt;UsersConversationssuccessschema&gt; UsersConversations(UsersConversationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersConversations(new UsersConversationsRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersConversationssuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersConversationsRequest](src/SlackWebApi/Requests/Users/UsersConversationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersConversationssuccessschema](src/SlackWebApi/Models/UsersConversationssuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersDeletePhotoschema&gt; UsersDeletePhoto(UsersDeletePhotoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersDeletePhoto(new UsersDeletePhotoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
    });
    // TODO: Handle 'response' of type UsersDeletePhotoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersDeletePhotoRequest](src/SlackWebApi/Requests/Users/UsersDeletePhotoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersDeletePhotoschema](src/SlackWebApi/Models/UsersDeletePhotoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApImethodusersGetPresence&gt; UsersGetPresence(UsersGetPresenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersGetPresence(new UsersGetPresenceRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type ApImethodusersGetPresence
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersGetPresenceRequest](src/SlackWebApi/Requests/Users/UsersGetPresenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApImethodusersGetPresence](src/SlackWebApi/Models/ApImethodusersGetPresence.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; UsersIdentity(UsersIdentityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersIdentity(new UsersIdentityRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersIdentityRequest](src/SlackWebApi/Requests/Users/UsersIdentityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersInfosuccessschema&gt; UsersInfo(UsersInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersInfo(new UsersInfoRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersInfosuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersInfoRequest](src/SlackWebApi/Requests/Users/UsersInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersInfosuccessschema](src/SlackWebApi/Models/UsersInfosuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersListschema&gt; UsersList(UsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersList(new UsersListRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersListschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersListRequest](src/SlackWebApi/Requests/Users/UsersListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersListschema](src/SlackWebApi/Models/UsersListschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersLookupByEmailsuccessschema&gt; UsersLookupByEmail(UsersLookupByEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersLookupByEmail(new UsersLookupByEmailRequest
    {
        Token = "some example string",
        Email = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersLookupByEmailsuccessschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersLookupByEmailRequest](src/SlackWebApi/Requests/Users/UsersLookupByEmailRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersLookupByEmailsuccessschema](src/SlackWebApi/Models/UsersLookupByEmailsuccessschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileGetschema&gt; UsersProfileGet(UsersProfileGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersProfileGet(new UsersProfileGetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersProfileGetschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersProfileGetRequest](src/SlackWebApi/Requests/UsersProfile/UsersProfileGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileGetschema](src/SlackWebApi/Models/UsersProfileGetschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileSetschema&gt; UsersProfileSet(UsersProfileSetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersProfileSet(new UsersProfileSetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersProfileSetschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersProfileSetRequest](src/SlackWebApi/Requests/UsersProfile/UsersProfileSetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileSetschema](src/SlackWebApi/Models/UsersProfileSetschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetActiveschema&gt; UsersSetActive(UsersSetActiveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersSetActive(new UsersSetActiveRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersSetActiveschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersSetActiveRequest](src/SlackWebApi/Requests/Users/UsersSetActiveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetActiveschema](src/SlackWebApi/Models/UsersSetActiveschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetPhotoschema&gt; UsersSetPhoto(UsersSetPhotoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersSetPhoto(new UsersSetPhotoRequest
    {
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Token = "some example string",
    });
    // TODO: Handle 'response' of type UsersSetPhotoschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersSetPhotoRequest](src/SlackWebApi/Requests/Users/UsersSetPhotoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetPhotoschema](src/SlackWebApi/Models/UsersSetPhotoschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersSetPresenceschema&gt; UsersSetPresence(UsersSetPresenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Users.UsersSetPresence(new UsersSetPresenceRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
        Presence = "some example string",
    });
    // TODO: Handle 'response' of type UsersSetPresenceschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersSetPresenceRequest](src/SlackWebApi/Requests/Users/UsersSetPresenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersSetPresenceschema](src/SlackWebApi/Models/UsersSetPresenceschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersProfile

> Source: [UsersProfile](src/SlackWebApi/Api/UsersProfile.cs)

<details>
<summary><code>Task&lt;UsersProfileGetschema&gt; UsersProfileGet(UsersProfileGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.UsersProfile.UsersProfileGet(new UsersProfileGetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersProfileGetschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersProfileGetRequest](src/SlackWebApi/Requests/UsersProfile/UsersProfileGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileGetschema](src/SlackWebApi/Models/UsersProfileGetschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersProfileSetschema&gt; UsersProfileSet(UsersProfileSetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.UsersProfile.UsersProfileSet(new UsersProfileSetRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type UsersProfileSetschema
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsersProfileSetRequest](src/SlackWebApi/Requests/UsersProfile/UsersProfileSetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersProfileSetschema](src/SlackWebApi/Models/UsersProfileSetschema.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Views

> Source: [Views](src/SlackWebApi/Api/Views.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsOpen(ViewsOpenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Views.ViewsOpen(new ViewsOpenRequest
    {
        TriggerId = "some example string",
        View = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ViewsOpenRequest](src/SlackWebApi/Requests/Views/ViewsOpenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsPublish(ViewsPublishRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Views.ViewsPublish(new ViewsPublishRequest
    {
        UserId = "some example string",
        View = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ViewsPublishRequest](src/SlackWebApi/Requests/Views/ViewsPublishRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsPush(ViewsPushRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Views.ViewsPush(new ViewsPushRequest
    {
        TriggerId = "some example string",
        View = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ViewsPushRequest](src/SlackWebApi/Requests/Views/ViewsPushRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; ViewsUpdate(ViewsUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Views.ViewsUpdate(new ViewsUpdateRequest
    {
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ViewsUpdateRequest](src/SlackWebApi/Requests/Views/ViewsUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Workflows

> Source: [Workflows](src/SlackWebApi/Api/Workflows.cs)

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; WorkflowsStepCompleted(WorkflowsStepCompletedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Workflows.WorkflowsStepCompleted(new WorkflowsStepCompletedRequest
    {
        WorkflowStepExecuteId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WorkflowsStepCompletedRequest](src/SlackWebApi/Requests/Workflows/WorkflowsStepCompletedRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; WorkflowsStepFailed(WorkflowsStepFailedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Workflows.WorkflowsStepFailed(new WorkflowsStepFailedRequest
    {
        WorkflowStepExecuteId = "some example string",
        Error = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WorkflowsStepFailedRequest](src/SlackWebApi/Requests/Workflows/WorkflowsStepFailedRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Defaultsuccesstemplate&gt; WorkflowsUpdateStep(WorkflowsUpdateStepRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.Workflows.WorkflowsUpdateStep(new WorkflowsUpdateStepRequest
    {
        WorkflowStepEditId = "some example string",
        Token = "some example string",
        ContentType = ContentType.ApplicationXWwwFormUrlencoded,
    });
    // TODO: Handle 'response' of type Defaultsuccesstemplate
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WorkflowsUpdateStepRequest](src/SlackWebApi/Requests/Workflows/WorkflowsUpdateStepRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Defaultsuccesstemplate](src/SlackWebApi/Models/Defaultsuccesstemplate.cs)</code>

**OnError**: <code>[ApiException](src/SlackWebApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/SlackWebApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

