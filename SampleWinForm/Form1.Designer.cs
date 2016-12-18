namespace SampleWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumber1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNumber1.Location = new System.Drawing.Point(23, 20);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumber1.MaxLength = 4;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(131, 25);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtNumber2
            // 
            this.txtNumber2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNumber2.Location = new System.Drawing.Point(243, 20);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumber2.MaxLength = 4;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(131, 25);
            this.txtNumber2.TabIndex = 1;
            this.txtNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(430, 18);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(197, 25);
            this.txtAnswer.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "＋",
            "－",
            "×",
            "÷"});
            this.cmbOperator.Location = new System.Drawing.Point(167, 18);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(64, 26);
            this.cmbOperator.TabIndex = 3;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(387, 15);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(33, 34);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 66);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Calculator１";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.ComboBox cmbOperator;
    }
}

