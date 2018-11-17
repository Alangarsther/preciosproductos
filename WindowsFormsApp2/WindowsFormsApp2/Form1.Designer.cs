namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnump = new System.Windows.Forms.TextBox();
            this.txtnumgen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTxttotalp = new System.Windows.Forms.RichTextBox();
            this.ListBoxRes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Numero Generacion";
            // 
            // txtnump
            // 
            this.txtnump.Location = new System.Drawing.Point(212, 52);
            this.txtnump.Name = "txtnump";
            this.txtnump.Size = new System.Drawing.Size(100, 20);
            this.txtnump.TabIndex = 2;
            // 
            // txtnumgen
            // 
            this.txtnumgen.Location = new System.Drawing.Point(212, 110);
            this.txtnumgen.Name = "txtnumgen";
            this.txtnumgen.Size = new System.Drawing.Size(100, 20);
            this.txtnumgen.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTxttotalp
            // 
            this.richTxttotalp.Location = new System.Drawing.Point(520, 155);
            this.richTxttotalp.Name = "richTxttotalp";
            this.richTxttotalp.Size = new System.Drawing.Size(185, 216);
            this.richTxttotalp.TabIndex = 5;
            this.richTxttotalp.Text = "";
            // 
            // ListBoxRes
            // 
            this.ListBoxRes.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ListBoxRes.FormattingEnabled = true;
            this.ListBoxRes.Location = new System.Drawing.Point(90, 181);
            this.ListBoxRes.Name = "ListBoxRes";
            this.ListBoxRes.Size = new System.Drawing.Size(158, 199);
            this.ListBoxRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxRes);
            this.Controls.Add(this.richTxttotalp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumgen);
            this.Controls.Add(this.txtnump);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GENERADOR DE ALBOR GENEALOGICO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnump;
        private System.Windows.Forms.TextBox txtnumgen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTxttotalp;
        private System.Windows.Forms.ListBox ListBoxRes;
    }
}

