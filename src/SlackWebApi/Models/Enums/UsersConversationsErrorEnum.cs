using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersConversationsErrorEnum>))]
public sealed record UsersConversationsErrorEnum : OpenStringEnum<UsersConversationsErrorEnum>
{
    private UsersConversationsErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersConversationsErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly UsersConversationsErrorEnum MissingScope = new("missing_scope");

    public static readonly UsersConversationsErrorEnum InvalidTypes = new("invalid_types");

    public static readonly UsersConversationsErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly UsersConversationsErrorEnum InvalidLimit = new("invalid_limit");

    public static readonly UsersConversationsErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersConversationsErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersConversationsErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersConversationsErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersConversationsErrorEnum NoPermission = new("no_permission");

    public static readonly UsersConversationsErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersConversationsErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersConversationsErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersConversationsErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersConversationsErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersConversationsErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersConversationsErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersConversationsErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersConversationsErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersConversationsErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersConversationsErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersConversationsErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onInvalidTypes,
        Func<TResult> onInvalidCursor,
        Func<TResult> onInvalidLimit,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
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
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == InvalidTypes => onInvalidTypes(),
            _ when this == InvalidCursor => onInvalidCursor(),
            _ when this == InvalidLimit => onInvalidLimit(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
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

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onMissingScope,
        Action onInvalidTypes,
        Action onInvalidCursor,
        Action onInvalidLimit,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
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
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == MissingScope) onMissingScope();
        else if (this == InvalidTypes) onInvalidTypes();
        else if (this == InvalidCursor) onInvalidCursor();
        else if (this == InvalidLimit) onInvalidLimit();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
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
