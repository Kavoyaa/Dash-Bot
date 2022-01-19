using System;
using System.Threading.Tasks;

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

public class InfoModule : BaseCommandModule
{
    [Command("ping")]
    public async Task Ping(CommandContext ctx)
    {
        await ctx.Channel.SendMessageAsync($"🏓 | ...pong! In {ctx.Client.Ping}ms.");
    }
}
