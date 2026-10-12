using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TeamAccessLogsErrorEnum>))]
public sealed record TeamAccessLogsErrorEnum : OpenStringEnum<TeamAccessLogsErrorEnum>
{
    private TeamAccessLogsErrorEnum(string value) : base(value)
    {
    }

    public static readonly TeamAccessLogsErrorEnum PaidOnly = new("paid_only");

    public static readonly TeamAccessLogsErrorEnum OverPaginationLimit = new("over_pagination_limit");

    public static readonly TeamAccessLogsErrorEnum NotAuthed = new("not_authed");

    public static readonly TeamAccessLogsErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly TeamAccessLogsErrorEnum AccountInactive = new("account_inactive");

    public static readonly TeamAccessLogsErrorEnum TokenRevoked = new("token_revoked");

    public static readonly TeamAccessLogsErrorEnum NoPermission = new("no_permission");

    public static readonly TeamAccessLogsErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly TeamAccessLogsErrorEnum UserIsBot = new("user_is_bot");

    public static readonly TeamAccessLogsErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly TeamAccessLogsErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly TeamAccessLogsErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly TeamAccessLogsErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly TeamAccessLogsErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly TeamAccessLogsErrorEnum MissingPostType = new("missing_post_type");

    public static readonly TeamAccessLogsErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly TeamAccessLogsErrorEnum InvalidJson = new("invalid_json");

    public static readonly TeamAccessLogsErrorEnum JsonNotObject = new("json_not_object");

    public static readonly TeamAccessLogsErrorEnum RequestTimeout = new("request_timeout");

    public static readonly TeamAccessLogsErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly TeamAccessLogsErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onPaidOnly,
        Func<TResult> onOverPaginationLimit,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
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
        Func<TResult> onFatalError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PaidOnly => onPaidOnly(),
            _ when this == OverPaginationLimit => onOverPaginationLimit(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
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
            _ when this == FatalError => onFatalError(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaidOnly,
        Action onOverPaginationLimit,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
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
        Action onFatalError,
        Action<string> otherwise)
    {
        if (this == PaidOnly) onPaidOnly();
        else if (this == OverPaginationLimit) onOverPaginationLimit();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
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
        else if (this == FatalError) onFatalError();
        else otherwise(Value);
    }
}
