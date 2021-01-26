namespace CatsAndDogs
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
            this.DogPicture = new System.Windows.Forms.PictureBox();
            this.GetaDog = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CatPicture = new System.Windows.Forms.PictureBox();
            this.GetaCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicture
            // 
            this.DogPicture.Location = new System.Drawing.Point(1114, 63);
            this.DogPicture.Name = "DogPicture";
            this.DogPicture.Size = new System.Drawing.Size(397, 405);
            this.DogPicture.TabIndex = 0;
            this.DogPicture.TabStop = false;
            // 
            // GetaDog
            // 
            this.GetaDog.Location = new System.Drawing.Point(1252, 536);
            this.GetaDog.Name = "GetaDog";
            this.GetaDog.Size = new System.Drawing.Size(139, 41);
            this.GetaDog.TabIndex = 1;
            this.GetaDog.Text = "Get a Dog";
            this.GetaDog.UseVisualStyleBackColor = true;
            this.GetaDog.Click += new System.EventHandler(this.GetaDog_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // CatPicture
            // 
            this.CatPicture.Location = new System.Drawing.Point(134, 63);
            this.CatPicture.Name = "CatPicture";
            this.CatPicture.Size = new System.Drawing.Size(397, 405);
            this.CatPicture.TabIndex = 3;
            this.CatPicture.TabStop = false;
            // 
            // GetaCat
            // 
            this.GetaCat.Location = new System.Drawing.Point(257, 516);
            this.GetaCat.Name = "GetaCat";
            this.GetaCat.Size = new System.Drawing.Size(130, 42);
            this.GetaCat.TabIndex = 4;
            this.GetaCat.Text = "Get a Cat";
            this.GetaCat.UseVisualStyleBackColor = true;
            this.GetaCat.Click += new System.EventHandler(this.GetaCat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 855);
            this.Controls.Add(this.GetaCat);
            this.Controls.Add(this.CatPicture);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GetaDog);
            this.Controls.Add(this.DogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicture;
        private System.Windows.Forms.Button GetaDog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox CatPicture;
        private System.Windows.Forms.Button GetaCat;
    }
}

