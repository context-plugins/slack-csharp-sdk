using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsRemoveErrorEnum>))]
public sealed record ReactionsRemoveErrorEnum : OpenStringEnum<ReactionsRemoveErrorEnum>
{
    private ReactionsRemoveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsRemoveErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly ReactionsRemoveErrorEnum FileNotFound = new("file_not_found");

    public static readonly ReactionsRemoveErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly ReactionsRemoveErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ReactionsRemoveErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly ReactionsRemoveErrorEnum InvalidName = new("invalid_name");

    public static readonly ReactionsRemoveErrorEnum NoReaction = new("no_reaction");

    public static readonly ReactionsRemoveErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsRemoveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsRemoveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ReactionsRemoveErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsRemoveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ReactionsRemoveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsRemoveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsRemoveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsRemoveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsRemoveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsRemoveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsRemoveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsRemoveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsRemoveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsRemoveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ReactionsRemoveErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onBadTimestamp,
        Func<TResult> onFileNotFound,
        Func<TResult> onFileCommentNotFound,
        Func<TResult> onMessageNotFound,
        Func<TResult> onNoItemSpecified,
        Func<TResult> onInvalidName,
        Func<TResult> onNoReaction,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
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
            _ when this == BadTimestamp => onBadTimestamp(),
            _ when this == FileNotFound => onFileNotFound(),
            _ when this == FileCommentNotFound => onFileCommentNotFound(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == NoItemSpecified => onNoItemSpecified(),
            _ when this == InvalidName => onInvalidName(),
            _ when this == NoReaction => onNoReaction(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
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

    public void Match(Action onBadTimestamp,
        Action onFileNotFound,
        Action onFileCommentNotFound,
        Action onMessageNotFound,
        Action onNoItemSpecified,
        Action onInvalidName,
        Action onNoReaction,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
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
        if (this == BadTimestamp) onBadTimestamp();
        else if (this == FileNotFound) onFileNotFound();
        else if (this == FileCommentNotFound) onFileCommentNotFound();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == NoItemSpecified) onNoItemSpecified();
        else if (this == InvalidName) onInvalidName();
        else if (this == NoReaction) onNoReaction();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
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
