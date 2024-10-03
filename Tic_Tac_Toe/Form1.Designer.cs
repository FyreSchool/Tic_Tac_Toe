
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playerOneScoreLabel = new Label();
            playerTwoScoreLabel = new Label();
            winnerLabel = new Label();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            resetButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // playerOneScoreLabel
            // 
            playerOneScoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            playerOneScoreLabel.Location = new Point(50, 50);
            playerOneScoreLabel.Name = "playerOneScoreLabel";
            playerOneScoreLabel.Size = new Size(196, 45);
            playerOneScoreLabel.TabIndex = 10;
            playerOneScoreLabel.Text = "Player 1: 0";
            // 
            // playerTwoScoreLabel
            // 
            playerTwoScoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            playerTwoScoreLabel.Location = new Point(705, 50);
            playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            playerTwoScoreLabel.Size = new Size(173, 60);
            playerTwoScoreLabel.TabIndex = 11;
            playerTwoScoreLabel.Text = "Player 2: 0";
            // 
            // winnerLabel
            // 
            winnerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            winnerLabel.Location = new Point(312, 50);
            winnerLabel.Name = "winnerLabel";
            winnerLabel.Size = new Size(300, 50);
            winnerLabel.TabIndex = 0;
            winnerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // A1
            // 
            A1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            A1.Location = new Point(312, 166);
            A1.Name = "A1";
            A1.Size = new Size(94, 86);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.FlatStyle = FlatStyle.Flat;
            A1.BackColor = Color.Transparent;
            A1.FlatAppearance.BorderSize = 0;
            A1.Click += button_Click;
            // 
            // A2
            // 
            A2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            A2.Location = new Point(412, 166);
            A2.Name = "A2";
            A2.Size = new Size(94, 86);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.FlatStyle = FlatStyle.Flat;
            A2.BackColor = Color.Transparent;
            A2.FlatAppearance.BorderSize = 0;
            A2.Click += button_Click;
            // 
            // A3
            // 
            A3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            A3.Location = new Point(512, 166);
            A3.Name = "A3";
            A3.Size = new Size(94, 86);
            A3.TabIndex = 2;
            A3.UseVisualStyleBackColor = true;
            A3.FlatStyle = FlatStyle.Flat;
            A3.BackColor = Color.Transparent;
            A3.FlatAppearance.BorderSize = 0;
            A3.Click += button_Click;
            // 
            // B1
            // 
            B1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            B1.Location = new Point(312, 258);
            B1.Name = "B1";
            B1.Size = new Size(94, 86);
            B1.TabIndex = 3;
            B1.UseVisualStyleBackColor = true;
            B1.FlatStyle = FlatStyle.Flat;
            B1.BackColor = Color.Transparent;
            B1.FlatAppearance.BorderSize = 0;
            B1.Click += button_Click;
            // 
            // B2
            // 
            B2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            B2.Location = new Point(412, 258);
            B2.Name = "B2";
            B2.Size = new Size(94, 86);
            B2.TabIndex = 4;
            B2.UseVisualStyleBackColor = true;
            B2.FlatStyle = FlatStyle.Flat;
            B2.BackColor = Color.Transparent;
            B2.FlatAppearance.BorderSize = 0;
            B2.Click += button_Click;
            // 
            // B3
            // 
            B3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            B3.Location = new Point(512, 258);
            B3.Name = "B3";
            B3.Size = new Size(94, 86);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = true;
            B3.FlatStyle = FlatStyle.Flat;
            B3.BackColor = Color.Transparent;
            B3.FlatAppearance.BorderSize = 0;
            B3.Click += button_Click;
            // 
            // C1
            // 
            C1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            C1.Location = new Point(312, 350);
            C1.Name = "C1";
            C1.Size = new Size(94, 86);
            C1.TabIndex = 6;
            C1.UseVisualStyleBackColor = true;
            C1.FlatStyle = FlatStyle.Flat;
            C1.BackColor = Color.Transparent;
            C1.FlatAppearance.BorderSize = 0;
            C1.Click += button_Click;
            // 
            // C2
            // 
            C2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            C2.Location = new Point(412, 350);
            C2.Name = "C2";
            C2.Size = new Size(94, 86);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = true;
            C2.FlatStyle = FlatStyle.Flat;
            C2.BackColor = Color.Transparent;
            C2.FlatAppearance.BorderSize = 0;
            C2.Click += button_Click;
            // 
            // C3
            // 
            C3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            C3.Location = new Point(512, 350);
            C3.Name = "C3";
            C3.Size = new Size(94, 86);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = true;
            C3.FlatStyle = FlatStyle.Flat;
            C3.BackColor = Color.Transparent;
            C3.FlatAppearance.BorderSize = 0;
            C3.Click += button_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 16F);
            resetButton.Location = new Point(362, 487);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(194, 45);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 618);
            Controls.Add(winnerLabel);
            Controls.Add(resetButton);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(playerOneScoreLabel);
            Controls.Add(playerTwoScoreLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionally set the form title
            this.Text = "Tic Tac Toe";

           
        }

        #endregion

        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button resetButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
