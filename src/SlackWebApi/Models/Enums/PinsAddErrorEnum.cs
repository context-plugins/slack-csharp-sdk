using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinsAddErrorEnum>))]
public sealed record PinsAddErrorEnum : OpenStringEnum<PinsAddErrorEnum>
{
    private PinsAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly PinsAddErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly PinsAddErrorEnum MessageNotFound = new("message_not_found");

    public static readonly PinsAddErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly PinsAddErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly PinsAddErrorEnum AlreadyPinned = new("already_pinned");

    public static readonly PinsAddErrorEnum PermissionDenied = new("permission_denied");

    public static readonly PinsAddErrorEnum FileNotShared = new("file_not_shared");

    public static readonly PinsAddErrorEnum NotPinnable = new("not_pinnable");

    public static readonly PinsAddErrorEnum NotAuthed = new("not_authed");

    public static readonly PinsAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly PinsAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly PinsAddErrorEnum NoPermission = new("no_permission");

    public static readonly PinsAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly PinsAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly PinsAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly PinsAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly PinsAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly PinsAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly PinsAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly PinsAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly PinsAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly PinsAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly PinsAddErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onBadTimestamp,
        Func<TResult> onMessageNotFound,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNoItemSpecified,
        Func<TResult> onAlreadyPinned,
        Func<TResult> onPermissionDenied,
        Func<TResult> onFileNotShared,
        Func<TResult> onNotPinnable,
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
            _ when this == BadTimestamp => onBadTimestamp(),
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NoItemSpecified => onNoItemSpecified(),
            _ when this == AlreadyPinned => onAlreadyPinned(),
            _ when this == PermissionDenied => onPermissionDenied(),
            _ when this == FileNotShared => onFileNotShared(),
            _ when this == NotPinnable => onNotPinnable(),
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

    public void Match(Action onBadTimestamp,
        Action onMessageNotFound,
        Action onChannelNotFound,
        Action onNoItemSpecified,
        Action onAlreadyPinned,
        Action onPermissionDenied,
        Action onFileNotShared,
        Action onNotPinnable,
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
        if (this == BadTimestamp) onBadTimestamp();
        else if (this == MessageNotFound) onMessageNotFound();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NoItemSpecified) onNoItemSpecified();
        else if (this == AlreadyPinned) onAlreadyPinned();
        else if (this == PermissionDenied) onPermissionDenied();
        else if (this == FileNotShared) onFileNotShared();
        else if (this == NotPinnable) onNotPinnable();
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
