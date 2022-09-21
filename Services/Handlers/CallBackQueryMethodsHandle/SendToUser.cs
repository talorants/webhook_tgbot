using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
    private string _reciterName = "default";
    private string _sectionName = "default";
    private int _surahNumber = 0;

    private async Task HandleSurahNumberAsync(ITelegramBotClient botClient, CallbackQuery query)
    {
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        var text = query.Data.Substring(4, 5);

        _logger.LogInformation($"tanlangan queryni datasi -> {text} ");

        if (text == "audio")
        {
            _logger.LogInformation($" ✅ audio send metodga kirdi  ");

            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 230;

            await SendDataToUser(botClient, query, surahId);
        }
        else if (text == "video")
        {
            _logger.LogInformation($" ✅ video send metodga kirdi ");

            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 110;

            await SendDataToUser(botClient, query, surahId);
        }
        else if (text == "proph")
        {
            _logger.LogInformation($" ✅ siyrat darslari send metodga kirdi ");

            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 600;

            await SendDataToUser(botClient, query, surahId);
        }
        else if (text == "alpha")
        {
            _logger.LogInformation($" ✅ arabAlifbo send metodga kirdi ");

            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 420;

            await SendDataToUser(botClient, query, surahId);
        }

    }

    private async Task SendDataToUser(ITelegramBotClient botClient, CallbackQuery? query, int id)
    {
        _logger.LogInformation($" ✅ {query.Message.Chat.FirstName} ismli userga  channaldan {id} - id dagi message yuborildi ");

        await botClient.ForwardMessageAsync(
           chatId: query.Message.Chat.Id,
           fromChatId: -1001407276572,
           id);
    }
}