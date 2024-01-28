namespace PlayYourCardsRightWinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.DownSelect = new System.Windows.Forms.PictureBox();
            this.UPSelect = new System.Windows.Forms.PictureBox();
            this.CardPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DownSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Your Cards Right";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(287, 232);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(139, 44);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(334, 216);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "0";
            // 
            // DownSelect
            // 
            this.DownSelect.Image = global::PlayYourCardsRightWinForms.Properties.Resources.down;
            this.DownSelect.Location = new System.Drawing.Point(188, 179);
            this.DownSelect.Name = "DownSelect";
            this.DownSelect.Size = new System.Drawing.Size(53, 50);
            this.DownSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownSelect.TabIndex = 6;
            this.DownSelect.TabStop = false;
            this.DownSelect.Click += new System.EventHandler(this.DownSelect_Click);
            // 
            // UPSelect
            // 
            this.UPSelect.Image = global::PlayYourCardsRightWinForms.Properties.Resources.up;
            this.UPSelect.Location = new System.Drawing.Point(188, 117);
            this.UPSelect.Name = "UPSelect";
            this.UPSelect.Size = new System.Drawing.Size(53, 50);
            this.UPSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UPSelect.TabIndex = 5;
            this.UPSelect.TabStop = false;
            this.UPSelect.Click += new System.EventHandler(this.UPSelect_Click);
            // 
            // CardPicture
            // 
            this.CardPicture.Image = global::PlayYourCardsRightWinForms.Properties.Resources.card_back;
            this.CardPicture.InitialImage = global::PlayYourCardsRightWinForms.Properties.Resources.card_back;
            this.CardPicture.Location = new System.Drawing.Point(20, 75);
            this.CardPicture.Name = "CardPicture";
            this.CardPicture.Size = new System.Drawing.Size(162, 215);
            this.CardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardPicture.TabIndex = 1;
            this.CardPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 336);
            this.Controls.Add(this.DownSelect);
            this.Controls.Add(this.UPSelect);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CardPicture);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Play Your Cards Right";
            ((System.ComponentModel.ISupportInitialize)(this.DownSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CardPicture;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox UPSelect;
        private System.Windows.Forms.PictureBox DownSelect;
    }
}

