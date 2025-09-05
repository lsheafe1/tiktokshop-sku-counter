namespace tiktokshop_sku_counter
{
    partial class Form
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            uxOpenFileDialog = new OpenFileDialog();
            uxAddButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            uxTable = new TableLayoutPanel();
            label1 = new Label();
            uxDataGridView = new DataGridView();
            label2 = new Label();
            uxResultBox = new TextBox();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            FileName = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            uxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uxDataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uxAddButton
            // 
            uxAddButton.Anchor = AnchorStyles.Top;
            uxAddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uxAddButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uxAddButton.Location = new Point(3, 3);
            uxAddButton.Name = "uxAddButton";
            uxAddButton.Size = new Size(44, 43);
            uxAddButton.TabIndex = 1;
            uxAddButton.Text = "+";
            uxAddButton.TextAlign = ContentAlignment.TopCenter;
            uxAddButton.UseVisualStyleBackColor = true;
            uxAddButton.Click += AddClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.Controls.Add(uxTable, 0, 0);
            tableLayoutPanel1.Controls.Add(uxDataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(uxResultBox, 2, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(600, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(978, 599);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // uxTable
            // 
            uxTable.AutoSize = true;
            uxTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uxTable.ColumnCount = 1;
            uxTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            uxTable.Controls.Add(label1, 0, 1);
            uxTable.Dock = DockStyle.Fill;
            uxTable.Location = new Point(3, 3);
            uxTable.Name = "uxTable";
            uxTable.RowCount = 2;
            uxTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            uxTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            uxTable.Size = new Size(354, 50);
            uxTable.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(348, 40);
            label1.TabIndex = 0;
            label1.Text = "CSV List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uxDataGridView
            // 
            uxDataGridView.AllowUserToAddRows = false;
            uxDataGridView.AllowUserToDeleteRows = false;
            uxDataGridView.AllowUserToResizeColumns = false;
            uxDataGridView.AllowUserToResizeRows = false;
            uxDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uxDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uxDataGridView.Columns.AddRange(new DataGridViewColumn[] { FileName, Remove });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uxDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            uxDataGridView.Dock = DockStyle.Fill;
            uxDataGridView.Location = new Point(3, 59);
            uxDataGridView.MultiSelect = false;
            uxDataGridView.Name = "uxDataGridView";
            uxDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uxDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uxDataGridView.RowHeadersVisible = false;
            uxDataGridView.ScrollBars = ScrollBars.Vertical;
            uxDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            uxDataGridView.ShowEditingIcon = false;
            uxDataGridView.Size = new Size(354, 437);
            uxDataGridView.TabIndex = 0;
            uxDataGridView.CellContentClick += DataGridViewCellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(403, 0);
            label2.Name = "label2";
            label2.Size = new Size(572, 56);
            label2.TabIndex = 3;
            label2.Text = "Results";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uxResultBox
            // 
            uxResultBox.BorderStyle = BorderStyle.FixedSingle;
            uxResultBox.Dock = DockStyle.Fill;
            uxResultBox.HideSelection = false;
            uxResultBox.Location = new Point(403, 59);
            uxResultBox.MaxLength = 0;
            uxResultBox.Multiline = true;
            uxResultBox.Name = "uxResultBox";
            uxResultBox.ReadOnly = true;
            uxResultBox.ShortcutsEnabled = false;
            uxResultBox.Size = new Size(572, 437);
            uxResultBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(403, 502);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(uxAddButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 502);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(354, 94);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // FileName
            // 
            FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FileName.DataPropertyName = "FileName";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileName.DefaultCellStyle = dataGridViewCellStyle1;
            FileName.HeaderText = "File Name";
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            // 
            // Remove
            // 
            Remove.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(20, 0, 20, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            Remove.DefaultCellStyle = dataGridViewCellStyle2;
            Remove.FlatStyle = FlatStyle.System;
            Remove.HeaderText = "Remove";
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Resizable = DataGridViewTriState.False;
            Remove.Text = "X";
            Remove.ToolTipText = "X";
            Remove.UseColumnTextForButtonValue = true;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 599);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(800, 500);
            Name = "Form";
            Text = "Form1";
            Load += FormLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            uxTable.ResumeLayout(false);
            uxTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uxDataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog uxOpenFileDialog;
        private Button uxAddButton;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView uxDataGridView;
        private TableLayoutPanel uxTable;
        private Label label1;
        private Label label2;
        private TextBox uxResultBox;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewButtonColumn Remove;
    }
}
