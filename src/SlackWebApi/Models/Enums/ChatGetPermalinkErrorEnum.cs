using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatGetPermalinkErrorEnum>))]
public sealed record ChatGetPermalinkErrorEnum : OpenStringEnum<ChatGetPermalinkErrorEnum>
{
    private ChatGetPermalinkErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatGetPermalinkErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatGetPermalinkErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ChatGetPermalinkErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatGetPermalinkErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatGetPermalinkErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatGetPermalinkErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatGetPermalinkErrorEnum NoPermission = new("no_permission");

    public static readonly ChatGetPermalinkErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatGetPermalinkErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatGetPermalinkErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatGetPermalinkErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatGetPermalinkErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatGetPermalinkErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatGetPermalinkErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatGetPermalinkErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatGetPermalinkErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatGetPermalinkErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatGetPermalinkErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatGetPermalinkErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatGetPermalinkErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onChannelNotFound,
        Func<TResult> onMessageNotFound,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
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
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
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

    public void Match(Action onChannelNotFound,
        Action onMessageNotFound,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
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
        if (this == ChannelNotFound) onChannelNotFound();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
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
