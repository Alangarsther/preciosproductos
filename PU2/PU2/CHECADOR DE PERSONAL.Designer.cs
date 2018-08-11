namespace PU2
{
    partial class CHECADOR_DE_PERSONAL
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(145, 38);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(428, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Sistema de control de entrada y salida de empresa sa de cv";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "POR FAVOR CHECAR ENTRADA O SALIDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PU2.Properties.Resources.icono_persona;
            this.pictureBox1.Location = new System.Drawing.Point(28, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(347, 198);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(65, 22);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "label3";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(359, 97);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(35, 13);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "label3";
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Location = new System.Drawing.Point(359, 75);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(35, 13);
            this.lblsubtitulo.TabIndex = 6;
            this.lblsubtitulo.Text = "label4";
            // 
            // CHECADOR_DE_PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "CHECADOR_DE_PERSONAL";
            this.Text = "CHECADOR_DE_PERSONAL";
            this.Load += new System.EventHandler(this.CHECADOR_DE_PERSONAL_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CHECADOR_DE_PERSONAL_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblsubtitulo;
    }
}