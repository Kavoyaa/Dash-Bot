using System;
using System.Threading.Tasks;

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

using Newtonsoft.Json;

public class AnimalsModule : BaseCommandModule
{
    [Command("dog")]
    [Description("Shows a random dog picture!")]
    public async Task Dog(CommandContext ctx)
    {
        dynamic response = await AnimalsModule.MakeRequest("https://dog.ceo/api/breeds/image/random");
        await ctx.RespondAsync(response.message.ToString());
    }

    public static async Task<dynamic> MakeRequest(string url)
    {
        using var client = new HttpClient();

        var result = await client.GetStringAsync(url);
        dynamic json = JsonConvert.DeserializeObject(result);
        return json;
    }
}
