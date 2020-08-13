namespace WinCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Button();
            this.lblMul = new System.Windows.Forms.Button();
            this.lblDiv = new System.Windows.Forms.Button();
            this.lblModulus = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(220, 114);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(427, 113);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(205, 234);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(75, 23);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Add";
            this.lblAdd.UseVisualStyleBackColor = true;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblSub
            // 
            this.lblSub.Location = new System.Drawing.Point(317, 234);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(75, 23);
            this.lblSub.TabIndex = 5;
            this.lblSub.Text = "Subtract";
            this.lblSub.UseVisualStyleBackColor = true;
            this.lblSub.Click += new System.EventHandler(this.lblSub_Click);
            // 
            // lblMul
            // 
            this.lblMul.Location = new System.Drawing.Point(427, 234);
            this.lblMul.Name = "lblMul";
            this.lblMul.Size = new System.Drawing.Size(75, 23);
            this.lblMul.TabIndex = 6;
            this.lblMul.Text = "Multiply";
            this.lblMul.UseVisualStyleBackColor = true;
            this.lblMul.Click += new System.EventHandler(this.lblMul_Click);
            // 
            // lblDiv
            // 
            this.lblDiv.Location = new System.Drawing.Point(541, 234);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(75, 23);
            this.lblDiv.TabIndex = 7;
            this.lblDiv.Text = "Division";
            this.lblDiv.UseVisualStyleBackColor = true;
            this.lblDiv.Click += new System.EventHandler(this.lblDiv_Click);
            // 
            // lblModulus
            // 
            this.lblModulus.Location = new System.Drawing.Point(648, 234);
            this.lblModulus.Name = "lblModulus";
            this.lblModulus.Size = new System.Drawing.Size(75, 23);
            this.lblModulus.TabIndex = 8;
            this.lblModulus.Text = "Modulus";
            this.lblModulus.UseVisualStyleBackColor = true;
            this.lblModulus.Click += new System.EventHandler(this.lblModulus_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(395, 306);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblModulus);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.lblMul);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button lblAdd;
        private System.Windows.Forms.Button lblSub;
        private System.Windows.Forms.Button lblMul;
        private System.Windows.Forms.Button lblDiv;
        private System.Windows.Forms.Button lblModulus;
        private System.Windows.Forms.Label lblResult;
    }
}

