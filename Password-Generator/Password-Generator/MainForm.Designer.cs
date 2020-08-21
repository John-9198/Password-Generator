namespace Password_Generator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyResultToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_symbols_settings = new System.Windows.Forms.GroupBox();
            this.groupBox_generation_settings = new System.Windows.Forms.GroupBox();
            this.radioButton_templates = new System.Windows.Forms.RadioButton();
            this.radioButton_own_symbols = new System.Windows.Forms.RadioButton();
            this.radioButton_none = new System.Windows.Forms.RadioButton();
            this.radioButton_new_line = new System.Windows.Forms.RadioButton();
            this.radioButton_two_new_lines = new System.Windows.Forms.RadioButton();
            this.radioButton_space = new System.Windows.Forms.RadioButton();
            this.radioButton_string = new System.Windows.Forms.RadioButton();
            this.checkBox_template_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_template_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_template_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_template_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_template_5 = new System.Windows.Forms.CheckBox();
            this.richTextBox_symbols_settings = new System.Windows.Forms.RichTextBox();
            this.richTextBox_string = new System.Windows.Forms.RichTextBox();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.label_passwords_number = new System.Windows.Forms.Label();
            this.label_single_password_length = new System.Windows.Forms.Label();
            this.checkBox_clear_result_every_generation = new System.Windows.Forms.CheckBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.button_set_own_symbols_to_default = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_clear_result = new System.Windows.Forms.Button();
            this.button_copy_result_to_clipboard = new System.Windows.Forms.Button();
            this.button_save_result_to_file = new System.Windows.Forms.Button();
            this.numericUpDown_passwords_number = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_single_password_length = new System.Windows.Forms.NumericUpDown();
            this.label_result = new System.Windows.Forms.Label();
            this.setOwnSymbolsToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAllSettingsToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox_symbols_settings.SuspendLayout();
            this.groupBox_generation_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_passwords_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_single_password_length)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearResultToolStripMenuItem,
            this.copyResultToClipboardToolStripMenuItem,
            this.saveResultToFileToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.resultToolStripMenuItem.Text = "Result";
            // 
            // clearResultToolStripMenuItem
            // 
            this.clearResultToolStripMenuItem.Name = "clearResultToolStripMenuItem";
            this.clearResultToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clearResultToolStripMenuItem.Text = "Clear result";
            // 
            // copyResultToClipboardToolStripMenuItem
            // 
            this.copyResultToClipboardToolStripMenuItem.Name = "copyResultToClipboardToolStripMenuItem";
            this.copyResultToClipboardToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.copyResultToClipboardToolStripMenuItem.Text = "Copy result to clipboard";
            // 
            // saveResultToFileToolStripMenuItem
            // 
            this.saveResultToFileToolStripMenuItem.Name = "saveResultToFileToolStripMenuItem";
            this.saveResultToFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.saveResultToFileToolStripMenuItem.Text = "Save result to file...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setOwnSymbolsToDefaultToolStripMenuItem,
            this.setAllSettingsToDefaultToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // groupBox_symbols_settings
            // 
            this.groupBox_symbols_settings.BackColor = System.Drawing.Color.White;
            this.groupBox_symbols_settings.Controls.Add(this.button_set_own_symbols_to_default);
            this.groupBox_symbols_settings.Controls.Add(this.richTextBox_symbols_settings);
            this.groupBox_symbols_settings.Controls.Add(this.checkBox_template_5);
            this.groupBox_symbols_settings.Controls.Add(this.checkBox_template_4);
            this.groupBox_symbols_settings.Controls.Add(this.checkBox_template_3);
            this.groupBox_symbols_settings.Controls.Add(this.checkBox_template_2);
            this.groupBox_symbols_settings.Controls.Add(this.checkBox_template_1);
            this.groupBox_symbols_settings.Controls.Add(this.radioButton_own_symbols);
            this.groupBox_symbols_settings.Controls.Add(this.radioButton_templates);
            this.groupBox_symbols_settings.Location = new System.Drawing.Point(12, 27);
            this.groupBox_symbols_settings.Name = "groupBox_symbols_settings";
            this.groupBox_symbols_settings.Size = new System.Drawing.Size(475, 241);
            this.groupBox_symbols_settings.TabIndex = 1;
            this.groupBox_symbols_settings.TabStop = false;
            this.groupBox_symbols_settings.Text = "Symbols settings";
            // 
            // groupBox_generation_settings
            // 
            this.groupBox_generation_settings.BackColor = System.Drawing.Color.White;
            this.groupBox_generation_settings.Controls.Add(this.numericUpDown_single_password_length);
            this.groupBox_generation_settings.Controls.Add(this.numericUpDown_passwords_number);
            this.groupBox_generation_settings.Controls.Add(this.checkBox_clear_result_every_generation);
            this.groupBox_generation_settings.Controls.Add(this.label_single_password_length);
            this.groupBox_generation_settings.Controls.Add(this.label_delimiter);
            this.groupBox_generation_settings.Controls.Add(this.label_passwords_number);
            this.groupBox_generation_settings.Controls.Add(this.richTextBox_string);
            this.groupBox_generation_settings.Controls.Add(this.radioButton_string);
            this.groupBox_generation_settings.Controls.Add(this.radioButton_space);
            this.groupBox_generation_settings.Controls.Add(this.radioButton_two_new_lines);
            this.groupBox_generation_settings.Controls.Add(this.radioButton_new_line);
            this.groupBox_generation_settings.Controls.Add(this.radioButton_none);
            this.groupBox_generation_settings.Location = new System.Drawing.Point(493, 27);
            this.groupBox_generation_settings.Name = "groupBox_generation_settings";
            this.groupBox_generation_settings.Size = new System.Drawing.Size(211, 327);
            this.groupBox_generation_settings.TabIndex = 2;
            this.groupBox_generation_settings.TabStop = false;
            this.groupBox_generation_settings.Text = "Generation settings";
            // 
            // radioButton_templates
            // 
            this.radioButton_templates.AutoSize = true;
            this.radioButton_templates.Checked = true;
            this.radioButton_templates.Location = new System.Drawing.Point(7, 20);
            this.radioButton_templates.Name = "radioButton_templates";
            this.radioButton_templates.Size = new System.Drawing.Size(85, 17);
            this.radioButton_templates.TabIndex = 0;
            this.radioButton_templates.TabStop = true;
            this.radioButton_templates.Text = "Templates:";
            this.radioButton_templates.UseVisualStyleBackColor = true;
            // 
            // radioButton_own_symbols
            // 
            this.radioButton_own_symbols.AutoSize = true;
            this.radioButton_own_symbols.Location = new System.Drawing.Point(7, 88);
            this.radioButton_own_symbols.Name = "radioButton_own_symbols";
            this.radioButton_own_symbols.Size = new System.Drawing.Size(97, 17);
            this.radioButton_own_symbols.TabIndex = 1;
            this.radioButton_own_symbols.Text = "Own symbols:";
            this.radioButton_own_symbols.UseVisualStyleBackColor = true;
            // 
            // radioButton_none
            // 
            this.radioButton_none.AutoSize = true;
            this.radioButton_none.Location = new System.Drawing.Point(9, 134);
            this.radioButton_none.Name = "radioButton_none";
            this.radioButton_none.Size = new System.Drawing.Size(49, 17);
            this.radioButton_none.TabIndex = 2;
            this.radioButton_none.Text = "None";
            this.radioButton_none.UseVisualStyleBackColor = true;
            // 
            // radioButton_new_line
            // 
            this.radioButton_new_line.AutoSize = true;
            this.radioButton_new_line.Checked = true;
            this.radioButton_new_line.Location = new System.Drawing.Point(9, 155);
            this.radioButton_new_line.Name = "radioButton_new_line";
            this.radioButton_new_line.Size = new System.Drawing.Size(73, 17);
            this.radioButton_new_line.TabIndex = 3;
            this.radioButton_new_line.TabStop = true;
            this.radioButton_new_line.Text = "New line";
            this.radioButton_new_line.UseVisualStyleBackColor = true;
            // 
            // radioButton_two_new_lines
            // 
            this.radioButton_two_new_lines.AutoSize = true;
            this.radioButton_two_new_lines.Location = new System.Drawing.Point(9, 178);
            this.radioButton_two_new_lines.Name = "radioButton_two_new_lines";
            this.radioButton_two_new_lines.Size = new System.Drawing.Size(103, 17);
            this.radioButton_two_new_lines.TabIndex = 4;
            this.radioButton_two_new_lines.Text = "Two new lines";
            this.radioButton_two_new_lines.UseVisualStyleBackColor = true;
            // 
            // radioButton_space
            // 
            this.radioButton_space.AutoSize = true;
            this.radioButton_space.Location = new System.Drawing.Point(9, 201);
            this.radioButton_space.Name = "radioButton_space";
            this.radioButton_space.Size = new System.Drawing.Size(55, 17);
            this.radioButton_space.TabIndex = 5;
            this.radioButton_space.Text = "Space";
            this.radioButton_space.UseVisualStyleBackColor = true;
            // 
            // radioButton_string
            // 
            this.radioButton_string.AutoSize = true;
            this.radioButton_string.Location = new System.Drawing.Point(9, 224);
            this.radioButton_string.Name = "radioButton_string";
            this.radioButton_string.Size = new System.Drawing.Size(67, 17);
            this.radioButton_string.TabIndex = 6;
            this.radioButton_string.Text = "String:";
            this.radioButton_string.UseVisualStyleBackColor = true;
            // 
            // checkBox_template_1
            // 
            this.checkBox_template_1.AutoSize = true;
            this.checkBox_template_1.Checked = true;
            this.checkBox_template_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_template_1.Location = new System.Drawing.Point(40, 43);
            this.checkBox_template_1.Name = "checkBox_template_1";
            this.checkBox_template_1.Size = new System.Drawing.Size(182, 17);
            this.checkBox_template_1.TabIndex = 2;
            this.checkBox_template_1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.checkBox_template_1.UseVisualStyleBackColor = true;
            // 
            // checkBox_template_2
            // 
            this.checkBox_template_2.AutoSize = true;
            this.checkBox_template_2.Checked = true;
            this.checkBox_template_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_template_2.Location = new System.Drawing.Point(40, 66);
            this.checkBox_template_2.Name = "checkBox_template_2";
            this.checkBox_template_2.Size = new System.Drawing.Size(182, 17);
            this.checkBox_template_2.TabIndex = 3;
            this.checkBox_template_2.Text = "abcdefghijklmnopqrstuvwxyz";
            this.checkBox_template_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_template_3
            // 
            this.checkBox_template_3.AutoSize = true;
            this.checkBox_template_3.Checked = true;
            this.checkBox_template_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_template_3.Location = new System.Drawing.Point(228, 43);
            this.checkBox_template_3.Name = "checkBox_template_3";
            this.checkBox_template_3.Size = new System.Drawing.Size(86, 17);
            this.checkBox_template_3.TabIndex = 4;
            this.checkBox_template_3.Text = "0123456789";
            this.checkBox_template_3.UseVisualStyleBackColor = true;
            // 
            // checkBox_template_4
            // 
            this.checkBox_template_4.AutoSize = true;
            this.checkBox_template_4.Checked = true;
            this.checkBox_template_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_template_4.Location = new System.Drawing.Point(228, 66);
            this.checkBox_template_4.Name = "checkBox_template_4";
            this.checkBox_template_4.Size = new System.Drawing.Size(152, 17);
            this.checkBox_template_4.TabIndex = 5;
            this.checkBox_template_4.Text = "!$%^*()-_=+<>.,{}[]:;";
            this.checkBox_template_4.UseVisualStyleBackColor = true;
            // 
            // checkBox_template_5
            // 
            this.checkBox_template_5.AutoSize = true;
            this.checkBox_template_5.Location = new System.Drawing.Point(386, 66);
            this.checkBox_template_5.Name = "checkBox_template_5";
            this.checkBox_template_5.Size = new System.Drawing.Size(80, 17);
            this.checkBox_template_5.TabIndex = 6;
            this.checkBox_template_5.Text = "~@#\'\"?/|\\";
            this.checkBox_template_5.UseVisualStyleBackColor = true;
            // 
            // richTextBox_symbols_settings
            // 
            this.richTextBox_symbols_settings.Enabled = false;
            this.richTextBox_symbols_settings.Location = new System.Drawing.Point(6, 112);
            this.richTextBox_symbols_settings.Name = "richTextBox_symbols_settings";
            this.richTextBox_symbols_settings.Size = new System.Drawing.Size(380, 123);
            this.richTextBox_symbols_settings.TabIndex = 7;
            this.richTextBox_symbols_settings.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!$%^*()-_=+<>.,{}[]" +
    ":;~@#\'\"?/|\\";
            // 
            // richTextBox_string
            // 
            this.richTextBox_string.Enabled = false;
            this.richTextBox_string.Location = new System.Drawing.Point(9, 247);
            this.richTextBox_string.Name = "richTextBox_string";
            this.richTextBox_string.Size = new System.Drawing.Size(196, 44);
            this.richTextBox_string.TabIndex = 8;
            this.richTextBox_string.Text = "";
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Location = new System.Drawing.Point(12, 360);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(692, 124);
            this.richTextBox_result.TabIndex = 8;
            this.richTextBox_result.Text = "";
            // 
            // label_passwords_number
            // 
            this.label_passwords_number.AutoSize = true;
            this.label_passwords_number.Location = new System.Drawing.Point(6, 16);
            this.label_passwords_number.Name = "label_passwords_number";
            this.label_passwords_number.Size = new System.Drawing.Size(109, 13);
            this.label_passwords_number.TabIndex = 9;
            this.label_passwords_number.Text = "Passwords number:";
            // 
            // label_single_password_length
            // 
            this.label_single_password_length.AutoSize = true;
            this.label_single_password_length.Location = new System.Drawing.Point(6, 66);
            this.label_single_password_length.Name = "label_single_password_length";
            this.label_single_password_length.Size = new System.Drawing.Size(145, 13);
            this.label_single_password_length.TabIndex = 10;
            this.label_single_password_length.Text = "Single password length:";
            // 
            // checkBox_clear_result_every_generation
            // 
            this.checkBox_clear_result_every_generation.AutoSize = true;
            this.checkBox_clear_result_every_generation.Checked = true;
            this.checkBox_clear_result_every_generation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_clear_result_every_generation.Location = new System.Drawing.Point(9, 302);
            this.checkBox_clear_result_every_generation.Name = "checkBox_clear_result_every_generation";
            this.checkBox_clear_result_every_generation.Size = new System.Drawing.Size(200, 17);
            this.checkBox_clear_result_every_generation.TabIndex = 11;
            this.checkBox_clear_result_every_generation.Text = "Clear result every generation";
            this.checkBox_clear_result_every_generation.UseVisualStyleBackColor = true;
            // 
            // label_delimiter
            // 
            this.label_delimiter.AutoSize = true;
            this.label_delimiter.Location = new System.Drawing.Point(6, 118);
            this.label_delimiter.Name = "label_delimiter";
            this.label_delimiter.Size = new System.Drawing.Size(67, 13);
            this.label_delimiter.TabIndex = 11;
            this.label_delimiter.Text = "Delimiter:";
            // 
            // button_set_own_symbols_to_default
            // 
            this.button_set_own_symbols_to_default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_set_own_symbols_to_default.Enabled = false;
            this.button_set_own_symbols_to_default.Location = new System.Drawing.Point(394, 112);
            this.button_set_own_symbols_to_default.Name = "button_set_own_symbols_to_default";
            this.button_set_own_symbols_to_default.Size = new System.Drawing.Size(75, 123);
            this.button_set_own_symbols_to_default.TabIndex = 8;
            this.button_set_own_symbols_to_default.Text = "Set own symbols to default";
            this.button_set_own_symbols_to_default.UseVisualStyleBackColor = false;
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_generate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate.Location = new System.Drawing.Point(12, 274);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(475, 62);
            this.button_generate.TabIndex = 12;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = false;
            // 
            // button_clear_result
            // 
            this.button_clear_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_clear_result.Location = new System.Drawing.Point(12, 490);
            this.button_clear_result.Name = "button_clear_result";
            this.button_clear_result.Size = new System.Drawing.Size(222, 23);
            this.button_clear_result.TabIndex = 13;
            this.button_clear_result.Text = "Clear result";
            this.button_clear_result.UseVisualStyleBackColor = false;
            // 
            // button_copy_result_to_clipboard
            // 
            this.button_copy_result_to_clipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_copy_result_to_clipboard.Location = new System.Drawing.Point(240, 490);
            this.button_copy_result_to_clipboard.Name = "button_copy_result_to_clipboard";
            this.button_copy_result_to_clipboard.Size = new System.Drawing.Size(222, 23);
            this.button_copy_result_to_clipboard.TabIndex = 14;
            this.button_copy_result_to_clipboard.Text = "Copy result to clipboard";
            this.button_copy_result_to_clipboard.UseVisualStyleBackColor = false;
            // 
            // button_save_result_to_file
            // 
            this.button_save_result_to_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_save_result_to_file.Location = new System.Drawing.Point(482, 490);
            this.button_save_result_to_file.Name = "button_save_result_to_file";
            this.button_save_result_to_file.Size = new System.Drawing.Size(222, 23);
            this.button_save_result_to_file.TabIndex = 15;
            this.button_save_result_to_file.Text = "Save result to file...";
            this.button_save_result_to_file.UseVisualStyleBackColor = false;
            // 
            // numericUpDown_passwords_number
            // 
            this.numericUpDown_passwords_number.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_passwords_number.Location = new System.Drawing.Point(9, 32);
            this.numericUpDown_passwords_number.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_passwords_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_passwords_number.Name = "numericUpDown_passwords_number";
            this.numericUpDown_passwords_number.Size = new System.Drawing.Size(196, 26);
            this.numericUpDown_passwords_number.TabIndex = 12;
            this.numericUpDown_passwords_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_passwords_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_single_password_length
            // 
            this.numericUpDown_single_password_length.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_single_password_length.Location = new System.Drawing.Point(9, 82);
            this.numericUpDown_single_password_length.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_single_password_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_single_password_length.Name = "numericUpDown_single_password_length";
            this.numericUpDown_single_password_length.Size = new System.Drawing.Size(196, 26);
            this.numericUpDown_single_password_length.TabIndex = 13;
            this.numericUpDown_single_password_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_single_password_length.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(12, 341);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(49, 13);
            this.label_result.TabIndex = 16;
            this.label_result.Text = "Result:";
            // 
            // setOwnSymbolsToDefaultToolStripMenuItem
            // 
            this.setOwnSymbolsToDefaultToolStripMenuItem.Name = "setOwnSymbolsToDefaultToolStripMenuItem";
            this.setOwnSymbolsToDefaultToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.setOwnSymbolsToDefaultToolStripMenuItem.Text = "Set own symbols to default";
            // 
            // setAllSettingsToDefaultToolStripMenuItem
            // 
            this.setAllSettingsToDefaultToolStripMenuItem.Name = "setAllSettingsToDefaultToolStripMenuItem";
            this.setAllSettingsToDefaultToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.setAllSettingsToDefaultToolStripMenuItem.Text = "Set all settings to default";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 522);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_save_result_to_file);
            this.Controls.Add(this.button_copy_result_to_clipboard);
            this.Controls.Add(this.button_clear_result);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.groupBox_generation_settings);
            this.Controls.Add(this.groupBox_symbols_settings);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator v.1.0.0 | by John-9198";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_symbols_settings.ResumeLayout(false);
            this.groupBox_symbols_settings.PerformLayout();
            this.groupBox_generation_settings.ResumeLayout(false);
            this.groupBox_generation_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_passwords_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_single_password_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyResultToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_symbols_settings;
        private System.Windows.Forms.GroupBox groupBox_generation_settings;
        private System.Windows.Forms.Button button_set_own_symbols_to_default;
        private System.Windows.Forms.RichTextBox richTextBox_symbols_settings;
        private System.Windows.Forms.CheckBox checkBox_template_5;
        private System.Windows.Forms.CheckBox checkBox_template_4;
        private System.Windows.Forms.CheckBox checkBox_template_3;
        private System.Windows.Forms.CheckBox checkBox_template_2;
        private System.Windows.Forms.CheckBox checkBox_template_1;
        private System.Windows.Forms.RadioButton radioButton_own_symbols;
        private System.Windows.Forms.RadioButton radioButton_templates;
        private System.Windows.Forms.NumericUpDown numericUpDown_single_password_length;
        private System.Windows.Forms.NumericUpDown numericUpDown_passwords_number;
        private System.Windows.Forms.CheckBox checkBox_clear_result_every_generation;
        private System.Windows.Forms.Label label_single_password_length;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.Label label_passwords_number;
        private System.Windows.Forms.RichTextBox richTextBox_string;
        private System.Windows.Forms.RadioButton radioButton_string;
        private System.Windows.Forms.RadioButton radioButton_space;
        private System.Windows.Forms.RadioButton radioButton_two_new_lines;
        private System.Windows.Forms.RadioButton radioButton_new_line;
        private System.Windows.Forms.RadioButton radioButton_none;
        private System.Windows.Forms.RichTextBox richTextBox_result;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_clear_result;
        private System.Windows.Forms.Button button_copy_result_to_clipboard;
        private System.Windows.Forms.Button button_save_result_to_file;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.ToolStripMenuItem setOwnSymbolsToDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAllSettingsToDefaultToolStripMenuItem;
    }
}

