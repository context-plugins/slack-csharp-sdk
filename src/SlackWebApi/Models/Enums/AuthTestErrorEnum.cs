using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AuthTestErrorEnum>))]
public sealed record AuthTestErrorEnum : OpenStringEnum<AuthTestErrorEnum>
{
    private AuthTestErrorEnum(string value) : base(value)
    {
    }

    public static readonly AuthTestErrorEnum NotAuthed = new("not_authed");

    public static readonly AuthTestErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AuthTestErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AuthTestErrorEnum AccountInactive = new("account_inactive");

    public static readonly AuthTestErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AuthTestErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AuthTestErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AuthTestErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AuthTestErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AuthTestErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AuthTestErrorEnum InvalidJson = new("invalid_json");

    public static readonly AuthTestErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AuthTestErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AuthTestErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onTokenRevoked,
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
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == TokenRevoked => onTokenRevoked(),
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

    public void Match(Action onNotAuthed,
        Action onInvalidAuth,
        Action onTokenRevoked,
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
        if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == TokenRevoked) onTokenRevoked();
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
