using System;
using System.Threading.Tasks;

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

public class InfoModule : BaseCommandModule
{
    [Command("ping")]
    [Description("Shows the bot's ping/latency.")]
    public async Task Ping(CommandContext ctx)
    {
        await ctx.Channel.SendMessageAsync($"🏓 | ...pong! In {ctx.Client.Ping}ms.");
    }
}
