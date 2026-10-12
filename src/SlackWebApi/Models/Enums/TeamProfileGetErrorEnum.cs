using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TeamProfileGetErrorEnum>))]
public sealed record TeamProfileGetErrorEnum : OpenStringEnum<TeamProfileGetErrorEnum>
{
    private TeamProfileGetErrorEnum(string value) : base(value)
    {
    }

    public static readonly TeamProfileGetErrorEnum NotAuthed = new("not_authed");

    public static readonly TeamProfileGetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly TeamProfileGetErrorEnum AccountInactive = new("account_inactive");

    public static readonly TeamProfileGetErrorEnum NoPermission = new("no_permission");

    public static readonly TeamProfileGetErrorEnum UserIsBot = new("user_is_bot");

    public static readonly TeamProfileGetErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly TeamProfileGetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly TeamProfileGetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly TeamProfileGetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly TeamProfileGetErrorEnum InvalidPostTyp = new("invalid_post_typ");

    public static readonly TeamProfileGetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly TeamProfileGetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly TeamProfileGetErrorEnum InvalidJson = new("invalid_json");

    public static readonly TeamProfileGetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly TeamProfileGetErrorEnum RequestTimeou = new("request_timeou");

    public static readonly TeamProfileGetErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onNoPermission,
        Func<TResult> onUserIsBot,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostTyp,
        Func<TResult> onMissingPostType,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeou,
        Func<TResult> onUpgradeRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == UserIsBot => onUserIsBot(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostTyp => onInvalidPostTyp(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeou => onRequestTimeou(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onNoPermission,
        Action onUserIsBot,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostTyp,
        Action onMissingPostType,
        Action onTeamAddedToOrg,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeou,
        Action onUpgradeRequired,
        Action<string> otherwise)
    {
        if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == NoPermission) onNoPermission();
        else if (this == UserIsBot) onUserIsBot();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostTyp) onInvalidPostTyp();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeou) onRequestTimeou();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else otherwise(Value);
    }
}
