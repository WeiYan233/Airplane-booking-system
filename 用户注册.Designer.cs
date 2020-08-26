namespace 航班订票系统
{
    partial class ResForm
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
            this.res_name_box = new System.Windows.Forms.TextBox();
            this.res_pwd_box = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("站酷酷黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "新用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("站酷酷黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(110, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // res_name_box
            // 
            this.res_name_box.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_name_box.Location = new System.Drawing.Point(212, 192);
            this.res_name_box.Margin = new System.Windows.Forms.Padding(4);
            this.res_name_box.Multiline = true;
            this.res_name_box.Name = "res_name_box";
            this.res_name_box.Size = new System.Drawing.Size(325, 35);
            this.res_name_box.TabIndex = 2;
            // 
            // res_pwd_box
            // 
            this.res_pwd_box.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_pwd_box.Location = new System.Drawing.Point(212, 271);
            this.res_pwd_box.Margin = new System.Windows.Forms.Padding(4);
            this.res_pwd_box.Multiline = true;
            this.res_pwd_box.Name = "res_pwd_box";
            this.res_pwd_box.Size = new System.Drawing.Size(325, 32);
            this.res_pwd_box.TabIndex = 3;
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.Font = new System.Drawing.Font("站酷酷黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit_button.Location = new System.Drawing.Point(146, 348);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(113, 49);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "提交";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("站酷酷黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(244, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 82);
            this.label3.TabIndex = 5;
            this.label3.Text = "注册";
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("站酷酷黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_button.Location = new System.Drawing.Point(424, 348);
            this.return_button.Margin = new System.Windows.Forms.Padding(4);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(113, 49);
            this.return_button.TabIndex = 6;
            this.return_button.Text = "返回";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // ResForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 459);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.res_pwd_box);
            this.Controls.Add(this.res_name_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResForm";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.ResForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox res_name_box;
        private System.Windows.Forms.TextBox res_pwd_box;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button return_button;
    }
}