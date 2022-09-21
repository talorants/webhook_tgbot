using Telegram.Bot;
using Telegram.Bot.Types;

namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{

    private async Task HandleNextAndBackProphet(ITelegramBotClient botClient, CallbackQuery query)
    {
        if (query.Data == "_nextProphet1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: Prophet2);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId);
        }
        else if (query.Data == "_nextProphet2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: Prophet3);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId);
        }
        else if (query.Data == "_nextProphet3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet4,
               replyMarkup: Prophet4 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId);
        }
        else if (query.Data == "_backProphet1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet1,
               replyMarkup: Prophet1);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId);
        }
        else if (query.Data == "_backProphet2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: Prophet2);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId);
        }
        else if (query.Data == "_backProphet3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: Prophet3);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId);
        }
    }
}