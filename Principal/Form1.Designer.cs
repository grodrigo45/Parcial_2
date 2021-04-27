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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pswTxt = new System.Windows.Forms.TextBox();
            this.backUpBtn = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(142, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario (con el que inicia sesión en la base de datos)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(141, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base de datos (El nombre de la base de datos )";
            // 
            // pswTxt
            // 
            this.pswTxt.Location = new System.Drawing.Point(141, 258);
            this.pswTxt.Name = "pswTxt";
            this.pswTxt.Size = new System.Drawing.Size(348, 20);
            this.pswTxt.TabIndex = 1;
            // 
            // backUpBtn
            // 
            this.backUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.backUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backUpBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.backUpBtn.Image = ((System.Drawing.Image) (resources.GetObject("backUpBtn.Image")));
            this.backUpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backUpBtn.Location = new System.Drawing.Point(784, 95);
            this.backUpBtn.Name = "backUpBtn";
            this.backUpBtn.Size = new System.Drawing.Size(120, 71);
            this.backUpBtn.TabIndex = 6;
            this.backUpBtn.Text = "Respaldar";
            this.backUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backUpBtn.UseVisualStyleBackColor = true;
            this.backUpBtn.Click += new System.EventHandler(this.backUpBtn_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(140, 134);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(347, 20);
            this.userTxt.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.Image = ((System.Drawing.Image) (resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(784, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "Restaurar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(141, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // dbTxt
            // 
            this.dbTxt.Location = new System.Drawing.Point(141, 387);
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(347, 20);
            this.dbTxt.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Image = ((System.Drawing.Image) (resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.Location = new System.Drawing.Point(784, 335);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 70);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Salir";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(237, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(580, 51);
            this.label4.TabIndex = 12;
            this.label4.Text = "Respaldo y Recuperacion de base de datos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dbTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.userTxt);
            this.panel1.Controls.Add(this.backUpBtn);
            this.panel1.Controls.Add(this.pswTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 441);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 481);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button backUpBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dbTxt;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox pswTxt;
        private System.Windows.Forms.TextBox userTxt;

        #endregion
    }
}