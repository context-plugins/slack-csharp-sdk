using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatMeMessageErrorEnum>))]
public sealed record ChatMeMessageErrorEnum : OpenStringEnum<ChatMeMessageErrorEnum>
{
    private ChatMeMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatMeMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatMeMessageErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ChatMeMessageErrorEnum IsArchived = new("is_archived");

    public static readonly ChatMeMessageErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatMeMessageErrorEnum NoText = new("no_text");

    public static readonly ChatMeMessageErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatMeMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatMeMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatMeMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatMeMessageErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatMeMessageErrorEnum NoPermission = new("no_permission");

    public static readonly ChatMeMessageErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatMeMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatMeMessageErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatMeMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatMeMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatMeMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatMeMessageErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatMeMessageErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatMeMessageErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatMeMessageErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatMeMessageErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatMeMessageErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatMeMessageErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onChannelNotFound,
        Func<TResult> onNotInChannel,
        Func<TResult> onIsArchived,
        Func<TResult> onMsgTooLong,
        Func<TResult> onNoText,
        Func<TResult> onRateLimited,
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
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == IsArchived => onIsArchived(),
            _ when this == MsgTooLong => onMsgTooLong(),
            _ when this == NoText => onNoText(),
            _ when this == RateLimited => onRateLimited(),
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
        Action onNotInChannel,
        Action onIsArchived,
        Action onMsgTooLong,
        Action onNoText,
        Action onRateLimited,
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
        else if (this == NotInChannel) onNotInChannel();
        else if (this == IsArchived) onIsArchived();
        else if (this == MsgTooLong) onMsgTooLong();
        else if (this == NoText) onNoText();
        else if (this == RateLimited) onRateLimited();
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
