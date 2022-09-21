using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
    private async Task HandleTextQuranAsync(ITelegramBotClient botClient, CallbackQuery query)
    {
        if (query.Data == "_textQuran")
        {
            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Qaysi tilda o'qimoqchisiz?",
                replyMarkup: books); 
        }
        else if (query.Data == "_uzBook")
        {
            await botClient.ForwardMessageAsync(
                chatId: query.Message.Chat.Id,
                fromChatId: -1001407276572,
                226);
        }
        else if (query.Data == "_arabBook")
        {
            await botClient.ForwardMessageAsync(
                chatId: query.Message.Chat.Id,
                fromChatId: -1001407276572,
                227);
        }
    }
}