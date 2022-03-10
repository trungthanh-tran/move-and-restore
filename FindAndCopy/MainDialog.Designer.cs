namespace FindAndCopy
{
    partial class MainDialog
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
            this.btnSrcChoose = new System.Windows.Forms.Button();
            this.btnDestChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            this.src = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findDataSet = new FindAndCopy.FindDataSet();
            this.findDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSrcChoose
            // 
            this.btnSrcChoose.Location = new System.Drawing.Point(30, 35);
            this.btnSrcChoose.Name = "btnSrcChoose";
            this.btnSrcChoose.Size = new System.Drawing.Size(214, 23);
            this.btnSrcChoose.TabIndex = 0;
            this.btnSrcChoose.Text = "Chọn thư mục tìm kiếm";
            this.btnSrcChoose.UseVisualStyleBackColor = true;
            this.btnSrcChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDestChoose
            // 
            this.btnDestChoose.Location = new System.Drawing.Point(30, 64);
            this.btnDestChoose.Name = "btnDestChoose";
            this.btnDestChoose.Size = new System.Drawing.Size(214, 23);
            this.btnDestChoose.TabIndex = 2;
            this.btnDestChoose.Text = "Chọn thư mục copy";
            this.btnDestChoose.UseVisualStyleBackColor = true;
            this.btnDestChoose.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mẫu tìm kiếm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(272, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(272, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(371, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(272, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(371, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(52, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 51);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(218, 137);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(132, 51);
            this.btnMove.TabIndex = 9;
            this.btnMove.Text = "Di chuyển";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số file tìm thấy: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 12;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(626, 340);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(395, 138);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(113, 50);
            this.btnHistory.TabIndex = 14;
            this.btnHistory.Text = "Xem các file đã chuyển";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_click);
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.AllowUserToAddRows = false;
            this.dataGridHistory.AllowUserToDeleteRows = false;
            this.dataGridHistory.AllowUserToResizeColumns = false;
            this.dataGridHistory.AllowUserToResizeRows = false;
            this.dataGridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.src,
            this.desc});
            this.dataGridHistory.Location = new System.Drawing.Point(30, 236);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.RowHeadersWidth = 51;
            this.dataGridHistory.RowTemplate.Height = 24;
            this.dataGridHistory.Size = new System.Drawing.Size(626, 284);
            this.dataGridHistory.TabIndex = 15;
            this.dataGridHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // src
            // 
            this.src.HeaderText = "Nguồn";
            this.src.MinimumWidth = 6;
            this.src.Name = "src";
            this.src.Width = 125;
            // 
            // desc
            // 
            this.desc.HeaderText = "Đích";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.Width = 125;
            // 
            // findDataSet
            // 
            this.findDataSet.DataSetName = "FindDataSet";
            this.findDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findDataSetBindingSource
            // 
            this.findDataSetBindingSource.DataSource = this.findDataSet;
            this.findDataSetBindingSource.Position = 0;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(543, 138);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(113, 50);
            this.btnRestore.TabIndex = 16;
            this.btnRestore.Text = "Khôi phục tất cả";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 603);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.dataGridHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDestChoose);
            this.Controls.Add(this.btnSrcChoose);
            this.Name = "MainDialog";
            this.Text = "Find And Copy (simple)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSrcChoose;
        private System.Windows.Forms.Button btnDestChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.DataGridView dataGridHistory;
        private System.Windows.Forms.BindingSource findDataSetBindingSource;
        private FindDataSet findDataSet;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.DataGridViewTextBoxColumn src;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}

