using System;
using Discord;
using Discord.Commands;

namespace Evan_discord_01
{
    public class BasicModule : ModuleBase<SocketCommandContext>
    {

        private int State = 0; 

        /// <summary>
        /// !hi 명령어를 입력했을 때 실행되는 함수
        /// </summary>
        ///

        [Command("영찬")]
        [Alias("ㅇㅊ", "김영찬")] //!안녕 또는 !ㅎㅇ 를 입력해도 실행 가능
        public async Task HelloCommand()
        {
            Random r = new Random();
            int i = r.Next(1, 4);
            string reply = "젊은 친구, 신사답게 행동해.";
            if (i == 1) reply = "쏠 수 있어.";
            else if (i == 2) reply = "예림이 그 패 봐봐. 혹시 장이야?";
            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync(reply);

            //Embed 메시지를 생성할 빌더 인스턴스 생성 
            EmbedBuilder eb = new()
            {
                //Embed 메시지의 속성 설정
                Color = Color.Blue,          // 메시지의 색을 파란색으로 설정
                Title = "Embed 제목",          //Embed의 제목
                Description = "Embed 설명"    //Embed의 설명
            };
            eb.AddField("필드 1", "필드 1 값");      //필드 선언
            eb.AddField("인라인 필드 1", "인라인 필드 1 값", true);    //인라인 필드 선언
            eb.AddField("인라인 필드 2", "인라인 필드 2 값", true);    //인라인 필드 선언

            //await Context.Channel.SendMessageAsync("", false, eb.Build());  //Embed를 빌드하여 메시지 전송
        }

        [Command("시작")]
        public async Task StartCommand()
        {
            if (Database.State == 0)
            {
             
                Database.State = 1;
                await Context.Channel.SendMessageAsync(State + "야구게임을 시작합니다.");

                Random rnd = new Random();
                int firstNum = rnd.Next(10);  
                int SecondNum = rnd.Next(10);   
                int thirdNum = rnd.Next(10);

            }
            else await Context.Channel.SendMessageAsync(State + "야구게임 중입니다.");
        }
    }
}