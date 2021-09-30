
namespace _18009560_ProgLibrary_System
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
            this.btnCalln = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnRepB = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalln
            // 
            this.btnCalln.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalln.BackgroundImage")));
            this.btnCalln.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalln.Location = new System.Drawing.Point(540, 172);
            this.btnCalln.Name = "btnCalln";
            this.btnCalln.Size = new System.Drawing.Size(253, 113);
            this.btnCalln.TabIndex = 10;
            this.btnCalln.UseVisualStyleBackColor = true;
            this.btnCalln.Click += new System.EventHandler(this.btnCalln_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArea.BackgroundImage")));
            this.btnArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArea.Location = new System.Drawing.Point(535, 345);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(258, 110);
            this.btnArea.TabIndex = 9;
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnRepB
            // 
            this.btnRepB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRepB.BackgroundImage")));
            this.btnRepB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepB.Location = new System.Drawing.Point(540, 12);
            this.btnRepB.Name = "btnRepB";
            this.btnRepB.Size = new System.Drawing.Size(253, 119);
            this.btnRepB.TabIndex = 8;
            this.btnRepB.UseVisualStyleBackColor = true;
            this.btnRepB.Click += new System.EventHandler(this.btnRepB_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(604, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(103, 17);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Replace Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(586, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(595, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Finding call numbers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(604, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Identifying Areas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCalln);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnRepB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalln;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnRepB;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

