using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PortableclassEvent
{
    public class Band
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string picture;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string twitter;

        public string Twitter
        {
            get { return twitter; }
            set { twitter = value; }
        }

        private string facebook;

        public string Facebook
        {
            get { return facebook; }
            set { facebook = value; }
        }
        private ObservableCollection<Genre> genres;

        public ObservableCollection<Genre> Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        public ObservableCollection<String> genreGetallen;

        public ObservableCollection<String> GenreGetallen
        {
            get { return genreGetallen; }
            set { genreGetallen = value; }
        }

        private int standardGenreGetal;

        public int StandardGenreGetal
        {
            get { return standardGenreGetal; }
            set { standardGenreGetal = value; }
        }

        private int lastID;

        public int LastID
        {
            get { return lastID; }
            set { lastID = value; }
        }
    }
}
