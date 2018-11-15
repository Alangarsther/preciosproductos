namespace ARBOL
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtnump = new System.Windows.Forms.TextBox();
            this.btmComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(34, 38);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 271);
            this.treeView1.TabIndex = 0;
            // 
            // txtnump
            // 
            this.txtnump.Location = new System.Drawing.Point(346, 41);
            this.txtnump.Name = "txtnump";
            this.txtnump.Size = new System.Drawing.Size(100, 20);
            this.txtnump.TabIndex = 1;
            // 
            // btmComenzar
            // 
            this.btmComenzar.Location = new System.Drawing.Point(487, 38);
            this.btmComenzar.Name = "btmComenzar";
            this.btmComenzar.Size = new System.Drawing.Size(75, 23);
            this.btmComenzar.TabIndex = 2;
            this.btmComenzar.Text = "comenzar";
            this.btmComenzar.UseVisualStyleBackColor = true;
            this.btmComenzar.Click += new System.EventHandler(this.btmComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero persona";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmComenzar);
            this.Controls.Add(this.txtnump);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtnump;
        private System.Windows.Forms.Button btmComenzar;
        private System.Windows.Forms.Label label1;
    }
}

