using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatScheduledMessagesListErrorEnum>))]
public sealed record ChatScheduledMessagesListErrorEnum : OpenStringEnum<ChatScheduledMessagesListErrorEnum>
{
    private ChatScheduledMessagesListErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatScheduledMessagesListErrorEnum InvalidChannel = new("invalid_channel");

    public static readonly ChatScheduledMessagesListErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatScheduledMessagesListErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatScheduledMessagesListErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatScheduledMessagesListErrorEnum NoPermission = new("no_permission");

    public static readonly ChatScheduledMessagesListErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatScheduledMessagesListErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly ChatScheduledMessagesListErrorEnum MissingScope = new("missing_scope");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatScheduledMessagesListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatScheduledMessagesListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatScheduledMessagesListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatScheduledMessagesListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatScheduledMessagesListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatScheduledMessagesListErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onInvalidChannel,
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
            _ when this == InvalidChannel => onInvalidChannel(),
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

    public void Match(Action onInvalidChannel,
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
        if (this == InvalidChannel) onInvalidChannel();
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
