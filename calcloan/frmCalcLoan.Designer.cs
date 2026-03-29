namespace calcloan
{
    partial class frmCalcLoan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtPaymentAmt = new System.Windows.Forms.TextBox();
            this.comboBoxDownType = new System.Windows.Forms.ComboBox();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.comboBoxGracePeriod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnnualRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalHousePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.labelFirstAmt = new System.Windows.Forms.Label();
            this.label1FirstInterest = new System.Windows.Forms.Label();
            this.labelMonthAmt = new System.Windows.Forms.Label();
            this.labelTotalPayment = new System.Windows.Forms.Label();
            this.labelTotalInterest = new System.Windows.Forms.Label();
            this.labelLoanAmt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.SystemColors.Control;
            this.grpInput.Controls.Add(this.txtPaymentAmt);
            this.grpInput.Controls.Add(this.comboBoxDownType);
            this.grpInput.Controls.Add(this.btnCalcu);
            this.grpInput.Controls.Add(this.msgLabel);
            this.grpInput.Controls.Add(this.comboBoxGracePeriod);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.txtLoanTerm);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.txtAnnualRate);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.txtDownPayment);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.txtTotalHousePrice);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(25, 23);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(712, 349);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = " 輸入 ";
            this.grpInput.UseCompatibleTextRendering = true;
            // 
            // txtPaymentAmt
            // 
            this.txtPaymentAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentAmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmt.Location = new System.Drawing.Point(515, 100);
            this.txtPaymentAmt.Name = "txtPaymentAmt";
            this.txtPaymentAmt.Size = new System.Drawing.Size(169, 35);
            this.txtPaymentAmt.TabIndex = 4;
            this.txtPaymentAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxDownType
            // 
            this.comboBoxDownType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDownType.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDownType.FormattingEnabled = true;
            this.comboBoxDownType.Location = new System.Drawing.Point(217, 100);
            this.comboBoxDownType.Name = "comboBoxDownType";
            this.comboBoxDownType.Size = new System.Drawing.Size(277, 33);
            this.comboBoxDownType.TabIndex = 3;
            // 
            // btnCalcu
            // 
            this.btnCalcu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcu.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalcu.Location = new System.Drawing.Point(517, 168);
            this.btnCalcu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(171, 109);
            this.btnCalcu.TabIndex = 12;
            this.btnCalcu.Text = "試算";
            this.btnCalcu.UseCompatibleTextRendering = true;
            this.btnCalcu.UseVisualStyleBackColor = false;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msgLabel.ForeColor = System.Drawing.Color.Red;
            this.msgLabel.Image = global::calcloan.Properties.Resources.StatusInvalid_18_18;
            this.msgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgLabel.Location = new System.Drawing.Point(158, 300);
            this.msgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 30);
            this.msgLabel.TabIndex = 10;
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgLabel.UseCompatibleTextRendering = true;
            this.msgLabel.Visible = false;
            // 
            // comboBoxGracePeriod
            // 
            this.comboBoxGracePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGracePeriod.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGracePeriod.FormattingEnabled = true;
            this.comboBoxGracePeriod.Location = new System.Drawing.Point(217, 246);
            this.comboBoxGracePeriod.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGracePeriod.Name = "comboBoxGracePeriod";
            this.comboBoxGracePeriod.Size = new System.Drawing.Size(278, 33);
            this.comboBoxGracePeriod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(30, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "寬限期(選填)：";
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanTerm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanTerm.Location = new System.Drawing.Point(217, 194);
            this.txtLoanTerm.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(278, 35);
            this.txtLoanTerm.TabIndex = 9;
            this.txtLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(30, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "貸款年限(年)：";
            // 
            // txtAnnualRate
            // 
            this.txtAnnualRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnnualRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualRate.Location = new System.Drawing.Point(216, 144);
            this.txtAnnualRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnualRate.Name = "txtAnnualRate";
            this.txtAnnualRate.Size = new System.Drawing.Size(278, 35);
            this.txtAnnualRate.TabIndex = 7;
            this.txtAnnualRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "貸款年利率(%)：";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(515, 100);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(97, 35);
            this.txtDownPayment.TabIndex = 5;
            this.txtDownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "自備款方式：";
            // 
            // txtTotalHousePrice
            // 
            this.txtTotalHousePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalHousePrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHousePrice.Location = new System.Drawing.Point(216, 48);
            this.txtTotalHousePrice.Name = "txtTotalHousePrice";
            this.txtTotalHousePrice.Size = new System.Drawing.Size(278, 35);
            this.txtTotalHousePrice.TabIndex = 1;
            this.txtTotalHousePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalHousePrice.TextChanged += new System.EventHandler(this.frmCalcLoan_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋總價(NT$)：";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.labelFirstAmt);
            this.grpOutput.Controls.Add(this.label1FirstInterest);
            this.grpOutput.Controls.Add(this.labelMonthAmt);
            this.grpOutput.Controls.Add(this.labelTotalPayment);
            this.grpOutput.Controls.Add(this.labelTotalInterest);
            this.grpOutput.Controls.Add(this.labelLoanAmt);
            this.grpOutput.Controls.Add(this.label11);
            this.grpOutput.Controls.Add(this.label10);
            this.grpOutput.Controls.Add(this.label9);
            this.grpOutput.Controls.Add(this.label8);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.label6);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(24, 378);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(713, 182);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = " 計算結果 ";
            // 
            // labelFirstAmt
            // 
            this.labelFirstAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirstAmt.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFirstAmt.Location = new System.Drawing.Point(490, 136);
            this.labelFirstAmt.Name = "labelFirstAmt";
            this.labelFirstAmt.Size = new System.Drawing.Size(217, 27);
            this.labelFirstAmt.TabIndex = 12;
            this.labelFirstAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1FirstInterest
            // 
            this.label1FirstInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1FirstInterest.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1FirstInterest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1FirstInterest.Location = new System.Drawing.Point(490, 93);
            this.label1FirstInterest.Name = "label1FirstInterest";
            this.label1FirstInterest.Size = new System.Drawing.Size(217, 27);
            this.label1FirstInterest.TabIndex = 11;
            this.label1FirstInterest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMonthAmt
            // 
            this.labelMonthAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMonthAmt.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMonthAmt.Location = new System.Drawing.Point(537, 49);
            this.labelMonthAmt.Name = "labelMonthAmt";
            this.labelMonthAmt.Size = new System.Drawing.Size(170, 27);
            this.labelMonthAmt.TabIndex = 10;
            this.labelMonthAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalPayment
            // 
            this.labelTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPayment.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalPayment.Location = new System.Drawing.Point(168, 136);
            this.labelTotalPayment.Name = "labelTotalPayment";
            this.labelTotalPayment.Size = new System.Drawing.Size(189, 27);
            this.labelTotalPayment.TabIndex = 9;
            this.labelTotalPayment.Text = " ";
            this.labelTotalPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalInterest
            // 
            this.labelTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalInterest.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalInterest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalInterest.Location = new System.Drawing.Point(168, 92);
            this.labelTotalInterest.Name = "labelTotalInterest";
            this.labelTotalInterest.Size = new System.Drawing.Size(189, 27);
            this.labelTotalInterest.TabIndex = 8;
            this.labelTotalInterest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLoanAmt
            // 
            this.labelLoanAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoanAmt.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoanAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLoanAmt.Location = new System.Drawing.Point(168, 49);
            this.labelLoanAmt.Name = "labelLoanAmt";
            this.labelLoanAmt.Size = new System.Drawing.Size(189, 27);
            this.labelLoanAmt.TabIndex = 7;
            this.labelLoanAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(379, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "每月應繳金額：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(379, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "首期本金：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(379, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "首期利息：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(31, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "總還款金額：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(31, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "總利息支出：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(31, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "貸款總金額：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmCalcLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(749, 566);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "frmCalcLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmCalcLoan_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalHousePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtAnnualRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGracePeriod;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.ComboBox comboBoxDownType;
        private System.Windows.Forms.TextBox txtPaymentAmt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLoanAmt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelFirstAmt;
        private System.Windows.Forms.Label label1FirstInterest;
        private System.Windows.Forms.Label labelMonthAmt;
        private System.Windows.Forms.Label labelTotalPayment;
        private System.Windows.Forms.Label labelTotalInterest;
    }
}

