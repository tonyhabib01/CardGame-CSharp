namespace Odd_and_Even_Card_Game
{
    partial class Selection
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
            this.components = new System.ComponentModel.Container();
            this.P1Name = new System.Windows.Forms.Label();
            this.P1Type = new System.Windows.Forms.Label();
            this.P1Score = new System.Windows.Forms.Label();
            this.P1Card = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P2NextCard = new System.Windows.Forms.PictureBox();
            this.P1NextCard = new System.Windows.Forms.PictureBox();
            this.P2Card = new System.Windows.Forms.PictureBox();
            this.P2Score = new System.Windows.Forms.Label();
            this.P2Type = new System.Windows.Forms.Label();
            this.P2Name = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.ListBoxRound = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.LBRemainingRound = new System.Windows.Forms.Label();
            this.LBRemainingCards = new System.Windows.Forms.Label();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.AutoTimer = new System.Windows.Forms.Timer(this.components);
            this.ListBoxGamePlayed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.P1Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2NextCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1NextCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Card)).BeginInit();
            this.SuspendLayout();
            // 
            // P1Name
            // 
            this.P1Name.AutoSize = true;
            this.P1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Name.ForeColor = System.Drawing.Color.White;
            this.P1Name.Location = new System.Drawing.Point(118, 43);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(59, 20);
            this.P1Name.TabIndex = 0;
            this.P1Name.Text = "Name: ";
            // 
            // P1Type
            // 
            this.P1Type.AutoSize = true;
            this.P1Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Type.ForeColor = System.Drawing.Color.White;
            this.P1Type.Location = new System.Drawing.Point(305, 43);
            this.P1Type.Name = "P1Type";
            this.P1Type.Size = new System.Drawing.Size(51, 20);
            this.P1Type.TabIndex = 2;
            this.P1Type.Text = "Type: ";
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.ForeColor = System.Drawing.Color.White;
            this.P1Score.Location = new System.Drawing.Point(206, 79);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(59, 20);
            this.P1Score.TabIndex = 4;
            this.P1Score.Text = "Score: ";
            // 
            // P1Card
            // 
            this.P1Card.Location = new System.Drawing.Point(195, 140);
            this.P1Card.Name = "P1Card";
            this.P1Card.Size = new System.Drawing.Size(109, 142);
            this.P1Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1Card.TabIndex = 6;
            this.P1Card.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dealt Card";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(132, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Next Two Cards to be Dealt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(201, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dealt Card";
            // 
            // P2NextCard
            // 
            this.P2NextCard.Location = new System.Drawing.Point(312, 308);
            this.P2NextCard.Name = "P2NextCard";
            this.P2NextCard.Size = new System.Drawing.Size(109, 142);
            this.P2NextCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2NextCard.TabIndex = 14;
            this.P2NextCard.TabStop = false;
            // 
            // P1NextCard
            // 
            this.P1NextCard.Location = new System.Drawing.Point(73, 308);
            this.P1NextCard.Name = "P1NextCard";
            this.P1NextCard.Size = new System.Drawing.Size(109, 142);
            this.P1NextCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1NextCard.TabIndex = 15;
            this.P1NextCard.TabStop = false;
            // 
            // P2Card
            // 
            this.P2Card.Location = new System.Drawing.Point(195, 486);
            this.P2Card.Name = "P2Card";
            this.P2Card.Size = new System.Drawing.Size(109, 142);
            this.P2Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2Card.TabIndex = 16;
            this.P2Card.TabStop = false;
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.ForeColor = System.Drawing.Color.White;
            this.P2Score.Location = new System.Drawing.Point(207, 674);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(59, 20);
            this.P2Score.TabIndex = 21;
            this.P2Score.Text = "Score: ";
            // 
            // P2Type
            // 
            this.P2Type.AutoSize = true;
            this.P2Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Type.ForeColor = System.Drawing.Color.White;
            this.P2Type.Location = new System.Drawing.Point(305, 638);
            this.P2Type.Name = "P2Type";
            this.P2Type.Size = new System.Drawing.Size(51, 20);
            this.P2Type.TabIndex = 19;
            this.P2Type.Text = "Type: ";
            // 
            // P2Name
            // 
            this.P2Name.AutoSize = true;
            this.P2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Name.ForeColor = System.Drawing.Color.White;
            this.P2Name.Location = new System.Drawing.Point(118, 638);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(59, 20);
            this.P2Name.TabIndex = 17;
            this.P2Name.Text = "Name: ";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(22, 716);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(95, 35);
            this.btnRoll.TabIndex = 22;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // ListBoxRound
            // 
            this.ListBoxRound.BackColor = System.Drawing.Color.DarkGreen;
            this.ListBoxRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxRound.ForeColor = System.Drawing.Color.White;
            this.ListBoxRound.FormattingEnabled = true;
            this.ListBoxRound.ItemHeight = 16;
            this.ListBoxRound.Location = new System.Drawing.Point(498, 140);
            this.ListBoxRound.Name = "ListBoxRound";
            this.ListBoxRound.Size = new System.Drawing.Size(115, 436);
            this.ListBoxRound.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(548, 716);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 35);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Quit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LBRemainingRound
            // 
            this.LBRemainingRound.AutoSize = true;
            this.LBRemainingRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRemainingRound.ForeColor = System.Drawing.Color.White;
            this.LBRemainingRound.Location = new System.Drawing.Point(472, 43);
            this.LBRemainingRound.Name = "LBRemainingRound";
            this.LBRemainingRound.Size = new System.Drawing.Size(141, 20);
            this.LBRemainingRound.TabIndex = 26;
            this.LBRemainingRound.Text = "Remaining Round:";
            // 
            // LBRemainingCards
            // 
            this.LBRemainingCards.AutoSize = true;
            this.LBRemainingCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRemainingCards.ForeColor = System.Drawing.Color.White;
            this.LBRemainingCards.Location = new System.Drawing.Point(478, 79);
            this.LBRemainingCards.Name = "LBRemainingCards";
            this.LBRemainingCards.Size = new System.Drawing.Size(135, 20);
            this.LBRemainingCards.TabIndex = 27;
            this.LBRemainingCards.Text = "Remaining Cards:";
            // 
            // BtnAuto
            // 
            this.BtnAuto.Location = new System.Drawing.Point(157, 716);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(95, 35);
            this.BtnAuto.TabIndex = 28;
            this.BtnAuto.Text = "Auto";
            this.BtnAuto.UseVisualStyleBackColor = true;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // AutoTimer
            // 
            this.AutoTimer.Interval = 2000;
            this.AutoTimer.Tick += new System.EventHandler(this.AutoTimer_Tick);
            // 
            // ListBoxGamePlayed
            // 
            this.ListBoxGamePlayed.BackColor = System.Drawing.Color.DarkGreen;
            this.ListBoxGamePlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxGamePlayed.ForeColor = System.Drawing.Color.White;
            this.ListBoxGamePlayed.FormattingEnabled = true;
            this.ListBoxGamePlayed.ItemHeight = 16;
            this.ListBoxGamePlayed.Location = new System.Drawing.Point(697, 140);
            this.ListBoxGamePlayed.Name = "ListBoxGamePlayed";
            this.ListBoxGamePlayed.Size = new System.Drawing.Size(232, 436);
            this.ListBoxGamePlayed.TabIndex = 29;
            this.ListBoxGamePlayed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxGamePlayed_MouseDoubleClick);
            // 
            // Selection
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(941, 756);
            this.Controls.Add(this.ListBoxGamePlayed);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.LBRemainingCards);
            this.Controls.Add(this.LBRemainingRound);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ListBoxRound);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P2Type);
            this.Controls.Add(this.P2Name);
            this.Controls.Add(this.P2Card);
            this.Controls.Add(this.P1NextCard);
            this.Controls.Add(this.P2NextCard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.P1Card);
            this.Controls.Add(this.P1Score);
            this.Controls.Add(this.P1Type);
            this.Controls.Add(this.P1Name);
            this.Name = "Selection";
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.Selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2NextCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1NextCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1Name;
        private System.Windows.Forms.Label P1Type;
        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.PictureBox P1Card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox P2NextCard;
        private System.Windows.Forms.PictureBox P1NextCard;
        private System.Windows.Forms.PictureBox P2Card;
        private System.Windows.Forms.Label P2Score;
        private System.Windows.Forms.Label P2Type;
        private System.Windows.Forms.Label P2Name;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListBox ListBoxRound;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LBRemainingRound;
        private System.Windows.Forms.Label LBRemainingCards;
        private System.Windows.Forms.Button BtnAuto;
        private System.Windows.Forms.Timer AutoTimer;
        private System.Windows.Forms.ListBox ListBoxGamePlayed;
    }
}