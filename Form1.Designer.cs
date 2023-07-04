namespace Calc {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.txtRealPart1 = new System.Windows.Forms.TextBox();
            this.txtImaginaryPart1 = new System.Windows.Forms.TextBox();
            this.txtRealPart2 = new System.Windows.Forms.TextBox();
            this.txtImaginaryPart2 = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDiv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRealPart1
            // 
            this.txtRealPart1.Location = new System.Drawing.Point(78, 59);
            this.txtRealPart1.Name = "txtRealPart1";
            this.txtRealPart1.Size = new System.Drawing.Size(100, 20);
            this.txtRealPart1.TabIndex = 0;
            // 
            // txtImaginaryPart1
            // 
            this.txtImaginaryPart1.Location = new System.Drawing.Point(220, 59);
            this.txtImaginaryPart1.Name = "txtImaginaryPart1";
            this.txtImaginaryPart1.Size = new System.Drawing.Size(100, 20);
            this.txtImaginaryPart1.TabIndex = 1;
            // 
            // txtRealPart2
            // 
            this.txtRealPart2.Location = new System.Drawing.Point(78, 142);
            this.txtRealPart2.Name = "txtRealPart2";
            this.txtRealPart2.Size = new System.Drawing.Size(100, 20);
            this.txtRealPart2.TabIndex = 2;
            // 
            // txtImaginaryPart2
            // 
            this.txtImaginaryPart2.Location = new System.Drawing.Point(220, 141);
            this.txtImaginaryPart2.Name = "txtImaginaryPart2";
            this.txtImaginaryPart2.Size = new System.Drawing.Size(100, 20);
            this.txtImaginaryPart2.TabIndex = 3;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(75, 269);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum";
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Location = new System.Drawing.Point(75, 309);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(20, 13);
            this.lblDifference.TabIndex = 5;
            this.lblDifference.Text = "Dif";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(75, 350);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(29, 13);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Prod";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 179);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 32);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Посчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Location = new System.Drawing.Point(78, 389);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(23, 13);
            this.lblDiv.TabIndex = 8;
            this.lblDiv.Text = "Div";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtImaginaryPart2);
            this.Controls.Add(this.txtRealPart2);
            this.Controls.Add(this.txtImaginaryPart1);
            this.Controls.Add(this.txtRealPart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRealPart1;
        private System.Windows.Forms.TextBox txtImaginaryPart1;
        private System.Windows.Forms.TextBox txtRealPart2;
        private System.Windows.Forms.TextBox txtImaginaryPart2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDiv;
    }
}

