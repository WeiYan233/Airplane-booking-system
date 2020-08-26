namespace 航班订票系统
{
    partial class CommonUserForm
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
            this.plane_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plane_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_box_1 = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.my_order_label = new System.Windows.Forms.Label();
            this.search_box_2 = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
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
            this.plane_id,
            this.plane_type,
            this.start_station,
            this.end_station,
            this.start_time,
            this.end_time,
            this.remain_tickets,
            this.price,
            this.reserve});
            this.display_box.Location = new System.Drawing.Point(3, 92);
            this.display_box.Margin = new System.Windows.Forms.Padding(4);
            this.display_box.MultiSelect = false;
            this.display_box.Name = "display_box";
            this.display_box.ReadOnly = true;
            this.display_box.RowHeadersVisible = false;
            this.display_box.RowHeadersWidth = 51;
            this.display_box.RowTemplate.Height = 23;
            this.display_box.Size = new System.Drawing.Size(812, 306);
            this.display_box.TabIndex = 0;
            this.display_box.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_box_CellContentClick);
            // 
            // plane_id
            // 
            this.plane_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.plane_id.HeaderText = "航班号";
            this.plane_id.MinimumWidth = 6;
            this.plane_id.Name = "plane_id";
            this.plane_id.ReadOnly = true;
            this.plane_id.Width = 81;
            // 
            // plane_type
            // 
            this.plane_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.plane_type.HeaderText = "飞机型号";
            this.plane_type.MinimumWidth = 6;
            this.plane_type.Name = "plane_type";
            this.plane_type.ReadOnly = true;
            this.plane_type.Width = 96;
            // 
            // start_station
            // 
            this.start_station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.start_station.HeaderText = "出发城市";
            this.start_station.MinimumWidth = 6;
            this.start_station.Name = "start_station";
            this.start_station.ReadOnly = true;
            this.start_station.Width = 96;
            // 
            // end_station
            // 
            this.end_station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.end_station.HeaderText = "到达城市";
            this.end_station.MinimumWidth = 6;
            this.end_station.Name = "end_station";
            this.end_station.ReadOnly = true;
            this.end_station.Width = 96;
            // 
            // start_time
            // 
            this.start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.start_time.HeaderText = "起飞时间";
            this.start_time.MinimumWidth = 6;
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            this.start_time.Width = 96;
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.end_time.HeaderText = "降落时间";
            this.end_time.MinimumWidth = 6;
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            this.end_time.Width = 96;
            // 
            // remain_tickets
            // 
            this.remain_tickets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.remain_tickets.HeaderText = "剩余票数";
            this.remain_tickets.MinimumWidth = 6;
            this.remain_tickets.Name = "remain_tickets";
            this.remain_tickets.ReadOnly = true;
            this.remain_tickets.Width = 96;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.HeaderText = "票价";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 66;
            // 
            // reserve
            // 
            this.reserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.reserve.HeaderText = "预订";
            this.reserve.MinimumWidth = 6;
            this.reserve.Name = "reserve";
            this.reserve.ReadOnly = true;
            this.reserve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reserve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reserve.Width = 66;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Location = new System.Drawing.Point(16, 12);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(257, 25);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2017, 10, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "出发：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(236, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "到达：";
            // 
            // search_box_1
            // 
            this.search_box_1.Location = new System.Drawing.Point(90, 59);
            this.search_box_1.Margin = new System.Windows.Forms.Padding(4);
            this.search_box_1.Name = "search_box_1";
            this.search_box_1.Size = new System.Drawing.Size(115, 25);
            this.search_box_1.TabIndex = 6;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_button.Location = new System.Drawing.Point(470, 55);
            this.search_button.Margin = new System.Windows.Forms.Padding(4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 29);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "搜索";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // my_order_label
            // 
            this.my_order_label.AutoSize = true;
            this.my_order_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_order_label.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.my_order_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.my_order_label.Location = new System.Drawing.Point(294, 15);
            this.my_order_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.my_order_label.Name = "my_order_label";
            this.my_order_label.Size = new System.Drawing.Size(89, 20);
            this.my_order_label.TabIndex = 10;
            this.my_order_label.Text = "我的订单";
            this.my_order_label.Click += new System.EventHandler(this.my_order_label_Click);
            // 
            // search_box_2
            // 
            this.search_box_2.Location = new System.Drawing.Point(313, 59);
            this.search_box_2.Margin = new System.Windows.Forms.Padding(4);
            this.search_box_2.Name = "search_box_2";
            this.search_box_2.Size = new System.Drawing.Size(115, 25);
            this.search_box_2.TabIndex = 11;
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_button.Location = new System.Drawing.Point(704, 15);
            this.return_button.Margin = new System.Windows.Forms.Padding(4);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(100, 29);
            this.return_button.TabIndex = 12;
            this.return_button.Text = "返回";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // CommonUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(817, 404);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.search_box_2);
            this.Controls.Add(this.my_order_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.display_box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CommonUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "航班信息查询";
            this.Load += new System.EventHandler(this.CommonUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView display_box;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_box_1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label my_order_label;
        private System.Windows.Forms.TextBox search_box_2;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn reserve;
    }
}