using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesInfoErrorEnum>))]
public sealed record FilesInfoErrorEnum : OpenStringEnum<FilesInfoErrorEnum>
{
    private FilesInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesInfoErrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesInfoErrorEnum FileDeleted = new("file_deleted");

    public static readonly FilesInfoErrorEnum TimezoneCountFailed = new("timezone_count_failed");

    public static readonly FilesInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesInfoErrorEnum NoPermission = new("no_permission");

    public static readonly FilesInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onFileNotFound,
        Func<TResult> onFileDeleted,
        Func<TResult> onTimezoneCountFailed,
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
            _ when this == TimezoneCountFailed => onTimezoneCountFailed(),
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
        Action onTimezoneCountFailed,
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
        else if (this == TimezoneCountFailed) onTimezoneCountFailed();
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
