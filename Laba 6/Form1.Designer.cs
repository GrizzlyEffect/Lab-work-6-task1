namespace Laba_6
{
    partial class Form1
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
            this.ParalBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcParal = new System.Windows.Forms.Button();
            this.btnCalcTrapez = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TrapBase1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParalHeight = new System.Windows.Forms.TextBox();
            this.TrapHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TrapBase2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.lbResultParal = new System.Windows.Forms.Label();
            this.lbResultTrapez = new System.Windows.Forms.Label();
            this.label222 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParalBase
            // 
            this.ParalBase.Location = new System.Drawing.Point(97, 55);
            this.ParalBase.Name = "ParalBase";
            this.ParalBase.Size = new System.Drawing.Size(127, 22);
            this.ParalBase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parallelogram";
            // 
            // btnCalcParal
            // 
            this.btnCalcParal.Location = new System.Drawing.Point(97, 133);
            this.btnCalcParal.Name = "btnCalcParal";
            this.btnCalcParal.Size = new System.Drawing.Size(127, 23);
            this.btnCalcParal.TabIndex = 2;
            this.btnCalcParal.Text = "Callculate";
            this.btnCalcParal.UseVisualStyleBackColor = true;
            this.btnCalcParal.Click += new System.EventHandler(this.btnCalcParal_Click);
            // 
            // btnCalcTrapez
            // 
            this.btnCalcTrapez.Location = new System.Drawing.Point(504, 175);
            this.btnCalcTrapez.Name = "btnCalcTrapez";
            this.btnCalcTrapez.Size = new System.Drawing.Size(127, 23);
            this.btnCalcTrapez.TabIndex = 3;
            this.btnCalcTrapez.Text = "Callculate";
            this.btnCalcTrapez.UseVisualStyleBackColor = true;
            this.btnCalcTrapez.Click += new System.EventHandler(this.btnCalcTrapez_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trapezium";
            // 
            // TrapBase1
            // 
            this.TrapBase1.Location = new System.Drawing.Point(504, 55);
            this.TrapBase1.Name = "TrapBase1";
            this.TrapBase1.Size = new System.Drawing.Size(127, 22);
            this.TrapBase1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height ->";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ParalHeight
            // 
            this.ParalHeight.Location = new System.Drawing.Point(97, 91);
            this.ParalHeight.Name = "ParalHeight";
            this.ParalHeight.Size = new System.Drawing.Size(127, 22);
            this.ParalHeight.TabIndex = 8;
            // 
            // TrapHeight
            // 
            this.TrapHeight.Location = new System.Drawing.Point(504, 133);
            this.TrapHeight.Name = "TrapHeight";
            this.TrapHeight.Size = new System.Drawing.Size(127, 22);
            this.TrapHeight.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Height ->";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "2-nd Base ->";
            // 
            // TrapBase2
            // 
            this.TrapBase2.Location = new System.Drawing.Point(504, 91);
            this.TrapBase2.Name = "TrapBase2";
            this.TrapBase2.Size = new System.Drawing.Size(127, 22);
            this.TrapBase2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "1-st Base ->";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(94, 194);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(45, 16);
            this.label111.TabIndex = 14;
            this.label111.Text = "Result";
            // 
            // lbResultParal
            // 
            this.lbResultParal.AutoSize = true;
            this.lbResultParal.Location = new System.Drawing.Point(94, 219);
            this.lbResultParal.Name = "lbResultParal";
            this.lbResultParal.Size = new System.Drawing.Size(0, 16);
            this.lbResultParal.TabIndex = 15;
            // 
            // lbResultTrapez
            // 
            this.lbResultTrapez.AutoSize = true;
            this.lbResultTrapez.Location = new System.Drawing.Point(501, 235);
            this.lbResultTrapez.Name = "lbResultTrapez";
            this.lbResultTrapez.Size = new System.Drawing.Size(0, 16);
            this.lbResultTrapez.TabIndex = 17;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Location = new System.Drawing.Point(501, 219);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(45, 16);
            this.label222.TabIndex = 16;
            this.label222.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultTrapez);
            this.Controls.Add(this.label222);
            this.Controls.Add(this.lbResultParal);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TrapHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TrapBase2);
            this.Controls.Add(this.ParalHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrapBase1);
            this.Controls.Add(this.btnCalcTrapez);
            this.Controls.Add(this.btnCalcParal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParalBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParalBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcParal;
        private System.Windows.Forms.Button btnCalcTrapez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrapBase1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ParalHeight;
        private System.Windows.Forms.TextBox TrapHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TrapBase2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label lbResultParal;
        private System.Windows.Forms.Label lbResultTrapez;
        private System.Windows.Forms.Label label222;
    }
}

