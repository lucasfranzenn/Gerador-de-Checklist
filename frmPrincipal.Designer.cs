namespace Gerador_de_Checklist
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblAutor = new Label();
            lblTarefa = new Label();
            txtTarefa = new MaskedTextBox();
            txtAutor = new TextBox();
            btnGerar = new Button();
            btnSair = new Button();
            tlpRequisitos = new TableLayoutPanel();
            pnlRequisitos = new Panel();
            btnConfig = new Button();
            pnlRequisitos.SuspendLayout();
            SuspendLayout();
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 12F);
            lblAutor.Location = new Point(12, 16);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(52, 21);
            lblAutor.TabIndex = 0;
            lblAutor.Text = "Autor:";
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Font = new Font("Segoe UI", 12F);
            lblTarefa.Location = new Point(12, 45);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(54, 21);
            lblTarefa.TabIndex = 1;
            lblTarefa.Text = "Tarefa:";
            // 
            // txtTarefa
            // 
            txtTarefa.BorderStyle = BorderStyle.FixedSingle;
            txtTarefa.Location = new Point(71, 45);
            txtTarefa.Mask = "######";
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(45, 23);
            txtTarefa.TabIndex = 1;
            txtTarefa.Leave += txtTarefa_Leave;
            // 
            // txtAutor
            // 
            txtAutor.BorderStyle = BorderStyle.FixedSingle;
            txtAutor.Location = new Point(71, 16);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 0;
            txtAutor.Enter += txtAutor_Enter;
            // 
            // btnGerar
            // 
            btnGerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGerar.Cursor = Cursors.Hand;
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Location = new Point(751, 16);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(153, 52);
            btnGerar.TabIndex = 3;
            btnGerar.Text = "&Gerar Checklist";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Click += btnSair_Click;
            // 
            // tlpRequisitos
            // 
            tlpRequisitos.AutoSize = true;
            tlpRequisitos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpRequisitos.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tlpRequisitos.ColumnCount = 4;
            tlpRequisitos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpRequisitos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tlpRequisitos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpRequisitos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpRequisitos.Dock = DockStyle.Top;
            tlpRequisitos.Location = new Point(0, 0);
            tlpRequisitos.Name = "tlpRequisitos";
            tlpRequisitos.RowCount = 1;
            tlpRequisitos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRequisitos.Size = new Size(891, 4);
            tlpRequisitos.TabIndex = 3;
            // 
            // pnlRequisitos
            // 
            pnlRequisitos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRequisitos.AutoScroll = true;
            pnlRequisitos.BackColor = SystemColors.Control;
            pnlRequisitos.BorderStyle = BorderStyle.FixedSingle;
            pnlRequisitos.Controls.Add(tlpRequisitos);
            pnlRequisitos.Location = new Point(12, 85);
            pnlRequisitos.Name = "pnlRequisitos";
            pnlRequisitos.Size = new Size(893, 496);
            pnlRequisitos.TabIndex = 4;
            // 
            // btnConfig
            // 
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Image = Properties.Resources.settings__1_;
            btnConfig.Location = new Point(695, 16);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(52, 52);
            btnConfig.TabIndex = 2;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new Size(914, 589);
            Controls.Add(btnConfig);
            Controls.Add(pnlRequisitos);
            Controls.Add(btnGerar);
            Controls.Add(txtAutor);
            Controls.Add(txtTarefa);
            Controls.Add(lblTarefa);
            Controls.Add(lblAutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(930, 250);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Checklist";
            Shown += frmPrincipal_Shown;
            pnlRequisitos.ResumeLayout(false);
            pnlRequisitos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAutor;
        private Label lblTarefa;
        private MaskedTextBox txtTarefa;
        private TextBox txtAutor;
        private Button btnGerar;
        private Button btnSair;
        private TableLayoutPanel tlpRequisitos;
        private Panel pnlRequisitos;
        private Button btnConfig;
    }
}
