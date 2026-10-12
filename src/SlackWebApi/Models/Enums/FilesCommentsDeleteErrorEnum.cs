using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesCommentsDeleteErrorEnum>))]
public sealed record FilesCommentsDeleteErrorEnum : OpenStringEnum<FilesCommentsDeleteErrorEnum>
{
    private FilesCommentsDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesCommentsDeleteErrorEnum CantDelete = new("cant_delete");

    public static readonly FilesCommentsDeleteErrorEnum CommentNotFound = new("comment_not_found");

    public static readonly FilesCommentsDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesCommentsDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesCommentsDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesCommentsDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly FilesCommentsDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesCommentsDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesCommentsDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesCommentsDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesCommentsDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesCommentsDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesCommentsDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesCommentsDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesCommentsDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesCommentsDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onCantDelete,
        Func<TResult> onCommentNotFound,
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
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeout,
        Func<TResult> onUpgradeRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CantDelete => onCantDelete(),
            _ when this == CommentNotFound => onCommentNotFound(),
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
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onCantDelete,
        Action onCommentNotFound,
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
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeout,
        Action onUpgradeRequired,
        Action<string> otherwise)
    {
        if (this == CantDelete) onCantDelete();
        else if (this == CommentNotFound) onCommentNotFound();
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
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else otherwise(Value);
    }
}
