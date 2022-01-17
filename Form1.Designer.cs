namespace Mencari_Elemen_Array
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
            this.lBNama = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBIndex = new System.Windows.Forms.TextBox();
            this.bTTampil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBNama
            // 
            this.lBNama.FormattingEnabled = true;
            this.lBNama.Location = new System.Drawing.Point(13, 13);
            this.lBNama.Name = "lBNama";
            this.lBNama.Size = new System.Drawing.Size(235, 147);
            this.lBNama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Index";
            // 
            // tBIndex
            // 
            this.tBIndex.Location = new System.Drawing.Point(54, 177);
            this.tBIndex.Name = "tBIndex";
            this.tBIndex.Size = new System.Drawing.Size(194, 20);
            this.tBIndex.TabIndex = 2;
            // 
            // bTTampil
            // 
            this.bTTampil.Location = new System.Drawing.Point(173, 203);
            this.bTTampil.Name = "bTTampil";
            this.bTTampil.Size = new System.Drawing.Size(75, 23);
            this.bTTampil.TabIndex = 3;
            this.bTTampil.Text = "Tampilkan";
            this.bTTampil.UseVisualStyleBackColor = true;
            this.bTTampil.Click += new System.EventHandler(this.bTTampil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 239);
            this.Controls.Add(this.bTTampil);
            this.Controls.Add(this.tBIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBNama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mencari Elemen Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBIndex;
        private System.Windows.Forms.Button bTTampil;
    }
}

