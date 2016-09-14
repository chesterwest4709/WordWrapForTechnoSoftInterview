namespace TechnoSoftCW
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.nLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpectedResult = new System.Windows.Forms.TextBox();
            this.btnNoWordSplit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(209, 79);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(13, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(560, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "The quick brown fox jumped over the lazy dog.";
            // 
            // nLength
            // 
            this.nLength.Location = new System.Drawing.Point(143, 80);
            this.nLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nLength.Name = "nLength";
            this.nLength.Size = new System.Drawing.Size(60, 20);
            this.nLength.TabIndex = 2;
            this.nLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input String";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(13, 120);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(560, 165);
            this.txtResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // txtExpectedResult
            // 
            this.txtExpectedResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpectedResult.Location = new System.Drawing.Point(12, 314);
            this.txtExpectedResult.Multiline = true;
            this.txtExpectedResult.Name = "txtExpectedResult";
            this.txtExpectedResult.Size = new System.Drawing.Size(560, 165);
            this.txtExpectedResult.TabIndex = 7;
            this.txtExpectedResult.Text = "The quick brown\\nfox jumped over\\nthe lazy dog.";
            // 
            // btnNoWordSplit
            // 
            this.btnNoWordSplit.AutoSize = true;
            this.btnNoWordSplit.Location = new System.Drawing.Point(303, 79);
            this.btnNoWordSplit.Name = "btnNoWordSplit";
            this.btnNoWordSplit.Size = new System.Drawing.Size(124, 23);
            this.btnNoWordSplit.TabIndex = 8;
            this.btnNoWordSplit.Text = "Execute (no word split)";
            this.btnNoWordSplit.UseVisualStyleBackColor = true;
            this.btnNoWordSplit.Click += new System.EventHandler(this.btnNoWordSplit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expected Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNoWordSplit);
            this.Controls.Add(this.txtExpectedResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nLength);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnExecute);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Test WordWrap Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.NumericUpDown nLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpectedResult;
        private System.Windows.Forms.Button btnNoWordSplit;
        private System.Windows.Forms.Label label4;
    }
}

