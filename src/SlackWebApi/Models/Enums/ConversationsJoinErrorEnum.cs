using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsJoinErrorEnum>))]
public sealed record ConversationsJoinErrorEnum : OpenStringEnum<ConversationsJoinErrorEnum>
{
    private ConversationsJoinErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsJoinErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsJoinErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsJoinErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsJoinErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsJoinErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsJoinErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsJoinErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsJoinErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsJoinErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsJoinErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsJoinErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsJoinErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsJoinErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsJoinErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsJoinErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsJoinErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsJoinErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsJoinErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsJoinErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsJoinErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsJoinErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsJoinErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsJoinErrorEnum SuperfluousCharset = new("superfluous_charset");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onIsArchived,
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
            _ when this == IsArchived => onIsArchived(),
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
        Action onIsArchived,
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
        else if (this == IsArchived) onIsArchived();
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
