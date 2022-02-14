namespace WinFormNotes.Views
{
    partial class TaskPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbTaskContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.DtpLimit = new System.Windows.Forms.DateTimePicker();
            this.ChkDateLimit = new System.Windows.Forms.CheckBox();
            this.PnlAside = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TspBtnSave = new System.Windows.Forms.ToolStripButton();
            this.TspBtnDiscard = new System.Windows.Forms.ToolStripButton();
            this.TspBtnNew = new System.Windows.Forms.ToolStripButton();
            this.TspBtnModify = new System.Windows.Forms.ToolStripButton();
            this.TspBtnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.PnlAside.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 100);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(504, 300);
            this.grd.TabIndex = 0;
            this.grd.Resize += new System.EventHandler(this.grd_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Tareas";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(504, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 400);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria";
            // 
            // CbCategory
            // 
            this.CbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(10, 46);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(180, 26);
            this.CbCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarea";
            // 
            // TbTaskContent
            // 
            this.TbTaskContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTaskContent.Location = new System.Drawing.Point(10, 96);
            this.TbTaskContent.Multiline = true;
            this.TbTaskContent.Name = "TbTaskContent";
            this.TbTaskContent.Size = new System.Drawing.Size(180, 100);
            this.TbTaskContent.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // CbState
            // 
            this.CbState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbState.FormattingEnabled = true;
            this.CbState.Location = new System.Drawing.Point(10, 220);
            this.CbState.Name = "CbState";
            this.CbState.Size = new System.Drawing.Size(180, 26);
            this.CbState.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de inicio";
            // 
            // DtpStart
            // 
            this.DtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStart.Location = new System.Drawing.Point(10, 270);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(180, 26);
            this.DtpStart.TabIndex = 7;
            // 
            // DtpLimit
            // 
            this.DtpLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpLimit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpLimit.Location = new System.Drawing.Point(10, 330);
            this.DtpLimit.Name = "DtpLimit";
            this.DtpLimit.Size = new System.Drawing.Size(180, 26);
            this.DtpLimit.TabIndex = 9;
            // 
            // ChkDateLimit
            // 
            this.ChkDateLimit.AutoSize = true;
            this.ChkDateLimit.Location = new System.Drawing.Point(10, 302);
            this.ChkDateLimit.Name = "ChkDateLimit";
            this.ChkDateLimit.Size = new System.Drawing.Size(103, 22);
            this.ChkDateLimit.TabIndex = 10;
            this.ChkDateLimit.Text = "Fecha limite";
            this.ChkDateLimit.UseVisualStyleBackColor = true;
            this.ChkDateLimit.CheckedChanged += new System.EventHandler(this.ChkDateLimit_CheckedChanged);
            // 
            // PnlAside
            // 
            this.PnlAside.BackColor = System.Drawing.Color.White;
            this.PnlAside.Controls.Add(this.toolStrip2);
            this.PnlAside.Controls.Add(this.toolStrip1);
            this.PnlAside.Controls.Add(this.ChkDateLimit);
            this.PnlAside.Controls.Add(this.DtpLimit);
            this.PnlAside.Controls.Add(this.DtpStart);
            this.PnlAside.Controls.Add(this.label5);
            this.PnlAside.Controls.Add(this.CbState);
            this.PnlAside.Controls.Add(this.label4);
            this.PnlAside.Controls.Add(this.TbTaskContent);
            this.PnlAside.Controls.Add(this.label3);
            this.PnlAside.Controls.Add(this.CbCategory);
            this.PnlAside.Controls.Add(this.label2);
            this.PnlAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlAside.Location = new System.Drawing.Point(507, 0);
            this.PnlAside.MaximumSize = new System.Drawing.Size(350, 0);
            this.PnlAside.MinimumSize = new System.Drawing.Size(200, 0);
            this.PnlAside.Name = "PnlAside";
            this.PnlAside.Size = new System.Drawing.Size(200, 400);
            this.PnlAside.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TspBtnNew,
            this.TspBtnModify,
            this.TspBtnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(200, 25);
            this.toolStrip1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 100);
            this.panel2.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TspBtnSave,
            this.TspBtnDiscard});
            this.toolStrip2.Location = new System.Drawing.Point(0, 375);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(200, 25);
            this.toolStrip2.TabIndex = 12;
            // 
            // TspBtnSave
            // 
            this.TspBtnSave.Image = global::WinFormNotes.Properties.Resources.disk_blue;
            this.TspBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspBtnSave.Name = "TspBtnSave";
            this.TspBtnSave.Size = new System.Drawing.Size(77, 22);
            this.TspBtnSave.Text = "Guardar";
            this.TspBtnSave.Click += new System.EventHandler(this.TspBtnSave_Click);
            // 
            // TspBtnDiscard
            // 
            this.TspBtnDiscard.Image = global::WinFormNotes.Properties.Resources.document_forbidden;
            this.TspBtnDiscard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspBtnDiscard.Name = "TspBtnDiscard";
            this.TspBtnDiscard.Size = new System.Drawing.Size(86, 22);
            this.TspBtnDiscard.Text = "Descartar";
            this.TspBtnDiscard.Click += new System.EventHandler(this.TspBtnDiscard_Click);
            // 
            // TspBtnNew
            // 
            this.TspBtnNew.Image = global::WinFormNotes.Properties.Resources.document_add;
            this.TspBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspBtnNew.Name = "TspBtnNew";
            this.TspBtnNew.Size = new System.Drawing.Size(69, 22);
            this.TspBtnNew.Text = "Nuevo";
            this.TspBtnNew.Click += new System.EventHandler(this.TspBtnNew_Click);
            // 
            // TspBtnModify
            // 
            this.TspBtnModify.Image = global::WinFormNotes.Properties.Resources.document_edit;
            this.TspBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspBtnModify.Name = "TspBtnModify";
            this.TspBtnModify.Size = new System.Drawing.Size(86, 22);
            this.TspBtnModify.Text = "Modificar";
            // 
            // TspBtnDelete
            // 
            this.TspBtnDelete.Image = global::WinFormNotes.Properties.Resources.document_error;
            this.TspBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspBtnDelete.Name = "TspBtnDelete";
            this.TspBtnDelete.Size = new System.Drawing.Size(79, 22);
            this.TspBtnDelete.Text = "Eliminar";
            // 
            // TaskPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PnlAside);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskPanel";
            this.Size = new System.Drawing.Size(707, 400);
            this.Load += new System.EventHandler(this.TaskPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.PnlAside.ResumeLayout(false);
            this.PnlAside.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbTaskContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.DateTimePicker DtpLimit;
        private System.Windows.Forms.CheckBox ChkDateLimit;
        private System.Windows.Forms.Panel PnlAside;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TspBtnNew;
        private System.Windows.Forms.ToolStripButton TspBtnModify;
        private System.Windows.Forms.ToolStripButton TspBtnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton TspBtnSave;
        private System.Windows.Forms.ToolStripButton TspBtnDiscard;
    }
}
