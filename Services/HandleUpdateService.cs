using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Examples.WebHook.Services;

public partial class HandleUpdateService
{
    private readonly ITelegramBotClient _botClient;
    private readonly ILogger<HandleUpdateService> _logger;

    public HandleUpdateService(ITelegramBotClient botClient, ILogger<HandleUpdateService> logger)
    {
        _botClient = botClient;
        _logger = logger;
    }

    public async Task EchoAsync(Update update)
    {
        var handler = update.Type switch
        {
            UpdateType.Message => MessageHandler(update.Message!),
            UpdateType.CallbackQuery => HandleCallbackQueryAsync(_botClient, update.CallbackQuery),
            UpdateType.ChannelPost => HandleChannelPostAsync(_botClient, update.ChannelPost),
            _ => UnknownUpdateHandlerAsync(update)
        };

        try
        {
            await handler;
        }
#pragma warning disable CA1031
        catch (Exception exception)
#pragma warning restore CA1031
        {
            await HandleErrorAsync(exception);
        }
    }

    // private async Task HandleCallbackQueryAsync(CallbackQuery callbackQuery)
    // {
    //     await _botClient.AnswerCallbackQueryAsync(
    //         callbackQueryId: callbackQuery.Id,
    //         text: $"Received {callbackQuery.Data}");

    //     await _botClient.SendTextMessageAsync(
    //         chatId: callbackQuery.Message!.Chat.Id,
    //         text: $"Received {callbackQuery.Data}");
    // }

    #region Inline Mode

    #endregion

    private Task UnknownUpdateHandlerAsync(Update update)
    {
        _logger.LogInformation("Unknown update type: {UpdateType}", update.Type);
        return Task.CompletedTask;
    }

    public Task HandleErrorAsync(Exception exception)
    {
        var ErrorMessage = exception switch
        {
            ApiRequestException apiRequestException => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        _logger.LogInformation("HandleError: {ErrorMessage}", ErrorMessage);
        return Task.CompletedTask;
    }

}
