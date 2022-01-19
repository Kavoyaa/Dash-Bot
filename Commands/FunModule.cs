using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

public class FunModule : BaseCommandModule
{
    [Command("say")]
    public async Task Say(CommandContext ctx, [RemainingText] string text)
    {
        await ctx.Channel.SendMessageAsync(text);
    }

    [Command("hello")]
    public async Task Hello(CommandContext ctx)
    {
        await ctx.RespondAsync("Hello!");
    }
}
