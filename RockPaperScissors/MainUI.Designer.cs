namespace RockPaperScissors
{
    partial class MainUI
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
            this.lblSelection = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.PictureBox();
            this.comBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.TextBox();
            this.labelDraw = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(286, 54);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(108, 15);
            this.lblSelection.TabIndex = 0;
            this.lblSelection.Text = "Are You Ready?";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(289, 89);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 26);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Let\'s Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(16, 32);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(250, 250);
            this.userBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userBox.TabIndex = 2;
            this.userBox.TabStop = false;
            // 
            // comBox
            // 
            this.comBox.Location = new System.Drawing.Point(414, 32);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(250, 250);
            this.comBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.comBox.TabIndex = 3;
            this.comBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Games Won";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "User: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Com: ";
            // 
            // lblCom
            // 
            this.lblCom.Location = new System.Drawing.Point(350, 195);
            this.lblCom.Name = "lblCom";
            this.lblCom.ReadOnly = true;
            this.lblCom.Size = new System.Drawing.Size(44, 20);
            this.lblCom.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(350, 163);
            this.lblUser.Name = "lblUser";
            this.lblUser.ReadOnly = true;
            this.lblUser.Size = new System.Drawing.Size(44, 20);
            this.lblUser.TabIndex = 9;
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraw.Location = new System.Drawing.Point(286, 224);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(48, 15);
            this.labelDraw.TabIndex = 10;
            this.labelDraw.Text = "Draw: ";
            // 
            // lblDraw
            // 
            this.lblDraw.Location = new System.Drawing.Point(350, 223);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.ReadOnly = true;
            this.lblDraw.Size = new System.Drawing.Size(44, 20);
            this.lblDraw.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(289, 292);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Com";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(289, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblSelection);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox userBox;
        private System.Windows.Forms.PictureBox comBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblCom;
        private System.Windows.Forms.TextBox lblUser;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.TextBox lblDraw;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
    }
}

