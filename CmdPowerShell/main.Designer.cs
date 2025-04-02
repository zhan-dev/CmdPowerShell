namespace CmdPowerShell
{
    partial class main
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
            this.history_lbl = new System.Windows.Forms.Label();
            this.pwShell_btn = new System.Windows.Forms.Button();
            this.pwShell_txt = new System.Windows.Forms.TextBox();
            this.cmd_btn = new System.Windows.Forms.Button();
            this.cmd_txt = new System.Windows.Forms.TextBox();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.historyDownload_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // history_lbl
            // 
            this.history_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.history_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.history_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_lbl.Location = new System.Drawing.Point(506, 0);
            this.history_lbl.Name = "history_lbl";
            this.history_lbl.Size = new System.Drawing.Size(358, 281);
            this.history_lbl.TabIndex = 2;
            this.history_lbl.Text = "Request History:";
            // 
            // pwShell_btn
            // 
            this.pwShell_btn.Location = new System.Drawing.Point(785, 238);
            this.pwShell_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwShell_btn.Name = "pwShell_btn";
            this.pwShell_btn.Size = new System.Drawing.Size(71, 33);
            this.pwShell_btn.TabIndex = 8;
            this.pwShell_btn.Text = "pShell";
            this.pwShell_btn.UseVisualStyleBackColor = true;
            this.pwShell_btn.Click += new System.EventHandler(this.pwShell_btn_Click);
            // 
            // pwShell_txt
            // 
            this.pwShell_txt.Location = new System.Drawing.Point(499, 241);
            this.pwShell_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwShell_txt.Name = "pwShell_txt";
            this.pwShell_txt.Size = new System.Drawing.Size(278, 26);
            this.pwShell_txt.TabIndex = 7;
            this.pwShell_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwShell_txt_KeyDown);
            this.pwShell_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pwShell_txt_KeyUp);
            // 
            // cmd_btn
            // 
            this.cmd_btn.Location = new System.Drawing.Point(785, 201);
            this.cmd_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_btn.Name = "cmd_btn";
            this.cmd_btn.Size = new System.Drawing.Size(71, 33);
            this.cmd_btn.TabIndex = 6;
            this.cmd_btn.Text = "cmd";
            this.cmd_btn.UseVisualStyleBackColor = true;
            this.cmd_btn.Click += new System.EventHandler(this.cmd_btn_Click);
            // 
            // cmd_txt
            // 
            this.cmd_txt.Location = new System.Drawing.Point(499, 204);
            this.cmd_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_txt.Name = "cmd_txt";
            this.cmd_txt.Size = new System.Drawing.Size(278, 26);
            this.cmd_txt.TabIndex = 5;
            this.cmd_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_txt_KeyDown);
            this.cmd_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmd_txt_KeyUp);
            // 
            // result_txt
            // 
            this.result_txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.result_txt.Location = new System.Drawing.Point(0, 0);
            this.result_txt.Multiline = true;
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result_txt.Size = new System.Drawing.Size(470, 281);
            this.result_txt.TabIndex = 10;
            this.result_txt.Text = "Result:";
            // 
            // historyDownload_btn
            // 
            this.historyDownload_btn.Image = global::CmdPowerShell.Properties.Resources.File_Download;
            this.historyDownload_btn.Location = new System.Drawing.Point(831, 12);
            this.historyDownload_btn.Name = "historyDownload_btn";
            this.historyDownload_btn.Size = new System.Drawing.Size(25, 25);
            this.historyDownload_btn.TabIndex = 11;
            this.historyDownload_btn.UseVisualStyleBackColor = true;
            this.historyDownload_btn.Click += new System.EventHandler(this.historyDownload_btn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 281);
            this.Controls.Add(this.historyDownload_btn);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.pwShell_btn);
            this.Controls.Add(this.pwShell_txt);
            this.Controls.Add(this.cmd_btn);
            this.Controls.Add(this.cmd_txt);
            this.Controls.Add(this.history_lbl);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 320);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label history_lbl;
        private System.Windows.Forms.Button pwShell_btn;
        private System.Windows.Forms.TextBox pwShell_txt;
        private System.Windows.Forms.Button cmd_btn;
        private System.Windows.Forms.TextBox cmd_txt;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Button historyDownload_btn;
    }
}

