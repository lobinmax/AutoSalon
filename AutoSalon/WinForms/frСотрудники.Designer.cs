    partial class frСотрудники
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonОбновить = new System.Windows.Forms.Button();
            this.gridViewСотрудники = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonУдалить = new System.Windows.Forms.Button();
            this.buttonИзменить = new System.Windows.Forms.Button();
            this.buttonДобавить = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСотрудники)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonУдалить);
            this.panel1.Controls.Add(this.buttonИзменить);
            this.panel1.Controls.Add(this.buttonДобавить);
            this.panel1.Controls.Add(this.buttonОбновить);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 47);
            this.panel1.TabIndex = 0;
            // 
            // buttonОбновить
            // 
            this.buttonОбновить.Location = new System.Drawing.Point(12, 12);
            this.buttonОбновить.Name = "buttonОбновить";
            this.buttonОбновить.Size = new System.Drawing.Size(104, 23);
            this.buttonОбновить.TabIndex = 0;
            this.buttonОбновить.Text = "Обновить";
            this.buttonОбновить.UseVisualStyleBackColor = true;
            this.buttonОбновить.Click += new System.EventHandler(this.simpleButtonОбновить_Click);
            // 
            // gridViewСотрудники
            // 
            this.gridViewСотрудники.AllowUserToAddRows = false;
            this.gridViewСотрудники.AllowUserToDeleteRows = false;
            this.gridViewСотрудники.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewСотрудники.ColumnHeadersHeight = 20;
            this.gridViewСотрудники.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewСотрудники.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewСотрудники.Location = new System.Drawing.Point(0, 0);
            this.gridViewСотрудники.MultiSelect = false;
            this.gridViewСотрудники.Name = "gridViewСотрудники";
            this.gridViewСотрудники.ReadOnly = true;
            this.gridViewСотрудники.RowHeadersWidth = 25;
            this.gridViewСотрудники.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewСотрудники.RowTemplate.Height = 18;
            this.gridViewСотрудники.RowTemplate.ReadOnly = true;
            this.gridViewСотрудники.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewСотрудники.Size = new System.Drawing.Size(1025, 425);
            this.gridViewСотрудники.TabIndex = 1;
            this.gridViewСотрудники.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewСотрудники_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gridViewСотрудники);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 427);
            this.panel2.TabIndex = 2;
            // 
            // buttonУдалить
            // 
            this.buttonУдалить.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.buttonУдалить.Location = new System.Drawing.Point(210, 12);
            this.buttonУдалить.Name = "buttonУдалить";
            this.buttonУдалить.Size = new System.Drawing.Size(28, 23);
            this.buttonУдалить.TabIndex = 3;
            this.buttonУдалить.UseVisualStyleBackColor = true;
            this.buttonУдалить.Click += new System.EventHandler(this.simpleButtonУдалить_Click);
            // 
            // buttonИзменить
            // 
            this.buttonИзменить.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.buttonИзменить.Location = new System.Drawing.Point(176, 12);
            this.buttonИзменить.Name = "buttonИзменить";
            this.buttonИзменить.Size = new System.Drawing.Size(28, 23);
            this.buttonИзменить.TabIndex = 2;
            this.buttonИзменить.UseVisualStyleBackColor = true;
            this.buttonИзменить.Click += new System.EventHandler(this.simpleButtonИзменить_Click);
            // 
            // buttonДобавить
            // 
            this.buttonДобавить.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.buttonДобавить.Location = new System.Drawing.Point(142, 12);
            this.buttonДобавить.Name = "buttonДобавить";
            this.buttonДобавить.Size = new System.Drawing.Size(28, 23);
            this.buttonДобавить.TabIndex = 1;
            this.buttonДобавить.UseVisualStyleBackColor = true;
            this.buttonДобавить.Click += new System.EventHandler(this.simpleButtonДобавить_Click);
            // 
            // frСотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frСотрудники";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.frСотрудники_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСотрудники)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonУдалить;
    private System.Windows.Forms.Button buttonИзменить;
    private System.Windows.Forms.Button buttonДобавить;
    private System.Windows.Forms.Button buttonОбновить;
    private System.Windows.Forms.DataGridView gridViewСотрудники;
    private System.Windows.Forms.Panel panel2;
}
