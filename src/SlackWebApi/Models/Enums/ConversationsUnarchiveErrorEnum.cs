using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsUnarchiveErrorEnum>))]
public sealed record ConversationsUnarchiveErrorEnum : OpenStringEnum<ConversationsUnarchiveErrorEnum>
{
    private ConversationsUnarchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsUnarchiveErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsUnarchiveErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsUnarchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsUnarchiveErrorEnum NotArchived = new("not_archived");

    public static readonly ConversationsUnarchiveErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsUnarchiveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsUnarchiveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsUnarchiveErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsUnarchiveErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsUnarchiveErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsUnarchiveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsUnarchiveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsUnarchiveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsUnarchiveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsUnarchiveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsUnarchiveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsUnarchiveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsUnarchiveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsUnarchiveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsUnarchiveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsUnarchiveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsUnarchiveErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsUnarchiveErrorEnum SuperfluousCharset = new("superfluous_charset");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNotArchived,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onUserIsBot,
        Func<TResult> onUserIsRestricted,
        Func<TResult> onUserIsUltraRestricted,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeout,
        Func<TResult> onUpgradeRequired,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onMissingCharset,
        Func<TResult> onSuperfluousCharset,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotArchived => onNotArchived(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == UserIsBot => onUserIsBot(),
            _ when this == UserIsRestricted => onUserIsRestricted(),
            _ when this == UserIsUltraRestricted => onUserIsUltraRestricted(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == MissingCharset => onMissingCharset(),
            _ when this == SuperfluousCharset => onSuperfluousCharset(),
            _ => otherwise(Value)
        };

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onMissingScope,
        Action onChannelNotFound,
        Action onNotArchived,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onUserIsBot,
        Action onUserIsRestricted,
        Action onUserIsUltraRestricted,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeout,
        Action onUpgradeRequired,
        Action onTeamAddedToOrg,
        Action onMissingCharset,
        Action onSuperfluousCharset,
        Action<string> otherwise)
    {
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotArchived) onNotArchived();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == UserIsBot) onUserIsBot();
        else if (this == UserIsRestricted) onUserIsRestricted();
        else if (this == UserIsUltraRestricted) onUserIsUltraRestricted();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == MissingCharset) onMissingCharset();
        else if (this == SuperfluousCharset) onSuperfluousCharset();
        else otherwise(Value);
    }
}
