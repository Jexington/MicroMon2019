using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace MicroMon2019
{
    public partial class frmMicroMon : Form
    {
        public frmMicroMon()
        {
            InitializeComponent();

            // Init Design
            grpBattle.Enabled = false;
            grpChoice.Enabled = false;
            
        }

        // Init Variables
        MicroMon curPlayerMicroMon;
        MicroMon curOpponentMicroMon;
        int dialogueCounter;
        bool battleOver = true;
        bool okClicked = false;
        int winCounter;



        private void btnOk_Click(object sender, EventArgs e)
        {
            okClicked = true;
        }

        private MicroMon makeMicroMon(string name)
        {
            MicroMon obj = new MicroMon(name);
            obj.initStats();
            return obj;
        }

        private void createDialogue(string[] dialogue)
        {
            // Takes a static list of strings and prints them out with a new line attached

            for (var i = 0; i < dialogue.Length; i++)
            {
                txtboxEvents.Text += dialogue[i] + Environment.NewLine;
                dialogueCounter++;
            }
        }

        private void populatePlayer(MicroMon playerMicro)
        {
            lblPlayerName.Text = playerMicro.getMicroMonName();
            prbHealthPlayer.Maximum = playerMicro.getMaxHealth();
            prbHealthPlayer.Value = playerMicro.getCurHealth();

            btnChoiceOne.Text = playerMicro.getMoveOne();
            btnChoiceTwo.Text = playerMicro.getMoveTwo();
            btnChoiceThree.Text = playerMicro.getMoveThree();

            // Set image for player panel
            if (playerMicro.getMicroMonName() == "fireboi")
            {
                pnlMicroPlayer.BackgroundImage = Properties.Resources.Fireboi;
            } else if (playerMicro.getMicroMonName() == "waterboi") {
                pnlMicroPlayer.BackgroundImage = Properties.Resources.Waterboi;
            } else if (playerMicro.getMicroMonName() == "earthboi") {
                pnlMicroPlayer.BackgroundImage = Properties.Resources.Earthboi;
            } else if (playerMicro.getMicroMonName() == "windboi"){
                pnlMicroPlayer.BackgroundImage = Properties.Resources.Windboi;
            } else if (playerMicro.getMicroMonName() == "darkboi") {
                pnlMicroPlayer.BackgroundImage = Properties.Resources.Darkboi;
            } else if (playerMicro.getMicroMonName() == "lightboi") {
                pnlMicroPlayer.BackgroundImage = Properties.Resources.Lightboi;
            }

        }

        private void populateOpponent(MicroMon opponentMicro)
        {
            lblOppName.Text = opponentMicro.getMicroMonName();
            prbHealthOpponent.Maximum = opponentMicro.getMaxHealth();
            prbHealthOpponent.Value = opponentMicro.getCurHealth();

            // Set image for opponent panel
            pnlMicroOpponent.BackgroundImage = null;

            if (opponentMicro.getMicroMonName() == "fireboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.Fireboi;
            }
            else if (opponentMicro.getMicroMonName() == "waterboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.Waterboi;
            }
            else if (opponentMicro.getMicroMonName() == "earthboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.Earthboi;
            }
            else if (opponentMicro.getMicroMonName() == "windboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.Windboi;
            }
            else if (opponentMicro.getMicroMonName() == "darkboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.Darkboi;
            }
            else if (opponentMicro.getMicroMonName() == "lightboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.Lightboi;
            }
            else if (opponentMicro.getMicroMonName() == "bossboi")
            {
                pnlMicroOpponent.BackgroundImage = Properties.Resources.BossBoi;
            }

        }

        private void startBattle(MicroMon playerMicroMon, MicroMon opponentMicroMon)
        {
            btnOk.Enabled = false;
            grpBattle.Enabled = true;
            grpChoice.Enabled = true;
            grpTournament.Enabled = false;
            grpSelectMicroMon.Enabled = false;
            battleOver = false;

            populatePlayer(playerMicroMon);
            populateOpponent(opponentMicroMon);
        }

        private void btnTestBattle_Click(object sender, EventArgs e)
        {
            MicroMon selectedPlayerMicroMon = playerSelect();
            MicroMon selectedOpponentMicroMon = makeMicroMon("waterboi");

            // Sets the global MicroMon variables to the currently selected MicroMon
            curPlayerMicroMon = selectedPlayerMicroMon;
            curOpponentMicroMon = selectedOpponentMicroMon;
            startBattle(selectedPlayerMicroMon, selectedOpponentMicroMon);
        }

        private string chooseOpponentMove(MicroMon opponentMicroMon)
        {
            string moveChoice = "";

            Random moveSelect = new Random();
            int moveSelectNum = moveSelect.Next(0, 3);

            if (moveSelectNum == 0)
            {
                moveChoice = opponentMicroMon.mMoveOne;
            }
            else if (moveSelectNum == 1)
            {
                moveChoice = opponentMicroMon.mMoveTwo;
            }
            else
            {
                moveChoice = opponentMicroMon.mMoveThree;
            }

            return moveChoice = opponentMicroMon.mMoveOne;
        }

        private void btnChoiceOne_Click(object sender, EventArgs e)
        {
            // Moves come in pairs so the opponent 
            useMove(btnChoiceOne.Text, curPlayerMicroMon, curOpponentMicroMon, true);

            // Add a delay
            Thread.Sleep(1000);

            useMove(chooseOpponentMove(curOpponentMicroMon), curPlayerMicroMon, curOpponentMicroMon, false);
        }

        private void btnChoiceTwo_Click(object sender, EventArgs e)
        {
            useMove(btnChoiceTwo.Text, curPlayerMicroMon, curOpponentMicroMon, true);

            // Add a delay
            Thread.Sleep(1000);

            useMove(chooseOpponentMove(curOpponentMicroMon), curPlayerMicroMon, curOpponentMicroMon, false);
        }

        private void btnChoiceThree_Click(object sender, EventArgs e)
        {
            useMove(btnChoiceThree.Text, curPlayerMicroMon, curOpponentMicroMon, true);

            // Add a delay
            Thread.Sleep(1000);

            useMove(chooseOpponentMove(curOpponentMicroMon), curPlayerMicroMon, curOpponentMicroMon, false);
        }

        private void useMove(string move, MicroMon playerMicroMon, MicroMon opponentMicroMon, bool playerTurn)
        {
            if (playerMicroMon.getAlive() == true && opponentMicroMon.getAlive() == true)
            {
                int curAttack;
                int curDefense;
                string curType;

                // Set current variables to the selected Micromon's stats
                if (playerTurn == true)
                {
                    curAttack = playerMicroMon.getAttack();
                    curDefense = playerMicroMon.getDefense();
                    curType = playerMicroMon.getMicroType();
                }
                else
                {
                    curAttack = opponentMicroMon.getAttack();
                    curDefense = opponentMicroMon.getDefense();
                    curType = opponentMicroMon.getMicroType();
                }

                // Move bank
                if (move.ToLower() == "tackle")
                {
                    if (playerTurn == true)
                    {
                        // Modify values to align with base and attack
                        opponentMicroMon.takeDamage(Math.Abs(2 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()));
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used tackle!" + Environment.NewLine;
                    }
                    else
                    {
                        playerMicroMon.takeDamage(2 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used tackle!" + Environment.NewLine;
                    }

                }

                if (move.ToLower() == "firebreath")
                {
                    if (playerTurn == true)
                    {
                        if (opponentMicroMon.getMicroType() == "wind")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "water")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            opponentMicroMon.takeDamage(4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        }
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Fire Breath!" + Environment.NewLine;
                    }
                    else
                    {
                        if (opponentMicroMon.getMicroType() == "fire")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "earth")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        }
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Fire Breath!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "phoenixheal")
                {
                    if (playerTurn == true)
                    {
                        playerMicroMon.heal(2);
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Phoenix Heal!" + Environment.NewLine;
                    }
                    else
                    {
                        opponentMicroMon.heal(2);
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Phoenix Heal!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "clawstrike")
                {
                    if (playerTurn == true)
                    {
                        opponentMicroMon.takeDamage(Math.Abs(1 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()));
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Claw Strike!" + Environment.NewLine;
                    }
                    else
                    {
                        playerMicroMon.takeDamage(1 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Claw Strike!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "watershield")
                {
                    if (playerTurn == true)
                    {
                        playerMicroMon.heal(3);
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Water Shield!" + Environment.NewLine;
                    }
                    else
                    {
                        opponentMicroMon.heal(3);
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Water Shield!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "rainofpain")
                {
                    if (playerTurn == true)
                    {
                        if (opponentMicroMon.getMicroType() == "fire")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "earth")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            opponentMicroMon.takeDamage(4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        }
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Rain of Pain!" + Environment.NewLine;
                    }
                    else
                    {
                        if (playerMicroMon.getMicroType() == "fire")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "earth")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        }
                        playerMicroMon.takeDamage(3 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Rain of Pain!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "rockwall")
                {
                    if (playerTurn == true)
                    {

                        opponentMicroMon.modDefense(3);
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Rock Wall!" + Environment.NewLine;
                    }
                    else
                    {
                        playerMicroMon.modDefense(3);
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Rock Wall!" + Environment.NewLine;
                    }


                }

                if (move.ToLower() == "meteoriteslam")
                {
                    if (playerTurn == true)
                    {
                        if (opponentMicroMon.getMicroType() == "water")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "dark")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()));
                        }
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Meteorite Slam!" + Environment.NewLine;
                    }
                    else
                    {
                        if (playerMicroMon.getMicroType() == "light")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "fire")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        }
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Meteorite Slam!" + Environment.NewLine;

                    }


                }

                if (move.ToLower() == "hurricaneheal")
                {
                    if (playerTurn == true)
                    {

                        playerMicroMon.heal(2);
                        prbHealthOpponent.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Hurricane Heal!" + Environment.NewLine;
                    }
                    else
                    {
                        opponentMicroMon.heal(2);
                        prbHealthPlayer.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Hurricane Heal!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "tornadostrike")
                {
                    if (playerTurn == true)
                    {
                        if (opponentMicroMon.getMicroType() == "light")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "fire")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()));
                        }
                        opponentMicroMon.takeDamage(2 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Tornado Strike!" + Environment.NewLine;
                    }
                    else
                    {
                        if (playerMicroMon.getMicroType() == "light")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "fire")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        }
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Tornado Strike!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "darkheal")
                {
                    if (playerTurn == true)
                    {

                        playerMicroMon.heal(2);
                        prbHealthOpponent.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Dark Heal!" + Environment.NewLine;
                    }
                    else
                    {
                        opponentMicroMon.heal(2);
                        prbHealthPlayer.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Dark Heal!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "blackmagic")
                {
                    if (playerTurn == true)
                    {
                        if (opponentMicroMon.getMicroType() == "earth")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "light")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()));
                        }
                        opponentMicroMon.takeDamage(2 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Black Magic!" + Environment.NewLine;
                    }
                    else
                    {
                        if (playerMicroMon.getMicroType() == "earth")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "light")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        }
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Black Magic!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "healingsun")
                {
                    if (playerTurn == true)
                    {
                        playerMicroMon.heal(2);
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Light Heal!" + Environment.NewLine;
                    }
                    else
                    {
                        opponentMicroMon.heal(2);
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Light Heal!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "burninglight")
                {
                    if (playerTurn == true)
                    {
                        if (opponentMicroMon.getMicroType() == "dark")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "wind")
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            opponentMicroMon.takeDamage((4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense()));
                        }
                        opponentMicroMon.takeDamage(2 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Burning light!" + Environment.NewLine;
                    }
                    else
                    {
                        if (playerMicroMon.getMicroType() == "dark")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) * 2);
                            txtboxEvents.Text += "It was super effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else if (opponentMicroMon.getMicroType() == "wind")
                        {
                            playerMicroMon.takeDamage((4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense()) / 2);
                            txtboxEvents.Text += "It was not very effective!!" + Environment.NewLine;
                            dialogueCounter++;
                            checkEventBox();
                        }
                        else
                        {
                            playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        }
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Burning Light!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "emberfury")
                {
                    if (playerTurn == true)
                    {

                        playerMicroMon.takeDamage(3);
                        prbHealthOpponent.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Ember Fury!" + Environment.NewLine;
                    }
                    else
                    {
                        opponentMicroMon.takeDamage(3);
                        prbHealthPlayer.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Ember Fury!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "tailswing")
                {
                    if (playerTurn == true)
                    {

                        opponentMicroMon.takeDamage(3 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Tail Swing!" + Environment.NewLine;
                    }
                    else
                    {
                        playerMicroMon.takeDamage(3 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Tail Swing!" + Environment.NewLine;
                    }
                }

                if (move.ToLower() == "apocalypse")
                {
                    if (playerTurn == true)
                    {

                        opponentMicroMon.takeDamage(4 + playerMicroMon.getAttack() - opponentMicroMon.getDefense());
                        prbHealthOpponent.Value = opponentMicroMon.getCurHealth();
                        txtboxEvents.Text += playerMicroMon.getMicroMonName() + " used Apocalypse!" + Environment.NewLine;
                    }
                    else
                    {
                        playerMicroMon.takeDamage(4 + opponentMicroMon.getAttack() - playerMicroMon.getDefense());
                        prbHealthPlayer.Value = playerMicroMon.getCurHealth();
                        txtboxEvents.Text += opponentMicroMon.getMicroMonName() + " used Apocalypse!" + Environment.NewLine;

                    }

                }
            }
            else if (playerMicroMon.mAlive == false && battleOver == false)
            {
                txtboxEvents.Text += "You Lost!!" + Environment.NewLine;
                battleOver = true;
                btnOk.Enabled = true;
                grpBattle.Enabled = false;
                grpChoice.Enabled = false;
                grpSelectMicroMon.Enabled = true;
                grpTournament.Enabled = true;
                winCounter = 0;
                lblWinCounter.Text = "Win Counter: " + winCounter.ToString();
            }
            else if (opponentMicroMon.mAlive == false && battleOver == false)
            {
                txtboxEvents.Text += "You Won!!" + Environment.NewLine;
                battleOver = true;
                btnOk.Enabled = true;
                grpBattle.Enabled = false;
                grpChoice.Enabled = false;
                grpSelectMicroMon.Enabled = true;
                grpTournament.Enabled = true;
                winCounter += 1;
                lblWinCounter.Text = "Win Counter: " + winCounter.ToString();
            }
            dialogueCounter++;
            checkEventBox();
        }

        // If the txtboxEvents is overflowing, it resets it.
        private void checkEventBox()
        {
            if (dialogueCounter >= 16)
            {
                txtboxEvents.Text = "";
                dialogueCounter = 0;
                Thread.Sleep(1000);
            }
        }

        private void btnStartTournament_Click(object sender, EventArgs e)
        {


            if (winCounter < 3)
            {
                string[] curDialogue = { "Hello and welcome to the IronCup tourniment!!" };
                createDialogue(curDialogue);

                MicroMon selectedPlayerMicroMon = playerSelect();
                MicroMon selectedOpponentMicroMon = tournamentOpponentSelect();

                // Sets the global MicroMon variables to the currently selected MicroMon
                curPlayerMicroMon = selectedPlayerMicroMon;
                curOpponentMicroMon = selectedOpponentMicroMon;
                startBattle(selectedPlayerMicroMon, selectedOpponentMicroMon);
            }
            else if (winCounter >= 3)
            {
                string[] curDialogue = { "Here's the final challenge!! " };
                createDialogue(curDialogue);

                MicroMon selectedPlayerMicroMon = playerSelect();
                MicroMon selectedOpponentMicroMon = makeMicroMon("bossboi");

                curPlayerMicroMon = selectedPlayerMicroMon;
                curOpponentMicroMon = selectedOpponentMicroMon;
                startBattle(selectedPlayerMicroMon, selectedOpponentMicroMon);
            }
            
        }

        //Randomly selects a Micromon for the opponent.
        private MicroMon tournamentOpponentSelect()
        {
            Random selector = new Random();
            int randomSelector = selector.Next(0, 6);

            if (randomSelector == 0)
            {
                return makeMicroMon("fireboi");
            }
            else if (randomSelector == 1)
            {
                return makeMicroMon("waterboi");
            }
            else if (randomSelector == 2)
            {
                return makeMicroMon("earthboi");
            }
            else if (randomSelector == 3)
            {
                return makeMicroMon("windboi");
            }
            else if (randomSelector == 4)
            {
                return makeMicroMon("lightboi");
            }
            else if (randomSelector == 5)
            {
                return makeMicroMon("darkboi");
            }
            else
            {
                return makeMicroMon("flireboi");
            }
        }

        private MicroMon playerSelect()
        {
            if (rdoFire.Checked == true)
            {
                return makeMicroMon("fireboi");
            }
            else if (rdoWater.Checked == true)
            {
                return makeMicroMon("waterboi");
            }
            else if (rdoEarth.Checked == true)
            {
                return makeMicroMon("earthboi");
            }
            else if (rdoWind.Checked == true)
            {
                return makeMicroMon("windboi");
            }
            else if (rdoDark.Checked == true)
            {
                return makeMicroMon("darkboi");
            }
            else if (rdoLight.Checked == true)
            {
                return makeMicroMon("lightboi");
            }

            return makeMicroMon("fireboi");
        }

        private void btnTestFinal_Click(object sender, EventArgs e)
        {
            string[] curDialogue = { "Here's the final challenge!! " };
            createDialogue(curDialogue);

            MicroMon selectedPlayerMicroMon = playerSelect();
            MicroMon selectedOpponentMicroMon = makeMicroMon("bossboi");

            curPlayerMicroMon = selectedPlayerMicroMon;
            curOpponentMicroMon = selectedOpponentMicroMon;
            startBattle(selectedPlayerMicroMon, selectedOpponentMicroMon);
        }
    }
}
