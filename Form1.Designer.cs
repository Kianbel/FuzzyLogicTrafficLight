namespace FuzzyLogicTrafficLight
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l1TimeLabel = new System.Windows.Forms.Label();
            this.l1CarsWaitingLabel = new System.Windows.Forms.Label();
            this.l2TimeLabel = new System.Windows.Forms.Label();
            this.l2CarWaitingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 627);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1TimeLabel
            // 
            this.l1TimeLabel.AutoSize = true;
            this.l1TimeLabel.BackColor = System.Drawing.Color.Green;
            this.l1TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1TimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l1TimeLabel.Location = new System.Drawing.Point(491, 386);
            this.l1TimeLabel.Name = "l1TimeLabel";
            this.l1TimeLabel.Size = new System.Drawing.Size(127, 13);
            this.l1TimeLabel.TabIndex = 2;
            this.l1TimeLabel.Text = "Waiting/Go time: 10s";
            // 
            // l1CarsWaitingLabel
            // 
            this.l1CarsWaitingLabel.AutoSize = true;
            this.l1CarsWaitingLabel.BackColor = System.Drawing.Color.Green;
            this.l1CarsWaitingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1CarsWaitingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l1CarsWaitingLabel.Location = new System.Drawing.Point(437, 575);
            this.l1CarsWaitingLabel.Name = "l1CarsWaitingLabel";
            this.l1CarsWaitingLabel.Size = new System.Drawing.Size(91, 13);
            this.l1CarsWaitingLabel.TabIndex = 3;
            this.l1CarsWaitingLabel.Text = "Cars waiting: 0";
            // 
            // l2TimeLabel
            // 
            this.l2TimeLabel.AutoSize = true;
            this.l2TimeLabel.BackColor = System.Drawing.Color.Green;
            this.l2TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2TimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l2TimeLabel.Location = new System.Drawing.Point(174, 188);
            this.l2TimeLabel.Name = "l2TimeLabel";
            this.l2TimeLabel.Size = new System.Drawing.Size(127, 13);
            this.l2TimeLabel.TabIndex = 4;
            this.l2TimeLabel.Text = "Waiting/Go time: 10s";
            // 
            // l2CarWaitingLabel
            // 
            this.l2CarWaitingLabel.AutoSize = true;
            this.l2CarWaitingLabel.BackColor = System.Drawing.Color.Green;
            this.l2CarWaitingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2CarWaitingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l2CarWaitingLabel.Location = new System.Drawing.Point(95, 222);
            this.l2CarWaitingLabel.Name = "l2CarWaitingLabel";
            this.l2CarWaitingLabel.Size = new System.Drawing.Size(91, 13);
            this.l2CarWaitingLabel.TabIndex = 5;
            this.l2CarWaitingLabel.Text = "Cars waiting: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 705);
            this.Controls.Add(this.l2CarWaitingLabel);
            this.Controls.Add(this.l2TimeLabel);
            this.Controls.Add(this.l1CarsWaitingLabel);
            this.Controls.Add(this.l1TimeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l1TimeLabel;
        private System.Windows.Forms.Label l1CarsWaitingLabel;
        private System.Windows.Forms.Label l2TimeLabel;
        private System.Windows.Forms.Label l2CarWaitingLabel;
    }
}

