using System;
using video;
using comment;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video vid = new Video();
        Comment com = new Comment();

        string title, author, name, text;
        int secon;

        vid._author = "PewDiePie";
        vid._title = "I Drew Every Day for 365 Days..... *it was painful*";
        vid._length = 1011;

        com._name = "KimiOmega";
        com._text = "He's even hit the point where 'the more you learn, the more you realize you don't know much', that's so good lol";
        vid._comments.Add(com);
        com = new Comment();

        com._name = "nicksuperheroart";
        com._text = "'I'm never gonna draw this good ever again' feeling is all too familiar for us artists pewds, great job sticking it for a year man!";
        vid._comments.Add(com);
        com = new Comment();

        com._name = "mel4416";
        com._text = "There's something so humbling about this. Taking one step forward and simultaneously three steps back, but still keeping at it... So happy to see Felix continuing this series :,)";
        vid._comments.Add(com);
        com = new Comment();


        videos.Add(vid);
        vid = new Video(); 

        vid._author = "Coldplay";
        vid._title = "Coldplay - The Scientist (Official 4K Video)";
        vid._length = 265;

        com._name = "Asad_.";
        com._text = "Dear stranger.... You have a great taste in music..... See you again after 20 yrs.";
        vid._comments.Add(com);
        com = new Comment();

        com._name = "ralstills";
        com._text = "I can’t explain it, but this song makes me feel so… human. Like, all of the highs and lows, the smiles and frowns, the mads and sads. It’s all captured so beautifully in this song.";
        vid._comments.Add(com);
        com = new Comment();

        com._name = "jacobalva7191";
        com._text = "when you're already sad, but you come here to get even more sadder. feels good man";
        vid._comments.Add(com);
        com = new Comment();


        videos.Add(vid);
        vid = new Video();

        vid._author = "piyoasdf";
        vid._title = "¡TAG de los 15 DIBUJOS! Recorriendo mis sketchbooks ";
        vid._length = 1355;

        com._name = "elizabeth1525";
        com._text = "7:20 Si haz hecho un dibujo en colaboración Piyo!! con Meri y Cristian Cermeño!";
        vid._comments.Add(com);
        com = new Comment();

        com._name = "Kurisuchannel22";
        com._text = "Re sii necesito más dibujos de Pollito humanizadooo";
        vid._comments.Add(com);
        com = new Comment();

        com._name = "angelgz9730";
        com._text = "El de las flores es icónico, tanto tiempo sin verlo me trajo nostalgia, esta hermoso";
        vid._comments.Add(com);
        com = new Comment();


        videos.Add(vid);
        vid = new Video();



        foreach (Video v in videos)
        {
            v.ShowVideo();
        }


    }
}