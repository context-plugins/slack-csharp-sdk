using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsMembersErrorEnum>))]
public sealed record ConversationsMembersErrorEnum : OpenStringEnum<ConversationsMembersErrorEnum>
{
    private ConversationsMembersErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsMembersErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsMembersErrorEnum InvalidLimit = new("invalid_limit");

    public static readonly ConversationsMembersErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly ConversationsMembersErrorEnum FetchMembersFailed = new("fetch_members_failed");

    public static readonly ConversationsMembersErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsMembersErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsMembersErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsMembersErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsMembersErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsMembersErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsMembersErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsMembersErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsMembersErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsMembersErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsMembersErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsMembersErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsMembersErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsMembersErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onChannelNotFound,
        Func<TResult> onInvalidLimit,
        Func<TResult> onInvalidCursor,
        Func<TResult> onFetchMembersFailed,
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
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == InvalidLimit => onInvalidLimit(),
            _ when this == InvalidCursor => onInvalidCursor(),
            _ when this == FetchMembersFailed => onFetchMembersFailed(),
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

    public void Match(Action onChannelNotFound,
        Action onInvalidLimit,
        Action onInvalidCursor,
        Action onFetchMembersFailed,
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
        if (this == ChannelNotFound) onChannelNotFound();
        else if (this == InvalidLimit) onInvalidLimit();
        else if (this == InvalidCursor) onInvalidCursor();
        else if (this == FetchMembersFailed) onFetchMembersFailed();
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
