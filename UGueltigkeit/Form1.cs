namespace UGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal X = 0;

        private void CmdErhoeheXY_Click(object sender, EventArgs e)
        {
            decimal y = 0;
            y += 0.1m;
            X += 0.1m;

            LblAnzeige.Text = 
                $"x : {X}\n" +
                $"y : {y}";
        }

        private void CmdErhoeheXZ_Click(object sender, EventArgs e)
        {
            decimal z = 0;
            z += 0.1m;
            X += 0.1m;

            LblAnzeige.Text = 
                $"x : {X}\n" +
                $"z : {z}";
        }
    }
}