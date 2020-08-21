using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class MainForm : Form
    {
        Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            radioButton_templates.Checked = Properties.Settings.Default.symbols_settings_is_templates;
            radioButton_own_symbols.Checked = !Properties.Settings.Default.symbols_settings_is_templates;
            checkBox_template_1.Checked = Properties.Settings.Default.symbols_settings_template_1;
            checkBox_template_2.Checked = Properties.Settings.Default.symbols_settings_template_2;
            checkBox_template_3.Checked = Properties.Settings.Default.symbols_settings_template_3;
            checkBox_template_4.Checked = Properties.Settings.Default.symbols_settings_template_4;
            checkBox_template_5.Checked = Properties.Settings.Default.symbols_settings_template_5;
            richTextBox_symbols_settings.Text = Properties.Settings.Default.symbols_settings_own_symbols_text;
            numericUpDown_passwords_number.Value = Properties.Settings.Default.generation_settings_number_of_passwords;
            numericUpDown_single_password_length.Value = Properties.Settings.Default.generation_settings_length_of_single_password;
            if (Properties.Settings.Default.generation_settings_delimiter == 1) radioButton_new_line.Checked = true;
            else if (Properties.Settings.Default.generation_settings_delimiter == 2) radioButton_two_new_lines.Checked = true;
            else if (Properties.Settings.Default.generation_settings_delimiter == 3) radioButton_space.Checked = true;
            else if (Properties.Settings.Default.generation_settings_delimiter == 4) radioButton_string.Checked = true;
            else radioButton_none.Checked = true;
            richTextBox_string.Text = Properties.Settings.Default.generation_settings_delimiter_symbols;
            checkBox_clear_result_every_generation.Checked = Properties.Settings.Default.generation_settings_clear_result_every_time;
            richTextBox_result.Text = Properties.Settings.Default.result;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.symbols_settings_is_templates = radioButton_templates.Checked;
            Properties.Settings.Default.symbols_settings_template_1 = checkBox_template_1.Checked;
            Properties.Settings.Default.symbols_settings_template_2 = checkBox_template_2.Checked;
            Properties.Settings.Default.symbols_settings_template_3 = checkBox_template_3.Checked;
            Properties.Settings.Default.symbols_settings_template_4 = checkBox_template_4.Checked;
            Properties.Settings.Default.symbols_settings_template_5 = checkBox_template_5.Checked;
            Properties.Settings.Default.symbols_settings_own_symbols_text = richTextBox_symbols_settings.Text;
            Properties.Settings.Default.generation_settings_number_of_passwords = numericUpDown_passwords_number.Value;
            Properties.Settings.Default.generation_settings_length_of_single_password = numericUpDown_single_password_length.Value;
            if (radioButton_new_line.Checked == true) Properties.Settings.Default.generation_settings_delimiter = 1;
            else if (radioButton_two_new_lines.Checked == true) Properties.Settings.Default.generation_settings_delimiter = 2;
            else if (radioButton_space.Checked == true) Properties.Settings.Default.generation_settings_delimiter = 3;
            else if (radioButton_string.Checked == true) Properties.Settings.Default.generation_settings_delimiter = 4;
            else Properties.Settings.Default.generation_settings_delimiter = 0;
            Properties.Settings.Default.generation_settings_delimiter_symbols = richTextBox_string.Text;
            Properties.Settings.Default.generation_settings_clear_result_every_time = checkBox_clear_result_every_generation.Checked;
            Properties.Settings.Default.result = richTextBox_result.Text;
            Properties.Settings.Default.Save();
        }

        private void radioButton_symbol_settings_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_templates.Checked == true)
            {
                richTextBox_symbols_settings.Enabled = false;
                button_set_own_symbols_to_default.Enabled = false;

                checkBox_template_1.Enabled = true;
                checkBox_template_2.Enabled = true;
                checkBox_template_3.Enabled = true;
                checkBox_template_4.Enabled = true;
                checkBox_template_5.Enabled = true;
            }
            else if (radioButton_own_symbols.Checked == true)
            {
                richTextBox_symbols_settings.Enabled = true;
                button_set_own_symbols_to_default.Enabled = true;

                checkBox_template_1.Enabled = false;
                checkBox_template_2.Enabled = false;
                checkBox_template_3.Enabled = false;
                checkBox_template_4.Enabled = false;
                checkBox_template_5.Enabled = false;
            }
        }

        private void button_set_own_symbols_to_default_Click(object sender, EventArgs e)
        {
            richTextBox_symbols_settings.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!$%^*()-_=+<>.,{}[]:;~@#'\"?/|\\";
        }

        private void radioButton_delimiter_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton_none.Checked == true) ||
                (radioButton_new_line.Checked == true) ||
                (radioButton_two_new_lines.Checked == true) ||
                (radioButton_space.Checked == true))
            {
                richTextBox_string.Enabled = false;
            }
            else if (radioButton_string.Checked == true)
            {
                richTextBox_string.Enabled = true;
            }
        }

        private string GeneratePassword(int length, string alphabet)
        {
            string password = "";
            for (int i = 0; i < length; i++)
            {
                int symbol_id = rand.Next(0, alphabet.Length);
                password += alphabet[symbol_id];
            }
            return password;
        }

        private string GenerateResult(int passwords_number, int length, string alphabet, string delimiter)
        {
            string result = "";
            for (int i = 0; i < passwords_number; i++)
            {
                string password = GeneratePassword(length, alphabet);
                if (i != 0) result += delimiter;
                result += password;
            }
            return result;
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            int passwords_number = Convert.ToInt32(numericUpDown_passwords_number.Value);
            int length = Convert.ToInt32(numericUpDown_single_password_length.Value);

            string alphabet = "";
            if (radioButton_templates.Checked == true)
            {
                if (checkBox_template_1.Checked == true)
                {
                    alphabet += checkBox_template_1.Text;
                }
                if (checkBox_template_2.Checked == true)
                {
                    alphabet += checkBox_template_2.Text;
                }
                if (checkBox_template_3.Checked == true)
                {
                    alphabet += checkBox_template_3.Text;
                }
                if (checkBox_template_4.Checked == true)
                {
                    alphabet += checkBox_template_4.Text;
                }
                if (checkBox_template_5.Checked == true)
                {
                    alphabet += checkBox_template_5.Text;
                }
                if (alphabet == "")
                {
                    MessageBox.Show("At least one template must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (radioButton_own_symbols.Checked == true)
            {
                if (richTextBox_symbols_settings.Text == "")
                {
                    MessageBox.Show("Textarea for \"Own symbols\" must contain at least one symbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    alphabet = richTextBox_symbols_settings.Text;
                }
            }
            else throw (new Exception("Symbol settings did not set."));

            string delimiter = "";
            if (radioButton_new_line.Checked == true)
            {
                delimiter = "\n";
            }
            else if (radioButton_two_new_lines.Checked == true)
            {
                delimiter = "\n\n";
            }
            else if (radioButton_space.Checked == true)
            {
                delimiter = " ";
            }
            else if (radioButton_string.Checked == true)
            {
                delimiter = richTextBox_string.Text;
            }

            string generated_result = GenerateResult(passwords_number, length, alphabet, delimiter);
            if (generated_result.Length > richTextBox_result.MaxLength)
            {
                MessageBox.Show("Generated result does not fit in the textarea!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (checkBox_clear_result_every_generation.Checked == true)
            {
                richTextBox_result.Text = generated_result;
            }
            else
            {
                if (richTextBox_result.Text != "")
                {
                    richTextBox_result.Text += delimiter;
                }
                richTextBox_result.Text += generated_result;
            }
        }

        private void button_clear_result_Click(object sender, EventArgs e)
        {
            richTextBox_result.Clear();
        }

        private void button_copy_result_to_clipboard_Click(object sender, EventArgs e)
        {
            if (richTextBox_result.Text == "")
            {
                MessageBox.Show("Result has no symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Clipboard.SetText(richTextBox_result.Text);
            }
        }

        private void button_save_result_to_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "result.txt";
            dialog.Filter = "Normal txt file (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            DialogResult dialog_result = dialog.ShowDialog();
            if (dialog_result != DialogResult.Cancel)
            {
                System.IO.File.WriteAllText(dialog.FileName, richTextBox_result.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setAllSettingsToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_set_own_symbols_to_default.PerformClick();

            radioButton_templates.Checked = true;
            checkBox_template_1.Checked = true;
            checkBox_template_2.Checked = true;
            checkBox_template_3.Checked = true;
            checkBox_template_4.Checked = true;
            checkBox_template_5.Checked = false;

            numericUpDown_passwords_number.Value = 1;
            numericUpDown_single_password_length.Value = 64;
            radioButton_new_line.Checked = true;
            richTextBox_string.Clear();
            checkBox_clear_result_every_generation.Checked = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help_text = "This program is designed to generate passwords." +
                " The group of tools \"Symbol settings\" allows setting up symbols that will be used for" +
                " generating passwords. Special symbols are divided into two groups, the second group includes symbols" +
                " that some sites do not allow using in their passwords." +
                "\n\n" +
                "The \"Generation settings\" tool group allows setting up the number and length of passwords," +
                " as well as the way to add them to the Result field. " +
                "\n\n" +
                "You can copy the result manually or use a special button.You can also save the result to a file." +
                "\n\n" +
                "The program saves the settings on restart. Some functions of the program are duplicated in the top" +
                " menu, there is also an option to reset the program settings." +
                "\n\n" +
                "John-9198. Unpermanent.";

            MessageBox.Show(help_text, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Generator v.1.0.0 | by John-9198\n\nRelease: 21.08.2020\nhttps://github.com/John-9198/Password-Generator\n\nFeedback and suggestions:\njohn-9198@protonmail.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
