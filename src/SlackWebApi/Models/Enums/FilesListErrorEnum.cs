using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesListErrorEnum>))]
public sealed record FilesListErrorEnum : OpenStringEnum<FilesListErrorEnum>
{
    private FilesListErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesListErrorEnum UserNotFound = new("user_not_found");

    public static readonly FilesListErrorEnum UnknownType = new("unknown_type");

    public static readonly FilesListErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesListErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesListErrorEnum NoPermission = new("no_permission");

    public static readonly FilesListErrorEnum UserIsBot = new("user_is_bot");

    public static readonly FilesListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesListErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesListErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onUserNotFound,
        Func<TResult> onUnknownType,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onNoPermission,
        Func<TResult> onUserIsBot,
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
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == UnknownType => onUnknownType(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == UserIsBot => onUserIsBot(),
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

    public void Match(Action onUserNotFound,
        Action onUnknownType,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onNoPermission,
        Action onUserIsBot,
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
        if (this == UserNotFound) onUserNotFound();
        else if (this == UnknownType) onUnknownType();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == NoPermission) onNoPermission();
        else if (this == UserIsBot) onUserIsBot();
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
