using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinsListErrorEnum>))]
public sealed record PinsListErrorEnum : OpenStringEnum<PinsListErrorEnum>
{
    private PinsListErrorEnum(string value) : base(value)
    {
    }

    public static readonly PinsListErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly PinsListErrorEnum NotAuthed = new("not_authed");

    public static readonly PinsListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly PinsListErrorEnum AccountInactive = new("account_inactive");

    public static readonly PinsListErrorEnum NoPermission = new("no_permission");

    public static readonly PinsListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly PinsListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly PinsListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly PinsListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly PinsListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly PinsListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly PinsListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly PinsListErrorEnum InvalidJson = new("invalid_json");

    public static readonly PinsListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly PinsListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly PinsListErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onChannelNotFound,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onNoPermission,
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
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == NoPermission => onNoPermission(),
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

    public void Match(Action onChannelNotFound,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onNoPermission,
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
        if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == NoPermission) onNoPermission();
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
