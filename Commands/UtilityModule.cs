using System;
using System.Threading.Tasks;

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

public class UtilityModule : BaseCommandModule
{
    [Command("uppercase")]
    [Description("Converts the given text to UPPERCASE.")]
    [Aliases("upper")]
    public async Task Uppercase(CommandContext ctx, [RemainingText][Description("The text you want to convert.")] string text)
    {
        await ctx.RespondAsync(text.ToUpper());
    }

    [Command("lowercase")]
    [Description("Converts the given text to lowercase.")]
    [Aliases("lower")]
    public async Task Lowercase(CommandContext ctx, [RemainingText][Description("The text you want to convert.")] string text)
    {
        await ctx.RespondAsync(text.ToLower());
    }
}
