using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
  private async Task HandleNextAndBackLessons(ITelegramBotClient botClient, CallbackQuery query)
    {   
        if (query.Data == "_nextLesson1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson2);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_nextLesson2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson3 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_nextLesson3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson4 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_backLesson1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson1 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_backLesson2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson2 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_backLesson3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson3 );
               
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
    }
}
