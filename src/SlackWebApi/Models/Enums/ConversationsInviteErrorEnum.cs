using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsInviteErrorEnum>))]
public sealed record ConversationsInviteErrorEnum : OpenStringEnum<ConversationsInviteErrorEnum>
{
    private ConversationsInviteErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsInviteErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsInviteErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsInviteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsInviteErrorEnum UserNotFound = new("user_not_found");

    public static readonly ConversationsInviteErrorEnum NoUser = new("no_user");

    public static readonly ConversationsInviteErrorEnum CantInviteSelf = new("cant_invite_self");

    public static readonly ConversationsInviteErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsInviteErrorEnum AlreadyInChannel = new("already_in_channel");

    public static readonly ConversationsInviteErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsInviteErrorEnum CantInvite = new("cant_invite");

    public static readonly ConversationsInviteErrorEnum TooManyUsers = new("too_many_users");

    public static readonly ConversationsInviteErrorEnum UraMaxChannels = new("ura_max_channels");

    public static readonly ConversationsInviteErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsInviteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsInviteErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsInviteErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsInviteErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsInviteErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsInviteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsInviteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsInviteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsInviteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsInviteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsInviteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsInviteErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsInviteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsInviteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsInviteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsInviteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsInviteErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsInviteErrorEnum SuperfluousCharset = new("superfluous_charset");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onUserNotFound,
        Func<TResult> onNoUser,
        Func<TResult> onCantInviteSelf,
        Func<TResult> onNotInChannel,
        Func<TResult> onAlreadyInChannel,
        Func<TResult> onIsArchived,
        Func<TResult> onCantInvite,
        Func<TResult> onTooManyUsers,
        Func<TResult> onUraMaxChannels,
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
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == NoUser => onNoUser(),
            _ when this == CantInviteSelf => onCantInviteSelf(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == AlreadyInChannel => onAlreadyInChannel(),
            _ when this == IsArchived => onIsArchived(),
            _ when this == CantInvite => onCantInvite(),
            _ when this == TooManyUsers => onTooManyUsers(),
            _ when this == UraMaxChannels => onUraMaxChannels(),
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
        Action onUserNotFound,
        Action onNoUser,
        Action onCantInviteSelf,
        Action onNotInChannel,
        Action onAlreadyInChannel,
        Action onIsArchived,
        Action onCantInvite,
        Action onTooManyUsers,
        Action onUraMaxChannels,
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
        else if (this == UserNotFound) onUserNotFound();
        else if (this == NoUser) onNoUser();
        else if (this == CantInviteSelf) onCantInviteSelf();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == AlreadyInChannel) onAlreadyInChannel();
        else if (this == IsArchived) onIsArchived();
        else if (this == CantInvite) onCantInvite();
        else if (this == TooManyUsers) onTooManyUsers();
        else if (this == UraMaxChannels) onUraMaxChannels();
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
