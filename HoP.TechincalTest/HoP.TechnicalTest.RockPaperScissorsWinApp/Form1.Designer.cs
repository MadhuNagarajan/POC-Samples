namespace HoP.TechnicalTest.RockPaperScissorsWinApp
{
    partial class FromRPSGame
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.cmbxGameType = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.txtGameValue = new System.Windows.Forms.TextBox();
            this.txtCompChoice1 = new System.Windows.Forms.TextBox();
            this.txtCompChoice2 = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Type";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 52);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(81, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player 1 Choice";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(12, 82);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(81, 13);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Player 2 Choice";
            // 
            // cmbxGameType
            // 
            this.cmbxGameType.FormattingEnabled = true;
            this.cmbxGameType.Items.AddRange(new object[] {
            "Player Vs Computer",
            "Computer Vs Computer",
            "Player Vs Player"});
            this.cmbxGameType.Location = new System.Drawing.Point(120, 23);
            this.cmbxGameType.Name = "cmbxGameType";
            this.cmbxGameType.Size = new System.Drawing.Size(121, 21);
            this.cmbxGameType.TabIndex = 3;
            this.cmbxGameType.SelectedValueChanged += new System.EventHandler(this.cmbxGameType_SelectedValueChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(120, 154);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtResult
            // 
            this.txtResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtResult.Location = new System.Drawing.Point(120, 118);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(205, 20);
            this.txtResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result";
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbPlayer2.Location = new System.Drawing.Point(120, 82);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayer2.TabIndex = 7;
            this.cmbPlayer2.Visible = false;
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbPlayer1.Location = new System.Drawing.Point(120, 52);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayer1.TabIndex = 8;
            this.cmbPlayer1.Visible = false;
            // 
            // txtGameValue
            // 
            this.txtGameValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtGameValue.Location = new System.Drawing.Point(262, 52);
            this.txtGameValue.Multiline = true;
            this.txtGameValue.Name = "txtGameValue";
            this.txtGameValue.ReadOnly = true;
            this.txtGameValue.Size = new System.Drawing.Size(132, 60);
            this.txtGameValue.TabIndex = 9;
            this.txtGameValue.Text = "0 = Invaid\r\n1 = Rock\r\n2 = Paper\r\n3 = Scissor";
            // 
            // txtCompChoice1
            // 
            this.txtCompChoice1.Location = new System.Drawing.Point(120, 53);
            this.txtCompChoice1.Name = "txtCompChoice1";
            this.txtCompChoice1.ReadOnly = true;
            this.txtCompChoice1.Size = new System.Drawing.Size(121, 20);
            this.txtCompChoice1.TabIndex = 10;
            this.txtCompChoice1.Visible = false;
            // 
            // txtCompChoice2
            // 
            this.txtCompChoice2.Location = new System.Drawing.Point(120, 83);
            this.txtCompChoice2.Name = "txtCompChoice2";
            this.txtCompChoice2.ReadOnly = true;
            this.txtCompChoice2.Size = new System.Drawing.Size(121, 20);
            this.txtCompChoice2.TabIndex = 11;
            this.txtCompChoice2.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(210, 154);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // FromRPSGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 230);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtCompChoice2);
            this.Controls.Add(this.txtCompChoice1);
            this.Controls.Add(this.txtGameValue);
            this.Controls.Add(this.cmbPlayer1);
            this.Controls.Add(this.cmbPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cmbxGameType);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "FromRPSGame";
            this.Text = "HoP Rock Paper Scissor Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.ComboBox cmbxGameType;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.TextBox txtGameValue;
        private System.Windows.Forms.TextBox txtCompChoice1;
        private System.Windows.Forms.TextBox txtCompChoice2;
        private System.Windows.Forms.Button btnRestart;
    }
}

