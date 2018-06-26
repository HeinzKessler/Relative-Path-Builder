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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxIsFilename1 = new System.Windows.Forms.CheckBox();
            this.checkBoxIsFilename2 = new System.Windows.Forms.CheckBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxPath1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPath2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse1.Location = new System.Drawing.Point(396, 40);
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
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path 2:";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse2.Location = new System.Drawing.Point(395, 124);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(96, 23);
            this.buttonBrowse2.TabIndex = 7;
            this.buttonBrowse2.Text = "Browse...";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(11, 202);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(375, 22);
            this.textBoxResult.TabIndex = 10;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Relative path from Path 1 to Path 2:";
            // 
            // checkBoxIsFilename1
            // 
            this.checkBoxIsFilename1.AutoSize = true;
            this.checkBoxIsFilename1.Location = new System.Drawing.Point(11, 69);
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
            this.checkBoxIsFilename2.Location = new System.Drawing.Point(11, 151);
            this.checkBoxIsFilename2.Name = "checkBoxIsFilename2";
            this.checkBoxIsFilename2.Size = new System.Drawing.Size(113, 17);
            this.checkBoxIsFilename2.TabIndex = 8;
            this.checkBoxIsFilename2.Text = "This is a filename";
            this.checkBoxIsFilename2.UseVisualStyleBackColor = true;
            // 
            // buttonSwap
            // 
            this.buttonSwap.Image = global::RelativePathBuilder.Properties.Resources.swap_24px;
            this.buttonSwap.Location = new System.Drawing.Point(234, 74);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(38, 38);
            this.buttonSwap.TabIndex = 4;
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Image = global::RelativePathBuilder.Properties.Resources.copy_16px;
            this.buttonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopy.Location = new System.Drawing.Point(396, 202);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(95, 23);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(9, 99);
            this.linkLabel2.Location = new System.Drawing.Point(11, 242);
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
            this.labelVersion.Location = new System.Drawing.Point(122, 242);
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
            this.comboBoxPath1.Location = new System.Drawing.Point(12, 40);
            this.comboBoxPath1.Name = "comboBoxPath1";
            this.comboBoxPath1.Size = new System.Drawing.Size(373, 21);
            this.comboBoxPath1.TabIndex = 15;
            this.comboBoxPath1.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // comboBoxPath2
            // 
            this.comboBoxPath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPath2.FormattingEnabled = true;
            this.comboBoxPath2.Location = new System.Drawing.Point(11, 124);
            this.comboBoxPath2.Name = "comboBoxPath2";
            this.comboBoxPath2.Size = new System.Drawing.Size(373, 21);
            this.comboBoxPath2.TabIndex = 16;
            this.comboBoxPath2.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.checkBoxIsFilename2);
            this.Controls.Add(this.checkBoxIsFilename1);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.comboBoxPath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this.comboBoxPath1);
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
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxIsFilename1;
        private System.Windows.Forms.CheckBox checkBoxIsFilename2;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ComboBox comboBoxPath1;
        private System.Windows.Forms.ComboBox comboBoxPath2;
    }
}

