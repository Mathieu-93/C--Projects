using System;

namespace ex1
{
    class Album
    {
        public Album(){album_ = "Unknown";artist_= "Unknown";date_ =0;track_=0;licznik_++;}
        public Album(string album_,int date_)
        {
            this.album_=album_;
            this.date_= date_;
            licznik_++;
        }
        public Album(int track_)
        {
           if (track_<0){ Console.WriteLine("The number of track is negative!");}
           else{this.track_=track_;} 
           licznik_++;
        }

        private string album_,artist_;
        

        public string nameOfAlbum{
            get{return album_;}
            set{album_= value;}
        }
        public string nameOfArtist{
            get{return artist_;}
            set{artist_= value;}
        }
        private int track_,date_;
        public static int licznik_;

        public int nameOfTrack{
            get{return track_;}
            set{track_= value;}
        }
        public int nameOfDate{
            get{return date_;}
            set{date_= value;}
        }
        public void ShowAlbumInfo()
        {
            Console.WriteLine("Album: " + nameOfAlbum + " Artist:" + nameOfArtist + " :date(" + nameOfDate + ")\n" + "nr.track:" + nameOfTrack);
        }

        public static int HowManyAlbums(){ return licznik_; }

        public static int ClearAlbumCounter(){ return licznik_ =0; }
        
    }


}