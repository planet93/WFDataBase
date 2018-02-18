namespace WFDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileXlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTableBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillTableBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDateTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonRunQuery3 = new System.Windows.Forms.Button();
            this.buttonRunQuery2 = new System.Windows.Forms.Button();
            this.buttonRunQuery1 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolsStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.SaveFileXlsToolStripMenuItem,
            this.SaveFileCsvToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.OpenFileToolStripMenuItem.Text = "Открыть БД";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveFileXlsToolStripMenuItem
            // 
            this.SaveFileXlsToolStripMenuItem.Name = "SaveFileXlsToolStripMenuItem";
            this.SaveFileXlsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SaveFileXlsToolStripMenuItem.Text = "Сохранить как xlsx";
            this.SaveFileXlsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileXlsToolStripMenuItem_Click);
            // 
            // SaveFileCsvToolStripMenuItem
            // 
            this.SaveFileCsvToolStripMenuItem.Name = "SaveFileCsvToolStripMenuItem";
            this.SaveFileCsvToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SaveFileCsvToolStripMenuItem.Text = "Сохранить как csv";
            this.SaveFileCsvToolStripMenuItem.Click += new System.EventHandler(this.SaveFileCsvToolStripMenuItem_Click);
            // 
            // ToolsStripMenuItem
            // 
            this.ToolsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTableBDToolStripMenuItem,
            this.FillTableBDToolStripMenuItem,
            this.ShowDateTablesToolStripMenuItem,
            this.QueryJoinToolStripMenuItem});
            this.ToolsStripMenuItem.Enabled = false;
            this.ToolsStripMenuItem.Name = "ToolsStripMenuItem";
            this.ToolsStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ToolsStripMenuItem.Text = "Инструменты";
            // 
            // CreateTableBDToolStripMenuItem
            // 
            this.CreateTableBDToolStripMenuItem.Name = "CreateTableBDToolStripMenuItem";
            this.CreateTableBDToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.CreateTableBDToolStripMenuItem.Text = "Создать таблицы в БД";
            this.CreateTableBDToolStripMenuItem.Click += new System.EventHandler(this.CreateTableBDToolStripMenuItem_Click);
            // 
            // FillTableBDToolStripMenuItem
            // 
            this.FillTableBDToolStripMenuItem.Name = "FillTableBDToolStripMenuItem";
            this.FillTableBDToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.FillTableBDToolStripMenuItem.Text = "Заполнить таблицы БД";
            this.FillTableBDToolStripMenuItem.Click += new System.EventHandler(this.FillTableBDToolStripMenuItem_Click);
            // 
            // ShowDateTablesToolStripMenuItem
            // 
            this.ShowDateTablesToolStripMenuItem.Name = "ShowDateTablesToolStripMenuItem";
            this.ShowDateTablesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.ShowDateTablesToolStripMenuItem.Text = "Показать данные таблиц";
            this.ShowDateTablesToolStripMenuItem.Click += new System.EventHandler(this.ShowDateTablesToolStripMenuItem_Click);
            // 
            // QueryJoinToolStripMenuItem
            // 
            this.QueryJoinToolStripMenuItem.Name = "QueryJoinToolStripMenuItem";
            this.QueryJoinToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.QueryJoinToolStripMenuItem.Text = "Запрос JOIN";
            this.QueryJoinToolStripMenuItem.Click += new System.EventHandler(this.QueryJoinToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 349);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(541, 317);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(547, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Table3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(547, 323);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonRunQuery3);
            this.tabPage4.Controls.Add(this.buttonRunQuery2);
            this.tabPage4.Controls.Add(this.buttonRunQuery1);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(547, 323);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Query";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonRunQuery3
            // 
            this.buttonRunQuery3.Location = new System.Drawing.Point(349, 236);
            this.buttonRunQuery3.Name = "buttonRunQuery3";
            this.buttonRunQuery3.Size = new System.Drawing.Size(195, 84);
            this.buttonRunQuery3.TabIndex = 3;
            this.buttonRunQuery3.Text = "Показать только id, дату и целое число из двух таблиц (фильтр - целые числа больш" +
    "е 50)";
            this.buttonRunQuery3.UseVisualStyleBackColor = true;
            this.buttonRunQuery3.Click += new System.EventHandler(this.buttonRunQuery3_Click);
            // 
            // buttonRunQuery2
            // 
            this.buttonRunQuery2.Location = new System.Drawing.Point(178, 236);
            this.buttonRunQuery2.Name = "buttonRunQuery2";
            this.buttonRunQuery2.Size = new System.Drawing.Size(165, 84);
            this.buttonRunQuery2.TabIndex = 2;
            this.buttonRunQuery2.Text = "Показать только id, дату и целое число из двух таблиц, отсортировав по дате из вт" +
    "орой таблицы";
            this.buttonRunQuery2.UseVisualStyleBackColor = true;
            this.buttonRunQuery2.Click += new System.EventHandler(this.buttonRunQuery2_Click);
            // 
            // buttonRunQuery1
            // 
            this.buttonRunQuery1.Location = new System.Drawing.Point(3, 236);
            this.buttonRunQuery1.Name = "buttonRunQuery1";
            this.buttonRunQuery1.Size = new System.Drawing.Size(163, 84);
            this.buttonRunQuery1.TabIndex = 1;
            this.buttonRunQuery1.Text = "Показать только id, дату и целое число из двух таблиц";
            this.buttonRunQuery1.UseVisualStyleBackColor = true;
            this.buttonRunQuery1.Click += new System.EventHandler(this.buttonRunQuery1_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(549, 233);
            this.dataGridView4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Application WorkingWithBD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileXlsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem ToolsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FillTableBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTableBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowDateTablesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem QueryJoinToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button buttonRunQuery1;
        private System.Windows.Forms.Button buttonRunQuery2;
        private System.Windows.Forms.Button buttonRunQuery3;
        private System.Windows.Forms.ToolStripMenuItem SaveFileCsvToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

