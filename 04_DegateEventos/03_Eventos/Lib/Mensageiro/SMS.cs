using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _03_Eventos.Lib.VideoEncode;

namespace _03_Eventos.Lib.Mensageiro;
public class SMS
{
    public void EnviarMensagem(object sender, VideoEventArgs args)
    {
        Console.WriteLine("SMS enviado para o video" + args.Video.Nome);
    }
}
