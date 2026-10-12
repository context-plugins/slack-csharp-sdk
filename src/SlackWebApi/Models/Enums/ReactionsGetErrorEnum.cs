using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsGetErrorEnum>))]
public sealed record ReactionsGetErrorEnum : OpenStringEnum<ReactionsGetErrorEnum>
{
    private ReactionsGetErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsGetErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly ReactionsGetErrorEnum FileNotFound = new("file_not_found");

    public static readonly ReactionsGetErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly ReactionsGetErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ReactionsGetErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly ReactionsGetErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsGetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsGetErrorEnum AccountInactive = new("account_inactive");

    public static readonly ReactionsGetErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsGetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsGetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsGetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsGetErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsGetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsGetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsGetErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsGetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsGetErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsGetErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onBadTimestamp,
        Func<TResult> onFileNotFound,
        Func<TResult> onFileCommentNotFound,
        Func<TResult> onMessageNotFound,
        Func<TResult> onNoItemSpecified,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onNoPermission,
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
            _ when this == FileNotFound => onFileNotFound(),
            _ when this == FileCommentNotFound => onFileCommentNotFound(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == NoItemSpecified => onNoItemSpecified(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == NoPermission => onNoPermission(),
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
        Action onFileNotFound,
        Action onFileCommentNotFound,
        Action onMessageNotFound,
        Action onNoItemSpecified,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onNoPermission,
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
        else if (this == FileNotFound) onFileNotFound();
        else if (this == FileCommentNotFound) onFileCommentNotFound();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == NoItemSpecified) onNoItemSpecified();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == NoPermission) onNoPermission();
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
