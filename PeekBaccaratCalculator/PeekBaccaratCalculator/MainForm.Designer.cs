
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
            this.txtPlayerCard1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankerCard1 = new System.Windows.Forms.TextBox();
            this.txtPlayerCard2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankerCard2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayerOrBanker = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSimulations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerCard1
            // 
            this.txtPlayerCard1.Location = new System.Drawing.Point(81, 64);
            this.txtPlayerCard1.Name = "txtPlayerCard1";
            this.txtPlayerCard1.Size = new System.Drawing.Size(73, 20);
            this.txtPlayerCard1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1st Card:";
            // 
            // txtBankerCard1
            // 
            this.txtBankerCard1.Location = new System.Drawing.Point(81, 116);
            this.txtBankerCard1.Name = "txtBankerCard1";
            this.txtBankerCard1.Size = new System.Drawing.Size(73, 20);
            this.txtBankerCard1.TabIndex = 3;
            // 
            // txtPlayerCard2
            // 
            this.txtPlayerCard2.Location = new System.Drawing.Point(81, 90);
            this.txtPlayerCard2.Name = "txtPlayerCard2";
            this.txtPlayerCard2.Size = new System.Drawing.Size(73, 20);
            this.txtPlayerCard2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd Card:";
            // 
            // txtBankerCard2
            // 
            this.txtBankerCard2.Location = new System.Drawing.Point(81, 142);
            this.txtBankerCard2.Name = "txtBankerCard2";
            this.txtBankerCard2.Size = new System.Drawing.Size(73, 20);
            this.txtBankerCard2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "4th Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "3rd Card:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(81, 197);
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
            this.chkTopMost.Location = new System.Drawing.Point(81, 226);
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
            // txtPlayerOrBanker
            // 
            this.txtPlayerOrBanker.Location = new System.Drawing.Point(81, 38);
            this.txtPlayerOrBanker.Name = "txtPlayerOrBanker";
            this.txtPlayerOrBanker.Size = new System.Drawing.Size(73, 20);
            this.txtPlayerOrBanker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // txtSimulations
            // 
            this.txtSimulations.Location = new System.Drawing.Point(81, 12);
            this.txtSimulations.Name = "txtSimulations";
            this.txtSimulations.Size = new System.Drawing.Size(73, 20);
            this.txtSimulations.TabIndex = 10;
            this.txtSimulations.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Simulations:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 251);
            this.Controls.Add(this.txtSimulations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlayerOrBanker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlayerCard2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayerCard1);
            this.Controls.Add(this.txtBankerCard2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBankerCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peek Baccarat Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerCard1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankerCard1;
        private System.Windows.Forms.TextBox txtPlayerCard2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankerCard2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlayerOrBanker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSimulations;
        private System.Windows.Forms.Label label1;
    }
}

