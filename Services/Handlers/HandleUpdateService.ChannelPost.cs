 
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{

    private async Task HandleChannelPostAsync(ITelegramBotClient botClient, Message? channelPost)
    {
        ArgumentNullException.ThrowIfNull(channelPost);

        var channelPostMessageId = channelPost.MessageId;

        _logger.LogInformation($"New Data successfully added to channelId {channelPost.Chat.Id} , dataId: {channelPostMessageId}, dataType: {channelPost.Type}");
    }
}