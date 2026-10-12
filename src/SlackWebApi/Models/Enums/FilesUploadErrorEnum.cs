using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesUploadErrorEnum>))]
public sealed record FilesUploadErrorEnum : OpenStringEnum<FilesUploadErrorEnum>
{
    private FilesUploadErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesUploadErrorEnum PostingToGeneralChannelDenied = new(
        "posting_to_general_channel_denied");

    public static readonly FilesUploadErrorEnum InvalidChannel = new("invalid_channel");

    public static readonly FilesUploadErrorEnum FileUploadsDisabled = new("file_uploads_disabled");

    public static readonly FilesUploadErrorEnum FileUploadsExceptImagesDisabled = new(
        "file_uploads_except_images_disabled");

    public static readonly FilesUploadErrorEnum StorageLimitReached = new("storage_limit_reached");

    public static readonly FilesUploadErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesUploadErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesUploadErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesUploadErrorEnum NoPermission = new("no_permission");

    public static readonly FilesUploadErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesUploadErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesUploadErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesUploadErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesUploadErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesUploadErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesUploadErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesUploadErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesUploadErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesUploadErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesUploadErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onPostingToGeneralChannelDenied,
        Func<TResult> onInvalidChannel,
        Func<TResult> onFileUploadsDisabled,
        Func<TResult> onFileUploadsExceptImagesDisabled,
        Func<TResult> onStorageLimitReached,
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
            _ when this == PostingToGeneralChannelDenied => onPostingToGeneralChannelDenied(),
            _ when this == InvalidChannel => onInvalidChannel(),
            _ when this == FileUploadsDisabled => onFileUploadsDisabled(),
            _ when this == FileUploadsExceptImagesDisabled => onFileUploadsExceptImagesDisabled(),
            _ when this == StorageLimitReached => onStorageLimitReached(),
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

    public void Match(Action onPostingToGeneralChannelDenied,
        Action onInvalidChannel,
        Action onFileUploadsDisabled,
        Action onFileUploadsExceptImagesDisabled,
        Action onStorageLimitReached,
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
        if (this == PostingToGeneralChannelDenied) onPostingToGeneralChannelDenied();
        else if (this == InvalidChannel) onInvalidChannel();
        else if (this == FileUploadsDisabled) onFileUploadsDisabled();
        else if (this == FileUploadsExceptImagesDisabled) onFileUploadsExceptImagesDisabled();
        else if (this == StorageLimitReached) onStorageLimitReached();
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
