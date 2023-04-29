using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Ali_Azhar_D
{
    public partial class Form1 : Form
    {
        private static List<Classmovie> daftarMovies = new List<Classmovie>();
        public bool[,] RandomKursi()
        {
            Random random = new Random();
            int kursiKosong = random .Next(30, 80);
            bool[,] myArray = new bool[10, 10];

            while (kursiKosong != 0)
            {
                int b = random.Next(0, 10);
                int k = random.Next(0, 10);
                if (myArray[b,k] == false)
                {
                    myArray[b,k] = true;
                    kursiKosong--;
                }
            }
            return myArray;
        }
        public Form1()
        {
            InitializeComponent();


            //Input Data Movie
            List<playingTime> daftarPlayTime = new List<playingTime>();
            playingTime playTime1 = new playingTime("16:00", RandomKursi());
            daftarPlayTime.Add(playTime1);
            playingTime playTime2 = new playingTime("18:00", RandomKursi());
            daftarPlayTime.Add(playTime2);
            playingTime playTime3 = new playingTime("20:00", RandomKursi());
            daftarPlayTime.Add(playTime3);
            

            Classmovie movie1 = new Classmovie("Missing", "Img1", "Film Misteri", daftarPlayTime);
            daftarMovies.Add(movie1);



            List<playingTime> daftarPlayTime2 = new List<playingTime>();

            playingTime playTime4 = new playingTime("16:00", RandomKursi());
            daftarPlayTime2.Add(playTime4);
            playingTime playTime5 = new playingTime("18:00", RandomKursi());
            daftarPlayTime2.Add(playTime5);
            playingTime playTime6 = new playingTime("20:00", RandomKursi());
            daftarPlayTime2.Add(playTime6);
            Classmovie movie2 = new Classmovie("Manifest", "Img2", "Film Misteri", daftarPlayTime2);
            daftarMovies.Add(movie2);


            List<playingTime> daftarPlayTime3 = new List<playingTime>();

            playingTime playTime7 = new playingTime("16:00", RandomKursi());
            daftarPlayTime3.Add(playTime7);
            playingTime playTime8 = new playingTime("18:00", RandomKursi());
            daftarPlayTime3.Add(playTime8);
            playingTime playTime9 = new playingTime("20:00", RandomKursi());
            daftarPlayTime3.Add(playTime9);
            Classmovie movie3 = new Classmovie("Avengers End Game", "Img3", "Film Action", daftarPlayTime3);
            daftarMovies.Add(movie3);


            List<playingTime> daftarPlayTime4 = new List<playingTime>();

            playingTime playTime10= new playingTime("16:00", RandomKursi());
            daftarPlayTime4.Add(playTime10);
            playingTime playTime11 = new playingTime("18:00", RandomKursi());
            daftarPlayTime4.Add(playTime11);
            playingTime playTime12 = new playingTime("20:00", RandomKursi());
            daftarPlayTime4.Add(playTime12);
            Classmovie movie4 = new Classmovie("John Wick Chapter 4", "Img4", "Film Action", daftarPlayTime4);
            daftarMovies.Add(movie4);


            List<playingTime> daftarPlayTime5 = new List<playingTime>();

            playingTime playTime13 = new playingTime("16:00", RandomKursi());
            daftarPlayTime5.Add(playTime13);
            playingTime playTime14 = new playingTime("18:00", RandomKursi());
            daftarPlayTime5.Add(playTime14);
            playingTime playTime15 = new playingTime("20:00", RandomKursi());
            daftarPlayTime5.Add(playTime15);
            Classmovie movie5 = new Classmovie("Lampor (Keranda Terbang)", "Img5", "Film Horror", daftarPlayTime5);
            daftarMovies.Add(movie5);


            List<playingTime> daftarPlayTime6 = new List<playingTime>();

            playingTime playTime16 = new playingTime("16:00", RandomKursi());
            daftarPlayTime6.Add(playTime16);
            playingTime playTime17 = new playingTime("18:00", RandomKursi());
            daftarPlayTime6.Add(playTime17);
            playingTime playTime18 = new playingTime("20:00", RandomKursi());
            daftarPlayTime6.Add(playTime18);
            Classmovie movie6 = new Classmovie("Pocong the Origin", "Img6", "Film Horror", daftarPlayTime6);
            daftarMovies.Add(movie6);


            List<playingTime> daftarPlayTime7 = new List<playingTime>();

            playingTime playTime19 = new playingTime("16:00", RandomKursi());
            daftarPlayTime7.Add(playTime19);
            playingTime playTime20 = new playingTime("18:00", RandomKursi());
            daftarPlayTime7.Add(playTime20);
            playingTime playTime21 = new playingTime("20:00", RandomKursi());
            daftarPlayTime7.Add(playTime21);
            Classmovie movie7 = new Classmovie("Mencuri Raden Saleh", "Img7", "Film Horror", daftarPlayTime7);
            daftarMovies.Add(movie7);


            List<playingTime> daftarPlayTime8 = new List<playingTime>();

            playingTime playTime22 = new playingTime("16:00", RandomKursi());
            daftarPlayTime8.Add(playTime22);
            playingTime playTime23 = new playingTime("18:00", RandomKursi());
            daftarPlayTime8.Add(playTime23);
            playingTime playTime24 = new playingTime("20:00", RandomKursi());
            daftarPlayTime8.Add(playTime24);
            Classmovie movie8 = new Classmovie("Megan", "Img8", "Film Horror & Misteri", daftarPlayTime8);
            daftarMovies.Add(movie8);

            

           
            //Tampilkan Movie


            for (int b = 0; b < daftarMovies.Count; b++)
            {
                // Create a new Image control
                PictureBox picture = new PictureBox();

                // Set the properties of the textbox
                picture.Name = "Img" + b.ToString();

                string imgPath = "C:\\Users\\User\\Pictures\\Folder Gambar\\Img "+b.ToString()+".jpg";
                picture.ImageLocation = imgPath;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Size = new Size(150, 200);
                picture.Location = new Point(50, (100 + b * 250));
                // Add the Label Judul to the form
                this.panel2.Controls.Add(picture);


                ////////Ali Azhar D Copyrights//////////
                // Create a new Label control
                Label label = new Label();
               
                // Set the properties of the textbox
                label.Name = "lbljdl" + b.ToString();
                label.Text = daftarMovies[b].getJudulMovie();
                label.Size = new Size(100, 30);
                label.Font = new Font(label.Font, FontStyle.Bold);
                label.Location = new Point(200, (100 + b * 250));
                // Add the textbox to the form
                this.panel2.Controls.Add(label);
                
                ///////Ali AZHAR D Copyrights/////////


                // Create a new Label Desc control
                Label labeldesc = new Label();

                // Set the properties of the textbox
                labeldesc.Name = "lbldesc" + b.ToString();
                labeldesc.Text = daftarMovies[b].getDescMovie();
                labeldesc.Size = new Size(100, 30);

                labeldesc.Location = new Point(200, (150 + b * 250));

                // Add the textbox to the form
                this.panel2.Controls.Add(labeldesc);


                // Create a new Label Playing Time control
                for (int i = 0; i < daftarMovies[b].getPlayingTime().Count; i++)
                {
                    Button Btnlplay = new Button();

                    // Set the properties of the textbox
                    Btnlplay.Name = "lblPlayTime" + i.ToString();
                    Btnlplay.Text = daftarMovies[b].getPlayingTime()[i].getTime();
                    Btnlplay.Size = new Size(70, 30);
                    
                    Btnlplay.Location = new Point((50 + (i * 75)), (310 + b * 250));
                    Btnlplay.Click += new EventHandler(Btnplay_Click);
                    // Add the textbox to the form
                    this.panel2.Controls.Add(Btnlplay);
                }

                //Create a Button Playing time control
                for (int i = 0; i < daftarMovies[b].getPlayingTime().Count; i++)
                {
                    Button btnplay = new Button();
                    // set the properties of the textbox
                    btnplay.Name = "btnPlayTime"+ i.ToString();
                    btnplay.Text = daftarMovies[b].getPlayingTime()[i].getTime();
                    btnplay.Size = new Size(70, 30);
                    btnplay.Location = new Point((50 + (i * 75)), (310 + b * 250));
                    btnplay.Click += new EventHandler(Btnplay_Click);

                    this.panel2.Controls.Add(btnplay);
                }

                


            }
        }
        private void Btnplay_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Display a message box with an input field and OK/Cancel buttons
            DialogResult dialogResult = MessageBox.Show("Enter Number of Ticket!", "Input Dialog", MessageBoxButtons.OKCancel);

            // If the user clicks the OK button, get the input value and display it
            if (dialogResult == DialogResult.OK)
            {
                string inputTiket = Microsoft.VisualBasic.Interaction.InputBox("Please enter number of tickets", "Input Dialog", "");
                string filterNoMovie = new string(clickedButton.Name.Where(c => Char.IsDigit(c)).ToArray());
                int noMovie = int.Parse(filterNoMovie);
                string playTimeNow = clickedButton.Text;

                foreach (playingTime playingtime in daftarMovies[noMovie / 10].getPlayingTime())
                {
                    if (playTimeNow == playingtime.getTime())
                    {
                        Form2 form2 = new Form2(inputTiket, playTimeNow, playingtime.getArrayKursi());
                        form2.Show();
                    }

                }

            }

        }


        


    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        

       
    

