using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsListErrorEnum>))]
public sealed record ConversationsListErrorEnum : OpenStringEnum<ConversationsListErrorEnum>
{
    private ConversationsListErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsListErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsListErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsListErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsListErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsListErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onMissingScope,
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
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onMissingScope,
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
        if (this == MissingScope) onMissingScope();
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
