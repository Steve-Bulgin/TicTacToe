namespace SBulginAssignment2
{
    partial class TicTacToeForm
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
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl00
            // 
            this.lbl00.AutoSize = true;
            this.lbl00.BackColor = System.Drawing.Color.Transparent;
            this.lbl00.Location = new System.Drawing.Point(90, 126);
            this.lbl00.MinimumSize = new System.Drawing.Size(90, 74);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(90, 74);
            this.lbl00.TabIndex = 0;
            this.lbl00.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Transparent;
            this.lbl10.Location = new System.Drawing.Point(185, 121);
            this.lbl10.MinimumSize = new System.Drawing.Size(121, 79);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(121, 79);
            this.lbl10.TabIndex = 1;
            this.lbl10.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.BackColor = System.Drawing.Color.Transparent;
            this.lbl20.Location = new System.Drawing.Point(312, 121);
            this.lbl20.MinimumSize = new System.Drawing.Size(95, 79);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(95, 79);
            this.lbl20.TabIndex = 2;
            this.lbl20.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.BackColor = System.Drawing.Color.Transparent;
            this.lbl01.Location = new System.Drawing.Point(90, 209);
            this.lbl01.MinimumSize = new System.Drawing.Size(88, 96);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(88, 96);
            this.lbl01.TabIndex = 3;
            this.lbl01.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Transparent;
            this.lbl11.Location = new System.Drawing.Point(185, 209);
            this.lbl11.MinimumSize = new System.Drawing.Size(120, 95);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(120, 95);
            this.lbl11.TabIndex = 4;
            this.lbl11.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.BackColor = System.Drawing.Color.Transparent;
            this.lbl21.Location = new System.Drawing.Point(312, 209);
            this.lbl21.MinimumSize = new System.Drawing.Size(93, 96);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(93, 96);
            this.lbl21.TabIndex = 5;
            this.lbl21.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.BackColor = System.Drawing.Color.Transparent;
            this.lbl02.Location = new System.Drawing.Point(90, 314);
            this.lbl02.MinimumSize = new System.Drawing.Size(89, 88);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(89, 88);
            this.lbl02.TabIndex = 6;
            this.lbl02.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Transparent;
            this.lbl12.Location = new System.Drawing.Point(185, 314);
            this.lbl12.MinimumSize = new System.Drawing.Size(120, 88);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(120, 88);
            this.lbl12.TabIndex = 7;
            this.lbl12.Click += new System.EventHandler(this.label_Click);
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.BackColor = System.Drawing.Color.Transparent;
            this.lbl22.Location = new System.Drawing.Point(312, 314);
            this.lbl22.MinimumSize = new System.Drawing.Size(90, 90);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(90, 90);
            this.lbl22.TabIndex = 8;
            this.lbl22.Click += new System.EventHandler(this.label_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SBulginAssignment2.Properties.Resources.game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(440, 444);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl00);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 483);
            this.MinimumSize = new System.Drawing.Size(456, 483);
            this.Name = "TicTacToeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl22;
    }
}

