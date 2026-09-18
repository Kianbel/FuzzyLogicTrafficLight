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
            this.l1GoTimeLabel = new System.Windows.Forms.Label();
            this.l1CarsWaitingLabel = new System.Windows.Forms.Label();
            this.l2WaitingTimeLabel = new System.Windows.Forms.Label();
            this.l2CarsWaitingLabel = new System.Windows.Forms.Label();
            this.l1WaitingTimeLabel = new System.Windows.Forms.Label();
            this.l2GoTimeLabel = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(303, 631);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start w/ Randomized Add Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1GoTimeLabel
            // 
            this.l1GoTimeLabel.AutoSize = true;
            this.l1GoTimeLabel.BackColor = System.Drawing.Color.Green;
            this.l1GoTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1GoTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l1GoTimeLabel.Location = new System.Drawing.Point(491, 386);
            this.l1GoTimeLabel.Name = "l1GoTimeLabel";
            this.l1GoTimeLabel.Size = new System.Drawing.Size(132, 13);
            this.l1GoTimeLabel.TabIndex = 2;
            this.l1GoTimeLabel.Text = "Go Time Remaining: 0";
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
            // l2WaitingTimeLabel
            // 
            this.l2WaitingTimeLabel.AutoSize = true;
            this.l2WaitingTimeLabel.BackColor = System.Drawing.Color.Green;
            this.l2WaitingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2WaitingTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l2WaitingTimeLabel.Location = new System.Drawing.Point(143, 188);
            this.l2WaitingTimeLabel.Name = "l2WaitingTimeLabel";
            this.l2WaitingTimeLabel.Size = new System.Drawing.Size(96, 13);
            this.l2WaitingTimeLabel.TabIndex = 4;
            this.l2WaitingTimeLabel.Text = "Waiting Time: 0";
            // 
            // l2CarsWaitingLabel
            // 
            this.l2CarsWaitingLabel.AutoSize = true;
            this.l2CarsWaitingLabel.BackColor = System.Drawing.Color.Green;
            this.l2CarsWaitingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2CarsWaitingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l2CarsWaitingLabel.Location = new System.Drawing.Point(95, 222);
            this.l2CarsWaitingLabel.Name = "l2CarsWaitingLabel";
            this.l2CarsWaitingLabel.Size = new System.Drawing.Size(91, 13);
            this.l2CarsWaitingLabel.TabIndex = 5;
            this.l2CarsWaitingLabel.Text = "Cars waiting: 0";
            // 
            // l1WaitingTimeLabel
            // 
            this.l1WaitingTimeLabel.AutoSize = true;
            this.l1WaitingTimeLabel.BackColor = System.Drawing.Color.Green;
            this.l1WaitingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1WaitingTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l1WaitingTimeLabel.Location = new System.Drawing.Point(491, 408);
            this.l1WaitingTimeLabel.Name = "l1WaitingTimeLabel";
            this.l1WaitingTimeLabel.Size = new System.Drawing.Size(96, 13);
            this.l1WaitingTimeLabel.TabIndex = 6;
            this.l1WaitingTimeLabel.Text = "Waiting Time: 0";
            // 
            // l2GoTimeLabel
            // 
            this.l2GoTimeLabel.AutoSize = true;
            this.l2GoTimeLabel.BackColor = System.Drawing.Color.Green;
            this.l2GoTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2GoTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l2GoTimeLabel.Location = new System.Drawing.Point(143, 164);
            this.l2GoTimeLabel.Name = "l2GoTimeLabel";
            this.l2GoTimeLabel.Size = new System.Drawing.Size(132, 13);
            this.l2GoTimeLabel.TabIndex = 7;
            this.l2GoTimeLabel.Text = "Go Time Remaining: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 705);
            this.Controls.Add(this.l2GoTimeLabel);
            this.Controls.Add(this.l1WaitingTimeLabel);
            this.Controls.Add(this.l2CarsWaitingLabel);
            this.Controls.Add(this.l2WaitingTimeLabel);
            this.Controls.Add(this.l1CarsWaitingLabel);
            this.Controls.Add(this.l1GoTimeLabel);
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
        private System.Windows.Forms.Label l1GoTimeLabel;
        private System.Windows.Forms.Label l1CarsWaitingLabel;
        private System.Windows.Forms.Label l2WaitingTimeLabel;
        private System.Windows.Forms.Label l2CarsWaitingLabel;
        private System.Windows.Forms.Label l1WaitingTimeLabel;
        private System.Windows.Forms.Label l2GoTimeLabel;
    }
}

