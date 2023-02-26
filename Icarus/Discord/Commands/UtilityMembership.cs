﻿using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.SlashCommands;

using Icarus.Models;

namespace Icarus.Discord.Commands
{
    public partial class Utility
    {
        [DiscordEventHandler("Ready")]
        public static Task OnReady(DiscordClient client, ReadyEventArgs e)
        {
            _ = UpdateMemberList(client);
            return Task.CompletedTask;
        }

        private static async Task UpdateMemberList(DiscordClient client)
        {
            client.Logger.LogInformation("Updating member list...");
            var count = 0;
            var guildId = ulong.Parse(DiscordBotService.Configuration["discord:guild"]);
            var guild = client.Guilds[guildId];

            var context = new DataContext(DiscordBotService.Configuration);

            var loggedMembers = context.Member.Select(m => m.DiscordId).ToList();

            var members = await guild.GetAllMembersAsync();
            client.Logger.LogInformation("Found {memberCount} members.", members.Count);
            foreach (var m in members)
            {
                if (!loggedMembers.Contains(m.Id))
                {
                    var member = new Member()
                    {
                        CreatedAt = DateTime.Now,
                        DiscordId = m.Id,
                    };
                    context.Member.Add(member);
                    client.Logger.LogInformation("Created member: {memberId} - {memberUsername}", m.Id, m.Username);
                    count++;
                }
            }

            await context.SaveChangesAsync();
            client.Logger.LogInformation("Member list update complete. {count} added.", count);
        }
    }
}
