using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace calcloan
{
    public partial class frmCalcLoan : Form
    {
        private string spacestr = "     ";
        ToolTip toolTip = null;

        public frmCalcLoan()
        {
            InitializeComponent();

            // 設置Tag屬性來選擇符號及預設值
            this.txtTotalHousePrice.Tag = "NT$";  // 用來加 NT$
            this.txtPaymentAmt.Tag = "NT$";  // 用來加 NT$
            this.txtDownPayment.Tag = "%";  // 用來加 %
            //this.txtTotalHousePrice.Text = string.Format("{0:C0}", 0);
            //this.txtPaymentAmt.Text = string.Format("{0:C0}", 0);
            //this.txtDownPayment.Text = "20"; // 20%頭期款
            this.txtAnnualRate.Tag = "%";  // 用來加 %
            //this.txtAnnualRate.Text = "2"; // 2%年利率
            this.txtLoanTerm.Tag = " ";
            //this.txtLoanTerm.Text = "30"; //30年貸款期限

            comboBoxDownType.Items.Add("百分比");
            comboBoxDownType.Items.Add("金額");
            //comboBoxDownType.SelectedIndex = 0; // 預設百分比
            //txtDownPayment.Visible = true;
            //txtPaymentAmt.Visible = false;


            // 設置 ComboBox 的選項
            comboBoxGracePeriod.Items.Add("無寬限期");
            comboBoxGracePeriod.Items.Add("12個月");
            comboBoxGracePeriod.Items.Add("24個月");
            comboBoxGracePeriod.Items.Add("36個月");
            comboBoxGracePeriod.Items.Add("48個月");
            comboBoxGracePeriod.Items.Add("60個月");

            //// 預設 "無寬限期"
            //comboBoxGracePeriod.SelectedIndex = 0;
            reset();
            initToolTip();
        }

        private void initToolTip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txtTotalHousePrice, "請輸入房屋總價金額，範圍為0~10,000萬");
            toolTip.SetToolTip(txtDownPayment, "請輸入自備款比率，範圍為0%~90%");
            toolTip.SetToolTip(txtPaymentAmt, "請輸入自備款金額，需小於房屋總價");
            toolTip.SetToolTip(txtAnnualRate, "請輸入貸款年利率，範圍為0%~10%");
            toolTip.SetToolTip(txtLoanTerm, "請輸入貸款年限，範圍為1~30年");
        }

        private void reset()
        {
            // 預設 "無寬限期"
            comboBoxGracePeriod.SelectedIndex = 0;
            this.txtTotalHousePrice.Text = string.Format("{0:C0}", 0);
            this.txtPaymentAmt.Text = string.Format("{0:C0}", 0);
            this.txtDownPayment.Text = "20"; // 20%頭期款
            this.txtAnnualRate.Text = "2"; // 2%年利率
            this.txtLoanTerm.Text = "30"; //30年貸款期限

            comboBoxDownType.SelectedIndex = 0; // 預設百分比
            txtDownPayment.Visible = true;
            txtPaymentAmt.Visible = false;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("是否要關閉", "關閉視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                reset();
                e.Cancel = false;
            }
        }

        private void frmCalcLoan_Load(object sender, EventArgs e)
        {
            // 註冊 FormClosing 事件處理程序
            //this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            // 需要格式化的 TextBox 加入事件處理
            this.txtTotalHousePrice.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
            this.txtTotalHousePrice.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtTotalHousePrice.Validating += new CancelEventHandler(TextBox_Validating);
            this.txtTotalHousePrice.Leave += new EventHandler(TextBox_Leave);

            //預設為百分比事件處理
            this.txtDownPayment.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
            this.txtDownPayment.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtDownPayment.Validating += new CancelEventHandler(TextBox_Validating);
            this.txtDownPayment.Leave += new EventHandler(TextBox_Leave);

            //this.txtPaymentAmt.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
            //this.txtPaymentAmt.TextChanged += new EventHandler(TextBox_TextChanged);
            //this.txtPaymentAmt.Validating += new CancelEventHandler(TextBox_Validating);
            //this.txtPaymentAmt.Leave += new EventHandler(TextBox_Leave);

            this.txtAnnualRate.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
            this.txtAnnualRate.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtAnnualRate.Validating += new CancelEventHandler(TextBox_Validating);
            this.txtAnnualRate.Leave += new EventHandler(TextBox_Leave);

            this.txtLoanTerm.KeyPress += new KeyPressEventHandler(Integer_KeyPress);
            this.txtLoanTerm.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtLoanTerm.Validating += new CancelEventHandler(TextBox_Validating);
            this.txtLoanTerm.Leave += new EventHandler(TextBox_Leave);

            this.comboBoxDownType.SelectedIndexChanged += new EventHandler(comboBoxDownType_SelectedIndexChanged);

        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;
            msgLabel.Text = "";
            msgLabel.Visible = false;
            // 只允許數字、小數點和控制鍵（倒退鍵等）
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                msgLabel.Text = spacestr + "只能輸入數字或小數點";
                msgLabel.Visible = true;
                e.Handled = true;  // 阻止輸入非數字或非小數點
            }

            // 允許一個小數點，防止多個小數點
            if (e.KeyChar == '.' && currentText.Contains("."))
            {
                msgLabel.Text = spacestr + "只能輸入一個小數點";
                msgLabel.Visible = true;
                e.Handled = true;  // 阻止第二個小數點的輸入
            }
            
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;
            msgLabel.Text = "";
            msgLabel.Visible = false;
            // 只允許數字、小數點和控制鍵（倒退鍵等）
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {

                msgLabel.Text = spacestr + "只能輸入數字";
                msgLabel.Visible = true;
                e.Handled = true;  // 阻止輸入非數字
            }

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;
			string symbolTag;
			if (textBox.Tag != null)
			{
				symbolTag = textBox.Tag.ToString();
			}
			else
			{
				symbolTag = "";
			}
            // 根據 Tag 移除對應符號和逗號取得純數值
            string dataValue = currentText.Replace(symbolTag, "").Replace(",", "").Trim();
            
            // 如果為空或只是小數點，不進行格式化
            if (string.IsNullOrEmpty(dataValue) || dataValue == ".")
                return;

            // 如果以小數點結尾或者小數點後的最後一位為0時，不進行格式化
            //if (dataValue.EndsWith(".") || (dataValue.Contains(".") && dataValue.EndsWith("0")))
            if (dataValue.EndsWith("."))
                return;

            // 將字串轉換為數值
            if (double.TryParse(dataValue, out double value))
            {

                string formattedText = "";

                //判斷是否有小數部分: 有小數依小數位數顯示
                int decimalIndex = 0;  // 小數位數
                int idx = dataValue.IndexOf(".");

                if (idx == -1)
                    decimalIndex = 0;  // 沒有小數
                else
                {
                    decimalIndex = dataValue.Substring(idx + 1).Length;  // 小數位數
                }

                string controlName = textBox.Name;

                if (controlName == "txtTotalHousePrice")
                {

                    if (value < 0 || value > 100000000)
                    {
                        msgLabel.Text = spacestr + "房屋總價 0~10,000萬";
                        msgLabel.Visible = true;
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }

                    if (comboBoxDownType.SelectedIndex == 1) // 選擇金額
                    {
                        //自備款金額fundsprice. fundsprice需小於房屋總價value
                        string funds = txtPaymentAmt.Text.Replace("NT$", "").Replace(",", "").Trim();
                        double fundsprice = Convert.ToDouble(funds);
                        if (fundsprice < 0 || fundsprice > value)
                        {
                            msgLabel.Text = spacestr + "自備款金額需小於房屋總價";
                            msgLabel.Visible = true;
                        }
                        else
                        {
                            msgLabel.Text = "";
                            msgLabel.Visible = false;
                        }
                    }

                    formattedText = string.Format("{0:C" + decimalIndex.ToString() + "}", value);
                }
                else if (controlName == "txtDownPayment")
                {
                    //自備款比率
                    if (value < 0 || value > 90)
                    {
                        msgLabel.Text = spacestr + "自備款比率範圍: 0%~90%";
                        msgLabel.Visible = true;
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    // 百分比格式
                    //string formatString = (value % 1 == 0) ? "{0:P0}" : "{0:P2}";
                    formattedText = string.Format("{0:P" + decimalIndex.ToString() + "}", value / 100);
                }
                else if (controlName == "txtPaymentAmt")
                {
                    //房屋總價金額
                    string housePrice = txtTotalHousePrice.Text.Replace("NT$", "").Replace(",", "").Trim();
                    double totalprice = Convert.ToDouble(housePrice);
                    //自備款金額
                    if (value < 0 || value > totalprice)
                    {

                        msgLabel.Text = spacestr + "自備款金額需小於房屋總價";
                        msgLabel.Visible = true;
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    formattedText = string.Format("{0:C" + decimalIndex.ToString() + "}", value);
                }
                else if (controlName == "txtAnnualRate")
                {
                    if (value < 0 || value > 10)
                    {
                        msgLabel.Text = spacestr + "貸款利率範圍: 0%~10%";
                        msgLabel.Visible = true;

                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    // 百分比格式
                    //string formatString = (value % 1 == 0) ? "{0:P0}" : "{0:P2}";
                    formattedText = string.Format("{0:P" + decimalIndex.ToString() + "}", value / 100);
                }
                else
				{

                    // 判斷數字是否為1~30
                    if (value < 1 || value > 30)
                    {
                        msgLabel.Text = spacestr + "貸款年限必須在1~30年之間";
                        msgLabel.Visible = true;
                        return;
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    formattedText = string.Format("{0:N0}", value);
                }

                textBox.Text = formattedText;
                // 游標移到末尾
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox_Validating(sender, e, false);
        }

        private void TextBox_Validating(object sender, CancelEventArgs e, bool chk)
        {

            double val = 0;
            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;
            string symbolTag;
            string formattedText = "";
            string formattedString = "";
            if (textBox.Tag != null)
            {
                symbolTag = textBox.Tag.ToString();
            }
            else
            {
                symbolTag = "";
            }
            // 根據 Tag 移除對應符號和逗號取得純數值
            string dataValue = currentText.Replace(symbolTag, "").Replace(",", "").Trim();
            //if (chk && (symbolTag.Contains("%") || symbolTag.Contains("NT$")))
            if (chk)
            {
                if (dataValue.Contains(".") && dataValue.EndsWith("0"))
                {
                    dataValue = dataValue.TrimEnd('0');//如果是離開事件，去掉末尾的0
                }
            }

            if (double.TryParse(dataValue, out val))
            {
                //判斷是否有小數部分: 有小數依小數位數顯示
                int decimalIndex = 0;  // 小數位數
                int idx = dataValue.IndexOf(".");

                if (idx == -1)
                    decimalIndex = 0;  // 沒有小數
                else
                {
                    decimalIndex = dataValue.Substring(idx + 1).Length;  // 小數位數
                }

                if (textBox.Name == "txtTotalHousePrice")
                {
                    if (val < 0 || val > 100000000)
                    {
                        msgLabel.Text = spacestr + "房屋總價 0~10,000萬";
                        msgLabel.Visible = true;
                        e.Cancel = true;// 阻止焦點離開
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }

                    if (comboBoxDownType.SelectedIndex == 1) // 選擇金額
                    {
                        //自備款金額fundsprice. fundsprice需小於房屋總價 val
                        string funds = txtPaymentAmt.Text.Replace("NT$", "").Replace(",", "").Trim();
                        double fundsprice = Convert.ToDouble(funds);
                        if (fundsprice < 0 || fundsprice > val)
                        {
                            msgLabel.Text = spacestr + "自備款金額需小於房屋總價";
                            msgLabel.Visible = true;
                            e.Cancel = true;// 阻止焦點離開
                        }
                        else
                        {
                            msgLabel.Text = "";
                            msgLabel.Visible = false;
                        }
                    }

                    formattedString = "{0:C" + decimalIndex.ToString() + "}";
                    formattedText = string.Format(formattedString, val);
                }
                else if (textBox.Name == "txtDownPayment")
                {
                    //自備款比率
                    if (val < 0 || val > 90)
                    {
                        msgLabel.Text = spacestr + "自備款比率範圍: 0%~90%";
                        msgLabel.Visible = true;
                        e.Cancel = true;// 阻止焦點離開
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    formattedString = "{0:P" + decimalIndex.ToString() + "}";
                    formattedText = string.Format(formattedString, val / 100);
                }
                else if (textBox.Name == "txtPaymentAmt")
                {
                    //房屋總價金額
                    string housePrice = txtTotalHousePrice.Text.Replace("NT$", "").Replace(",", "").Trim();
                    double totalprice = Convert.ToDouble(housePrice);
                    //自備款金額
                    if (val < 0 || val > totalprice)
                    {
                        msgLabel.Text = spacestr + "自備款金額需小於房屋總價";
                        msgLabel.Visible = true;
                        e.Cancel = true;// 阻止焦點離開
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    formattedString = "{0:C" + decimalIndex.ToString() + "}";
                    formattedText = string.Format(formattedString, val);
                }
                else if (textBox.Name == "txtAnnualRate")
                {
                    if (val < 0 || val > 10)
                    {
                        msgLabel.Text = spacestr + "貸款利率範圍: 0%~10%";
                        msgLabel.Visible = true;
                        e.Cancel = true;// 阻止焦點離開
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    formattedString = "{0:P" + decimalIndex.ToString() + "}";
                    formattedText = string.Format(formattedString, val / 100);
                }
                else 
                {
                    if (val < 0 || val > 30)
                    {
                        msgLabel.Text = spacestr + "貸款年限必須在1~30年之間";
                        msgLabel.Visible = true;
                        e.Cancel = true;// 阻止焦點離開
                    }
                    else
                    {
                        msgLabel.Text = "";
                        msgLabel.Visible = false;
                    }
                    formattedString = "{0:N0}";
                    formattedText = string.Format(formattedString, val);
                }
                
                textBox.Text = formattedText;
                // 游標移到末尾
                textBox.SelectionStart = textBox.Text.Length;
            }
        }


        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox_Validating(sender, new CancelEventArgs(), true);
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int downType = comboBoxDownType.SelectedIndex;
            btnCalcu.Enabled = false;
            msgLabel.Text = "計算中...";
            msgLabel.Visible = true;
            txtTotalHousePrice.Enabled = false;
            comboBoxDownType.Enabled = false;

            if (downType == 0) // 選擇百分比
            {
                txtDownPayment.Enabled = false;    
            }
            else if (downType == 1) // 選擇金額
            {
                txtPaymentAmt.Enabled = false;
            }
            txtAnnualRate.Enabled = false;
            txtLoanTerm.Enabled = false;
            txtAnnualRate.Enabled = false;
            comboBoxGracePeriod.Enabled = false;



            // 取得輸入值
            //房屋總價金額
            string housePrice = txtTotalHousePrice.Text.Replace("NT$", "").Replace(",", "").Trim();
            decimal totalHousePrice = Convert.ToDecimal(housePrice);

            decimal downPaymentAmt = 0;
            if (downType == 0) // 選擇百分比
            {
                string downPaymentPercentStr = txtDownPayment.Text.Replace("%", "").Replace(",", "").Trim();
                downPaymentAmt = decimal.Parse(downPaymentPercentStr) / 100 * totalHousePrice;
            }
            else if (downType == 1) // 選擇金額
            {
                string downPaymentAmtStr = txtPaymentAmt.Text.Replace("NT$", "").Replace(",", "").Trim();
                downPaymentAmt = decimal.Parse(downPaymentAmtStr);
            }

            //貸款總金額 = 房屋總價金額 - 自備款金額
            decimal loanAmount = totalHousePrice - downPaymentAmt; 

            //貸款利率(年利率->月利率)
            string annualInterestRateStr = txtAnnualRate.Text.Replace("%", "").Replace(",", "").Trim();
            decimal annualInterestRate = decimal.Parse(annualInterestRateStr) / 100;            

            // 計算月利率 = 年利率 / 12
            decimal monthInterestRate = annualInterestRate / 12;

            // 貸款年限(年->月)
            string loanTermStr = txtLoanTerm.Text.Replace(",", "").Trim();
            int loanTerm = int.Parse(loanTermStr);
            int loanMonths = loanTerm * 12; // 貸款月數 = 貸款年限 * 12

            // 計算寬限期每月利息（只付利息）
            int graceMonths = comboBoxGracePeriod.SelectedIndex * 12; //取得寬限期:無寬限期為0，12個月為1年，24個月為2年，以此類推
            decimal monthInterestPayment = loanAmount * monthInterestRate;

            // 計算寬限期結束後剩下的本金，再重新計算每月還款的金額（本金+利息）
            int remainingMonths = loanMonths - graceMonths; // 剩下的貸款月數

            // 計算每月應繳金額 ＝每月應還本金金額 + 每月應付利息金額
            //                  ＝ 貸款本金 * 每月應還本息金額之平均攤還率
            decimal monthlyPayment = 0;
            if (remainingMonths > 0)
            {
                monthlyPayment = loanAmount * (monthInterestRate * (decimal)Math.Pow((double)(1 + monthInterestRate), remainingMonths)) / ((decimal)Math.Pow((double)(1 + monthInterestRate), remainingMonths) - 1);
            }

            // 計算首期利息與本金
            decimal firstInterest = 0;
            decimal firstAmount = 0;

            if (graceMonths > 0)
            {
                // 寬限期內，只支付利息，不還本金
                firstInterest = monthInterestPayment; // 首期利息為寬限期每月利息
                firstAmount = 0; // 首期本金為0
            }
            else
            {
                // 無寬限期，正常計算首期利息、本金
                firstInterest = loanAmount * monthInterestRate;//每月應付利息金額＝本金餘額 * 月利率
                firstAmount = monthlyPayment - firstInterest;  //每月應還本金金額＝平均每月應還本息金額 - 每月應付利息金額

            }

            // 計算 總利息支出 = 寬限期每月利息 * 寬限期月數 + 寬限期結束後每月應繳金額 * 剩餘月數 - 貸款總金額
            decimal totalInterestLoan = 0;
            if (remainingMonths > 0)
            {
                totalInterestLoan = monthlyPayment * remainingMonths - loanAmount;
            }
            // 寬限期只付利息，不付本金
            decimal totalInterest = monthInterestPayment * graceMonths + totalInterestLoan;

            // 計算 總還款金額 = 總利息支出 + 貸款總金額
            decimal totalPayment = totalInterest + loanAmount;

            //// 顯示計算結果
            // 貸款總金額
            //labelLoanAmt.Text = string.Format("{0:C2}", loanAmount);
            labelLoanAmt.Text = $"{loanAmount:C2}";
            // 每月應繳金額
            labelMonthAmt.Text = string.Format("{0:C2}", monthlyPayment);
            // 首期利息 
            label1FirstInterest.Text = string.Format("{0:C2}", firstInterest);
            // 首期本金 
            labelFirstAmt.Text = string.Format("{0:C2}", firstAmount);
            // 總利息支出
            labelTotalInterest.Text = string.Format("{0:C2}", totalInterest);
            // 總還款金額
            labelTotalPayment.Text = string.Format("{0:C2}", totalPayment);

            msgLabel.Text = "";
            msgLabel.Visible = false;

            txtTotalHousePrice.Enabled = true;
            comboBoxDownType.Enabled = true;

            if (downType == 0) // 選擇百分比
            {
                txtDownPayment.Enabled = true;
            }
            else if (downType == 1) // 選擇金額
            {
                txtPaymentAmt.Enabled = true;
            }
            txtAnnualRate.Enabled = true;
            txtLoanTerm.Enabled = true;
            txtAnnualRate.Enabled = true;
            comboBoxGracePeriod.Enabled = true;
            btnCalcu.Enabled = true;
        }


        private void comboBoxDownType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 根據選擇的項目來顯示或隱藏對應的輸入框
            if (comboBoxDownType.SelectedIndex == 0)  // 百分比
            {
                txtDownPayment.Visible = true;
                txtPaymentAmt.Visible = false;
                RegisterPercentage();
                txtDownPayment.Focus(); //觸發Validating
            }
            else if (comboBoxDownType.SelectedIndex == 1)  // 金額
            {
                txtDownPayment.Visible = false;
                txtPaymentAmt.Visible = true;
                RegisterAmount();
                txtPaymentAmt.Focus(); //觸發Validating
            }
        }

        private void RegisterPercentage()
        {
            // 移除金額輸入框的事件處理
            this.txtPaymentAmt.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            this.txtPaymentAmt.TextChanged -= new EventHandler(TextBox_TextChanged);
            this.txtPaymentAmt.Validating -= new CancelEventHandler(TextBox_Validating);
            this.txtPaymentAmt.Leave -= new EventHandler(TextBox_Leave);

            // 註冊百分比輸入框的事件處理
            this.txtDownPayment.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
            this.txtDownPayment.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtDownPayment.Validating += new CancelEventHandler(TextBox_Validating);
            this.txtDownPayment.Leave += new EventHandler(TextBox_Leave);
        }

        private void RegisterAmount()
        {
            // 移除百分比輸入框的事件處理
            this.txtDownPayment.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            this.txtDownPayment.TextChanged -= new EventHandler(TextBox_TextChanged);
            this.txtDownPayment.Validating -= new CancelEventHandler(TextBox_Validating);
            this.txtDownPayment.Leave -= new EventHandler(TextBox_Leave);

            // 註冊金額輸入框的事件處理
            this.txtPaymentAmt.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
            this.txtPaymentAmt.TextChanged += new EventHandler(TextBox_TextChanged);
            this.txtPaymentAmt.Validating += new CancelEventHandler(TextBox_Validating);
            this.txtPaymentAmt.Leave += new EventHandler(TextBox_Leave);
        }
    }
}
