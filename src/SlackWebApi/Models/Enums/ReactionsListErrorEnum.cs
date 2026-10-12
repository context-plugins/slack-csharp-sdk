using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsListErrorEnum>))]
public sealed record ReactionsListErrorEnum : OpenStringEnum<ReactionsListErrorEnum>
{
    private ReactionsListErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsListErrorEnum UserNotFound = new("user_not_found");

    public static readonly ReactionsListErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsListErrorEnum AccountInactiv = new("account_inactiv");

    public static readonly ReactionsListErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ReactionsListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsListErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ReactionsListErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onUserNotFound,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactiv,
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
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactiv => onAccountInactiv(),
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

    public void Match(Action onUserNotFound,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactiv,
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
        if (this == UserNotFound) onUserNotFound();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactiv) onAccountInactiv();
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
