﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;

using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;

using Newtonsoft.Json;

namespace Dash
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var configJsonData = string.Empty;

            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                configJsonData = await sr.ReadToEndAsync().ConfigureAwait(false);

            var configJson = JsonConvert.DeserializeObject<ConfigJson>(configJsonData);

            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                Intents = DiscordIntents.AllUnprivileged
            });

            var commands = discord.UseCommandsNext(new CommandsNextConfiguration() { StringPrefixes = new[] { configJson.Prefix } });

            commands.RegisterCommands<FunModule>();
            commands.RegisterCommands<InfoModule>();
            commands.RegisterCommands<UtilityModule>();
            commands.RegisterCommands<AnimalsModule>();

            discord.Ready += OnReady;

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        private static Task OnReady(DiscordClient s, ReadyEventArgs e)
        {
            Console.WriteLine("Bot online!");
            return Task.CompletedTask;
        }
    }
}
