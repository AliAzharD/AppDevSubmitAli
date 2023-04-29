using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W7_Ali_Azhar_D
{
    class playingTime
    {
        private string time;
        private bool[,] myArray = new bool[10, 10];

        public playingTime(string time, bool[,] myArray)
        {
            this.time = time;
            this.myArray = myArray;
        }

        public void setTime(string time) { this.time = time; }
        public string getTime() { return this.time; }
        public bool[,] getArrayKursi() { return this.myArray; }
        public void setArrayKursi(bool[,] array) { this.myArray = array; }
    }

    internal class Classmovie
    {
       

        //AliAzharD Project//
        private string JudulMovie;
        private string ImageMovie;
        private string DescriptionMovie;
        private List <playingTime> PlayingTime = new List <playingTime> ();
       
        public Classmovie(string judulMovie, string imageMovie, string descriptionMovie, List<playingTime> playingTime)
        {
            this.JudulMovie = judulMovie;
            this.ImageMovie = imageMovie;
            this.DescriptionMovie = descriptionMovie;
            this.PlayingTime = playingTime;
        }

        public void SetJudulMovie(string judul)
        {
            this.JudulMovie = judul;
        }
        public string getJudulMovie()
        {
            return this.JudulMovie;
        }

        public void setImageMovie(string url)
        {
            this.ImageMovie = url;
        }
        public string getlImageMovie()
        {
            return this.ImageMovie;
        }

        public void setDescriptionMovie(string desc)
        {
            this.DescriptionMovie = desc;
        }
        public string getDescMovie()
        {
            return this.DescriptionMovie;
        }

        public void setPlayingTime(playingTime playingTime)
        {
            this.PlayingTime.Add(playingTime);
        }
        public List <playingTime> getPlayingTime()
        {
            return this.PlayingTime;
        }
    }
    

}
