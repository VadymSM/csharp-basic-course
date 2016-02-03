using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class Song
    {
        private string _author;
        private string _album;
        private int _time;
        private int _rating;

        public Song(string author, string album, int time, int rating)
        {
            _author = author;
            _album = album;
            _time = time;
            _rating = rating;
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public override string ToString()
        {
            return _author + " " + _album + " " + _time + " " + _rating;
        }
    }
    

}
