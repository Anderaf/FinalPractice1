namespace FinalPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sender sender = new Sender();

            try
            {
                while (true)
                {
                    Console.Write("Введите ссылку: ");
                    string url = Console.ReadLine();

                    Console.Write("Введите команду(info, download): ");
                    switch (Console.ReadLine())
                    {
                        case "info":
                            sender.SetCommand(new VideoTitleAndDescriptionCommand(url, new YoutubeVideoGetter()));
                            sender.Run();
                            break;
                        case "download":
                            sender.SetCommand(new VideoDownloadCommand(url, $"video.mpeg", new YoutubeVideoGetter()));
                            sender.Run();
                            break;
                        default:
                            Console.WriteLine("Неверная команда \n");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}