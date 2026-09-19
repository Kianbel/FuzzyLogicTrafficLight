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
            this.startRandomizedCarButton = new System.Windows.Forms.Button();
            this.l1GoTimeLabel = new System.Windows.Forms.Label();
            this.l1CarsWaitingLabel = new System.Windows.Forms.Label();
            this.l2WaitingTimeLabel = new System.Windows.Forms.Label();
            this.l2CarsWaitingLabel = new System.Windows.Forms.Label();
            this.l1WaitingTimeLabel = new System.Windows.Forms.Label();
            this.l2GoTimeLabel = new System.Windows.Forms.Label();
            this.startInputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopAllButton = new System.Windows.Forms.Button();
            this.carsQueuedInput = new System.Windows.Forms.NumericUpDown();
            this.waitingTimeInput = new System.Windows.Forms.NumericUpDown();
            this.setInputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsQueuedInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTimeInput)).BeginInit();
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
            // startRandomizedCarButton
            // 
            this.startRandomizedCarButton.Location = new System.Drawing.Point(202, 640);
            this.startRandomizedCarButton.Margin = new System.Windows.Forms.Padding(2);
            this.startRandomizedCarButton.Name = "startRandomizedCarButton";
            this.startRandomizedCarButton.Size = new System.Drawing.Size(173, 28);
            this.startRandomizedCarButton.TabIndex = 1;
            this.startRandomizedCarButton.Text = "Start w/ Randomized Add Car";
            this.startRandomizedCarButton.UseVisualStyleBackColor = true;
            this.startRandomizedCarButton.Click += new System.EventHandler(this.button1_Click);
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
            // startInputButton
            // 
            this.startInputButton.Location = new System.Drawing.Point(772, 640);
            this.startInputButton.Name = "startInputButton";
            this.startInputButton.Size = new System.Drawing.Size(173, 28);
            this.startInputButton.TabIndex = 8;
            this.startInputButton.Text = "Start w/ Input";
            this.startInputButton.UseVisualStyleBackColor = true;
            this.startInputButton.Click += new System.EventHandler(this.startInputButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cars Queued";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Waiting Time (secs)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(822, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "----- Initial Inputs -----";
            // 
            // stopAllButton
            // 
            this.stopAllButton.BackColor = System.Drawing.Color.IndianRed;
            this.stopAllButton.Location = new System.Drawing.Point(494, 640);
            this.stopAllButton.Name = "stopAllButton";
            this.stopAllButton.Size = new System.Drawing.Size(173, 28);
            this.stopAllButton.TabIndex = 15;
            this.stopAllButton.Text = "Stop All";
            this.stopAllButton.UseVisualStyleBackColor = false;
            this.stopAllButton.Click += new System.EventHandler(this.stopAllButton_Click);
            // 
            // carsQueuedInput
            // 
            this.carsQueuedInput.Location = new System.Drawing.Point(825, 523);
            this.carsQueuedInput.Name = "carsQueuedInput";
            this.carsQueuedInput.Size = new System.Drawing.Size(120, 20);
            this.carsQueuedInput.TabIndex = 16;
            // 
            // waitingTimeInput
            // 
            this.waitingTimeInput.DecimalPlaces = 2;
            this.waitingTimeInput.Location = new System.Drawing.Point(825, 556);
            this.waitingTimeInput.Name = "waitingTimeInput";
            this.waitingTimeInput.Size = new System.Drawing.Size(120, 20);
            this.waitingTimeInput.TabIndex = 17;
            // 
            // setInputButton
            // 
            this.setInputButton.Location = new System.Drawing.Point(825, 582);
            this.setInputButton.Name = "setInputButton";
            this.setInputButton.Size = new System.Drawing.Size(75, 23);
            this.setInputButton.TabIndex = 18;
            this.setInputButton.Text = "Set";
            this.setInputButton.UseVisualStyleBackColor = true;
            this.setInputButton.Click += new System.EventHandler(this.setInputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 705);
            this.Controls.Add(this.setInputButton);
            this.Controls.Add(this.waitingTimeInput);
            this.Controls.Add(this.carsQueuedInput);
            this.Controls.Add(this.stopAllButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startInputButton);
            this.Controls.Add(this.l2GoTimeLabel);
            this.Controls.Add(this.l1WaitingTimeLabel);
            this.Controls.Add(this.l2CarsWaitingLabel);
            this.Controls.Add(this.l2WaitingTimeLabel);
            this.Controls.Add(this.l1CarsWaitingLabel);
            this.Controls.Add(this.l1GoTimeLabel);
            this.Controls.Add(this.startRandomizedCarButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsQueuedInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTimeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startRandomizedCarButton;
        private System.Windows.Forms.Label l1GoTimeLabel;
        private System.Windows.Forms.Label l1CarsWaitingLabel;
        private System.Windows.Forms.Label l2WaitingTimeLabel;
        private System.Windows.Forms.Label l2CarsWaitingLabel;
        private System.Windows.Forms.Label l1WaitingTimeLabel;
        private System.Windows.Forms.Label l2GoTimeLabel;
        private System.Windows.Forms.Button startInputButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopAllButton;
        private System.Windows.Forms.NumericUpDown carsQueuedInput;
        private System.Windows.Forms.NumericUpDown waitingTimeInput;
        private System.Windows.Forms.Button setInputButton;
    }
}

