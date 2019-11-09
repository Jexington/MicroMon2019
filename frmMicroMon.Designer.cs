namespace MicroMon2019
{
    partial class frmMicroMon
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
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.btnChoiceThree = new System.Windows.Forms.Button();
            this.btnChoiceTwo = new System.Windows.Forms.Button();
            this.btnChoiceOne = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtboxEvents = new System.Windows.Forms.TextBox();
            this.pnlMicroOpponent = new System.Windows.Forms.Panel();
            this.pnlMicroPlayer = new System.Windows.Forms.Panel();
            this.prbHealthPlayer = new System.Windows.Forms.ProgressBar();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.prbHealthOpponent = new System.Windows.Forms.ProgressBar();
            this.lblOppName = new System.Windows.Forms.Label();
            this.grpDebug = new System.Windows.Forms.GroupBox();
            this.btnTestBattle = new System.Windows.Forms.Button();
            this.grpBattle = new System.Windows.Forms.GroupBox();
            this.grpDialogue = new System.Windows.Forms.GroupBox();
            this.grpTournament = new System.Windows.Forms.GroupBox();
            this.lblWinCounter = new System.Windows.Forms.Label();
            this.btnStartTournament = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSelectMicroMon = new System.Windows.Forms.GroupBox();
            this.rdoLight = new System.Windows.Forms.RadioButton();
            this.rdoDark = new System.Windows.Forms.RadioButton();
            this.rdoWind = new System.Windows.Forms.RadioButton();
            this.rdoEarth = new System.Windows.Forms.RadioButton();
            this.rdoWater = new System.Windows.Forms.RadioButton();
            this.rdoFire = new System.Windows.Forms.RadioButton();
            this.btnTestFinal = new System.Windows.Forms.Button();
            this.grpChoice.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.grpBattle.SuspendLayout();
            this.grpDialogue.SuspendLayout();
            this.grpTournament.SuspendLayout();
            this.grpSelectMicroMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.btnChoiceThree);
            this.grpChoice.Controls.Add(this.btnChoiceTwo);
            this.grpChoice.Controls.Add(this.btnChoiceOne);
            this.grpChoice.Location = new System.Drawing.Point(12, 350);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(776, 124);
            this.grpChoice.TabIndex = 0;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "grpChoice";
            // 
            // btnChoiceThree
            // 
            this.btnChoiceThree.Location = new System.Drawing.Point(583, 29);
            this.btnChoiceThree.Name = "btnChoiceThree";
            this.btnChoiceThree.Size = new System.Drawing.Size(178, 74);
            this.btnChoiceThree.TabIndex = 3;
            this.btnChoiceThree.Text = "Choice 3";
            this.btnChoiceThree.UseVisualStyleBackColor = true;
            this.btnChoiceThree.Click += new System.EventHandler(this.btnChoiceThree_Click);
            // 
            // btnChoiceTwo
            // 
            this.btnChoiceTwo.Location = new System.Drawing.Point(300, 29);
            this.btnChoiceTwo.Name = "btnChoiceTwo";
            this.btnChoiceTwo.Size = new System.Drawing.Size(178, 74);
            this.btnChoiceTwo.TabIndex = 2;
            this.btnChoiceTwo.Text = "Choice 2";
            this.btnChoiceTwo.UseVisualStyleBackColor = true;
            this.btnChoiceTwo.Click += new System.EventHandler(this.btnChoiceTwo_Click);
            // 
            // btnChoiceOne
            // 
            this.btnChoiceOne.Location = new System.Drawing.Point(28, 29);
            this.btnChoiceOne.Name = "btnChoiceOne";
            this.btnChoiceOne.Size = new System.Drawing.Size(178, 74);
            this.btnChoiceOne.TabIndex = 1;
            this.btnChoiceOne.Text = "Choice 1";
            this.btnChoiceOne.UseVisualStyleBackColor = true;
            this.btnChoiceOne.Click += new System.EventHandler(this.btnChoiceOne_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(17, 253);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(161, 43);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Okay";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtboxEvents
            // 
            this.txtboxEvents.Location = new System.Drawing.Point(17, 19);
            this.txtboxEvents.Multiline = true;
            this.txtboxEvents.Name = "txtboxEvents";
            this.txtboxEvents.Size = new System.Drawing.Size(161, 218);
            this.txtboxEvents.TabIndex = 5;
            // 
            // pnlMicroOpponent
            // 
            this.pnlMicroOpponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMicroOpponent.Location = new System.Drawing.Point(476, 10);
            this.pnlMicroOpponent.Name = "pnlMicroOpponent";
            this.pnlMicroOpponent.Size = new System.Drawing.Size(161, 158);
            this.pnlMicroOpponent.TabIndex = 6;
            // 
            // pnlMicroPlayer
            // 
            this.pnlMicroPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMicroPlayer.Location = new System.Drawing.Point(16, 159);
            this.pnlMicroPlayer.Name = "pnlMicroPlayer";
            this.pnlMicroPlayer.Size = new System.Drawing.Size(161, 158);
            this.pnlMicroPlayer.TabIndex = 5;
            // 
            // prbHealthPlayer
            // 
            this.prbHealthPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.prbHealthPlayer.Location = new System.Drawing.Point(200, 294);
            this.prbHealthPlayer.Name = "prbHealthPlayer";
            this.prbHealthPlayer.Size = new System.Drawing.Size(100, 23);
            this.prbHealthPlayer.TabIndex = 7;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(241, 278);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(17, 13);
            this.lblPlayerName.TabIndex = 11;
            this.lblPlayerName.Text = "\"\"";
            // 
            // prbHealthOpponent
            // 
            this.prbHealthOpponent.Location = new System.Drawing.Point(361, 19);
            this.prbHealthOpponent.Name = "prbHealthOpponent";
            this.prbHealthOpponent.Size = new System.Drawing.Size(100, 23);
            this.prbHealthOpponent.TabIndex = 12;
            // 
            // lblOppName
            // 
            this.lblOppName.AutoSize = true;
            this.lblOppName.Location = new System.Drawing.Point(402, 45);
            this.lblOppName.Name = "lblOppName";
            this.lblOppName.Size = new System.Drawing.Size(17, 13);
            this.lblOppName.TabIndex = 13;
            this.lblOppName.Text = "\"\"";
            // 
            // grpDebug
            // 
            this.grpDebug.Controls.Add(this.btnTestFinal);
            this.grpDebug.Controls.Add(this.btnTestBattle);
            this.grpDebug.Location = new System.Drawing.Point(12, 480);
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Size = new System.Drawing.Size(300, 122);
            this.grpDebug.TabIndex = 14;
            this.grpDebug.TabStop = false;
            this.grpDebug.Text = "Debug";
            // 
            // btnTestBattle
            // 
            this.btnTestBattle.Location = new System.Drawing.Point(6, 30);
            this.btnTestBattle.Name = "btnTestBattle";
            this.btnTestBattle.Size = new System.Drawing.Size(79, 74);
            this.btnTestBattle.TabIndex = 15;
            this.btnTestBattle.Text = "Test Battle";
            this.btnTestBattle.UseVisualStyleBackColor = true;
            this.btnTestBattle.Click += new System.EventHandler(this.btnTestBattle_Click);
            // 
            // grpBattle
            // 
            this.grpBattle.Controls.Add(this.pnlMicroOpponent);
            this.grpBattle.Controls.Add(this.pnlMicroPlayer);
            this.grpBattle.Controls.Add(this.lblOppName);
            this.grpBattle.Controls.Add(this.prbHealthPlayer);
            this.grpBattle.Controls.Add(this.prbHealthOpponent);
            this.grpBattle.Controls.Add(this.lblPlayerName);
            this.grpBattle.Location = new System.Drawing.Point(12, 12);
            this.grpBattle.Name = "grpBattle";
            this.grpBattle.Size = new System.Drawing.Size(654, 332);
            this.grpBattle.TabIndex = 15;
            this.grpBattle.TabStop = false;
            this.grpBattle.Text = "Battle Box";
            // 
            // grpDialogue
            // 
            this.grpDialogue.Controls.Add(this.btnOk);
            this.grpDialogue.Controls.Add(this.txtboxEvents);
            this.grpDialogue.Location = new System.Drawing.Point(692, 22);
            this.grpDialogue.Name = "grpDialogue";
            this.grpDialogue.Size = new System.Drawing.Size(200, 322);
            this.grpDialogue.TabIndex = 16;
            this.grpDialogue.TabStop = false;
            this.grpDialogue.Text = "Dialogue Box";
            // 
            // grpTournament
            // 
            this.grpTournament.Controls.Add(this.lblWinCounter);
            this.grpTournament.Controls.Add(this.btnStartTournament);
            this.grpTournament.Location = new System.Drawing.Point(898, 22);
            this.grpTournament.Name = "grpTournament";
            this.grpTournament.Size = new System.Drawing.Size(200, 322);
            this.grpTournament.TabIndex = 18;
            this.grpTournament.TabStop = false;
            this.grpTournament.Text = "Tournament";
            // 
            // lblWinCounter
            // 
            this.lblWinCounter.AutoSize = true;
            this.lblWinCounter.Location = new System.Drawing.Point(21, 20);
            this.lblWinCounter.Name = "lblWinCounter";
            this.lblWinCounter.Size = new System.Drawing.Size(78, 13);
            this.lblWinCounter.TabIndex = 1;
            this.lblWinCounter.Text = "Win Counter: 0";
            // 
            // btnStartTournament
            // 
            this.btnStartTournament.Location = new System.Drawing.Point(21, 54);
            this.btnStartTournament.Name = "btnStartTournament";
            this.btnStartTournament.Size = new System.Drawing.Size(160, 75);
            this.btnStartTournament.TabIndex = 0;
            this.btnStartTournament.Text = "The Iron Cup";
            this.btnStartTournament.UseVisualStyleBackColor = true;
            this.btnStartTournament.Click += new System.EventHandler(this.btnStartTournament_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // grpSelectMicroMon
            // 
            this.grpSelectMicroMon.Controls.Add(this.rdoLight);
            this.grpSelectMicroMon.Controls.Add(this.rdoDark);
            this.grpSelectMicroMon.Controls.Add(this.rdoWind);
            this.grpSelectMicroMon.Controls.Add(this.rdoEarth);
            this.grpSelectMicroMon.Controls.Add(this.rdoWater);
            this.grpSelectMicroMon.Controls.Add(this.rdoFire);
            this.grpSelectMicroMon.Location = new System.Drawing.Point(804, 353);
            this.grpSelectMicroMon.Name = "grpSelectMicroMon";
            this.grpSelectMicroMon.Size = new System.Drawing.Size(294, 249);
            this.grpSelectMicroMon.TabIndex = 20;
            this.grpSelectMicroMon.TabStop = false;
            this.grpSelectMicroMon.Text = "Select Your MicroMon";
            // 
            // rdoLight
            // 
            this.rdoLight.AutoSize = true;
            this.rdoLight.Location = new System.Drawing.Point(6, 141);
            this.rdoLight.Name = "rdoLight";
            this.rdoLight.Size = new System.Drawing.Size(48, 17);
            this.rdoLight.TabIndex = 5;
            this.rdoLight.Text = "Light";
            this.rdoLight.UseVisualStyleBackColor = true;
            // 
            // rdoDark
            // 
            this.rdoDark.AutoSize = true;
            this.rdoDark.Location = new System.Drawing.Point(6, 118);
            this.rdoDark.Name = "rdoDark";
            this.rdoDark.Size = new System.Drawing.Size(48, 17);
            this.rdoDark.TabIndex = 4;
            this.rdoDark.Text = "Dark";
            this.rdoDark.UseVisualStyleBackColor = true;
            // 
            // rdoWind
            // 
            this.rdoWind.AutoSize = true;
            this.rdoWind.Location = new System.Drawing.Point(6, 95);
            this.rdoWind.Name = "rdoWind";
            this.rdoWind.Size = new System.Drawing.Size(50, 17);
            this.rdoWind.TabIndex = 3;
            this.rdoWind.Text = "Wind";
            this.rdoWind.UseVisualStyleBackColor = true;
            // 
            // rdoEarth
            // 
            this.rdoEarth.AutoSize = true;
            this.rdoEarth.Location = new System.Drawing.Point(6, 72);
            this.rdoEarth.Name = "rdoEarth";
            this.rdoEarth.Size = new System.Drawing.Size(50, 17);
            this.rdoEarth.TabIndex = 2;
            this.rdoEarth.Text = "Earth";
            this.rdoEarth.UseVisualStyleBackColor = true;
            // 
            // rdoWater
            // 
            this.rdoWater.AutoSize = true;
            this.rdoWater.Location = new System.Drawing.Point(6, 49);
            this.rdoWater.Name = "rdoWater";
            this.rdoWater.Size = new System.Drawing.Size(54, 17);
            this.rdoWater.TabIndex = 1;
            this.rdoWater.Text = "Water";
            this.rdoWater.UseVisualStyleBackColor = true;
            // 
            // rdoFire
            // 
            this.rdoFire.AutoSize = true;
            this.rdoFire.Checked = true;
            this.rdoFire.Location = new System.Drawing.Point(6, 26);
            this.rdoFire.Name = "rdoFire";
            this.rdoFire.Size = new System.Drawing.Size(42, 17);
            this.rdoFire.TabIndex = 0;
            this.rdoFire.TabStop = true;
            this.rdoFire.Text = "Fire";
            this.rdoFire.UseVisualStyleBackColor = true;
            // 
            // btnTestFinal
            // 
            this.btnTestFinal.Location = new System.Drawing.Point(102, 30);
            this.btnTestFinal.Name = "btnTestFinal";
            this.btnTestFinal.Size = new System.Drawing.Size(75, 74);
            this.btnTestFinal.TabIndex = 16;
            this.btnTestFinal.Text = "Test Final Battle";
            this.btnTestFinal.UseVisualStyleBackColor = true;
            this.btnTestFinal.Click += new System.EventHandler(this.btnTestFinal_Click);
            // 
            // frmMicroMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 614);
            this.Controls.Add(this.grpSelectMicroMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTournament);
            this.Controls.Add(this.grpDialogue);
            this.Controls.Add(this.grpBattle);
            this.Controls.Add(this.grpDebug);
            this.Controls.Add(this.grpChoice);
            this.Name = "frmMicroMon";
            this.Text = "MicroMon";
            this.grpChoice.ResumeLayout(false);
            this.grpDebug.ResumeLayout(false);
            this.grpBattle.ResumeLayout(false);
            this.grpBattle.PerformLayout();
            this.grpDialogue.ResumeLayout(false);
            this.grpDialogue.PerformLayout();
            this.grpTournament.ResumeLayout(false);
            this.grpTournament.PerformLayout();
            this.grpSelectMicroMon.ResumeLayout(false);
            this.grpSelectMicroMon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoice;
        private System.Windows.Forms.Button btnChoiceThree;
        private System.Windows.Forms.Button btnChoiceTwo;
        private System.Windows.Forms.Button btnChoiceOne;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtboxEvents;
        private System.Windows.Forms.Panel pnlMicroOpponent;
        private System.Windows.Forms.Panel pnlMicroPlayer;
        private System.Windows.Forms.ProgressBar prbHealthPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ProgressBar prbHealthOpponent;
        private System.Windows.Forms.Label lblOppName;
        private System.Windows.Forms.GroupBox grpDebug;
        private System.Windows.Forms.Button btnTestBattle;
        private System.Windows.Forms.GroupBox grpBattle;
        private System.Windows.Forms.GroupBox grpDialogue;
        private System.Windows.Forms.GroupBox grpTournament;
        private System.Windows.Forms.Button btnStartTournament;
        private System.Windows.Forms.Label lblWinCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSelectMicroMon;
        private System.Windows.Forms.RadioButton rdoLight;
        private System.Windows.Forms.RadioButton rdoDark;
        private System.Windows.Forms.RadioButton rdoWind;
        private System.Windows.Forms.RadioButton rdoEarth;
        private System.Windows.Forms.RadioButton rdoWater;
        private System.Windows.Forms.RadioButton rdoFire;
        private System.Windows.Forms.Button btnTestFinal;
    }
}

