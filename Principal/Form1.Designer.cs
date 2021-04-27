namespace Principal
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
            this.userTxt = new System.Windows.Forms.TextBox();
            this.pswTxt = new System.Windows.Forms.TextBox();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backUpBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(75, 119);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(347, 20);
            this.userTxt.TabIndex = 0;
            // 
            // pswTxt
            // 
            this.pswTxt.Location = new System.Drawing.Point(74, 199);
            this.pswTxt.Name = "pswTxt";
            this.pswTxt.Size = new System.Drawing.Size(348, 20);
            this.pswTxt.TabIndex = 1;
            // 
            // dbTxt
            // 
            this.dbTxt.Location = new System.Drawing.Point(73, 286);
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(347, 20);
            this.dbTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(75, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario  (mismo de la base de datos)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(73, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base de datos (Nombre)";
            // 
            // backUpBtn
            // 
            this.backUpBtn.Location = new System.Drawing.Point(74, 353);
            this.backUpBtn.Name = "backUpBtn";
            this.backUpBtn.Size = new System.Drawing.Size(126, 31);
            this.backUpBtn.TabIndex = 6;
            this.backUpBtn.Text = "Respaldo";
            this.backUpBtn.UseVisualStyleBackColor = true;
            this.backUpBtn.Click += new System.EventHandler(this.backUpBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Restaurar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backUpBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbTxt);
            this.Controls.Add(this.pswTxt);
            this.Controls.Add(this.userTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button backUpBtn;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pswTxt;
        private System.Windows.Forms.TextBox dbTxt;

        private System.Windows.Forms.TextBox userTxt;

        #endregion
    }
}