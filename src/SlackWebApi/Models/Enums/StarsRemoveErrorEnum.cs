using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<StarsRemoveErrorEnum>))]
public sealed record StarsRemoveErrorEnum : OpenStringEnum<StarsRemoveErrorEnum>
{
    private StarsRemoveErrorEnum(string value) : base(value)
    {
    }

    public static readonly StarsRemoveErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly StarsRemoveErrorEnum MessageNotFound = new("message_not_found");

    public static readonly StarsRemoveErrorEnum FileNotFound = new("file_not_found");

    public static readonly StarsRemoveErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly StarsRemoveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly StarsRemoveErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly StarsRemoveErrorEnum NotStarred = new("not_starred");

    public static readonly StarsRemoveErrorEnum NotAuthed = new("not_authed");

    public static readonly StarsRemoveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly StarsRemoveErrorEnum AccountInactive = new("account_inactive");

    public static readonly StarsRemoveErrorEnum TokenRevoked = new("token_revoked");

    public static readonly StarsRemoveErrorEnum NoPermission = new("no_permission");

    public static readonly StarsRemoveErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly StarsRemoveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly StarsRemoveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly StarsRemoveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly StarsRemoveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly StarsRemoveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly StarsRemoveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly StarsRemoveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly StarsRemoveErrorEnum InvalidJson = new("invalid_json");

    public static readonly StarsRemoveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly StarsRemoveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly StarsRemoveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly StarsRemoveErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onBadTimestamp,
        Func<TResult> onMessageNotFound,
        Func<TResult> onFileNotFound,
        Func<TResult> onFileCommentNotFound,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNoItemSpecified,
        Func<TResult> onNotStarred,
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
            _ when this == BadTimestamp => onBadTimestamp(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == FileNotFound => onFileNotFound(),
            _ when this == FileCommentNotFound => onFileCommentNotFound(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NoItemSpecified => onNoItemSpecified(),
            _ when this == NotStarred => onNotStarred(),
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

    public void Match(Action onBadTimestamp,
        Action onMessageNotFound,
        Action onFileNotFound,
        Action onFileCommentNotFound,
        Action onChannelNotFound,
        Action onNoItemSpecified,
        Action onNotStarred,
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
        if (this == BadTimestamp) onBadTimestamp();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == FileNotFound) onFileNotFound();
        else if (this == FileCommentNotFound) onFileCommentNotFound();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NoItemSpecified) onNoItemSpecified();
        else if (this == NotStarred) onNotStarred();
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
