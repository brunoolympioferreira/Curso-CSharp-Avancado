namespace _03_Eventos.Lib;

public class VideoEncode
{
    //public delegate void VideoEncodedHandler(Video video);
    //ublic event VideoEncodedHandler Encoded;

    public event EventHandler<VideoEventArgs> Encoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Convertendo o video...");
        Thread.Sleep(2000);
        Console.WriteLine("Video convertido!");

        Encoded(null, new VideoEventArgs() {Video = video });
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
