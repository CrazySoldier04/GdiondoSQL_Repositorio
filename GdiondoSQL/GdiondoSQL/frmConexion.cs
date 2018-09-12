using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GdiondoSQL
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private int _imageIndex;
        private String _etiqueta;
        MySqlConnection cn;

        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }

        public String Etiqueta
        {
            get { return _etiqueta; }
            set { _etiqueta = value; }
        }

        public frmConexion(String etiqueta, int imageIndex)
        {
            this.Etiqueta = etiqueta;
            this.ImageIndex = imageIndex;
        }

        public override string ToString()
        {
            return Etiqueta;
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxConexion_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index >= 0)
            {
                if (e.Index < listImages.Images.Count)
                {
                    Image img = new Bitmap(listImages.Images[e.Index], new Size(24, 24));
                    e.Graphics.DrawImage(img, new PointF(e.Bounds.Left, e.Bounds.Top));
                }
                if (e.Index == 0)
                {
                    e.Graphics.DrawString(string.Format("MySql", e.Index), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
                }
                else if (e.Index == 1)
                {
                    e.Graphics.DrawString(string.Format("SqlServer", e.Index), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
                }
                else if (e.Index == 2)
                {
                    e.Graphics.DrawString(string.Format("Sql Lite", e.Index), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
                }
                else if (e.Index == 3)
                {
                    e.Graphics.DrawString(string.Format("Postgres", e.Index), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
                }
                else if (e.Index == 4)
                {
                    e.Graphics.DrawString(string.Format("RavenDB", e.Index), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
                }
                else if (e.Index == 5)
                {
                    e.Graphics.DrawString(string.Format("MongoDB", e.Index), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
                }

            }
        }

        private void cbxConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (cbxConexion.SelectedIndex == 0)
            {
                txtHost.Text = "127.0.0.1";
                txtUsuario.Text = "root";
                txtPuerto.Text = "3306";
            }
            else if (cbxConexion.SelectedIndex == 1)
            {
                txtHost.Text = "";
                txtUsuario.Text = "sa";
                txtPuerto.Text = "1433";
            }
            else if (cbxConexion.SelectedIndex == 2)
            {
                txtHost.Text = "";
                txtUsuario.Text = "";
                txtPuerto.Text = "";
            }
            else if (cbxConexion.SelectedIndex == 3)
            {
                txtHost.Text = "";
                txtUsuario.Text = "postgres";
                txtPuerto.Text = "5432";
            }
            else if (cbxConexion.SelectedIndex == 4)
            {
                txtHost.Text = "";
                txtUsuario.Text = "";
                txtPuerto.Text = "9090";
            }
            else if (cbxConexion.SelectedIndex == 5)
            {
                txtHost.Text = "";
                txtUsuario.Text = "";
                txtPuerto.Text = "27017";
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmConexion_Load(object sender, EventArgs e)
        {
            cbxConexion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxConexion.DrawMode = DrawMode.OwnerDrawFixed;
            cbxConexion.Items.AddRange(Enumerable.Repeat<string>("", listImages.Images.Count).ToArray());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cbxConexion.SelectedIndex == 0)
            {
                cn = new MySqlConnection("server=" + txtHost.Text + ";port=" + txtPuerto.Text + ";uid=" + txtUsuario.Text + ";pwd=" + txtPwd.Text +  ";database=" + txtBaseDeDatos.Text + ";");
                cn.Open();
                MessageBox.Show("holis");
                cn.Close();
            }
        }
    }
}
