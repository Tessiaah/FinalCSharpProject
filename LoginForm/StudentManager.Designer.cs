namespace LoginForm
{
    partial class StudentManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(129, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtrar por nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(120, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 5);
            this.panel1.TabIndex = 4;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.Thistle;
            this.txtFilter.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilter.Location = new System.Drawing.Point(519, 140);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(501, 26);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Thistle;
            this.btnFilter.BackgroundImage = global::LoginForm.Properties.Resources.search;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.DimGray;
            this.btnFilter.Location = new System.Drawing.Point(1026, 132);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 41);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvStudents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Press Start 2P", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.Location = new System.Drawing.Point(150, 216);
            this.dgvStudents.Name = "dgvStudents";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Press Start 2P", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudents.Size = new System.Drawing.Size(971, 264);
            this.dgvStudents.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEdit.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Location = new System.Drawing.Point(498, 500);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(257, 58);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Terminar Edição";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.C_UI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.ControlBox = false;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StudentManager";
            this.Text = "StudentManager";
            this.Load += new System.EventHandler(this.StudentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnEdit;
    }
}