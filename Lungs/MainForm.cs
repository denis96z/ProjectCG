using System.Windows.Forms;

namespace Lungs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FileManager fm = new FileManager();
            _Scene = fm.LoadModel("clean.xml");

            _Scene.Light.Position.X = 50;
            _Scene.Light.Position.Y = 10;
            _Scene.Light.Position.Z = -200;
        }

        private Scene _Scene;
        private Screen _Screen;

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            SpotSceneObjectModification m = null;

            switch (e.KeyCode)
            {
                case Keys.Add:
                    m = new VertexScaling(1.5, 1.5, 1.5);
                    break;

                case Keys.Subtract:
                    m = new VertexScaling(0.75, 0.75, 0.75);
                    break;

                case Keys.X:
                    m = new VertexRotationOX(System.Math.PI / 6);
                    break;

                case Keys.Y:
                    m = new VertexRotationOY(System.Math.PI / 6);
                    break;

                case Keys.Z:
                    m = new VertexRotationOZ(System.Math.PI / 6);
                    break;

                case Keys.U:
                    m = new VertexMovement(0, 10, 0);
                    break;

                case Keys.D:
                    m = new VertexMovement(0, -10, 0);
                    break;
            }

            _Scene.Model.Modify(m);
            _Screen.DrawScene(_Scene);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _Screen = new Screen(CreateGraphics(),
                ClientSize.Width, ClientSize.Height, progressBar1);
            _Screen.DrawScene(_Scene);
        }
    }
}
