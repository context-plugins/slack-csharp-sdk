using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsAddErrorEnum>))]
public sealed record ReactionsAddErrorEnum : OpenStringEnum<ReactionsAddErrorEnum>
{
    private ReactionsAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsAddErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly ReactionsAddErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ReactionsAddErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly ReactionsAddErrorEnum InvalidName = new("invalid_name");

    public static readonly ReactionsAddErrorEnum AlreadyReacted = new("already_reacted");

    public static readonly ReactionsAddErrorEnum TooManyEmoji = new("too_many_emoji");

    public static readonly ReactionsAddErrorEnum TooManyReactions = new("too_many_reactions");

    public static readonly ReactionsAddErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly ReactionsAddErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ReactionsAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsAddErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onBadTimestamp,
        Func<TResult> onMessageNotFound,
        Func<TResult> onNoItemSpecified,
        Func<TResult> onInvalidName,
        Func<TResult> onAlreadyReacted,
        Func<TResult> onTooManyEmoji,
        Func<TResult> onTooManyReactions,
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
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BadTimestamp => onBadTimestamp(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == NoItemSpecified => onNoItemSpecified(),
            _ when this == InvalidName => onInvalidName(),
            _ when this == AlreadyReacted => onAlreadyReacted(),
            _ when this == TooManyEmoji => onTooManyEmoji(),
            _ when this == TooManyReactions => onTooManyReactions(),
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
            _ => otherwise(Value)
        };

    public void Match(Action onBadTimestamp,
        Action onMessageNotFound,
        Action onNoItemSpecified,
        Action onInvalidName,
        Action onAlreadyReacted,
        Action onTooManyEmoji,
        Action onTooManyReactions,
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
        Action<string> otherwise)
    {
        if (this == BadTimestamp) onBadTimestamp();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == NoItemSpecified) onNoItemSpecified();
        else if (this == InvalidName) onInvalidName();
        else if (this == AlreadyReacted) onAlreadyReacted();
        else if (this == TooManyEmoji) onTooManyEmoji();
        else if (this == TooManyReactions) onTooManyReactions();
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
        else otherwise(Value);
    }
}
