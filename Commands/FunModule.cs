using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

public class FunModule : BaseCommandModule
{
    [Command("say")]
    [Description("Have the bot say something!")]
    public async Task Say(CommandContext ctx, [RemainingText][Description("The message you want the bot to say.")] string text)
    {
        await ctx.Channel.SendMessageAsync(text);
    }

    [Command("hello")]
    [Description("Says hello.")]
    public async Task Hello(CommandContext ctx)
    {
        await ctx.RespondAsync("Hello!");
    }
}
