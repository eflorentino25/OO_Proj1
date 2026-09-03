namespace OO_Proj1
{
    public partial class Form1 : Form
    {
        int gv_deltax = 1,gv_deltay = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void S1_PBOX_MAIN_Click(object sender, EventArgs e)
        {

        }

        private void S1_TM_UPD_Tick(object sender, EventArgs e)
        {
            S1_LBL_XPOS.Text = "X:" + S1_PBOX_MAIN.Location.X.ToString();
            S1_LBL_YPOS.Text = "Y:" + S1_PBOX_MAIN.Location.Y.ToString();

            int lv_ScreenSizeX = this.Size.Width,
                lv_ScreenSizeY = this.Size.Height - 25;

            int lv_ImageSizeX = S1_PBOX_MAIN.Size.Width,
                lv_ImageSizeY = S1_PBOX_MAIN.Size.Height;

            int lv_ImagePosX = S1_PBOX_MAIN.Location.X,
                lv_ImagePosY = S1_PBOX_MAIN.Location.Y;
            // (x,y) da S1_PBOX_MAIN

            lv_ImagePosX = lv_ImagePosX + gv_deltax;
            lv_ImagePosY = lv_ImagePosY + gv_deltay;

            if ((lv_ImagePosX > (lv_ScreenSizeX - lv_ImageSizeX)) || (lv_ImagePosX < 0))
            {
                gv_deltax = -gv_deltax;
            }
            else
            {
                S1_PBOX_MAIN.Location = new Point(lv_ImagePosX, lv_ImagePosY);
            }
            if ((lv_ImagePosY > (lv_ScreenSizeY - lv_ImageSizeY)) || (lv_ImagePosY < 0))
            {
                gv_deltay = -gv_deltay;
            }
            else
            {
                S1_PBOX_MAIN.Location = new Point(lv_ImagePosX, lv_ImagePosY);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            S1_TM_UPD.Start();
        }
    }
}
