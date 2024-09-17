namespace Calculator
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator Application In C#";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(521, 108);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(194, 34);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(521, 169);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(194, 34);
            this.txt2.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(96, 232);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 39);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "ADDITION";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(700, 232);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(149, 39);
            this.btndiv.TabIndex = 4;
            this.btndiv.Text = "DIVISION";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(461, 232);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(233, 39);
            this.btnmul.TabIndex = 5;
            this.btnmul.Text = "MULTIPLICATION";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(254, 232);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(201, 39);
            this.btnsub.TabIndex = 6;
            this.btnsub.Text = "SUBTRACTION";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(213, 300);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 37);
            this.lbl_result.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter First Num:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Second Num:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = ";";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

