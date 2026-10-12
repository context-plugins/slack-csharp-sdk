using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsSetPurposeErrorEnum>))]
public sealed record ConversationsSetPurposeErrorEnum : OpenStringEnum<ConversationsSetPurposeErrorEnum>
{
    private ConversationsSetPurposeErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsSetPurposeErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsSetPurposeErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsSetPurposeErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsSetPurposeErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsSetPurposeErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsSetPurposeErrorEnum TooLong = new("too_long");

    public static readonly ConversationsSetPurposeErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsSetPurposeErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsSetPurposeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsSetPurposeErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsSetPurposeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsSetPurposeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsSetPurposeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsSetPurposeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsSetPurposeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsSetPurposeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsSetPurposeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsSetPurposeErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsSetPurposeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsSetPurposeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsSetPurposeErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNotInChannel,
        Func<TResult> onIsArchived,
        Func<TResult> onTooLong,
        Func<TResult> onUserIsRestricted,
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
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == IsArchived => onIsArchived(),
            _ when this == TooLong => onTooLong(),
            _ when this == UserIsRestricted => onUserIsRestricted(),
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
        Action onMissingScope,
        Action onChannelNotFound,
        Action onNotInChannel,
        Action onIsArchived,
        Action onTooLong,
        Action onUserIsRestricted,
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
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == IsArchived) onIsArchived();
        else if (this == TooLong) onTooLong();
        else if (this == UserIsRestricted) onUserIsRestricted();
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
