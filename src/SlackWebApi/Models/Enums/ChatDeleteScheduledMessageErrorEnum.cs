using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatDeleteScheduledMessageErrorEnum>))]
public sealed record ChatDeleteScheduledMessageErrorEnum : OpenStringEnum<ChatDeleteScheduledMessageErrorEnum>
{
    private ChatDeleteScheduledMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidScheduledMessageId = new(
        "invalid_scheduled_message_id");

    public static readonly ChatDeleteScheduledMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatDeleteScheduledMessageErrorEnum BadToken = new("bad_token");

    public static readonly ChatDeleteScheduledMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatDeleteScheduledMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatDeleteScheduledMessageErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatDeleteScheduledMessageErrorEnum NoPermission = new("no_permission");

    public static readonly ChatDeleteScheduledMessageErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatDeleteScheduledMessageErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly ChatDeleteScheduledMessageErrorEnum MissingScope = new("missing_scope");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatDeleteScheduledMessageErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatDeleteScheduledMessageErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatDeleteScheduledMessageErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatDeleteScheduledMessageErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatDeleteScheduledMessageErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatDeleteScheduledMessageErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onInvalidScheduledMessageId,
        Func<TResult> onChannelNotFound,
        Func<TResult> onBadToken,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
        Func<TResult> onEkmAccessDenied,
        Func<TResult> onMissingScope,
        Func<TResult> onInvalidArguments,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeout,
        Func<TResult> onUpgradeRequired,
        Func<TResult> onFatalError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvalidScheduledMessageId => onInvalidScheduledMessageId(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == BadToken => onBadToken(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
            _ when this == EkmAccessDenied => onEkmAccessDenied(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == InvalidArguments => onInvalidArguments(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ when this == FatalError => onFatalError(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalidScheduledMessageId,
        Action onChannelNotFound,
        Action onBadToken,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
        Action onEkmAccessDenied,
        Action onMissingScope,
        Action onInvalidArguments,
        Action onInvalidArgName,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onTeamAddedToOrg,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeout,
        Action onUpgradeRequired,
        Action onFatalError,
        Action<string> otherwise)
    {
        if (this == InvalidScheduledMessageId) onInvalidScheduledMessageId();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == BadToken) onBadToken();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
        else if (this == EkmAccessDenied) onEkmAccessDenied();
        else if (this == MissingScope) onMissingScope();
        else if (this == InvalidArguments) onInvalidArguments();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else if (this == FatalError) onFatalError();
        else otherwise(Value);
    }
}
