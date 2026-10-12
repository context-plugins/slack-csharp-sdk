using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatDeleteErrorEnum>))]
public sealed record ChatDeleteErrorEnum : OpenStringEnum<ChatDeleteErrorEnum>
{
    private ChatDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatDeleteErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ChatDeleteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatDeleteErrorEnum CantDeleteMessage = new("cant_delete_message");

    public static readonly ChatDeleteErrorEnum ComplianceExportsPreventDeletion = new(
        "compliance_exports_prevent_deletion");

    public static readonly ChatDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatDeleteErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly ChatDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatDeleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatDeleteErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onMessageNotFound,
        Func<TResult> onChannelNotFound,
        Func<TResult> onCantDeleteMessage,
        Func<TResult> onComplianceExportsPreventDeletion,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
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
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == CantDeleteMessage => onCantDeleteMessage(),
            _ when this == ComplianceExportsPreventDeletion => onComplianceExportsPreventDeletion(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
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

    public void Match(Action onMessageNotFound,
        Action onChannelNotFound,
        Action onCantDeleteMessage,
        Action onComplianceExportsPreventDeletion,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
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
        if (this == MessageNotFound) onMessageNotFound();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == CantDeleteMessage) onCantDeleteMessage();
        else if (this == ComplianceExportsPreventDeletion) onComplianceExportsPreventDeletion();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
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
