using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsKickErrorEnum>))]
public sealed record ConversationsKickErrorEnum : OpenStringEnum<ConversationsKickErrorEnum>
{
    private ConversationsKickErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsKickErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsKickErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsKickErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsKickErrorEnum UserNotFound = new("user_not_found");

    public static readonly ConversationsKickErrorEnum CantKickSelf = new("cant_kick_self");

    public static readonly ConversationsKickErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsKickErrorEnum CantKickFromGeneral = new("cant_kick_from_general");

    public static readonly ConversationsKickErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ConversationsKickErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsKickErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsKickErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsKickErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsKickErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsKickErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsKickErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsKickErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsKickErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsKickErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsKickErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsKickErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsKickErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsKickErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsKickErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onUserNotFound,
        Func<TResult> onCantKickSelf,
        Func<TResult> onNotInChannel,
        Func<TResult> onCantKickFromGeneral,
        Func<TResult> onRestrictedAction,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onUserIsBot,
        Func<TResult> onUserIsRestricted,
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
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == CantKickSelf => onCantKickSelf(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == CantKickFromGeneral => onCantKickFromGeneral(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == UserIsBot => onUserIsBot(),
            _ when this == UserIsRestricted => onUserIsRestricted(),
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
            _ => otherwise(Value)
        };

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onMissingScope,
        Action onChannelNotFound,
        Action onUserNotFound,
        Action onCantKickSelf,
        Action onNotInChannel,
        Action onCantKickFromGeneral,
        Action onRestrictedAction,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onUserIsBot,
        Action onUserIsRestricted,
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
        Action<string> otherwise)
    {
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == UserNotFound) onUserNotFound();
        else if (this == CantKickSelf) onCantKickSelf();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == CantKickFromGeneral) onCantKickFromGeneral();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == UserIsBot) onUserIsBot();
        else if (this == UserIsRestricted) onUserIsRestricted();
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
        else otherwise(Value);
    }
}
