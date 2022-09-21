using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
 private async Task HandleVideoQuranAsync(ITelegramBotClient botClient,CallbackQuery query)
    {
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

        var root = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(root, "Resources/img1-40.png");

        var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

        using var stream = new MemoryStream(bytes);

        await botClient.SendPhotoAsync(
            query.Message.Chat.Id,
            photo: stream,
            replyMarkup: buttonsVideo1);
    }
}
