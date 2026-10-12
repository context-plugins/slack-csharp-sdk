using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsRepliesErrorEnum>))]
public sealed record ConversationsRepliesErrorEnum : OpenStringEnum<ConversationsRepliesErrorEnum>
{
    private ConversationsRepliesErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsRepliesErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsRepliesErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsRepliesErrorEnum ThreadNotFound = new("thread_not_found");

    public static readonly ConversationsRepliesErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsRepliesErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsRepliesErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsRepliesErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsRepliesErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsRepliesErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsRepliesErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsRepliesErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsRepliesErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsRepliesErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsRepliesErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsRepliesErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsRepliesErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsRepliesErrorEnum UpgradeRequired = new("upgrade_required");

    public TResult Match<TResult>(Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onThreadNotFound,
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
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ThreadNotFound => onThreadNotFound(),
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

    public void Match(Action onMissingScope,
        Action onChannelNotFound,
        Action onThreadNotFound,
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
        if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ThreadNotFound) onThreadNotFound();
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
