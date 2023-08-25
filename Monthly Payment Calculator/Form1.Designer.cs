namespace Monthly_Payment_Calculator
{
    partial class Form1
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.loanAmountTxtBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.emiGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearCLBtn = new System.Windows.Forms.Button();
            this.loanMonthsTxtBox = new System.Windows.Forms.TextBox();
            this.interestRateTxtBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.emiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(6, 75);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(115, 40);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // loanAmountTxtBox
            // 
            this.loanAmountTxtBox.Location = new System.Drawing.Point(144, 26);
            this.loanAmountTxtBox.Name = "loanAmountTxtBox";
            this.loanAmountTxtBox.Size = new System.Drawing.Size(100, 23);
            this.loanAmountTxtBox.TabIndex = 0;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 15;
            this.outputListBox.Location = new System.Drawing.Point(12, 173);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(760, 124);
            this.outputListBox.TabIndex = 1;
            // 
            // emiGroupBox
            // 
            this.emiGroupBox.Controls.Add(this.label6);
            this.emiGroupBox.Controls.Add(this.label5);
            this.emiGroupBox.Controls.Add(this.label4);
            this.emiGroupBox.Controls.Add(this.label3);
            this.emiGroupBox.Controls.Add(this.label2);
            this.emiGroupBox.Controls.Add(this.label1);
            this.emiGroupBox.Controls.Add(this.clearCLBtn);
            this.emiGroupBox.Controls.Add(this.loanMonthsTxtBox);
            this.emiGroupBox.Controls.Add(this.interestRateTxtBox);
            this.emiGroupBox.Controls.Add(this.exitBtn);
            this.emiGroupBox.Controls.Add(this.deleteItemBtn);
            this.emiGroupBox.Controls.Add(this.clearBtn);
            this.emiGroupBox.Controls.Add(this.calculateBtn);
            this.emiGroupBox.Controls.Add(this.loanAmountTxtBox);
            this.emiGroupBox.Location = new System.Drawing.Point(12, 28);
            this.emiGroupBox.Name = "emiGroupBox";
            this.emiGroupBox.Size = new System.Drawing.Size(760, 130);
            this.emiGroupBox.TabIndex = 0;
            this.emiGroupBox.TabStop = false;
            this.emiGroupBox.Text = "EMI Calculator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mnths";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Pay Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Interest Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Loan Amount:";
            // 
            // clearCLBtn
            // 
            this.clearCLBtn.Location = new System.Drawing.Point(480, 75);
            this.clearCLBtn.Name = "clearCLBtn";
            this.clearCLBtn.Size = new System.Drawing.Size(115, 40);
            this.clearCLBtn.TabIndex = 6;
            this.clearCLBtn.Text = "Clear List Box";
            this.clearCLBtn.UseVisualStyleBackColor = true;
            this.clearCLBtn.Click += new System.EventHandler(this.clearCLBtn_Click);
            // 
            // loanMonthsTxtBox
            // 
            this.loanMonthsTxtBox.Location = new System.Drawing.Point(608, 26);
            this.loanMonthsTxtBox.Name = "loanMonthsTxtBox";
            this.loanMonthsTxtBox.Size = new System.Drawing.Size(100, 23);
            this.loanMonthsTxtBox.TabIndex = 2;
            // 
            // interestRateTxtBox
            // 
            this.interestRateTxtBox.Location = new System.Drawing.Point(372, 26);
            this.interestRateTxtBox.Name = "interestRateTxtBox";
            this.interestRateTxtBox.Size = new System.Drawing.Size(100, 23);
            this.interestRateTxtBox.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(638, 75);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 40);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(322, 75);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(115, 40);
            this.deleteItemBtn.TabIndex = 5;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(164, 75);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 40);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(784, 333);
            this.Controls.Add(this.emiGroupBox);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.emiGroupBox.ResumeLayout(false);
            this.emiGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button calculateBtn;
        private TextBox loanAmountTxtBox;
        private ListBox outputListBox;
        private GroupBox emiGroupBox;
        private Button exitBtn;
        private Button deleteItemBtn;
        private Button clearBtn;
        private TextBox interestRateTxtBox;
        private TextBox loanMonthsTxtBox;
        private Button clearCLBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}