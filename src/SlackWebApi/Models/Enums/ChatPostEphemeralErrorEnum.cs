using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatPostEphemeralErrorEnum>))]
public sealed record ChatPostEphemeralErrorEnum : OpenStringEnum<ChatPostEphemeralErrorEnum>
{
    private ChatPostEphemeralErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatPostEphemeralErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatPostEphemeralErrorEnum IsArchived = new("is_archived");

    public static readonly ChatPostEphemeralErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatPostEphemeralErrorEnum NoText = new("no_text");

    public static readonly ChatPostEphemeralErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ChatPostEphemeralErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatPostEphemeralErrorEnum UserNotInChannel = new("user_not_in_channel");

    public static readonly ChatPostEphemeralErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatPostEphemeralErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatPostEphemeralErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatPostEphemeralErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatPostEphemeralErrorEnum NoPermission = new("no_permission");

    public static readonly ChatPostEphemeralErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatPostEphemeralErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatPostEphemeralErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatPostEphemeralErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatPostEphemeralErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatPostEphemeralErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatPostEphemeralErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatPostEphemeralErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatPostEphemeralErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatPostEphemeralErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatPostEphemeralErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatPostEphemeralErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatPostEphemeralErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onChannelNotFound,
        Func<TResult> onIsArchived,
        Func<TResult> onMsgTooLong,
        Func<TResult> onNoText,
        Func<TResult> onRestrictedAction,
        Func<TResult> onTooManyAttachments,
        Func<TResult> onUserNotInChannel,
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
            _ when this == IsArchived => onIsArchived(),
            _ when this == MsgTooLong => onMsgTooLong(),
            _ when this == NoText => onNoText(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == TooManyAttachments => onTooManyAttachments(),
            _ when this == UserNotInChannel => onUserNotInChannel(),
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
        Action onIsArchived,
        Action onMsgTooLong,
        Action onNoText,
        Action onRestrictedAction,
        Action onTooManyAttachments,
        Action onUserNotInChannel,
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
        else if (this == IsArchived) onIsArchived();
        else if (this == MsgTooLong) onMsgTooLong();
        else if (this == NoText) onNoText();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == TooManyAttachments) onTooManyAttachments();
        else if (this == UserNotInChannel) onUserNotInChannel();
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
