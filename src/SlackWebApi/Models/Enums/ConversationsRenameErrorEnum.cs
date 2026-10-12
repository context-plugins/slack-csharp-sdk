using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsRenameErrorEnum>))]
public sealed record ConversationsRenameErrorEnum : OpenStringEnum<ConversationsRenameErrorEnum>
{
    private ConversationsRenameErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsRenameErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsRenameErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsRenameErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsRenameErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsRenameErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsRenameErrorEnum NotAuthorized = new("not_authorized");

    public static readonly ConversationsRenameErrorEnum InvalidName = new("invalid_name");

    public static readonly ConversationsRenameErrorEnum NameTaken = new("name_taken");

    public static readonly ConversationsRenameErrorEnum InvalidNameRequired = new("invalid_name_required");

    public static readonly ConversationsRenameErrorEnum InvalidNamePunctuation = new("invalid_name_punctuation");

    public static readonly ConversationsRenameErrorEnum InvalidNameMaxlength = new("invalid_name_maxlength");

    public static readonly ConversationsRenameErrorEnum InvalidNameSpecials = new("invalid_name_specials");

    public static readonly ConversationsRenameErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsRenameErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsRenameErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsRenameErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsRenameErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsRenameErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsRenameErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsRenameErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsRenameErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsRenameErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsRenameErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsRenameErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsRenameErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onUserIsRestricted,
        Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNotInChannel,
        Func<TResult> onNotAuthorized,
        Func<TResult> onInvalidName,
        Func<TResult> onNameTaken,
        Func<TResult> onInvalidNameRequired,
        Func<TResult> onInvalidNamePunctuation,
        Func<TResult> onInvalidNameMaxlength,
        Func<TResult> onInvalidNameSpecials,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
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
            _ when this == UserIsRestricted => onUserIsRestricted(),
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == NotAuthorized => onNotAuthorized(),
            _ when this == InvalidName => onInvalidName(),
            _ when this == NameTaken => onNameTaken(),
            _ when this == InvalidNameRequired => onInvalidNameRequired(),
            _ when this == InvalidNamePunctuation => onInvalidNamePunctuation(),
            _ when this == InvalidNameMaxlength => onInvalidNameMaxlength(),
            _ when this == InvalidNameSpecials => onInvalidNameSpecials(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
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

    public void Match(Action onUserIsRestricted,
        Action onMethodNotSupportedForChannelType,
        Action onMissingScope,
        Action onChannelNotFound,
        Action onNotInChannel,
        Action onNotAuthorized,
        Action onInvalidName,
        Action onNameTaken,
        Action onInvalidNameRequired,
        Action onInvalidNamePunctuation,
        Action onInvalidNameMaxlength,
        Action onInvalidNameSpecials,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
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
        if (this == UserIsRestricted) onUserIsRestricted();
        else if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == NotAuthorized) onNotAuthorized();
        else if (this == InvalidName) onInvalidName();
        else if (this == NameTaken) onNameTaken();
        else if (this == InvalidNameRequired) onInvalidNameRequired();
        else if (this == InvalidNamePunctuation) onInvalidNamePunctuation();
        else if (this == InvalidNameMaxlength) onInvalidNameMaxlength();
        else if (this == InvalidNameSpecials) onInvalidNameSpecials();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
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
