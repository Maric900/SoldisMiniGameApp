namespace SoldisMiniGameApp
{
    partial class FlappyBird
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
            this.scoreTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pipeDown2 = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBirdPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gameTimeFlappyBird = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBirdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(344, 403);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(113, 38);
            this.scoreTxt.TabIndex = 8;
            this.scoreTxt.Text = "Score:0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoldisMiniGameApp.Properties.Resources.cloud;
            this.pictureBox1.Location = new System.Drawing.Point(194, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::SoldisMiniGameApp.Properties.Resources.pipedown;
            this.pipeTop2.Location = new System.Drawing.Point(935, -29);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(100, 146);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 7;
            this.pipeTop2.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::SoldisMiniGameApp.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-22, 384);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(859, 90);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 6;
            this.Ground.TabStop = false;
            // 
            // pipeDown2
            // 
            this.pipeDown2.Image = global::SoldisMiniGameApp.Properties.Resources.pipe;
            this.pipeDown2.Location = new System.Drawing.Point(951, 286);
            this.pipeDown2.Name = "pipeDown2";
            this.pipeDown2.Size = new System.Drawing.Size(93, 143);
            this.pipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown2.TabIndex = 5;
            this.pipeDown2.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::SoldisMiniGameApp.Properties.Resources.pipe;
            this.pipeDown.Location = new System.Drawing.Point(376, 247);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 182);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 4;
            this.pipeDown.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::SoldisMiniGameApp.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(376, -13);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 104);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // flappyBirdPicture
            // 
            this.flappyBirdPicture.Image = global::SoldisMiniGameApp.Properties.Resources.bird;
            this.flappyBirdPicture.Location = new System.Drawing.Point(76, 188);
            this.flappyBirdPicture.Margin = new System.Windows.Forms.Padding(40, 20, 20, 20);
            this.flappyBirdPicture.Name = "flappyBirdPicture";
            this.flappyBirdPicture.Size = new System.Drawing.Size(74, 60);
            this.flappyBirdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBirdPicture.TabIndex = 2;
            this.flappyBirdPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoldisMiniGameApp.Properties.Resources.cloud;
            this.pictureBox2.Location = new System.Drawing.Point(529, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SoldisMiniGameApp.Properties.Resources.cloud;
            this.pictureBox3.Location = new System.Drawing.Point(659, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // gameTimeFlappyBird
            // 
            this.gameTimeFlappyBird.Enabled = true;
            this.gameTimeFlappyBird.Interval = 20;
            this.gameTimeFlappyBird.Tick += new System.EventHandler(this.gameTimeEvent);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.flappyBirdPicture);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pipeDown2);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlappyBird";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBirdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBirdPicture;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox pipeDown2;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer gameTimeFlappyBird;
    }
}