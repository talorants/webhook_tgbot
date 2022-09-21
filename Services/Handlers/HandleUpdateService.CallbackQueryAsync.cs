using Telegram.Bot;
using Telegram.Bot.Types;
 
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
      private async Task HandleCallbackQueryAsync(ITelegramBotClient botClient, CallbackQuery? query)
    {
        ArgumentNullException.ThrowIfNull(query);

        var key = query.Data;

        _logger.LogInformation("Received CallbackQuery from {from.FirstName} : {query.Data}", query.From?.FirstName, query.Data);

        var queryValue = query.Data;

        _logger.LogInformation("button is {queryValue}", queryValue);

        var handler = query.Data switch
        {
            "_audioQuran" => HandleAudioQuranAsync(botClient, query ),
            "_videoQuran" => HandleVideoQuranAsync(botClient, query ),
            "_textQuran" or "_arabBook" or "_uzBook" => HandleTextQuranAsync(botClient, query ),
            "_prophet" or "_alphabet" => HandleProphetAndAlphabetAsync(botClient, query ),
            "_nextLesson1" or "_nextLesson2" or "_nextLesson3" => HandleNextAndBackLessons(botClient, query ),
            "_backLesson1" or "_backLesson2" or "_backLesson3" => HandleNextAndBackLessons(botClient, query ),
            "_next1" or "_next2" or "_back1" or "_back2" => HandleViewOfAudioSurahsync(botClient, query ),
            // "_reciters1" or "_reciters2" or "_reciters3" => HandleRecitersAsync(botClient, query ),
            "_nextVideo1" or "_nextVideo2" or "_backVideo1" or "_backVideo2" => HandleViewOfVideoSurahsync(botClient, query ),
            "_nextProphet1" or "_nextProphet2" or "_nextProphet3" => HandleNextAndBackProphet(botClient, query ),
            "_backProphet1" or "_backProphet2" or "_backProphet3" => HandleNextAndBackProphet(botClient, query ),
            _ => HandleSurahNumberAsync(botClient, query)
        };
    }
}