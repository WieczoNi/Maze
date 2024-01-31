namespace Maze
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer endSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        private void MoveToStart()
        {
            
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_Click(object sender, EventArgs e)
        {

        }
        private void finishLabel_MouseHover(object sender, EventArgs e)
        {

        }
        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            endSoundPlayer.Play();
            MessageBox.Show("Herzlichen Glückwunsch!");
            MoveToStart();
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
            MoveToStart();
        }
    }
}