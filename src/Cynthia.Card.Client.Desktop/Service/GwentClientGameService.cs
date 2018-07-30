using System;
using System.Linq;
using System.Threading.Tasks;
using Alsein.Utilities.LifetimeAnnotations;
using Cynthia.Card.Common;

namespace Cynthia.Card.Client
{
    [Transient]
    public class GwentClientGameService
    {
        private GwentLocalPlayer _player;
        public async Task Play(GwentLocalPlayer player)
        {
            _player = player;
            Console.WriteLine("开始游戏");
            var op1 = await _player.ReceiveFromUpstreamAsync();
            Console.WriteLine("已接收到第一个指令");
            var op2 = await _player.ReceiveFromUpstreamAsync();
            Console.WriteLine("已接收到第二个指令");
            var op3 = await _player.ReceiveFromUpstreamAsync();
            Console.WriteLine("已接收到第三个指令");
        }
    }
}