namespace LoginForm
{
    partial class HomeScreen
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
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnEE = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnInsc = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.Thistle;
            this.btnAlunos.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlunos.Location = new System.Drawing.Point(171, 419);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(204, 58);
            this.btnAlunos.TabIndex = 7;
            this.btnAlunos.Text = "Gestão de Alunos";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnEE
            // 
            this.btnEE.BackColor = System.Drawing.Color.Thistle;
            this.btnEE.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEE.ForeColor = System.Drawing.Color.DimGray;
            this.btnEE.Location = new System.Drawing.Point(414, 419);
            this.btnEE.Name = "btnEE";
            this.btnEE.Size = new System.Drawing.Size(204, 58);
            this.btnEE.TabIndex = 8;
            this.btnEE.Text = "Gestão de E.E";
            this.btnEE.UseVisualStyleBackColor = false;
            this.btnEE.Click += new System.EventHandler(this.btnEE_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Thistle;
            this.btnCursos.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.DimGray;
            this.btnCursos.Location = new System.Drawing.Point(653, 419);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(204, 58);
            this.btnCursos.TabIndex = 9;
            this.btnCursos.Text = "Gestão de Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnInsc
            // 
            this.btnInsc.BackColor = System.Drawing.Color.Thistle;
            this.btnInsc.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsc.ForeColor = System.Drawing.Color.DimGray;
            this.btnInsc.Location = new System.Drawing.Point(895, 419);
            this.btnInsc.Name = "btnInsc";
            this.btnInsc.Size = new System.Drawing.Size(204, 58);
            this.btnInsc.TabIndex = 10;
            this.btnInsc.Text = "Área de Admin";
            this.btnInsc.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Press Start 2P", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(122, 113);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "< Voltar";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.C_HomePage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsc);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.btnEE);
            this.Controls.Add(this.btnAlunos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnEE;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnInsc;
        private System.Windows.Forms.Button btnBack;
    }
}