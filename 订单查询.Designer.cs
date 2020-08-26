namespace 航班订票系统
{
    partial class MyOrderForm
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
            this.display_box = new System.Windows.Forms.DataGridView();
            this.remain_tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plane_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plane_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.user_label = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display_box)).BeginInit();
            this.SuspendLayout();
            // 
            // display_box
            // 
            this.display_box.AllowUserToAddRows = false;
            this.display_box.AllowUserToDeleteRows = false;
            this.display_box.AllowUserToResizeColumns = false;
            this.display_box.AllowUserToResizeRows = false;
            this.display_box.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display_box.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.remain_tickets,
            this.price,
            this.plane_id,
            this.plane_type,
            this.start_station,
            this.end_station,
            this.start_time,
            this.end_time,
            this.reserve});
            this.display_box.Location = new System.Drawing.Point(3, 50);
            this.display_box.Margin = new System.Windows.Forms.Padding(4);
            this.display_box.MultiSelect = false;
            this.display_box.Name = "display_box";
            this.display_box.RowHeadersVisible = false;
            this.display_box.RowHeadersWidth = 51;
            this.display_box.RowTemplate.Height = 23;
            this.display_box.Size = new System.Drawing.Size(940, 296);
            this.display_box.TabIndex = 1;
            this.display_box.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_box_CellContentClick);
            // 
            // remain_tickets
            // 
            this.remain_tickets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remain_tickets.HeaderText = "乘客姓名";
            this.remain_tickets.MinimumWidth = 6;
            this.remain_tickets.Name = "remain_tickets";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "身份证号";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // plane_id
            // 
            this.plane_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plane_id.HeaderText = "航班号";
            this.plane_id.MinimumWidth = 6;
            this.plane_id.Name = "plane_id";
            // 
            // plane_type
            // 
            this.plane_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plane_type.HeaderText = "飞机型号";
            this.plane_type.MinimumWidth = 6;
            this.plane_type.Name = "plane_type";
            // 
            // start_station
            // 
            this.start_station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_station.HeaderText = "出发城市";
            this.start_station.MinimumWidth = 6;
            this.start_station.Name = "start_station";
            // 
            // end_station
            // 
            this.end_station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_station.HeaderText = "到达城市";
            this.end_station.MinimumWidth = 6;
            this.end_station.Name = "end_station";
            // 
            // start_time
            // 
            this.start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_time.HeaderText = "起飞时间";
            this.start_time.MinimumWidth = 6;
            this.start_time.Name = "start_time";
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_time.HeaderText = "降落时间";
            this.end_time.MinimumWidth = 6;
            this.end_time.Name = "end_time";
            // 
            // reserve
            // 
            this.reserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reserve.HeaderText = "退订";
            this.reserve.MinimumWidth = 6;
            this.reserve.Name = "reserve";
            this.reserve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reserve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_label.Location = new System.Drawing.Point(16, 13);
            this.user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(89, 20);
            this.user_label.TabIndex = 2;
            this.user_label.Text = "用户名：";
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("站酷酷黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_button.Location = new System.Drawing.Point(598, 9);
            this.return_button.Margin = new System.Windows.Forms.Padding(4);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(146, 29);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "返回订票界面";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("站酷酷黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit_button.Location = new System.Drawing.Point(791, 9);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(130, 29);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "退出系统";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // MyOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 349);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.display_box);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyOrderForm";
            this.Text = "我的订单";
            this.Load += new System.EventHandler(this.MyOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView display_box;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewButtonColumn reserve;
    }
}