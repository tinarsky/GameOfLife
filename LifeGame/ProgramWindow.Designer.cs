﻿using LifeGame.Config;
using System.Windows.Forms;

namespace LifeGame
{
    partial class ProgramWindow
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
            this.components = new System.ComponentModel.Container();
            this._deadToAliveCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._settingsAndGameSplitContainer = new System.Windows.Forms.SplitContainer();
            this._densityLabel = new System.Windows.Forms.Label();
            this._densityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._clearMapButton = new System.Windows.Forms.Button();
            this._randomMapButton = new System.Windows.Forms.Button();
            this._mapEditorLabel = new System.Windows.Forms.Label();
            this._pauseButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._startButton = new System.Windows.Forms.Button();
            this._defaultRulesButton = new System.Windows.Forms.Button();
            this._aliveToAliveCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._fromDeadToAliveLabel = new System.Windows.Forms.Label();
            this._fromAliveToAliveLabel = new System.Windows.Forms.Label();
            this._rulesLabel = new System.Windows.Forms.Label();
            this._playingField = new System.Windows.Forms.PictureBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._settingsAndGameSplitContainer)).BeginInit();
            this._settingsAndGameSplitContainer.Panel1.SuspendLayout();
            this._settingsAndGameSplitContainer.Panel2.SuspendLayout();
            this._settingsAndGameSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._densityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._playingField)).BeginInit();
            this.SuspendLayout();
            // 
            // _deadToAliveCheckedListBox
            // 
            this._deadToAliveCheckedListBox.CheckOnClick = true;
            this._deadToAliveCheckedListBox.ColumnWidth = 120;
            this._deadToAliveCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deadToAliveCheckedListBox.FormattingEnabled = true;
            this._deadToAliveCheckedListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._deadToAliveCheckedListBox.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8});
            this._deadToAliveCheckedListBox.Location = new System.Drawing.Point(22, 318);
            this._deadToAliveCheckedListBox.MultiColumn = true;
            this._deadToAliveCheckedListBox.Name = "_deadToAliveCheckedListBox";
            this._deadToAliveCheckedListBox.Size = new System.Drawing.Size(248, 128);
            this._deadToAliveCheckedListBox.TabIndex = 3;
            this._deadToAliveCheckedListBox.TabStop = false;
            this._deadToAliveCheckedListBox.UseTabStops = false;
            this._deadToAliveCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // _settingsAndGameSplitContainer
            // 
            this._settingsAndGameSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._settingsAndGameSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this._settingsAndGameSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._settingsAndGameSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._settingsAndGameSplitContainer.IsSplitterFixed = true;
            this._settingsAndGameSplitContainer.Location = new System.Drawing.Point(0, 0);
            this._settingsAndGameSplitContainer.Name = "_settingsAndGameSplitContainer";
            // 
            // _settingsAndGameSplitContainer.Panel1
            // 
            this._settingsAndGameSplitContainer.Panel1.AccessibleName = "";
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._densityLabel);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._densityNumericUpDown);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._clearMapButton);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._randomMapButton);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._mapEditorLabel);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._pauseButton);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._stopButton);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._startButton);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._defaultRulesButton);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._aliveToAliveCheckedListBox);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._deadToAliveCheckedListBox);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._fromDeadToAliveLabel);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._fromAliveToAliveLabel);
            this._settingsAndGameSplitContainer.Panel1.Controls.Add(this._rulesLabel);
            // 
            // _settingsAndGameSplitContainer.Panel2
            // 
            this._settingsAndGameSplitContainer.Panel2.Controls.Add(this._playingField);
            this._settingsAndGameSplitContainer.Size = new System.Drawing.Size(1227, 1146);
            this._settingsAndGameSplitContainer.SplitterDistance = 277;
            this._settingsAndGameSplitContainer.TabIndex = 0;
            // 
            // _densityLabel
            // 
            this._densityLabel.AutoSize = true;
            this._densityLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._densityLabel.Location = new System.Drawing.Point(89, 614);
            this._densityLabel.Name = "_densityLabel";
            this._densityLabel.Size = new System.Drawing.Size(106, 38);
            this._densityLabel.TabIndex = 13;
            this._densityLabel.Text = "density";
            // 
            // _densityNumericUpDown
            // 
            this._densityNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._densityNumericUpDown.Location = new System.Drawing.Point(51, 657);
            this._densityNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._densityNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._densityNumericUpDown.Name = "_densityNumericUpDown";
            this._densityNumericUpDown.ReadOnly = true;
            this._densityNumericUpDown.Size = new System.Drawing.Size(180, 34);
            this._densityNumericUpDown.TabIndex = 12;
            this._densityNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _clearMapButton
            // 
            this._clearMapButton.BackColor = System.Drawing.Color.White;
            this._clearMapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._clearMapButton.Location = new System.Drawing.Point(51, 776);
            this._clearMapButton.Name = "_clearMapButton";
            this._clearMapButton.Size = new System.Drawing.Size(180, 55);
            this._clearMapButton.TabIndex = 11;
            this._clearMapButton.Text = "clear map";
            this._clearMapButton.UseVisualStyleBackColor = false;
            this._clearMapButton.Click += new System.EventHandler(this.ClearMapButtonClick);
            // 
            // _randomMapButton
            // 
            this._randomMapButton.BackColor = System.Drawing.Color.White;
            this._randomMapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._randomMapButton.Location = new System.Drawing.Point(51, 701);
            this._randomMapButton.Name = "_randomMapButton";
            this._randomMapButton.Size = new System.Drawing.Size(180, 55);
            this._randomMapButton.TabIndex = 10;
            this._randomMapButton.Text = "random map";
            this._randomMapButton.UseVisualStyleBackColor = false;
            this._randomMapButton.Click += new System.EventHandler(this.RandomMapButtonClick);
            // 
            // _mapEditorLabel
            // 
            this._mapEditorLabel.AutoSize = true;
            this._mapEditorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._mapEditorLabel.Location = new System.Drawing.Point(47, 550);
            this._mapEditorLabel.Name = "_mapEditorLabel";
            this._mapEditorLabel.Size = new System.Drawing.Size(195, 48);
            this._mapEditorLabel.TabIndex = 9;
            this._mapEditorLabel.Text = "Map Editor";
            this._mapEditorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _pauseButton
            // 
            this._pauseButton.BackColor = System.Drawing.Color.Yellow;
            this._pauseButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._pauseButton.Location = new System.Drawing.Point(51, 1056);
            this._pauseButton.Name = "_pauseButton";
            this._pauseButton.Size = new System.Drawing.Size(180, 63);
            this._pauseButton.TabIndex = 8;
            this._pauseButton.Text = "Pause";
            this._pauseButton.UseVisualStyleBackColor = false;
            this._pauseButton.Visible = false;
            this._pauseButton.Click += new System.EventHandler(this.PauseButtonClick);
            // 
            // _stopButton
            // 
            this._stopButton.BackColor = System.Drawing.Color.White;
            this._stopButton.Enabled = false;
            this._stopButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._stopButton.Location = new System.Drawing.Point(51, 972);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(180, 63);
            this._stopButton.TabIndex = 7;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = false;
            this._stopButton.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // _startButton
            // 
            this._startButton.BackColor = System.Drawing.Color.GreenYellow;
            this._startButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._startButton.Location = new System.Drawing.Point(51, 887);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(180, 63);
            this._startButton.TabIndex = 6;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = false;
            this._startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // _defaultRulesButton
            // 
            this._defaultRulesButton.BackColor = System.Drawing.Color.White;
            this._defaultRulesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._defaultRulesButton.Location = new System.Drawing.Point(51, 461);
            this._defaultRulesButton.Name = "_defaultRulesButton";
            this._defaultRulesButton.Size = new System.Drawing.Size(180, 55);
            this._defaultRulesButton.TabIndex = 5;
            this._defaultRulesButton.Text = "default rules";
            this._defaultRulesButton.UseVisualStyleBackColor = false;
            this._defaultRulesButton.Click += new System.EventHandler(this.DefaultRulesButtonClick);
            // 
            // _aliveToAliveCheckedListBox
            // 
            this._aliveToAliveCheckedListBox.CheckOnClick = true;
            this._aliveToAliveCheckedListBox.ColumnWidth = 120;
            this._aliveToAliveCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._aliveToAliveCheckedListBox.FormattingEnabled = true;
            this._aliveToAliveCheckedListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._aliveToAliveCheckedListBox.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8});
            this._aliveToAliveCheckedListBox.Location = new System.Drawing.Point(22, 125);
            this._aliveToAliveCheckedListBox.MultiColumn = true;
            this._aliveToAliveCheckedListBox.Name = "_aliveToAliveCheckedListBox";
            this._aliveToAliveCheckedListBox.Size = new System.Drawing.Size(248, 128);
            this._aliveToAliveCheckedListBox.TabIndex = 4;
            this._aliveToAliveCheckedListBox.TabStop = false;
            this._aliveToAliveCheckedListBox.UseTabStops = false;
            this._aliveToAliveCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // _fromDeadToAliveLabel
            // 
            this._fromDeadToAliveLabel.AutoSize = true;
            this._fromDeadToAliveLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fromDeadToAliveLabel.Location = new System.Drawing.Point(46, 276);
            this._fromDeadToAliveLabel.Name = "_fromDeadToAliveLabel";
            this._fromDeadToAliveLabel.Size = new System.Drawing.Size(180, 38);
            this._fromDeadToAliveLabel.TabIndex = 2;
            this._fromDeadToAliveLabel.Text = "dead -> alive";
            this._fromDeadToAliveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _fromAliveToAliveLabel
            // 
            this._fromAliveToAliveLabel.AutoSize = true;
            this._fromAliveToAliveLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fromAliveToAliveLabel.Location = new System.Drawing.Point(51, 84);
            this._fromAliveToAliveLabel.Name = "_fromAliveToAliveLabel";
            this._fromAliveToAliveLabel.Size = new System.Drawing.Size(175, 38);
            this._fromAliveToAliveLabel.TabIndex = 1;
            this._fromAliveToAliveLabel.Text = "alive -> alive";
            this._fromAliveToAliveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _rulesLabel
            // 
            this._rulesLabel.AutoSize = true;
            this._rulesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rulesLabel.Location = new System.Drawing.Point(84, 19);
            this._rulesLabel.Name = "_rulesLabel";
            this._rulesLabel.Size = new System.Drawing.Size(105, 48);
            this._rulesLabel.TabIndex = 0;
            this._rulesLabel.Text = "Rules";
            this._rulesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _playingField
            // 
            this._playingField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._playingField.Location = new System.Drawing.Point(0, 0);
            this._playingField.Name = "_playingField";
            this._playingField.Size = new System.Drawing.Size(942, 1142);
            this._playingField.TabIndex = 0;
            this._playingField.TabStop = false;
            this._playingField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayingFieldMouseClick);
            this._playingField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayingFieldMouseMove);
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Interval = DefaultMapSettings.TimerInterval;
            this._timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // ProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 1146);
            this.Controls.Add(this._settingsAndGameSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgramWindow";
            this.Text = "Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._settingsAndGameSplitContainer.Panel1.ResumeLayout(false);
            this._settingsAndGameSplitContainer.Panel1.PerformLayout();
            this._settingsAndGameSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._settingsAndGameSplitContainer)).EndInit();
            this._settingsAndGameSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._densityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._playingField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _settingsAndGameSplitContainer;
        private System.Windows.Forms.PictureBox _playingField;
        private System.Windows.Forms.CheckedListBox _deadToAliveCheckedListBox;
        private System.Windows.Forms.Label _fromDeadToAliveLabel;
        private System.Windows.Forms.Label _fromAliveToAliveLabel;
        private System.Windows.Forms.Label _rulesLabel;
        private System.Windows.Forms.CheckedListBox _aliveToAliveCheckedListBox;
        private System.Windows.Forms.Button _defaultRulesButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Timer _timer;
        private Button _pauseButton;
        private Label _mapEditorLabel;
        private Button _clearMapButton;
        private Button _randomMapButton;
        private Label _densityLabel;
        private NumericUpDown _densityNumericUpDown;
    }
}

