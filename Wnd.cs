using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPluginxD
{
    public partial class Wnd : Form
    {
        public Wnd()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
            base.OnClosing(e);
        }

        private void General_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.General = General.Checked;
        }

        private void Trade_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.Trade = Trade.Checked;
        }

        private void Guild_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.Guild = Guild.Checked;
        }

        private void World_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.World = World.Checked;
        }

        private void Region_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.Region = RegionxD.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Core.Settings.Criterias.Add(criteria_input.Text);
        }

        private void AddBlacklist_Click(object sender, EventArgs e)
        {
            Core.Settings.Blacklist.Add(bl_input.Text);
        }

        private void Wnd_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Core.Messages;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            Blacklist.DataSource = Core.Settings.Blacklist;
            Criterias.DataSource = Core.Settings.Criterias;            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals((string)"Trading"))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Core.Settings.TradingColor;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals((string)"Region"))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Core.Settings.RegionColor;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals((string)"World2"))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Core.Settings.World2Color;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals((string)"Guild"))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Core.Settings.GuildColor;
                }
            }
            catch
            {
                MessageBox.Show("DisplayEvent Error report it !", "Error");
            }
           
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ChatPluginXD - Made by Kritters for https://skandiabot.com ! Feel free to recommend this plugin if you want to :)", "About ChatPluginXD");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            using (var saveFile = new SaveFileDialog()
            {
                Title = "Save settings file...",
                Filter = "XML files|*.xml",
                OverwritePrompt = true,
                InitialDirectory = Core.ProfilesDirectory,
            })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Helper.Save(saveFile.FileName, Core.Settings);
                }
            }
            BringToFront();
        }

        private void ouvrirToolStripButton_Click(object sender, EventArgs e)
        {
            using (var loadFile = new OpenFileDialog()
            {
                Title = "Load settings file...",
                Filter = "XML files|*.xml",
                Multiselect = false,
                CheckFileExists = true,
                InitialDirectory = Core.ProfilesDirectory,
            })
            {
                if (loadFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(loadFile.FileName))
                    {
                        Core.Settings.Blacklist.Clear();
                        Core.Settings.Criterias.Clear();
                        Core.Settings = Helper.Load<Settings>(loadFile.FileName);
                        Blacklist.DataSource = Core.Settings.Blacklist;
                        Criterias.DataSource = Core.Settings.Criterias;   
                      
                    }
                    else
                    {
                        MessageBox.Show("The selected file was not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.SoundNotif = checkBox1.Checked;
        }

        private void Mp_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.Whispers = Mp.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.EnableLogs = checkBox2.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {//checkBox4
            Core.Settings.SkandiaChatNotif = checkBox4.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Core.Settings.MailNotification = checkBox3.Checked;
        }
        //checkBox4
    }
}
