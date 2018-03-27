using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstChallenge.Models
{
    public class ComicBookManager
    {
        public static List<ComicBook> GetComicBooks() {
            return new List<ComicBook> {
                new ComicBook {ComicBookId=1, ComicTitle="Ultimate Spider-Man", EpisodeNumber=32, EpisodeTitle="Knock Knock It's Doc Ock", Characters = new List<Character>{ new Character { CharacterId=1, Name="Spider-Man" }}},
                new ComicBook {ComicBookId=2, ComicTitle="Old Man Wolverine", EpisodeNumber=13, EpisodeTitle="Fight", Characters = new List<Character>{new Character {CharacterId=2, Name="Wolverine" }, new Character {CharacterId=1, Name="Spider-Man"}}},
                new ComicBook {ComicBookId=3, ComicTitle="Deadpool", EpisodeNumber=17, EpisodeTitle="Do These Tights Make My Ass Look Fat?", Characters= new List<Character>{new Character {CharacterId=3, Name="Deadpool" }}}
            };
        }
    }

    public class ComicBook
    {
        public int ComicBookId { get; set; }
        public string ComicTitle { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeTitle { get; set; }
        public List<Character> Characters { get; set; }
    }

    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
    }
}