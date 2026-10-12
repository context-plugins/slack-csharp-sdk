using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersListErrorEnum>))]
public sealed record UsersListErrorEnum : OpenStringEnum<UsersListErrorEnum>
{
    private UsersListErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersListErrorEnum LimitRequired = new("limit_required");

    public static readonly UsersListErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly UsersListErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersListErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersListErrorEnum NoPermission = new("no_permission");

    public static readonly UsersListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersListErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersListErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onLimitRequired,
        Func<TResult> onInvalidCursor,
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
            _ when this == LimitRequired => onLimitRequired(),
            _ when this == InvalidCursor => onInvalidCursor(),
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

    public void Match(Action onLimitRequired,
        Action onInvalidCursor,
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
        if (this == LimitRequired) onLimitRequired();
        else if (this == InvalidCursor) onInvalidCursor();
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
