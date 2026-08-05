using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesUploadErrorEnum>))]
public sealed record FilesUploadErrorEnum : StringEnum<FilesUploadErrorEnum>
{
    private FilesUploadErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesUploadErrorEnum PostingToGeneralChannelDenied = new("posting_to_general_channel_denied");

    public static readonly FilesUploadErrorEnum InvalidChannel = new("invalid_channel");

    public static readonly FilesUploadErrorEnum FileUploadsDisabled = new("file_uploads_disabled");

    public static readonly FilesUploadErrorEnum FileUploadsExceptImagesDisabled = new("file_uploads_except_images_disabled");

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

    public static FilesUploadErrorEnum FromValue(string value) => FromValueCore(value);
}
