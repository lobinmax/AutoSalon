    partial class frСправочники
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
            this.ButtonУдалить = new System.Windows.Forms.Button();
            this.ButtonИзменить = new System.Windows.Forms.Button();
            this.ButtonДобавить = new System.Windows.Forms.Button();
            this.ButtonОбновить = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageТипыКПП = new System.Windows.Forms.TabPage();
            this.gridViewТипыКпп = new System.Windows.Forms.DataGridView();
            this.tabPageТипыКузова = new System.Windows.Forms.TabPage();
            this.tabPageТипыПривода = new System.Windows.Forms.TabPage();
            this.tabPageТипыТоплива = new System.Windows.Forms.TabPage();
            this.tabPageЗаказыСтатусы = new System.Windows.Forms.TabPage();
            this.tabPageСтраны = new System.Windows.Forms.TabPage();
            this.gridViewТипКузова = new System.Windows.Forms.DataGridView();
            this.gridViewТипыПривода = new System.Windows.Forms.DataGridView();
            this.gridViewТипыТоплива = new System.Windows.Forms.DataGridView();
            this.gridViewСтатусыЗаказа = new System.Windows.Forms.DataGridView();
            this.gridViewСтраны = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageТипыКПП.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыКпп)).BeginInit();
            this.tabPageТипыКузова.SuspendLayout();
            this.tabPageТипыПривода.SuspendLayout();
            this.tabPageТипыТоплива.SuspendLayout();
            this.tabPageЗаказыСтатусы.SuspendLayout();
            this.tabPageСтраны.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипКузова)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыПривода)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыТоплива)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтатусыЗаказа)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтраны)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ButtonУдалить);
            this.panel1.Controls.Add(this.ButtonИзменить);
            this.panel1.Controls.Add(this.ButtonДобавить);
            this.panel1.Controls.Add(this.ButtonОбновить);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 47);
            this.panel1.TabIndex = 1;
            // 
            // ButtonУдалить
            // 
            this.ButtonУдалить.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.ButtonУдалить.Location = new System.Drawing.Point(210, 12);
            this.ButtonУдалить.Name = "ButtonУдалить";
            this.ButtonУдалить.Size = new System.Drawing.Size(28, 23);
            this.ButtonУдалить.TabIndex = 3;
            this.ButtonУдалить.UseVisualStyleBackColor = true;
            // 
            // ButtonИзменить
            // 
            this.ButtonИзменить.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.ButtonИзменить.Location = new System.Drawing.Point(176, 12);
            this.ButtonИзменить.Name = "ButtonИзменить";
            this.ButtonИзменить.Size = new System.Drawing.Size(28, 23);
            this.ButtonИзменить.TabIndex = 2;
            this.ButtonИзменить.UseVisualStyleBackColor = true;
            // 
            // ButtonДобавить
            // 
            this.ButtonДобавить.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.ButtonДобавить.Location = new System.Drawing.Point(142, 12);
            this.ButtonДобавить.Name = "ButtonДобавить";
            this.ButtonДобавить.Size = new System.Drawing.Size(28, 23);
            this.ButtonДобавить.TabIndex = 1;
            this.ButtonДобавить.UseVisualStyleBackColor = true;
            // 
            // ButtonОбновить
            // 
            this.ButtonОбновить.Location = new System.Drawing.Point(12, 12);
            this.ButtonОбновить.Name = "ButtonОбновить";
            this.ButtonОбновить.Size = new System.Drawing.Size(104, 23);
            this.ButtonОбновить.TabIndex = 0;
            this.ButtonОбновить.Text = "Обновить";
            this.ButtonОбновить.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 455);
            this.panel2.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageТипыКПП);
            this.tabControl.Controls.Add(this.tabPageТипыКузова);
            this.tabControl.Controls.Add(this.tabPageТипыПривода);
            this.tabControl.Controls.Add(this.tabPageТипыТоплива);
            this.tabControl.Controls.Add(this.tabPageЗаказыСтатусы);
            this.tabControl.Controls.Add(this.tabPageСтраны);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1096, 453);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageТипыКПП
            // 
            this.tabPageТипыКПП.Controls.Add(this.gridViewТипыКпп);
            this.tabPageТипыКПП.Location = new System.Drawing.Point(4, 22);
            this.tabPageТипыКПП.Name = "tabPageТипыКПП";
            this.tabPageТипыКПП.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageТипыКПП.Size = new System.Drawing.Size(970, 394);
            this.tabPageТипыКПП.TabIndex = 0;
            this.tabPageТипыКПП.Text = "Типы КПП";
            this.tabPageТипыКПП.UseVisualStyleBackColor = true;
            // 
            // gridViewТипыКпп
            // 
            this.gridViewТипыКпп.AllowUserToAddRows = false;
            this.gridViewТипыКпп.AllowUserToDeleteRows = false;
            this.gridViewТипыКпп.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewТипыКпп.ColumnHeadersHeight = 20;
            this.gridViewТипыКпп.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewТипыКпп.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewТипыКпп.Location = new System.Drawing.Point(3, 3);
            this.gridViewТипыКпп.MultiSelect = false;
            this.gridViewТипыКпп.Name = "gridViewТипыКпп";
            this.gridViewТипыКпп.ReadOnly = true;
            this.gridViewТипыКпп.RowHeadersWidth = 25;
            this.gridViewТипыКпп.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewТипыКпп.RowTemplate.Height = 18;
            this.gridViewТипыКпп.RowTemplate.ReadOnly = true;
            this.gridViewТипыКпп.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewТипыКпп.Size = new System.Drawing.Size(964, 388);
            this.gridViewТипыКпп.TabIndex = 2;
            // 
            // tabPageТипыКузова
            // 
            this.tabPageТипыКузова.Controls.Add(this.gridViewТипКузова);
            this.tabPageТипыКузова.Location = new System.Drawing.Point(4, 22);
            this.tabPageТипыКузова.Name = "tabPageТипыКузова";
            this.tabPageТипыКузова.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageТипыКузова.Size = new System.Drawing.Size(1088, 427);
            this.tabPageТипыКузова.TabIndex = 1;
            this.tabPageТипыКузова.Text = "Типы кузова";
            this.tabPageТипыКузова.UseVisualStyleBackColor = true;
            // 
            // tabPageТипыПривода
            // 
            this.tabPageТипыПривода.Controls.Add(this.gridViewТипыПривода);
            this.tabPageТипыПривода.Location = new System.Drawing.Point(4, 22);
            this.tabPageТипыПривода.Name = "tabPageТипыПривода";
            this.tabPageТипыПривода.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageТипыПривода.Size = new System.Drawing.Size(970, 394);
            this.tabPageТипыПривода.TabIndex = 2;
            this.tabPageТипыПривода.Text = "Типы привода";
            this.tabPageТипыПривода.UseVisualStyleBackColor = true;
            // 
            // tabPageТипыТоплива
            // 
            this.tabPageТипыТоплива.Controls.Add(this.gridViewТипыТоплива);
            this.tabPageТипыТоплива.Location = new System.Drawing.Point(4, 22);
            this.tabPageТипыТоплива.Name = "tabPageТипыТоплива";
            this.tabPageТипыТоплива.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageТипыТоплива.Size = new System.Drawing.Size(970, 394);
            this.tabPageТипыТоплива.TabIndex = 3;
            this.tabPageТипыТоплива.Text = "Типы топлива";
            this.tabPageТипыТоплива.UseVisualStyleBackColor = true;
            // 
            // tabPageЗаказыСтатусы
            // 
            this.tabPageЗаказыСтатусы.Controls.Add(this.gridViewСтатусыЗаказа);
            this.tabPageЗаказыСтатусы.Location = new System.Drawing.Point(4, 22);
            this.tabPageЗаказыСтатусы.Name = "tabPageЗаказыСтатусы";
            this.tabPageЗаказыСтатусы.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageЗаказыСтатусы.Size = new System.Drawing.Size(970, 394);
            this.tabPageЗаказыСтатусы.TabIndex = 4;
            this.tabPageЗаказыСтатусы.Text = "Статусы заказов";
            this.tabPageЗаказыСтатусы.UseVisualStyleBackColor = true;
            // 
            // tabPageСтраны
            // 
            this.tabPageСтраны.Controls.Add(this.gridViewСтраны);
            this.tabPageСтраны.Location = new System.Drawing.Point(4, 22);
            this.tabPageСтраны.Name = "tabPageСтраны";
            this.tabPageСтраны.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageСтраны.Size = new System.Drawing.Size(970, 394);
            this.tabPageСтраны.TabIndex = 5;
            this.tabPageСтраны.Text = "Страны";
            this.tabPageСтраны.UseVisualStyleBackColor = true;
            // 
            // gridViewТипКузова
            // 
            this.gridViewТипКузова.AllowUserToAddRows = false;
            this.gridViewТипКузова.AllowUserToDeleteRows = false;
            this.gridViewТипКузова.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewТипКузова.ColumnHeadersHeight = 20;
            this.gridViewТипКузова.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewТипКузова.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewТипКузова.Location = new System.Drawing.Point(3, 3);
            this.gridViewТипКузова.MultiSelect = false;
            this.gridViewТипКузова.Name = "gridViewТипКузова";
            this.gridViewТипКузова.ReadOnly = true;
            this.gridViewТипКузова.RowHeadersWidth = 25;
            this.gridViewТипКузова.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewТипКузова.RowTemplate.Height = 18;
            this.gridViewТипКузова.RowTemplate.ReadOnly = true;
            this.gridViewТипКузова.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewТипКузова.Size = new System.Drawing.Size(1082, 421);
            this.gridViewТипКузова.TabIndex = 3;
            // 
            // gridViewТипыПривода
            // 
            this.gridViewТипыПривода.AllowUserToAddRows = false;
            this.gridViewТипыПривода.AllowUserToDeleteRows = false;
            this.gridViewТипыПривода.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewТипыПривода.ColumnHeadersHeight = 20;
            this.gridViewТипыПривода.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewТипыПривода.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewТипыПривода.Location = new System.Drawing.Point(3, 3);
            this.gridViewТипыПривода.MultiSelect = false;
            this.gridViewТипыПривода.Name = "gridViewТипыПривода";
            this.gridViewТипыПривода.ReadOnly = true;
            this.gridViewТипыПривода.RowHeadersWidth = 25;
            this.gridViewТипыПривода.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewТипыПривода.RowTemplate.Height = 18;
            this.gridViewТипыПривода.RowTemplate.ReadOnly = true;
            this.gridViewТипыПривода.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewТипыПривода.Size = new System.Drawing.Size(964, 388);
            this.gridViewТипыПривода.TabIndex = 3;
            // 
            // gridViewТипыТоплива
            // 
            this.gridViewТипыТоплива.AllowUserToAddRows = false;
            this.gridViewТипыТоплива.AllowUserToDeleteRows = false;
            this.gridViewТипыТоплива.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewТипыТоплива.ColumnHeadersHeight = 20;
            this.gridViewТипыТоплива.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewТипыТоплива.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewТипыТоплива.Location = new System.Drawing.Point(3, 3);
            this.gridViewТипыТоплива.MultiSelect = false;
            this.gridViewТипыТоплива.Name = "gridViewТипыТоплива";
            this.gridViewТипыТоплива.ReadOnly = true;
            this.gridViewТипыТоплива.RowHeadersWidth = 25;
            this.gridViewТипыТоплива.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewТипыТоплива.RowTemplate.Height = 18;
            this.gridViewТипыТоплива.RowTemplate.ReadOnly = true;
            this.gridViewТипыТоплива.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewТипыТоплива.Size = new System.Drawing.Size(964, 388);
            this.gridViewТипыТоплива.TabIndex = 3;
            // 
            // gridViewСтатусыЗаказа
            // 
            this.gridViewСтатусыЗаказа.AllowUserToAddRows = false;
            this.gridViewСтатусыЗаказа.AllowUserToDeleteRows = false;
            this.gridViewСтатусыЗаказа.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewСтатусыЗаказа.ColumnHeadersHeight = 20;
            this.gridViewСтатусыЗаказа.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewСтатусыЗаказа.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewСтатусыЗаказа.Location = new System.Drawing.Point(3, 3);
            this.gridViewСтатусыЗаказа.MultiSelect = false;
            this.gridViewСтатусыЗаказа.Name = "gridViewСтатусыЗаказа";
            this.gridViewСтатусыЗаказа.ReadOnly = true;
            this.gridViewСтатусыЗаказа.RowHeadersWidth = 25;
            this.gridViewСтатусыЗаказа.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewСтатусыЗаказа.RowTemplate.Height = 18;
            this.gridViewСтатусыЗаказа.RowTemplate.ReadOnly = true;
            this.gridViewСтатусыЗаказа.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewСтатусыЗаказа.Size = new System.Drawing.Size(964, 388);
            this.gridViewСтатусыЗаказа.TabIndex = 3;
            // 
            // gridViewСтраны
            // 
            this.gridViewСтраны.AllowUserToAddRows = false;
            this.gridViewСтраны.AllowUserToDeleteRows = false;
            this.gridViewСтраны.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewСтраны.ColumnHeadersHeight = 20;
            this.gridViewСтраны.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewСтраны.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewСтраны.Location = new System.Drawing.Point(3, 3);
            this.gridViewСтраны.MultiSelect = false;
            this.gridViewСтраны.Name = "gridViewСтраны";
            this.gridViewСтраны.ReadOnly = true;
            this.gridViewСтраны.RowHeadersWidth = 25;
            this.gridViewСтраны.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewСтраны.RowTemplate.Height = 18;
            this.gridViewСтраны.RowTemplate.ReadOnly = true;
            this.gridViewСтраны.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewСтраны.Size = new System.Drawing.Size(964, 388);
            this.gridViewСтраны.TabIndex = 3;
            // 
            // frСправочники
            // 
            this.ClientSize = new System.Drawing.Size(1100, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frСправочники";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.frСправочники_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageТипыКПП.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыКпп)).EndInit();
            this.tabPageТипыКузова.ResumeLayout(false);
            this.tabPageТипыПривода.ResumeLayout(false);
            this.tabPageТипыТоплива.ResumeLayout(false);
            this.tabPageЗаказыСтатусы.ResumeLayout(false);
            this.tabPageСтраны.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипКузова)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыПривода)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыТоплива)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтатусыЗаказа)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтраны)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button ButtonУдалить;
    private System.Windows.Forms.Button ButtonИзменить;
    private System.Windows.Forms.Button ButtonДобавить;
    private System.Windows.Forms.Button ButtonОбновить;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageТипыКПП;
    private System.Windows.Forms.TabPage tabPageТипыКузова;
    private System.Windows.Forms.TabPage tabPageТипыПривода;
    private System.Windows.Forms.TabPage tabPageТипыТоплива;
    private System.Windows.Forms.TabPage tabPageЗаказыСтатусы;
    private System.Windows.Forms.TabPage tabPageСтраны;
    private System.Windows.Forms.DataGridView gridViewТипыКпп;
    private System.Windows.Forms.DataGridView gridViewТипКузова;
    private System.Windows.Forms.DataGridView gridViewТипыПривода;
    private System.Windows.Forms.DataGridView gridViewТипыТоплива;
    private System.Windows.Forms.DataGridView gridViewСтатусыЗаказа;
    private System.Windows.Forms.DataGridView gridViewСтраны;
}
