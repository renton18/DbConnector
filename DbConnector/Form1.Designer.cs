namespace DbConnector
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlServerBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dbPortCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serverNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dbNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbTypeCb = new System.Windows.Forms.ComboBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.userTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 396);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showDgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 192);
            this.panel3.TabIndex = 2;
            // 
            // showDgv
            // 
            this.showDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDgv.Location = new System.Drawing.Point(0, 0);
            this.showDgv.Name = "showDgv";
            this.showDgv.RowTemplate.Height = 21;
            this.showDgv.Size = new System.Drawing.Size(794, 192);
            this.showDgv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sqlServerBt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 192);
            this.panel1.TabIndex = 0;
            // 
            // sqlServerBt
            // 
            this.sqlServerBt.Location = new System.Drawing.Point(261, 9);
            this.sqlServerBt.Name = "sqlServerBt";
            this.sqlServerBt.Size = new System.Drawing.Size(145, 47);
            this.sqlServerBt.TabIndex = 0;
            this.sqlServerBt.Text = "データ取得";
            this.sqlServerBt.UseVisualStyleBackColor = true;
            this.sqlServerBt.Click += new System.EventHandler(this.sqlServerBt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dbPortCb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.serverNameTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dbNameTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dbTypeCb);
            this.panel2.Controls.Add(this.passwordTb);
            this.panel2.Controls.Add(this.userTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 180);
            this.panel2.TabIndex = 3;
            // 
            // dbPortCb
            // 
            this.dbPortCb.FormattingEnabled = true;
            this.dbPortCb.Items.AddRange(new object[] {
            "3306",
            "1433"});
            this.dbPortCb.Location = new System.Drawing.Point(83, 70);
            this.dbPortCb.Name = "dbPortCb";
            this.dbPortCb.Size = new System.Drawing.Size(148, 20);
            this.dbPortCb.TabIndex = 5;
            this.dbPortCb.Text = "3306";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // serverNameTb
            // 
            this.serverNameTb.Location = new System.Drawing.Point(83, 45);
            this.serverNameTb.Name = "serverNameTb";
            this.serverNameTb.Size = new System.Drawing.Size(148, 19);
            this.serverNameTb.TabIndex = 10;
            this.serverNameTb.Text = "localhost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "ServerName";
            // 
            // dbNameTb
            // 
            this.dbNameTb.Location = new System.Drawing.Point(83, 95);
            this.dbNameTb.Name = "dbNameTb";
            this.dbNameTb.Size = new System.Drawing.Size(148, 19);
            this.dbNameTb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "DB Name";
            // 
            // dbTypeCb
            // 
            this.dbTypeCb.FormattingEnabled = true;
            this.dbTypeCb.Items.AddRange(new object[] {
            "mysql",
            "sqlserver"});
            this.dbTypeCb.Location = new System.Drawing.Point(83, 19);
            this.dbTypeCb.Name = "dbTypeCb";
            this.dbTypeCb.Size = new System.Drawing.Size(148, 20);
            this.dbTypeCb.TabIndex = 4;
            this.dbTypeCb.Text = "mysql";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(83, 145);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(148, 19);
            this.passwordTb.TabIndex = 6;
            // 
            // userTb
            // 
            this.userTb.Location = new System.Drawing.Point(83, 120);
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(148, 19);
            this.userTb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "DB Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sqlServerBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView showDgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox dbTypeCb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox userTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dbPortCb;
        private System.Windows.Forms.Label label6;
    }
}

