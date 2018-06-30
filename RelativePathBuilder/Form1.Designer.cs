namespace RelativePathBuilder
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
        protected override void Dispose( bool disposing )
        {

            if( disposing && (components != null) )
            {
                if( 1 == 1 )
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.textBoxResult12 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxIsFilename1 = new System.Windows.Forms.CheckBox();
            this.checkBoxIsFilename2 = new System.Windows.Forms.CheckBox();
            this.buttonCopy12 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxPath1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPath2 = new System.Windows.Forms.ComboBox();
            this.buttonCopy21 = new System.Windows.Forms.Button();
            this.textBoxResult21 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResult12 = new System.Windows.Forms.Label();
            this.labelResult21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse1.Location = new System.Drawing.Point(441, 40);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(95, 23);
            this.buttonBrowse1.TabIndex = 2;
            this.buttonBrowse1.Text = "Browse...";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse2.Location = new System.Drawing.Point(440, 109);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(96, 23);
            this.buttonBrowse2.TabIndex = 7;
            this.buttonBrowse2.Text = "Browse...";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // textBoxResult12
            // 
            this.textBoxResult12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult12.Location = new System.Drawing.Point(67, 202);
            this.textBoxResult12.Multiline = true;
            this.textBoxResult12.Name = "textBoxResult12";
            this.textBoxResult12.ReadOnly = true;
            this.textBoxResult12.Size = new System.Drawing.Size(364, 22);
            this.textBoxResult12.TabIndex = 10;
            this.textBoxResult12.TextChanged += new System.EventHandler(this.textBoxResult12_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Relative paths:";
            // 
            // checkBoxIsFilename1
            // 
            this.checkBoxIsFilename1.AutoSize = true;
            this.checkBoxIsFilename1.Location = new System.Drawing.Point(42, 69);
            this.checkBoxIsFilename1.Name = "checkBoxIsFilename1";
            this.checkBoxIsFilename1.Size = new System.Drawing.Size(113, 17);
            this.checkBoxIsFilename1.TabIndex = 3;
            this.checkBoxIsFilename1.Text = "This is a filename";
            this.checkBoxIsFilename1.UseVisualStyleBackColor = true;
            this.checkBoxIsFilename1.CheckedChanged += new System.EventHandler(this.CheckboxCheckChanged);
            // 
            // checkBoxIsFilename2
            // 
            this.checkBoxIsFilename2.AutoSize = true;
            this.checkBoxIsFilename2.Location = new System.Drawing.Point(42, 136);
            this.checkBoxIsFilename2.Name = "checkBoxIsFilename2";
            this.checkBoxIsFilename2.Size = new System.Drawing.Size(113, 17);
            this.checkBoxIsFilename2.TabIndex = 8;
            this.checkBoxIsFilename2.Text = "This is a filename";
            this.checkBoxIsFilename2.UseVisualStyleBackColor = true;
            // 
            // buttonCopy12
            // 
            this.buttonCopy12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy12.Enabled = false;
            this.buttonCopy12.Image = global::RelativePathBuilder.Properties.Resources.copy_16px;
            this.buttonCopy12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopy12.Location = new System.Drawing.Point(441, 202);
            this.buttonCopy12.Name = "buttonCopy12";
            this.buttonCopy12.Size = new System.Drawing.Size(95, 23);
            this.buttonCopy12.TabIndex = 11;
            this.buttonCopy12.Text = "Copy";
            this.buttonCopy12.UseVisualStyleBackColor = true;
            this.buttonCopy12.Click += new System.EventHandler(this.buttonCopy12_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(9, 99);
            this.linkLabel2.Location = new System.Drawing.Point(11, 290);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(105, 20);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Icons by Icons8.com";
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(122, 290);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(371, 20);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "by Heinz Kessler, Version {0}";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxPath1
            // 
            this.comboBoxPath1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPath1.FormattingEnabled = true;
            this.comboBoxPath1.Location = new System.Drawing.Point(42, 40);
            this.comboBoxPath1.Name = "comboBoxPath1";
            this.comboBoxPath1.Size = new System.Drawing.Size(388, 21);
            this.comboBoxPath1.TabIndex = 15;
            this.comboBoxPath1.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // comboBoxPath2
            // 
            this.comboBoxPath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPath2.FormattingEnabled = true;
            this.comboBoxPath2.Location = new System.Drawing.Point(42, 109);
            this.comboBoxPath2.Name = "comboBoxPath2";
            this.comboBoxPath2.Size = new System.Drawing.Size(387, 21);
            this.comboBoxPath2.TabIndex = 16;
            this.comboBoxPath2.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonCopy21
            // 
            this.buttonCopy21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy21.Enabled = false;
            this.buttonCopy21.Image = global::RelativePathBuilder.Properties.Resources.copy_16px;
            this.buttonCopy21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopy21.Location = new System.Drawing.Point(440, 231);
            this.buttonCopy21.Name = "buttonCopy21";
            this.buttonCopy21.Size = new System.Drawing.Size(95, 23);
            this.buttonCopy21.TabIndex = 18;
            this.buttonCopy21.Text = "Copy";
            this.buttonCopy21.UseVisualStyleBackColor = true;
            this.buttonCopy21.Click += new System.EventHandler(this.buttonCopy21_Click);
            // 
            // textBoxResult21
            // 
            this.textBoxResult21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult21.Location = new System.Drawing.Point(67, 231);
            this.textBoxResult21.Multiline = true;
            this.textBoxResult21.Name = "textBoxResult21";
            this.textBoxResult21.ReadOnly = true;
            this.textBoxResult21.Size = new System.Drawing.Size(363, 22);
            this.textBoxResult21.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "2";
            // 
            // labelResult12
            // 
            this.labelResult12.AutoSize = true;
            this.labelResult12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult12.Location = new System.Drawing.Point(12, 196);
            this.labelResult12.Name = "labelResult12";
            this.labelResult12.Size = new System.Drawing.Size(49, 30);
            this.labelResult12.TabIndex = 21;
            this.labelResult12.Text = "1>2";
            // 
            // labelResult21
            // 
            this.labelResult21.AutoSize = true;
            this.labelResult21.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult21.Location = new System.Drawing.Point(12, 225);
            this.labelResult21.Name = "labelResult21";
            this.labelResult21.Size = new System.Drawing.Size(49, 30);
            this.labelResult21.TabIndex = 22;
            this.labelResult21.Text = "2>1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(552, 312);
            this.Controls.Add(this.buttonCopy21);
            this.Controls.Add(this.textBoxResult21);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.checkBoxIsFilename2);
            this.Controls.Add(this.checkBoxIsFilename1);
            this.Controls.Add(this.buttonCopy12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.comboBoxPath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this.comboBoxPath1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResult12);
            this.Controls.Add(this.labelResult21);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Relative Path Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.TextBox textBoxResult12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCopy12;
        private System.Windows.Forms.CheckBox checkBoxIsFilename1;
        private System.Windows.Forms.CheckBox checkBoxIsFilename2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ComboBox comboBoxPath1;
        private System.Windows.Forms.ComboBox comboBoxPath2;
        private System.Windows.Forms.Button buttonCopy21;
        private System.Windows.Forms.TextBox textBoxResult21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResult12;
        private System.Windows.Forms.Label labelResult21;
    }
}

