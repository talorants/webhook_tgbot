using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
    private async Task HandleProphetAndAlphabetAsync(ITelegramBotClient botClient, CallbackQuery query)
    {
        if (query.Data == "_prophet")
        {
            _sectionName = query.Data;
            _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Bu bo'limda siz payg'ambarimiz Muhammad Mustafo Sallallohu alayhi vasallam " +
                "hayotlari haqida to'liq malumotga ega bo'lasiz \nin sha Alloh \n");

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: aboutProphet1,
                replyMarkup: Prophet1);
        }

        else if (query.Data == "_alphabet")
        {
            _sectionName = query.Data;
            _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: $" Qur'on arab tilida nozil bo'lgan " +
                    "va albatta musxafni asl tilida o'qish eng katta savoblardan biri hisoblanadi." +
                    " Bu bo'limda siz Arab harflarini o'rganishingiz mumkin");

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: alphabetText1,
                replyMarkup: Lesson1);
        }

    }
}