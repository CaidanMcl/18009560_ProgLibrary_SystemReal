
namespace _18009560_ProgLibrary_System
{
    partial class ReplacingBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplacingBooks));
            this.btnGen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(162, 358);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(143, 71);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate Call Numbers";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(332, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 85);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Location = new System.Drawing.Point(332, 183);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 88);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(441, 67);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(347, 292);
            this.lb1.TabIndex = 31;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.SystemColors.Highlight;
            this.lb2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(12, 69);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(293, 276);
            this.lb2.TabIndex = 32;
            this.lb2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(428, 365);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(140, 64);
            this.btnCalc.TabIndex = 33;
            this.btnCalc.Text = "Check if sorted Correctly ";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(128, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(553, 38);
            this.progressBar1.TabIndex = 34;
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGen);
            this.Name = "ReplacingBooks";
            this.Text = "ReplacingBooks";
            this.Load += new System.EventHandler(this.ReplacingBooks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}