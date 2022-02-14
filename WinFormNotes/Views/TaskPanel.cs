using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNotes.Views
{
    public partial class TaskPanel : UserControl
    {
        bool initializing = true; //Variable que indica si el UserControl se esta generando
        private readonly Container container;

        public TaskPanel(Container _container)
        {
            container = _container;
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        //Eventos
        private void TaskPanel_Load(object sender, EventArgs e)
        {
            initializing = false;
            grdSetup();
            AsideClean();
            AsideEnabled(false);
        }

        private void grd_Resize(object sender, EventArgs e)
        {
            grdColResize();
        }

        private void TspBtnNew_Click(object sender, EventArgs e)
        {
            AsideClean();
            AsideEnabled(true);
        }

        private void ChkDateLimit_CheckedChanged(object sender, EventArgs e)
        {
            DtpLimit.Enabled = ChkDateLimit.Checked;
        }

        private void TspBtnSave_Click(object sender, EventArgs e)
        {
            TaskSaveUpdate();
        }

        private void TspBtnDiscard_Click(object sender, EventArgs e)
        {
            AsideClean();
            AsideEnabled(false);
        }

        //Metodos
        /// <summary>
        /// Configuracion de la grilla, estilos, columnas, comportamiento, etc.
        /// </summary>
        private void grdSetup()
        {
            //Apariencia general
            grd.Font = new Font("Century Gothic", 11);
            grd.BackgroundColor = Color.White;
            grd.BorderStyle = BorderStyle.None;
            grd.RowHeadersVisible = false;
            grd.ReadOnly = true;
            grd.AllowUserToResizeColumns = false;
            grd.AllowUserToResizeRows = false;
            grd.AllowUserToAddRows = false;

            //Apariencia ColumnHeaders
            grd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grd.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            grd.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            grd.EnableHeadersVisualStyles = false;

            //Columnas
            grd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id",
                HeaderText = "ID",
                Visible = false,
            });
            grd.Columns.Add(new DataGridViewTextBoxColumn() 
            { 
                Name = "category",
                HeaderText = "Categoria",
            });
            grd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "task",
                HeaderText = "Tarea",
            });
            grd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "state",
                HeaderText = "Estado",
            });
            grd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "date_start",
                HeaderText = "Fecha Asignacion",
            });
            grd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "time_rest",
                HeaderText = "Tiempo restante (dias)",
            });
            grd.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "date_end",
                HeaderText = "Fecha de Entrega",
            });

            grdColResize();
        }

        /// <summary>
        /// Configura la estetica y contenido del panel Aside.
        /// </summary>
        private void AsideClean()
        {
            TspBtnNew.Visible = true;
            TspBtnModify.Visible = false;
            TspBtnDelete.Enabled = false;

            CbCategory.Items.Clear();
            CbCategory.Items.Add("Power Installer Toolkit");

            TbTaskContent.Text = "";

            CbState.Items.Clear();
            CbState.Items.Add("Sin Empezar");
            CbState.Items.Add("En Curso");
            CbState.Items.Add("Pausado");
            CbState.Items.Add("Omitida");
            CbState.Items.Add("Completa");

            ChkDateLimit.Checked = false;
            DtpStart.Value = DateTime.Now;
            DtpLimit.Value = DateTime.Now;
        }

        /// <summary>
        /// Redimenciono las columnas calculando el ancho del DataGridView
        /// </summary>
        private void grdColResize()
        {
            if (initializing) return;

            grd.Columns["category"].Width = 200;
            grd.Columns["state"].Width = 100;
            grd.Columns["date_start"].Width = 100;
            grd.Columns["time_rest"].Width = 100;
            grd.Columns["date_end"].Width = 100;

            grd.Columns["task"].Width = grd.Width - 601;
        }

        /// <summary>
        /// Habilita o Inhabilita los controles del PnlAside
        /// </summary>
        private void AsideEnabled(bool Enabled)
        { 
            CbCategory.Enabled = Enabled;
            TbTaskContent.Enabled = Enabled;
            CbState.Enabled = Enabled;
            DtpStart.Enabled = Enabled;
            ChkDateLimit.Enabled = Enabled;
            DtpLimit.Enabled = ChkDateLimit.Checked && Enabled;
            TspBtnSave.Enabled = Enabled;
            TspBtnDiscard.Enabled = Enabled;
        }

        private void TaskSaveUpdate()
        {
            MessageBox.Show("Funcion sin terminar");
        }
    }
}
