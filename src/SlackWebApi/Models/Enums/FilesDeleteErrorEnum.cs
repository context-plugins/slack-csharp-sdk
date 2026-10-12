using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesDeleteErrorEnum>))]
public sealed record FilesDeleteErrorEnum : OpenStringEnum<FilesDeleteErrorEnum>
{
    private FilesDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesDeleteErrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesDeleteErrorEnum FileDeleted = new("file_deleted");

    public static readonly FilesDeleteErrorEnum CantDeleteFile = new("cant_delete_file");

    public static readonly FilesDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly FilesDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesDeleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onFileNotFound,
        Func<TResult> onFileDeleted,
        Func<TResult> onCantDeleteFile,
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
            _ when this == FileNotFound => onFileNotFound(),
            _ when this == FileDeleted => onFileDeleted(),
            _ when this == CantDeleteFile => onCantDeleteFile(),
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

    public void Match(Action onFileNotFound,
        Action onFileDeleted,
        Action onCantDeleteFile,
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
        if (this == FileNotFound) onFileNotFound();
        else if (this == FileDeleted) onFileDeleted();
        else if (this == CantDeleteFile) onCantDeleteFile();
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
