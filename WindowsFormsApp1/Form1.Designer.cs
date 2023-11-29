namespace MultiThread.WinFormsApp
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
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListMailTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRuningTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogs
            // 
            this.lbLogs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.Location = new System.Drawing.Point(0, 491);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(913, 95);
            this.lbLogs.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guidDataGridViewTextBoxColumn,
            this.ısRunningDataGridViewCheckBoxColumn,
            this.ısStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.nextRuningTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mailTaskBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(913, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnListMailTask
            // 
            this.btnListMailTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMailTask.Location = new System.Drawing.Point(0, 0);
            this.btnListMailTask.Name = "btnListMailTask";
            this.btnListMailTask.Size = new System.Drawing.Size(913, 23);
            this.btnListMailTask.TabIndex = 2;
            this.btnListMailTask.Text = "Get Mail Task";
            this.btnListMailTask.UseVisualStyleBackColor = true;
            this.btnListMailTask.Click += new System.EventHandler(this.btnListMailTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunTask);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(106, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRunTask
            // 
            this.btnRunTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTask.Enabled = false;
            this.btnRunTask.Location = new System.Drawing.Point(797, 19);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(112, 23);
            this.btnRunTask.TabIndex = 2;
            this.btnRunTask.Text = "Run";
            this.btnRunTask.UseVisualStyleBackColor = true;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "Guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            this.ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            this.ısRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            this.ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            this.ısStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            this.secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRuningTimeDataGridViewTextBoxColumn
            // 
            this.nextRuningTimeDataGridViewTextBoxColumn.DataPropertyName = "NextRuningTime";
            this.nextRuningTimeDataGridViewTextBoxColumn.HeaderText = "NextRuningTime";
            this.nextRuningTimeDataGridViewTextBoxColumn.Name = "nextRuningTimeDataGridViewTextBoxColumn";
            this.nextRuningTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailTaskBindingSource
            // 
            this.mailTaskBindingSource.DataSource = typeof(MultiThread.WinFormsApp.MailTask);
            this.mailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListMailTask);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbLogs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mailTaskBindingSource;
        private System.Windows.Forms.Button btnListMailTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRunTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextRuningTimeDataGridViewTextBoxColumn;
    }
}