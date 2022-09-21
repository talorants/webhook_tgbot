using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
    private async Task HandleAudioQuranAsync(ITelegramBotClient botClient, CallbackQuery query)
    {
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

        // await botClient.SendTextMessageAsync(
        //     query.Message.Chat.Id,
        //     text: "Qaysi 👳🏻‍♂️ qorining qiroatini tinglamoqchisiz?",
        //     replyMarkup: reciters );

        var root = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(root, "Resources/img1-40.png");

        var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

        using var stream = new MemoryStream(bytes);

        await botClient.SendPhotoAsync(
            query.Message.Chat.Id,
            photo: stream,
            replyMarkup: buttonsOfSurah1);

    }
}