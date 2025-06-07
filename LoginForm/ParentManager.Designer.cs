namespace LoginForm
{
    partial class ParentManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvParents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).BeginInit();
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
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.Thistle;
            this.txtFilter.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilter.Location = new System.Drawing.Point(519, 140);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(501, 26);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Thistle;
            this.btnFilter.BackgroundImage = global::LoginForm.Properties.Resources.search;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Enabled = false;
            this.btnFilter.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.DimGray;
            this.btnFilter.Location = new System.Drawing.Point(1026, 132);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 41);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // dgvParents
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.dgvParents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvParents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Press Start 2P", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParents.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvParents.EnableHeadersVisualStyles = false;
            this.dgvParents.Location = new System.Drawing.Point(150, 216);
            this.dgvParents.Name = "dgvParents";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Press Start 2P", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParents.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Press Start 2P", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.dgvParents.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvParents.Size = new System.Drawing.Size(971, 264);
            this.dgvParents.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(120, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 5);
            this.panel1.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEdit.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Location = new System.Drawing.Point(491, 501);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(257, 58);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Terminar Edição";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Press Start 2P", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(120, 537);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "< Voltar";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ParentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.C_UI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvParents);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentManager";
            this.Text = "ParentManager";
            this.Load += new System.EventHandler(this.ParentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
    }
}