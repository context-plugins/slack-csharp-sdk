using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinsRemoveErrorEnum>))]
public sealed record PinsRemoveErrorEnum : OpenStringEnum<PinsRemoveErrorEnum>
{
    private PinsRemoveErrorEnum(string value) : base(value)
    {
    }

    public static readonly PinsRemoveErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly PinsRemoveErrorEnum FileNotFound = new("file_not_found");

    public static readonly PinsRemoveErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly PinsRemoveErrorEnum MessageNotFound = new("message_not_found");

    public static readonly PinsRemoveErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly PinsRemoveErrorEnum NotPinned = new("not_pinned");

    public static readonly PinsRemoveErrorEnum PermissionDenied = new("permission_denied");

    public static readonly PinsRemoveErrorEnum NotAuthed = new("not_authed");

    public static readonly PinsRemoveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly PinsRemoveErrorEnum AccountInactive = new("account_inactive");

    public static readonly PinsRemoveErrorEnum NoPermission = new("no_permission");

    public static readonly PinsRemoveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly PinsRemoveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly PinsRemoveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly PinsRemoveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly PinsRemoveErrorEnum InvalidPostTyp = new("invalid_post_typ");

    public static readonly PinsRemoveErrorEnum MissingPostTyp = new("missing_post_typ");

    public static readonly PinsRemoveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly PinsRemoveErrorEnum InvalidJson = new("invalid_json");

    public static readonly PinsRemoveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly PinsRemoveErrorEnum RequestTimeou = new("request_timeou");

    public static readonly PinsRemoveErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onBadTimestamp,
        Func<TResult> onFileNotFound,
        Func<TResult> onFileCommentNotFound,
        Func<TResult> onMessageNotFound,
        Func<TResult> onNoItemSpecified,
        Func<TResult> onNotPinned,
        Func<TResult> onPermissionDenied,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onNoPermission,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostTyp,
        Func<TResult> onMissingPostTyp,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeou,
        Func<TResult> onUpgradeRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BadTimestamp => onBadTimestamp(),
            _ when this == FileNotFound => onFileNotFound(),
            _ when this == FileCommentNotFound => onFileCommentNotFound(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == NoItemSpecified => onNoItemSpecified(),
            _ when this == NotPinned => onNotPinned(),
            _ when this == PermissionDenied => onPermissionDenied(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostTyp => onInvalidPostTyp(),
            _ when this == MissingPostTyp => onMissingPostTyp(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeou => onRequestTimeou(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onBadTimestamp,
        Action onFileNotFound,
        Action onFileCommentNotFound,
        Action onMessageNotFound,
        Action onNoItemSpecified,
        Action onNotPinned,
        Action onPermissionDenied,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onNoPermission,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostTyp,
        Action onMissingPostTyp,
        Action onTeamAddedToOrg,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeou,
        Action onUpgradeRequired,
        Action<string> otherwise)
    {
        if (this == BadTimestamp) onBadTimestamp();
        else if (this == FileNotFound) onFileNotFound();
        else if (this == FileCommentNotFound) onFileCommentNotFound();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == NoItemSpecified) onNoItemSpecified();
        else if (this == NotPinned) onNotPinned();
        else if (this == PermissionDenied) onPermissionDenied();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == NoPermission) onNoPermission();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostTyp) onInvalidPostTyp();
        else if (this == MissingPostTyp) onMissingPostTyp();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeou) onRequestTimeou();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else otherwise(Value);
    }
}
