using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsLeaveErrorEnum>))]
public sealed record ConversationsLeaveErrorEnum : OpenStringEnum<ConversationsLeaveErrorEnum>
{
    private ConversationsLeaveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsLeaveErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsLeaveErrorEnum LastMember = new("last_member");

    public static readonly ConversationsLeaveErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsLeaveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsLeaveErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsLeaveErrorEnum CantLeaveGeneral = new("cant_leave_general");

    public static readonly ConversationsLeaveErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsLeaveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsLeaveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsLeaveErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsLeaveErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsLeaveErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsLeaveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsLeaveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsLeaveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsLeaveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsLeaveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsLeaveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsLeaveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsLeaveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsLeaveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsLeaveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsLeaveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsLeaveErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsLeaveErrorEnum SuperfluousCharset = new("superfluous_charset");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onLastMember,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onIsArchived,
        Func<TResult> onCantLeaveGeneral,
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
            _ when this == LastMember => onLastMember(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == IsArchived => onIsArchived(),
            _ when this == CantLeaveGeneral => onCantLeaveGeneral(),
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
        Action onLastMember,
        Action onMissingScope,
        Action onChannelNotFound,
        Action onIsArchived,
        Action onCantLeaveGeneral,
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
        else if (this == LastMember) onLastMember();
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == IsArchived) onIsArchived();
        else if (this == CantLeaveGeneral) onCantLeaveGeneral();
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
