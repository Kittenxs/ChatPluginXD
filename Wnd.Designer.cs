namespace ChatPluginxD
{
    partial class Wnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wnd));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBlacklist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bl_input = new System.Windows.Forms.TextBox();
            this.criteria_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.General = new System.Windows.Forms.CheckBox();
            this.Trade = new System.Windows.Forms.CheckBox();
            this.Guild = new System.Windows.Forms.CheckBox();
            this.World = new System.Windows.Forms.CheckBox();
            this.RegionxD = new System.Windows.Forms.CheckBox();
            this.Blacklist = new System.Windows.Forms.ListBox();
            this.Criterias = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ouvrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Mp = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // AddBlacklist
            // 
            this.AddBlacklist.Location = new System.Drawing.Point(944, 86);
            this.AddBlacklist.Name = "AddBlacklist";
            this.AddBlacklist.Size = new System.Drawing.Size(112, 23);
            this.AddBlacklist.TabIndex = 2;
            this.AddBlacklist.Text = "Add";
            this.AddBlacklist.UseVisualStyleBackColor = true;
            this.AddBlacklist.Click += new System.EventHandler(this.AddBlacklist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add player to blacklist";
            // 
            // bl_input
            // 
            this.bl_input.Location = new System.Drawing.Point(790, 88);
            this.bl_input.Name = "bl_input";
            this.bl_input.Size = new System.Drawing.Size(148, 20);
            this.bl_input.TabIndex = 4;
            // 
            // criteria_input
            // 
            this.criteria_input.Location = new System.Drawing.Point(790, 231);
            this.criteria_input.Name = "criteria_input";
            this.criteria_input.Size = new System.Drawing.Size(148, 20);
            this.criteria_input.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Filters";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(944, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // General
            // 
            this.General.AutoSize = true;
            this.General.Location = new System.Drawing.Point(15, 18);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(99, 17);
            this.General.TabIndex = 8;
            this.General.Text = "Enable General";
            this.General.UseVisualStyleBackColor = true;
            this.General.CheckedChanged += new System.EventHandler(this.General_CheckedChanged);
            // 
            // Trade
            // 
            this.Trade.AutoSize = true;
            this.Trade.Location = new System.Drawing.Point(120, 18);
            this.Trade.Name = "Trade";
            this.Trade.Size = new System.Drawing.Size(90, 17);
            this.Trade.TabIndex = 9;
            this.Trade.Text = "Enable Trade";
            this.Trade.UseVisualStyleBackColor = true;
            this.Trade.CheckedChanged += new System.EventHandler(this.Trade_CheckedChanged);
            // 
            // Guild
            // 
            this.Guild.AutoSize = true;
            this.Guild.Location = new System.Drawing.Point(225, 18);
            this.Guild.Name = "Guild";
            this.Guild.Size = new System.Drawing.Size(86, 17);
            this.Guild.TabIndex = 10;
            this.Guild.Text = "Enable Guild";
            this.Guild.UseVisualStyleBackColor = true;
            this.Guild.CheckedChanged += new System.EventHandler(this.Guild_CheckedChanged);
            // 
            // World
            // 
            this.World.AutoSize = true;
            this.World.Location = new System.Drawing.Point(330, 17);
            this.World.Name = "World";
            this.World.Size = new System.Drawing.Size(90, 17);
            this.World.TabIndex = 11;
            this.World.Text = "Enable World";
            this.World.UseVisualStyleBackColor = true;
            this.World.CheckedChanged += new System.EventHandler(this.World_CheckedChanged);
            // 
            // RegionxD
            // 
            this.RegionxD.AutoSize = true;
            this.RegionxD.Location = new System.Drawing.Point(435, 17);
            this.RegionxD.Name = "RegionxD";
            this.RegionxD.Size = new System.Drawing.Size(96, 17);
            this.RegionxD.TabIndex = 12;
            this.RegionxD.Text = "Enable Region";
            this.RegionxD.UseVisualStyleBackColor = true;
            this.RegionxD.CheckedChanged += new System.EventHandler(this.Region_CheckedChanged);
            // 
            // Blacklist
            // 
            this.Blacklist.FormattingEnabled = true;
            this.Blacklist.Location = new System.Drawing.Point(790, 114);
            this.Blacklist.Name = "Blacklist";
            this.Blacklist.Size = new System.Drawing.Size(266, 95);
            this.Blacklist.TabIndex = 13;
            // 
            // Criterias
            // 
            this.Criterias.FormattingEnabled = true;
            this.Criterias.Location = new System.Drawing.Point(790, 255);
            this.Criterias.Name = "Criterias";
            this.Criterias.Size = new System.Drawing.Size(266, 95);
            this.Criterias.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripButton,
            this.enregistrerToolStripButton,
            this.toolStripSeparator,
            this.ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ouvrirToolStripButton
            // 
            this.ouvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ouvrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripButton.Image")));
            this.ouvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripButton.Name = "ouvrirToolStripButton";
            this.ouvrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ouvrirToolStripButton.Text = "&Ouvrir Charger";
            this.ouvrirToolStripButton.Click += new System.EventHandler(this.ouvrirToolStripButton_Click);
            // 
            // enregistrerToolStripButton
            // 
            this.enregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
            this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
            this.enregistrerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.enregistrerToolStripButton.Text = "&Enregistrer";
            this.enregistrerToolStripButton.Click += new System.EventHandler(this.enregistrerToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            this.ToolStripButton.Click += new System.EventHandler(this.ToolStripButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Mp);
            this.groupBox2.Controls.Add(this.General);
            this.groupBox2.Controls.Add(this.Trade);
            this.groupBox2.Controls.Add(this.Guild);
            this.groupBox2.Controls.Add(this.World);
            this.groupBox2.Controls.Add(this.RegionxD);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 45);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chat Filters";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(910, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Enable Sound Notifications";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Mp
            // 
            this.Mp.AutoSize = true;
            this.Mp.Location = new System.Drawing.Point(537, 17);
            this.Mp.Name = "Mp";
            this.Mp.Size = new System.Drawing.Size(106, 17);
            this.Mp.TabIndex = 13;
            this.Mp.Text = "Enable Whispers";
            this.Mp.UseVisualStyleBackColor = true;
            this.Mp.CheckedChanged += new System.EventHandler(this.Mp_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(778, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Enable Textfile Logs";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(778, 31);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Enable MailSending";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(910, 31);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(148, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Enable SkandiaChat Notif";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Wnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 361);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Criterias);
            this.Controls.Add(this.Blacklist);
            this.Controls.Add(this.criteria_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bl_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBlacklist);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wnd";
            this.Text = "ChatPlugin - Wnd";
            this.Load += new System.EventHandler(this.Wnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBlacklist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bl_input;
        private System.Windows.Forms.TextBox criteria_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox General;
        private System.Windows.Forms.CheckBox Trade;
        private System.Windows.Forms.CheckBox Guild;
        private System.Windows.Forms.CheckBox World;
        private System.Windows.Forms.CheckBox RegionxD;
        private System.Windows.Forms.ListBox Blacklist;
        private System.Windows.Forms.ListBox Criterias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ouvrirToolStripButton;
        private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox Mp;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}