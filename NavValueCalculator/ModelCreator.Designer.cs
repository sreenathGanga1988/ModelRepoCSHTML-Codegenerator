namespace NavValueCalculator
{
    partial class ModelCreator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_modelname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_isselected = new System.Windows.Forms.CheckBox();
            this.chK_PostIndex = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Model = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Repo = new System.Windows.Forms.GroupBox();
            this.rht_repo = new System.Windows.Forms.RichTextBox();
            this.rcht_post = new System.Windows.Forms.GroupBox();
            this.rht_post = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Repo.SuspendLayout();
            this.rcht_post.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ModelName : ";
            // 
            // txt_modelname
            // 
            this.txt_modelname.Location = new System.Drawing.Point(106, 21);
            this.txt_modelname.Name = "txt_modelname";
            this.txt_modelname.Size = new System.Drawing.Size(192, 20);
            this.txt_modelname.TabIndex = 4;
            this.txt_modelname.Text = "TestModel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_isselected);
            this.panel1.Controls.Add(this.chK_PostIndex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_modelname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 92);
            this.panel1.TabIndex = 5;
            // 
            // chk_isselected
            // 
            this.chk_isselected.AutoSize = true;
            this.chk_isselected.Location = new System.Drawing.Point(602, 12);
            this.chk_isselected.Name = "chk_isselected";
            this.chk_isselected.Size = new System.Drawing.Size(98, 17);
            this.chk_isselected.TabIndex = 6;
            this.chk_isselected.Text = "Add IsSelected";
            this.chk_isselected.UseVisualStyleBackColor = true;
            // 
            // chK_PostIndex
            // 
            this.chK_PostIndex.AutoSize = true;
            this.chK_PostIndex.Location = new System.Drawing.Point(520, 12);
            this.chK_PostIndex.Name = "chK_PostIndex";
            this.chK_PostIndex.Size = new System.Drawing.Size(76, 17);
            this.chK_PostIndex.TabIndex = 5;
            this.chK_PostIndex.Text = "Post Index";
            this.chK_PostIndex.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 131);
            this.panel2.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(951, 107);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Query";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Controls.Add(this.Model);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 194);
            this.panel3.TabIndex = 7;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 24);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(951, 170);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Dock = System.Windows.Forms.DockStyle.Top;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model.Location = new System.Drawing.Point(0, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(68, 24);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 191);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(3, 16);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(338, 172);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            // 
            // Repo
            // 
            this.Repo.Controls.Add(this.rht_repo);
            this.Repo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Repo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repo.Location = new System.Drawing.Point(344, 417);
            this.Repo.Name = "Repo";
            this.Repo.Size = new System.Drawing.Size(269, 191);
            this.Repo.TabIndex = 10;
            this.Repo.TabStop = false;
            this.Repo.Text = "Repo";
            // 
            // rht_repo
            // 
            this.rht_repo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rht_repo.Location = new System.Drawing.Point(3, 16);
            this.rht_repo.Name = "rht_repo";
            this.rht_repo.Size = new System.Drawing.Size(263, 172);
            this.rht_repo.TabIndex = 0;
            this.rht_repo.Text = "";
            // 
            // rcht_post
            // 
            this.rcht_post.Controls.Add(this.rht_post);
            this.rcht_post.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcht_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rcht_post.Location = new System.Drawing.Point(613, 417);
            this.rcht_post.Name = "rcht_post";
            this.rcht_post.Size = new System.Drawing.Size(338, 191);
            this.rcht_post.TabIndex = 11;
            this.rcht_post.TabStop = false;
            this.rcht_post.Text = "groupBox2";
            // 
            // rht_post
            // 
            this.rht_post.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rht_post.Location = new System.Drawing.Point(3, 16);
            this.rht_post.Name = "rht_post";
            this.rht_post.Size = new System.Drawing.Size(332, 172);
            this.rht_post.TabIndex = 0;
            this.rht_post.Text = "";
            // 
            // ModelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 608);
            this.Controls.Add(this.rcht_post);
            this.Controls.Add(this.Repo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModelCreator";
            this.Text = "ModelCreator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Repo.ResumeLayout(false);
            this.rcht_post.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_modelname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.GroupBox Repo;
        private System.Windows.Forms.RichTextBox rht_repo;
        private System.Windows.Forms.GroupBox rcht_post;
        private System.Windows.Forms.RichTextBox rht_post;
        private System.Windows.Forms.CheckBox chk_isselected;
        private System.Windows.Forms.CheckBox chK_PostIndex;
    }
}