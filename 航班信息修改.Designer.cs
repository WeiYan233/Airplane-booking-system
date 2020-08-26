namespace 航班订票系统
{
    partial class AdminUserForm
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
            this.edit_plane = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.add_info_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_save_button = new System.Windows.Forms.Button();
            this.return_label = new System.Windows.Forms.Label();
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
            this.edit_plane,
            this.delete_info});
            this.display_box.Location = new System.Drawing.Point(0, 64);
            this.display_box.Margin = new System.Windows.Forms.Padding(4);
            this.display_box.MultiSelect = false;
            this.display_box.Name = "display_box";
            this.display_box.ReadOnly = true;
            this.display_box.RowHeadersVisible = false;
            this.display_box.RowHeadersWidth = 51;
            this.display_box.RowTemplate.Height = 23;
            this.display_box.Size = new System.Drawing.Size(888, 417);
            this.display_box.TabIndex = 1;
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
            // edit_plane
            // 
            this.edit_plane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.edit_plane.HeaderText = "编辑";
            this.edit_plane.MinimumWidth = 6;
            this.edit_plane.Name = "edit_plane";
            this.edit_plane.ReadOnly = true;
            this.edit_plane.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit_plane.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit_plane.Width = 66;
            // 
            // delete_info
            // 
            this.delete_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.delete_info.HeaderText = "删除";
            this.delete_info.MinimumWidth = 6;
            this.delete_info.Name = "delete_info";
            this.delete_info.ReadOnly = true;
            this.delete_info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete_info.Width = 66;
            // 
            // add_info_button
            // 
            this.add_info_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_info_button.Font = new System.Drawing.Font("站酷酷黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_info_button.Location = new System.Drawing.Point(13, 15);
            this.add_info_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_info_button.Name = "add_info_button";
            this.add_info_button.Size = new System.Drawing.Size(145, 41);
            this.add_info_button.TabIndex = 2;
            this.add_info_button.Text = "增加航班信息";
            this.add_info_button.UseVisualStyleBackColor = false;
            this.add_info_button.Click += new System.EventHandler(this.add_info_button_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(756, 24);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(89, 20);
            this.exit.TabIndex = 3;
            this.exit.Text = "退出系统";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("站酷酷黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save_button.Location = new System.Drawing.Point(9, 15);
            this.save_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(104, 41);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "保存修改";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Visible = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_save_button
            // 
            this.cancel_save_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancel_save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_save_button.Font = new System.Drawing.Font("站酷酷黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_save_button.Location = new System.Drawing.Point(155, 15);
            this.cancel_save_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_save_button.Name = "cancel_save_button";
            this.cancel_save_button.Size = new System.Drawing.Size(104, 41);
            this.cancel_save_button.TabIndex = 5;
            this.cancel_save_button.Text = "放弃修改";
            this.cancel_save_button.UseVisualStyleBackColor = false;
            this.cancel_save_button.Visible = false;
            this.cancel_save_button.Click += new System.EventHandler(this.cancel_save_button_Click);
            // 
            // return_label
            // 
            this.return_label.AutoSize = true;
            this.return_label.Font = new System.Drawing.Font("站酷酷黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_label.ForeColor = System.Drawing.Color.Red;
            this.return_label.Location = new System.Drawing.Point(685, 24);
            this.return_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.return_label.Name = "return_label";
            this.return_label.Size = new System.Drawing.Size(49, 20);
            this.return_label.TabIndex = 6;
            this.return_label.Text = "返回";
            this.return_label.Click += new System.EventHandler(this.return_Click);
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 486);
            this.Controls.Add(this.return_label);
            this.Controls.Add(this.cancel_save_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.add_info_button);
            this.Controls.Add(this.display_box);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改航班信息";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView display_box;
        private System.Windows.Forms.Button add_info_button;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn edit_plane;
        private System.Windows.Forms.DataGridViewButtonColumn delete_info;
        private System.Windows.Forms.Label return_label;
    }
}