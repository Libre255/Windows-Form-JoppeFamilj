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
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playFetchBtn
            // 
            this.playFetchBtn.Location = new System.Drawing.Point(60, 57);
            this.playFetchBtn.Name = "playFetchBtn";
            this.playFetchBtn.Size = new System.Drawing.Size(65, 65);
            this.playFetchBtn.TabIndex = 0;
            this.playFetchBtn.Text = "Play fetch";
            this.playFetchBtn.UseVisualStyleBackColor = true;
            this.playFetchBtn.Click += new System.EventHandler(this.playFetchBtn_Click);
            // 
            // ListAnimalsBtn
            // 
            this.ListAnimalsBtn.Location = new System.Drawing.Point(202, 57);
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
            this.listBox1.Location = new System.Drawing.Point(121, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(586, 154);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AnimalPicture
            // 
            this.AnimalPicture.Location = new System.Drawing.Point(252, 229);
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
            this.AnimalPicLabel.Location = new System.Drawing.Point(223, 189);
            this.AnimalPicLabel.Name = "AnimalPicLabel";
            this.AnimalPicLabel.Size = new System.Drawing.Size(58, 23);
            this.AnimalPicLabel.TabIndex = 4;
            this.AnimalPicLabel.Text = "none";
            this.AnimalPicLabel.Visible = false;
            // 
            // FeedPetBtn
            // 
            this.FeedPetBtn.Location = new System.Drawing.Point(131, 57);
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
            this.listView1.Location = new System.Drawing.Point(105, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 236);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}