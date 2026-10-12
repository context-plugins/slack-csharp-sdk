using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersInfoErrorEnum>))]
public sealed record UsersInfoErrorEnum : OpenStringEnum<UsersInfoErrorEnum>
{
    private UsersInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersInfoErrorEnum UserNotFound = new("user_not_found");

    public static readonly UsersInfoErrorEnum UserNotVisible = new("user_not_visible");

    public static readonly UsersInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onUserNotFound,
        Func<TResult> onUserNotVisible,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
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
            _ when this == UserNotVisible => onUserNotVisible(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
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
        Action onUserNotVisible,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
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
        else if (this == UserNotVisible) onUserNotVisible();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
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
