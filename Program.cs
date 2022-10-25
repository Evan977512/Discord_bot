using Discord;
using Discord.WebSocket;
using Evan_discord_01;

public class Program
{
    static void Main(string[] args) {
        DogShit bot = new();
        bot.Main().GetAwaiter().GetResult();
    }

}



