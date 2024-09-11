using System.Media;

namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int bot = 0;
        int play = 0;
        string[,] arr = new string[3, 3]
        {
            { "Ничья","Игрок","Бот"},
            { "Бот","Ничья","Игрок" },
            { "Игрок","Бот","Ничья" }
        };
        private Bitmap[] image =
        {
            Resource2.png_transparent_sewing_scissors_scissors_technic_sewing_scissors_thumbnail,
            Resource2.pngtree_blue_rock_clip_art_png_image_2689578,
            Resource2.png_transparent_paper_printing_creased_white_paper_texture_angle_white_thumbnail
        };

        private void button1_Click(object sender, EventArgs e)
        {
            
            play = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            play = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bot = new Random().Next(3);
            pictureBox1.Image = image[bot]; 
            label1.Text = arr[bot, play];
        }
    }
}
