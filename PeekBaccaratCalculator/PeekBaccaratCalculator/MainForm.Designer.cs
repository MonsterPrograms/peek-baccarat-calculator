
namespace PeekBaccaratCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numSimulations = new System.Windows.Forms.NumericUpDown();
            this.comboPlayerOrBanker = new System.Windows.Forms.ComboBox();
            this.comboPlayerCard1 = new System.Windows.Forms.ComboBox();
            this.comboPlayerCard2 = new System.Windows.Forms.ComboBox();
            this.comboBankerCard1 = new System.Windows.Forms.ComboBox();
            this.comboBankerCard2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulations)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1st Card:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd Card:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "4th Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "3rd Card:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(81, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(81, 231);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(68, 17);
            this.chkTopMost.TabIndex = 8;
            this.chkTopMost.Text = "TopMost";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "P/B:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Simulations:";
            // 
            // numSimulations
            // 
            this.numSimulations.Location = new System.Drawing.Point(81, 12);
            this.numSimulations.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSimulations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSimulations.Name = "numSimulations";
            this.numSimulations.Size = new System.Drawing.Size(73, 20);
            this.numSimulations.TabIndex = 0;
            this.numSimulations.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // comboPlayerOrBanker
            // 
            this.comboPlayerOrBanker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPlayerOrBanker.FormattingEnabled = true;
            this.comboPlayerOrBanker.Items.AddRange(new object[] {
            "Player",
            "Banker"});
            this.comboPlayerOrBanker.Location = new System.Drawing.Point(81, 38);
            this.comboPlayerOrBanker.Name = "comboPlayerOrBanker";
            this.comboPlayerOrBanker.Size = new System.Drawing.Size(73, 21);
            this.comboPlayerOrBanker.TabIndex = 1;
            this.comboPlayerOrBanker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboPlayerCard1
            // 
            this.comboPlayerCard1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPlayerCard1.FormattingEnabled = true;
            this.comboPlayerCard1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboPlayerCard1.Location = new System.Drawing.Point(81, 65);
            this.comboPlayerCard1.Name = "comboPlayerCard1";
            this.comboPlayerCard1.Size = new System.Drawing.Size(73, 21);
            this.comboPlayerCard1.TabIndex = 2;
            this.comboPlayerCard1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboPlayerCard2
            // 
            this.comboPlayerCard2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPlayerCard2.FormattingEnabled = true;
            this.comboPlayerCard2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboPlayerCard2.Location = new System.Drawing.Point(81, 92);
            this.comboPlayerCard2.Name = "comboPlayerCard2";
            this.comboPlayerCard2.Size = new System.Drawing.Size(73, 21);
            this.comboPlayerCard2.TabIndex = 3;
            this.comboPlayerCard2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboBankerCard1
            // 
            this.comboBankerCard1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBankerCard1.FormattingEnabled = true;
            this.comboBankerCard1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBankerCard1.Location = new System.Drawing.Point(81, 119);
            this.comboBankerCard1.Name = "comboBankerCard1";
            this.comboBankerCard1.Size = new System.Drawing.Size(73, 21);
            this.comboBankerCard1.TabIndex = 4;
            this.comboBankerCard1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboBankerCard2
            // 
            this.comboBankerCard2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBankerCard2.FormattingEnabled = true;
            this.comboBankerCard2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBankerCard2.Location = new System.Drawing.Point(81, 146);
            this.comboBankerCard2.Name = "comboBankerCard2";
            this.comboBankerCard2.Size = new System.Drawing.Size(73, 21);
            this.comboBankerCard2.TabIndex = 5;
            this.comboBankerCard2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 255);
            this.Controls.Add(this.comboBankerCard2);
            this.Controls.Add(this.comboBankerCard1);
            this.Controls.Add(this.comboPlayerCard2);
            this.Controls.Add(this.comboPlayerCard1);
            this.Controls.Add(this.comboPlayerOrBanker);
            this.Controls.Add(this.numSimulations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peek Baccarat Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numSimulations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSimulations;
        private System.Windows.Forms.ComboBox comboPlayerOrBanker;
        private System.Windows.Forms.ComboBox comboPlayerCard1;
        private System.Windows.Forms.ComboBox comboPlayerCard2;
        private System.Windows.Forms.ComboBox comboBankerCard1;
        private System.Windows.Forms.ComboBox comboBankerCard2;
    }
}

