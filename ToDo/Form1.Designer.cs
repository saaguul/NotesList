namespace ToDo
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usun_btn = new System.Windows.Forms.Button();
            this.cb_onTop = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(272, 110);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(0, 4);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 23);
            this.dodaj_btn.TabIndex = 1;
            this.dodaj_btn.Text = "Dodaj nowe";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(81, 4);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(91, 23);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edytuj wybrane";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.zapisz_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 113);
            this.textBox1.TabIndex = 3;
            // 
            // usun_btn
            // 
            this.usun_btn.Location = new System.Drawing.Point(178, 4);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(66, 23);
            this.usun_btn.TabIndex = 4;
            this.usun_btn.Text = "Usuń";
            this.usun_btn.UseVisualStyleBackColor = true;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // cb_onTop
            // 
            this.cb_onTop.AutoSize = true;
            this.cb_onTop.Checked = true;
            this.cb_onTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_onTop.Location = new System.Drawing.Point(250, 9);
            this.cb_onTop.Name = "cb_onTop";
            this.cb_onTop.Size = new System.Drawing.Size(15, 14);
            this.cb_onTop.TabIndex = 5;
            this.cb_onTop.UseVisualStyleBackColor = true;
            this.cb_onTop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 262);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.cb_onTop);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(291, 700);
            this.MinimumSize = new System.Drawing.Size(291, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToDo list";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.CheckBox cb_onTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

