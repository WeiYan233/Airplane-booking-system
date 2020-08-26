namespace 航班订票系统
{
    partial class ReserveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveForm));
            this.message_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.sure_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_label
            // 
            resources.ApplyResources(this.message_label, "message_label");
            this.message_label.Name = "message_label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // name_box
            // 
            resources.ApplyResources(this.name_box, "name_box");
            this.name_box.Name = "name_box";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // id_box
            // 
            resources.ApplyResources(this.id_box, "id_box");
            this.id_box.Name = "id_box";
            // 
            // sure_button
            // 
            this.sure_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.sure_button, "sure_button");
            this.sure_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sure_button.Name = "sure_button";
            this.sure_button.UseVisualStyleBackColor = false;
            this.sure_button.Click += new System.EventHandler(this.sure_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.quit_button, "quit_button");
            this.quit_button.Name = "quit_button";
            this.quit_button.UseVisualStyleBackColor = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // ReserveForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.sure_button);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message_label);
            this.Name = "ReserveForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Button sure_button;
        private System.Windows.Forms.Button quit_button;
    }
}