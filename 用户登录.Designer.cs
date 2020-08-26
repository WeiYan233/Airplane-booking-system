namespace 航班订票系统
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_type_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_name_box = new System.Windows.Forms.TextBox();
            this.login_pwd_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.res_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_type_box
            // 
            this.login_type_box.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_type_box.FormattingEnabled = true;
            this.login_type_box.Items.AddRange(new object[] {
            "普通用户",
            "管理员"});
            this.login_type_box.Location = new System.Drawing.Point(242, 216);
            this.login_type_box.Margin = new System.Windows.Forms.Padding(4);
            this.login_type_box.Name = "login_type_box";
            this.login_type_box.Size = new System.Drawing.Size(319, 33);
            this.login_type_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("站酷酷黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(121, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("站酷酷黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(144, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // login_name_box
            // 
            this.login_name_box.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_name_box.Location = new System.Drawing.Point(242, 273);
            this.login_name_box.Margin = new System.Windows.Forms.Padding(4);
            this.login_name_box.Multiline = true;
            this.login_name_box.Name = "login_name_box";
            this.login_name_box.Size = new System.Drawing.Size(319, 34);
            this.login_name_box.TabIndex = 3;
            // 
            // login_pwd_box
            // 
            this.login_pwd_box.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_pwd_box.Location = new System.Drawing.Point(242, 334);
            this.login_pwd_box.Margin = new System.Windows.Forms.Padding(4);
            this.login_pwd_box.Multiline = true;
            this.login_pwd_box.Name = "login_pwd_box";
            this.login_pwd_box.PasswordChar = '*';
            this.login_pwd_box.Size = new System.Drawing.Size(319, 35);
            this.login_pwd_box.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_button.Location = new System.Drawing.Point(210, 400);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(84, 51);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // res_button
            // 
            this.res_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.res_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.res_button.Font = new System.Drawing.Font("站酷酷黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.res_button.Location = new System.Drawing.Point(477, 400);
            this.res_button.Margin = new System.Windows.Forms.Padding(4);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(84, 51);
            this.res_button.TabIndex = 6;
            this.res_button.Text = "注册";
            this.res_button.UseVisualStyleBackColor = false;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("站酷酷黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(98, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "登录类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("站酷酷黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(144, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 82);
            this.label4.TabIndex = 9;
            this.label4.Text = "航班订票系统";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_pwd_box);
            this.Controls.Add(this.login_name_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_type_box);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "航班订票系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox login_type_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_name_box;
        private System.Windows.Forms.TextBox login_pwd_box;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

