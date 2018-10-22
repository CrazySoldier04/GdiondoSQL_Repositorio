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

        public frmDataBases(int indice)
        {
            InitializeComponent();
            index = indice;
        }

        private int index;
        MySql tablas = new MySql(frmConexion.host, frmConexion.puerto, frmConexion.user, frmConexion.pwd, frmConexion.database);
        PostgresSql libp = new PostgresSql();

        private void DatosPrincipales()
        {
            try
            {
                if (index == 0)
                {
                    tablas.Databases();
                    foreach (String item in MySql.lista)
                    {
                        TreeNode nodo = new TreeNode(item);
                        nodo.ImageIndex = 0;
                        tablas.Tables(item);
                        foreach (String tablas in MySql.listaTablas)
                        {
                            nodo.Nodes.Add(tablas);
                            nodo.ImageIndex = 1;
                        }
                        treeView1.Nodes.Add(nodo);
                        nodo.ImageIndex = 1;
                    }
                }
                else if(index == 3)
                {
                    libp.Databases();
                    foreach (String item in libp.databases)
                    {
                        TreeNode nodo = new TreeNode(item);
                        nodo.ImageIndex = 0;
                        tablas.Tables(item);
                        foreach (String tablas in libp.tables)
                        {
                            nodo.Nodes.Add(tablas);
                            nodo.ImageIndex = 1;
                        }
                        treeView1.Nodes.Add(nodo);
                        nodo.ImageIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void CargarDatos()
        {
            try
            {
                if (index == 0)
                {
                    dgvInfo.Columns.Clear();
                    dgvInfo.DataSource = tablas.TodosLosCampos(treeView1.SelectedNode.Text);
                }
                else if (index == 3)
                {
                    dgvInfo.Columns.Clear();
                    dgvInfo.DataSource = libp.TodosLosCampos(treeView1.SelectedNode.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmDataBases_Load(object sender, EventArgs e)
        {
            DatosPrincipales();
        }

        private void pnlCerrar_Paint(object sender, PaintEventArgs e)
        {
            //Close();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //treeView1.SelectedNode.ImageIndex = 1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CargarDatos();
        }

        private void pnlCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}