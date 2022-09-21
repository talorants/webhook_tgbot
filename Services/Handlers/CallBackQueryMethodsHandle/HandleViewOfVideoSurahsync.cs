
using Telegram.Bot;
using Telegram.Bot.Types;
 
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{  
 private async Task HandleViewOfVideoSurahsync(ITelegramBotClient botClient, CallbackQuery query)
    {
        if (query.Data == "_nextVideo1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo2 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_nextVideo2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img81-114.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath );

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo3 );
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_backVideo1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img1-40.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath );

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo1 );
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_backVideo2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo2 );
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }

    }
}