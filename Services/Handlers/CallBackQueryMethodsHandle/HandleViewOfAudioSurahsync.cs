using Telegram.Bot;
using Telegram.Bot.Types;
namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
    private async Task HandleViewOfAudioSurahsync(ITelegramBotClient botClient,
                                             CallbackQuery query)
    {
        if (query.Data == "_next1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsOfSurah2 );

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_next2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img81-114.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsOfSurah3 );
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_back1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img1-40.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath );

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsOfSurah1 );
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }
        else if (query.Data == "_back2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsOfSurah2 );
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId );
        }

    }
}