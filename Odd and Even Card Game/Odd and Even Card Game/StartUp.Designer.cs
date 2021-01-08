namespace Odd_and_Even_Card_Game
{
    partial class StartUp
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
            this.StartGame = new System.Windows.Forms.Button();
            this.GameName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Type1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Splitter();
            this.Player1Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Player2Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBRound = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(482, 635);
            this.StartGame.Margin = new System.Windows.Forms.Padding(1);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(294, 90);
            this.StartGame.TabIndex = 6;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // GameName
            // 
            this.GameName.AllowDrop = true;
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.White;
            this.GameName.Location = new System.Drawing.Point(154, 63);
            this.GameName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(446, 39);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Odd and Even Card Game";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(42, 189);
            this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Player 1 Name: ";
            // 
            // Player1Name
            // 
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(224, 189);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(1);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(179, 22);
            this.Player1Name.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 249);
            this.Label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 20);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Player 2 Name: ";
            // 
            // Player2Name
            // 
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.Location = new System.Drawing.Point(224, 249);
            this.Player2Name.Margin = new System.Windows.Forms.Padding(1);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(179, 22);
            this.Player2Name.TabIndex = 3;
            // 
            // Type1
            // 
            this.Type1.AutoSize = true;
            this.Type1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type1.ForeColor = System.Drawing.Color.White;
            this.Type1.Location = new System.Drawing.Point(478, 189);
            this.Type1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Type1.Name = "Type1";
            this.Type1.Size = new System.Drawing.Size(57, 20);
            this.Type1.TabIndex = 6;
            this.Type1.Text = "Type: ";
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Margin = new System.Windows.Forms.Padding(1);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(1, 753);
            this.t.TabIndex = 7;
            this.t.TabStop = false;
            // 
            // Player1Type
            // 
            this.Player1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player1Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Type.FormattingEnabled = true;
            this.Player1Type.Location = new System.Drawing.Point(554, 189);
            this.Player1Type.Margin = new System.Windows.Forms.Padding(1);
            this.Player1Type.Name = "Player1Type";
            this.Player1Type.Size = new System.Drawing.Size(115, 24);
            this.Player1Type.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type: ";
            // 
            // Player2Type
            // 
            this.Player2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player2Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Type.FormattingEnabled = true;
            this.Player2Type.Location = new System.Drawing.Point(554, 253);
            this.Player2Type.Margin = new System.Windows.Forms.Padding(1);
            this.Player2Type.Name = "Player2Type";
            this.Player2Type.Size = new System.Drawing.Size(115, 24);
            this.Player2Type.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Round: ";
            // 
            // CBRound
            // 
            this.CBRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRound.FormattingEnabled = true;
            this.CBRound.Location = new System.Drawing.Point(224, 308);
            this.CBRound.Margin = new System.Windows.Forms.Padding(1);
            this.CBRound.Name = "CBRound";
            this.CBRound.Size = new System.Drawing.Size(102, 23);
            this.CBRound.TabIndex = 5;
            // 
            // StartUp
            // 
            this.AcceptButton = this.StartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(792, 753);
            this.Controls.Add(this.CBRound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Player2Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Player1Type);
            this.Controls.Add(this.t);
            this.Controls.Add(this.Type1);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.StartGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "StartUp";
            this.Text = " ";
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.Label Type1;
        private System.Windows.Forms.Splitter t;
        private System.Windows.Forms.ComboBox Player1Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Player2Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBRound;
    }
}

