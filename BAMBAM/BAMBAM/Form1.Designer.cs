
namespace BAMBAM
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroMONSTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoMonstroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoMonstroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblConectar = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMONSTROToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroMONSTROToolStripMenuItem
            // 
            this.cadastroMONSTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoMonstroToolStripMenuItem,
            this.cursoMonstroToolStripMenuItem});
            this.cadastroMONSTROToolStripMenuItem.Name = "cadastroMONSTROToolStripMenuItem";
            this.cadastroMONSTROToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.cadastroMONSTROToolStripMenuItem.Text = "Cadastro MONSTRO";
            // 
            // alunoMonstroToolStripMenuItem
            // 
            this.alunoMonstroToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.alunoMonstroToolStripMenuItem.Name = "alunoMonstroToolStripMenuItem";
            this.alunoMonstroToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.alunoMonstroToolStripMenuItem.Text = "Aluno Monstro";
            // 
            // cursoMonstroToolStripMenuItem
            // 
            this.cursoMonstroToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.cursoMonstroToolStripMenuItem.Name = "cursoMonstroToolStripMenuItem";
            this.cursoMonstroToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cursoMonstroToolStripMenuItem.Text = "Curso Monstro";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Transparent;
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(13, 292);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(171, 54);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btn_Conectar);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(534, 315);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 31);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR\r\n";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblConectar
            // 
            this.lblConectar.AutoSize = true;
            this.lblConectar.BackColor = System.Drawing.Color.Transparent;
            this.lblConectar.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConectar.ForeColor = System.Drawing.Color.Red;
            this.lblConectar.Location = new System.Drawing.Point(12, 57);
            this.lblConectar.Name = "lblConectar";
            this.lblConectar.Size = new System.Drawing.Size(212, 18);
            this.lblConectar.TabIndex = 3;
            this.lblConectar.Text = "SISTEMA  DESCONECTADO";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 359);
            this.Controls.Add(this.lblConectar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAMBAM CURSOS";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroMONSTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoMonstroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoMonstroToolStripMenuItem;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblConectar;
    }
}

