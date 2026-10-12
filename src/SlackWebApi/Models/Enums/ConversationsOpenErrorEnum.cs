using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsOpenErrorEnum>))]
public sealed record ConversationsOpenErrorEnum : OpenStringEnum<ConversationsOpenErrorEnum>
{
    private ConversationsOpenErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsOpenErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsOpenErrorEnum UserNotFound = new("user_not_found");

    public static readonly ConversationsOpenErrorEnum UserNotVisible = new("user_not_visible");

    public static readonly ConversationsOpenErrorEnum UserDisabled = new("user_disabled");

    public static readonly ConversationsOpenErrorEnum UsersListNotSupplied = new("users_list_not_supplied");

    public static readonly ConversationsOpenErrorEnum NotEnoughUsers = new("not_enough_users");

    public static readonly ConversationsOpenErrorEnum TooManyUsers = new("too_many_users");

    public static readonly ConversationsOpenErrorEnum InvalidUserCombination = new("invalid_user_combination");

    public static readonly ConversationsOpenErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsOpenErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsOpenErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsOpenErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsOpenErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsOpenErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsOpenErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsOpenErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsOpenErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsOpenErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsOpenErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsOpenErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsOpenErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsOpenErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsOpenErrorEnum ChannelNotFound = new("channel_not_found");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onUserNotFound,
        Func<TResult> onUserNotVisible,
        Func<TResult> onUserDisabled,
        Func<TResult> onUsersListNotSupplied,
        Func<TResult> onNotEnoughUsers,
        Func<TResult> onTooManyUsers,
        Func<TResult> onInvalidUserCombination,
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
        Func<TResult> onChannelNotFound,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == UserNotVisible => onUserNotVisible(),
            _ when this == UserDisabled => onUserDisabled(),
            _ when this == UsersListNotSupplied => onUsersListNotSupplied(),
            _ when this == NotEnoughUsers => onNotEnoughUsers(),
            _ when this == TooManyUsers => onTooManyUsers(),
            _ when this == InvalidUserCombination => onInvalidUserCombination(),
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
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ => otherwise(Value)
        };

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onUserNotFound,
        Action onUserNotVisible,
        Action onUserDisabled,
        Action onUsersListNotSupplied,
        Action onNotEnoughUsers,
        Action onTooManyUsers,
        Action onInvalidUserCombination,
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
        Action onChannelNotFound,
        Action<string> otherwise)
    {
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == UserNotFound) onUserNotFound();
        else if (this == UserNotVisible) onUserNotVisible();
        else if (this == UserDisabled) onUserDisabled();
        else if (this == UsersListNotSupplied) onUsersListNotSupplied();
        else if (this == NotEnoughUsers) onNotEnoughUsers();
        else if (this == TooManyUsers) onTooManyUsers();
        else if (this == InvalidUserCombination) onInvalidUserCombination();
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
        else if (this == ChannelNotFound) onChannelNotFound();
        else otherwise(Value);
    }
}
