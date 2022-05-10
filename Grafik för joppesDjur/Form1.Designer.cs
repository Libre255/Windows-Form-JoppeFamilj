namespace Grafik_för_joppesDjur
{
    partial class Form1
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
            this.playFetchBtn = new System.Windows.Forms.Button();
            this.ListAnimalsBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AnimalPicture = new System.Windows.Forms.PictureBox();
            this.AnimalPicLabel = new System.Windows.Forms.Label();
            this.FeedPetBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PrintAnimals = new System.Windows.Forms.Button();
            this.CheckBallStatus = new System.Windows.Forms.Button();
            this.Checkstatus = new System.Windows.Forms.TextBox();
            this.CheckLaserStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playFetchBtn
            // 
            this.playFetchBtn.Location = new System.Drawing.Point(199, 45);
            this.playFetchBtn.Name = "playFetchBtn";
            this.playFetchBtn.Size = new System.Drawing.Size(65, 65);
            this.playFetchBtn.TabIndex = 0;
            this.playFetchBtn.Text = "Play fetch";
            this.playFetchBtn.UseVisualStyleBackColor = true;
            this.playFetchBtn.Click += new System.EventHandler(this.playFetchBtn_Click);
            // 
            // ListAnimalsBtn
            // 
            this.ListAnimalsBtn.Location = new System.Drawing.Point(341, 45);
            this.ListAnimalsBtn.Name = "ListAnimalsBtn";
            this.ListAnimalsBtn.Size = new System.Drawing.Size(65, 65);
            this.ListAnimalsBtn.TabIndex = 1;
            this.ListAnimalsBtn.Text = "List animals";
            this.ListAnimalsBtn.UseVisualStyleBackColor = true;
            this.ListAnimalsBtn.Click += new System.EventHandler(this.ListAnimalsBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(124, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(586, 154);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AnimalPicture
            // 
            this.AnimalPicture.Location = new System.Drawing.Point(254, 198);
            this.AnimalPicture.Name = "AnimalPicture";
            this.AnimalPicture.Size = new System.Drawing.Size(294, 209);
            this.AnimalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnimalPicture.TabIndex = 3;
            this.AnimalPicture.TabStop = false;
            this.AnimalPicture.Visible = false;
            // 
            // AnimalPicLabel
            // 
            this.AnimalPicLabel.AutoSize = true;
            this.AnimalPicLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimalPicLabel.Location = new System.Drawing.Point(199, 172);
            this.AnimalPicLabel.Name = "AnimalPicLabel";
            this.AnimalPicLabel.Size = new System.Drawing.Size(58, 23);
            this.AnimalPicLabel.TabIndex = 4;
            this.AnimalPicLabel.Text = "none";
            this.AnimalPicLabel.Visible = false;
            this.AnimalPicLabel.Click += new System.EventHandler(this.AnimalPicLabel_Click);
            // 
            // FeedPetBtn
            // 
            this.FeedPetBtn.Location = new System.Drawing.Point(270, 45);
            this.FeedPetBtn.Name = "FeedPetBtn";
            this.FeedPetBtn.Size = new System.Drawing.Size(65, 65);
            this.FeedPetBtn.TabIndex = 5;
            this.FeedPetBtn.Text = "Feed Pet";
            this.FeedPetBtn.UseVisualStyleBackColor = true;
            this.FeedPetBtn.Click += new System.EventHandler(this.FeedPetBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1KeyDown);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(158, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 236);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // PrintAnimals
            // 
            this.PrintAnimals.Location = new System.Drawing.Point(412, 45);
            this.PrintAnimals.Name = "PrintAnimals";
            this.PrintAnimals.Size = new System.Drawing.Size(65, 65);
            this.PrintAnimals.TabIndex = 8;
            this.PrintAnimals.Text = "Print out Animals";
            this.PrintAnimals.UseVisualStyleBackColor = true;
            this.PrintAnimals.Click += new System.EventHandler(this.PrintAnimals_Click);
            // 
            // CheckBallStatus
            // 
            this.CheckBallStatus.Location = new System.Drawing.Point(483, 45);
            this.CheckBallStatus.Name = "CheckBallStatus";
            this.CheckBallStatus.Size = new System.Drawing.Size(65, 65);
            this.CheckBallStatus.TabIndex = 9;
            this.CheckBallStatus.Text = "Check Ball Status";
            this.CheckBallStatus.UseVisualStyleBackColor = true;
            this.CheckBallStatus.Click += new System.EventHandler(this.CheckBallStatus_Click);
            // 
            // Checkstatus
            // 
            this.Checkstatus.Location = new System.Drawing.Point(230, 172);
            this.Checkstatus.Multiline = true;
            this.Checkstatus.Name = "Checkstatus";
            this.Checkstatus.ReadOnly = true;
            this.Checkstatus.Size = new System.Drawing.Size(370, 32);
            this.Checkstatus.TabIndex = 10;
            this.Checkstatus.Visible = false;
            // 
            // CheckLaserStatus
            // 
            this.CheckLaserStatus.Location = new System.Drawing.Point(554, 45);
            this.CheckLaserStatus.Name = "CheckLaserStatus";
            this.CheckLaserStatus.Size = new System.Drawing.Size(65, 65);
            this.CheckLaserStatus.TabIndex = 11;
            this.CheckLaserStatus.Text = "Check Laser Status";
            this.CheckLaserStatus.UseVisualStyleBackColor = true;
            this.CheckLaserStatus.Click += new System.EventHandler(this.CheckLaserStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckLaserStatus);
            this.Controls.Add(this.Checkstatus);
            this.Controls.Add(this.CheckBallStatus);
            this.Controls.Add(this.PrintAnimals);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FeedPetBtn);
            this.Controls.Add(this.AnimalPicLabel);
            this.Controls.Add(this.AnimalPicture);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ListAnimalsBtn);
            this.Controls.Add(this.playFetchBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button playFetchBtn;
        private Button ListAnimalsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBox1;
        private PictureBox AnimalPicture;
        private Label AnimalPicLabel;
        private Button FeedPetBtn;
        private TextBox textBox1;
        private ListView listView1;
        private Button PrintAnimals;
        private Button CheckBallStatus;
        private TextBox Checkstatus;
        private Button CheckLaserStatus;
    }
}