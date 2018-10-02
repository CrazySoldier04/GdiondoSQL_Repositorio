using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdiondoSQL
{
    public partial class frmDataBases : Form
    {
        public frmDataBases()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            dgvInfo.Columns.Clear();
            dgvInfo.DataSource = tablas.TodosLosCampos(treeView1.SelectedNode.Text);
        }

        MySql tablas = new MySql(frmConexion.host, frmConexion.puerto, frmConexion.user, frmConexion.pwd, frmConexion.database);

        private void frmDataBases_Load(object sender, EventArgs e)
        {
            tablas.Databases();
            foreach (String item in MySql.lista)
            {
                TreeNode nodo = new TreeNode(item);
                tablas.Tables(item);
                foreach (String tablas in MySql.listaTablas)
                {
                    nodo.Nodes.Add(tablas);
                }
                treeView1.Nodes.Add(nodo);
            }
        }

        private void pnlCerrar_Paint(object sender, PaintEventArgs e)
        {
            //Close();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //CargarDatos();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CargarDatos();
        }
    }
}
