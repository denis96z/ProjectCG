using System;
using System.Windows.Forms;

namespace Lungs
{
    public partial class MainForm : Form
    {
        private Scene _Scene;
        private Model _Model1, _Model2;
        private Screen _Screen;
        private Nicotine _Nicotine;

        double t = 0;

        public MainForm()
        {
            InitializeComponent();
            _Scene = new Scene();

            Constants.MOVEMENT_DISTANCE = 5;
            Constants.ROTATION_ANGLE = Math.PI / 6;
            Constants.SCALING_COEFFICIENT_IN = 1.5;
            Constants.SCALING_COEFFICIENT_OUT = 0.7;
        }

        private void _OpenMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FileManager fm = new FileManager();

                    _Model1 = fm.LoadModel(_FolderBrowserDialog.SelectedPath + @"\clean.xml");
                    _Model2 = fm.LoadModel(_FolderBrowserDialog.SelectedPath + @"\dirty.xml");

                    _Nicotine = new Nicotine(_Model1, 0, _Model2, 24);

                    _Scene.Model = _Nicotine.Smoke(0.01);

                    _Screen = new Screen(pictureBox1.CreateGraphics(),
                        pictureBox1.Width, pictureBox1.Height, _ProgressBar);
                    _Screen.DrawScene(_Scene);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Ошибка!");
            }
        }

        private void ModifyModel(object sender, EventArgs e)
        {
            try
            {
                var mi = (ToolStripMenuItem)sender;
                SpotSceneObjectModification m = null;

                switch (mi.Name)
                {
                    case "_ModelRotationOXMI":
                        m = new VertexRotationOX(Constants.ROTATION_ANGLE);
                        break;

                    case "_ModelRotationOYMI":
                        m = new VertexRotationOY(Constants.ROTATION_ANGLE);
                        break;

                    case "_ModelRotationOZMI":
                        m = new VertexRotationOZ(Constants.ROTATION_ANGLE);
                        break;

                    case "_ModelScalingInMI":
                        m = new VertexScaling(Constants.SCALING_COEFFICIENT_IN,
                            Constants.SCALING_COEFFICIENT_IN, Constants.SCALING_COEFFICIENT_IN);
                        break;

                    case "_ModelScalingOutMI":
                        m = new VertexScaling(Constants.SCALING_COEFFICIENT_OUT,
                            Constants.SCALING_COEFFICIENT_OUT, Constants.SCALING_COEFFICIENT_OUT);
                        break;

                    default:
                        return;
                }

                _Model1.Modify(m);
                _Model2.Modify(m);
                _Scene.Model.Modify(m);
                _Screen.DrawScene(_Scene);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Ошибка!");
            }
        }

        private void Smoke(object sender, EventArgs e)
        {
            double t = _SmokingTimeTB.Value;

            if (_SmokingTimeTB.Value == 0)
            {
                t = 0.01;
            }

            _Scene.Model = _Nicotine.Smoke(t);
            _Screen.DrawScene(_Scene);
        }

        private void ModifyLight(object sender, EventArgs e)
        {
            try
            {
                var mi = (ToolStripMenuItem)sender;
                SpotSceneObjectModification m = null;

                switch (mi.Name)
                {
                    case "_LightMovementRightMI":
                        m = new LightMovement(Constants.MOVEMENT_DISTANCE, 0, 0);
                        break;

                    case "_LightMovementLeftMI":
                        m = new LightMovement(-Constants.MOVEMENT_DISTANCE, 0, 0);
                        break;

                    case "_LightMovementUpMI":
                        m = new LightMovement(0, -Constants.MOVEMENT_DISTANCE, 0);
                        break;

                    case "_LightMovementDownMI":
                        m = new LightMovement(0, Constants.MOVEMENT_DISTANCE, 0);
                        break;

                    case "_LightMovementForwardMI":
                        m = new LightMovement(0, 0, Constants.MOVEMENT_DISTANCE);
                        break;

                    case "_LightMovementBackMI":
                        m = new LightMovement(0, 0, -Constants.MOVEMENT_DISTANCE);
                        break;

                    default:
                        return;
                }

                _Scene.Light.Modify(m);
                _Screen.DrawScene(_Scene);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Ошибка!");
            }
        }
    }
}
