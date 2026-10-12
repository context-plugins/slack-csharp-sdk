using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersLookupByEmailErrorEnum>))]
public sealed record UsersLookupByEmailErrorEnum : OpenStringEnum<UsersLookupByEmailErrorEnum>
{
    private UsersLookupByEmailErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersLookupByEmailErrorEnum UsersNotFound = new("users_not_found");

    public static readonly UsersLookupByEmailErrorEnum EnterpriseIsRestricted = new("enterprise_is_restricted");

    public static readonly UsersLookupByEmailErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersLookupByEmailErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersLookupByEmailErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersLookupByEmailErrorEnum NoPermission = new("no_permission");

    public static readonly UsersLookupByEmailErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersLookupByEmailErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersLookupByEmailErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersLookupByEmailErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersLookupByEmailErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersLookupByEmailErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersLookupByEmailErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersLookupByEmailErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersLookupByEmailErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersLookupByEmailErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersLookupByEmailErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersLookupByEmailErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onUsersNotFound,
        Func<TResult> onEnterpriseIsRestricted,
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
            _ when this == UsersNotFound => onUsersNotFound(),
            _ when this == EnterpriseIsRestricted => onEnterpriseIsRestricted(),
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

    public void Match(Action onUsersNotFound,
        Action onEnterpriseIsRestricted,
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
        if (this == UsersNotFound) onUsersNotFound();
        else if (this == EnterpriseIsRestricted) onEnterpriseIsRestricted();
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
