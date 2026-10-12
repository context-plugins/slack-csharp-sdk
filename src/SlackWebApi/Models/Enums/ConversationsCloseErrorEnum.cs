using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsCloseErrorEnum>))]
public sealed record ConversationsCloseErrorEnum : OpenStringEnum<ConversationsCloseErrorEnum>
{
    private ConversationsCloseErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsCloseErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsCloseErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsCloseErrorEnum UserDoesNotOwnChannel = new("user_does_not_own_channel");

    public static readonly ConversationsCloseErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsCloseErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsCloseErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsCloseErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsCloseErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsCloseErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsCloseErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsCloseErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsCloseErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsCloseErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsCloseErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsCloseErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsCloseErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsCloseErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsCloseErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onChannelNotFound,
        Func<TResult> onUserDoesNotOwnChannel,
        Func<TResult> onMissingScope,
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
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == UserDoesNotOwnChannel => onUserDoesNotOwnChannel(),
            _ when this == MissingScope => onMissingScope(),
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
            _ => otherwise(Value)
        };

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onChannelNotFound,
        Action onUserDoesNotOwnChannel,
        Action onMissingScope,
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
        Action<string> otherwise)
    {
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == UserDoesNotOwnChannel) onUserDoesNotOwnChannel();
        else if (this == MissingScope) onMissingScope();
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
        else otherwise(Value);
    }
}
