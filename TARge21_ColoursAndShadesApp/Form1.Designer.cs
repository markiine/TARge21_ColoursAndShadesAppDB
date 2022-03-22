
namespace TARge21_ColoursAndShadesApp
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
            this.listPrimaryColour = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listShades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colours";
            // 
            // listPrimaryColour
            // 
            this.listPrimaryColour.FormattingEnabled = true;
            this.listPrimaryColour.Location = new System.Drawing.Point(102, 91);
            this.listPrimaryColour.Name = "listPrimaryColour";
            this.listPrimaryColour.Size = new System.Drawing.Size(120, 95);
            this.listPrimaryColour.TabIndex = 1;
            this.listPrimaryColour.SelectedIndexChanged += new System.EventHandler(this.listPrimaryColour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shades";
            // 
            // listShades
            // 
            this.listShades.FormattingEnabled = true;
            this.listShades.Location = new System.Drawing.Point(389, 91);
            this.listShades.Name = "listShades";
            this.listShades.Size = new System.Drawing.Size(120, 95);
            this.listShades.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPrimaryColour);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPrimaryColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listShades;
    }
}

