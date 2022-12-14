using Telegram.Bot.Types;

namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
   private async Task MessageHandler(Message message)
    {
        _logger.LogInformation("Receive message type: {MessageType}", message.Type);

        _logger.LogInformation("From: {from.Firstname} : {message.Text}   ", message.From?.FirstName, message.Text);

        if (message.Text == "/start")
        {
            await _botClient.ForwardMessageAsync(
                chatId: message.Chat.Id,
                fromChatId: -1001407276572,
                508);


            await _botClient.SendTextMessageAsync(
                message.Chat.Id,
                text: $"āŖļø \t\t\t\t\t\t\t\t\t\t {message.From?.FirstName ?? "š»"} \t\t\t\t\t\t\t\t\t\t  āŖļø   \n\n" +
                    "šæ Qur'on tingla botga  xush kelibsiz! \n\nš Bo'limni tanlang  š",
                replyMarkup: selectSection);

        }
        else if (message.Text == "/change")
        {
            await _botClient.SendTextMessageAsync(
               message.Chat.Id,
               text: $"š Bo'limni tanlang  š",
               replyMarkup: selectSection);

            await _botClient.DeleteMessageAsync(
                message.Chat.Id,
                message.MessageId);
        }
        else
        {
            await _botClient.SendTextMessageAsync(
                message.Chat.Id,
                text: "Iltimos, yuqorida ko'rsatilgan tugmalardan birini bosing");
        }
        // if (message.Type != MessageType.Text)
        //     return;

        // var action = message.Text!.Split(' ')[0] switch
        // {
        //     // "/inline"   => SendInlineKeyboard(_botClient, message),
        //     // "/keyboard" => SendReplyKeyboard(_botClient, message),
        //     // "/remove"   => RemoveKeyboard(_botClient, message),
        //     // "/photo"    => SendFile(_botClient, message),
        //     // "/request"  => RequestContactAndLocation(_botClient, message),
        //     // _           => Usage(_botClient, message)



        // // };
        // Message sentMessage = await action;
        // _logger.LogInformation("The message was sent with id: {SentMessageId}", sentMessage.MessageId);

        // Send inline keyboard
        // You can process responses in BotOnCallbackQueryReceived handler
        // static async Task<Message> SendInlineKeyboard(ITelegramBotClient bot, Message message)
        // {
        //     await bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

        //     // Simulate longer running task
        //     await Task.Delay(500);

        //     InlineKeyboardMarkup inlineKeyboard = new(
        //         new[]
        //         {
        //             // first row
        //             new []
        //             {
        //                 InlineKeyboardButton.WithCallbackData("1.1", "11"),
        //                 InlineKeyboardButton.WithCallbackData("1.2", "12"),
        //             },
        //             // second row
        //             new []
        //             {
        //                 InlineKeyboardButton.WithCallbackData("2.1", "21"),
        //                 InlineKeyboardButton.WithCallbackData("2.2", "22"),
        //             },
        //         });

        //     return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
        //                                           text: "Choose",
        //                                           replyMarkup: inlineKeyboard);
        // }

        // static async Task<Message> SendReplyKeyboard(ITelegramBotClient bot, Message message)
        // {
        //     ReplyKeyboardMarkup replyKeyboardMarkup = new(
        //         new[]
        //         {
        //                 new KeyboardButton[] { "1.1", "1.2" },
        //                 new KeyboardButton[] { "2.1", "2.2" },
        //         })
        //         {
        //             ResizeKeyboard = true
        //         };

        //     return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
        //                                           text: "Choose",
        //                                           replyMarkup: replyKeyboardMarkup);
        // }

        // static async Task<Message> RemoveKeyboard(ITelegramBotClient bot, Message message)
        // {
        //     return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
        //                                           text: "Removing keyboard",
        //                                           replyMarkup: new ReplyKeyboardRemove());
        // }

        // static async Task<Message> SendFile(ITelegramBotClient bot, Message message)
        // {
        //     await bot.SendChatActionAsync(message.Chat.Id, ChatAction.UploadPhoto);

        //     const string filePath = @"Files/tux.png";
        //     using FileStream fileStream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        //     var fileName = filePath.Split(Path.DirectorySeparatorChar).Last();

        //     return await bot.SendPhotoAsync(chatId: message.Chat.Id,
        //                                     photo: new InputOnlineFile(fileStream, fileName),
        //                                     caption: "Nice Picture");
        // }

        // static async Task<Message> RequestContactAndLocation(ITelegramBotClient bot, Message message)
        // {
        //     ReplyKeyboardMarkup RequestReplyKeyboard = new(
        //         new[]
        //         {
        //             KeyboardButton.WithRequestLocation("Location"),
        //             KeyboardButton.WithRequestContact("Contact"),
        //         });

        //     return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
        //                                           text: "Who or Where are you?",
        //                                           replyMarkup: RequestReplyKeyboard);
        // }

        // static async Task<Message> Usage(ITelegramBotClient bot, Message message)
        // {
        //     const string usage = "Usage:\n" +
        //                          "/inline   - send inline keyboard\n" +
        //                          "/keyboard - send custom keyboard\n" +
        //                          "/remove   - remove custom keyboard\n" +
        //                          "/photo    - send a photo\n" +
        //                          "/request  - request location or contact";

        //     return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
        //                                           text: usage,
        //                                           replyMarkup: new ReplyKeyboardRemove());
        // }

    }

}