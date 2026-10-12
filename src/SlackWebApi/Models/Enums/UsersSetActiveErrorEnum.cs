using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersSetActiveErrorEnum>))]
public sealed record UsersSetActiveErrorEnum : OpenStringEnum<UsersSetActiveErrorEnum>
{
    private UsersSetActiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersSetActiveErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersSetActiveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersSetActiveErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersSetActiveErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersSetActiveErrorEnum NoPermission = new("no_permission");

    public static readonly UsersSetActiveErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersSetActiveErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly UsersSetActiveErrorEnum MissingScope = new("missing_scope");

    public static readonly UsersSetActiveErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly UsersSetActiveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersSetActiveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersSetActiveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersSetActiveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersSetActiveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersSetActiveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersSetActiveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersSetActiveErrorEnum FatalError = new("fatal_error");

    public static readonly UsersSetActiveErrorEnum InternalError = new("internal_error");

    public TResult Match<TResult>(Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
        Func<TResult> onEkmAccessDenied,
        Func<TResult> onMissingScope,
        Func<TResult> onInvalidArguments,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onRequestTimeout,
        Func<TResult> onFatalError,
        Func<TResult> onInternalError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
            _ when this == EkmAccessDenied => onEkmAccessDenied(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == InvalidArguments => onInvalidArguments(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == FatalError => onFatalError(),
            _ when this == InternalError => onInternalError(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
        Action onEkmAccessDenied,
        Action onMissingScope,
        Action onInvalidArguments,
        Action onInvalidArgName,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onTeamAddedToOrg,
        Action onRequestTimeout,
        Action onFatalError,
        Action onInternalError,
        Action<string> otherwise)
    {
        if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
        else if (this == EkmAccessDenied) onEkmAccessDenied();
        else if (this == MissingScope) onMissingScope();
        else if (this == InvalidArguments) onInvalidArguments();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == FatalError) onFatalError();
        else if (this == InternalError) onInternalError();
        else otherwise(Value);
    }
}
