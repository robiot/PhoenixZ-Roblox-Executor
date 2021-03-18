namespace Phoenix
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.executeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.xBtn = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uppPanelDragControl = new ns1.BunifuDragControl(this.components);
            this.mainElipse = new ns1.BunifuElipse(this.components);
            this.executeBtnElipse = new ns1.BunifuElipse(this.components);
            this.clearBtnElipse = new ns1.BunifuElipse(this.components);
            this.openBtnElipse = new ns1.BunifuElipse(this.components);
            this.saveBtnElipse = new ns1.BunifuElipse(this.components);
            this.minusBtn = new System.Windows.Forms.Button();
            this.injectBtn = new System.Windows.Forms.Button();
            this.injectBtnElipse = new ns1.BunifuElipse(this.components);
            this.title = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsBox = new System.Windows.Forms.ListBox();
            this.scriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.scriptBoxElipse = new ns1.BunifuElipse(this.components);
            this.titleDragControl = new ns1.BunifuDragControl(this.components);
            this.iconDragControl = new ns1.BunifuDragControl(this.components);
            this.discordElipse = new ns1.BunifuElipse(this.components);
            this.killRblx = new System.Windows.Forms.Button();
            this.filloutPanel = new System.Windows.Forms.Panel();
            this.filloutPanelElipse = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scriptBox)).BeginInit();
            this.SuspendLayout();
            // 
            // executeBtn
            // 
            this.executeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.executeBtn.FlatAppearance.BorderSize = 0;
            this.executeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.executeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.executeBtn.Location = new System.Drawing.Point(9, 348);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(161, 35);
            this.executeBtn.TabIndex = 1;
            this.executeBtn.TabStop = false;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.clearBtn.Location = new System.Drawing.Point(176, 348);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 35);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.TabStop = false;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.openBtn.Location = new System.Drawing.Point(297, 348);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(115, 35);
            this.openBtn.TabIndex = 3;
            this.openBtn.TabStop = false;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(418, 348);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 35);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.xBtn.FlatAppearance.BorderSize = 0;
            this.xBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.xBtn.Location = new System.Drawing.Point(704, -1);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(35, 35);
            this.xBtn.TabIndex = 5;
            this.xBtn.TabStop = false;
            this.xBtn.Text = "X";
            this.xBtn.UseVisualStyleBackColor = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.upPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.upPanel.Location = new System.Drawing.Point(-5, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(727, 34);
            this.upPanel.TabIndex = 6;
            this.upPanel.WrapContents = false;
            // 
            // uppPanelDragControl
            // 
            this.uppPanelDragControl.Fixed = true;
            this.uppPanelDragControl.Horizontal = true;
            this.uppPanelDragControl.TargetControl = this.upPanel;
            this.uppPanelDragControl.Vertical = true;
            // 
            // mainElipse
            // 
            this.mainElipse.ElipseRadius = 15;
            this.mainElipse.TargetControl = this;
            // 
            // executeBtnElipse
            // 
            this.executeBtnElipse.ElipseRadius = 5;
            this.executeBtnElipse.TargetControl = this.executeBtn;
            // 
            // clearBtnElipse
            // 
            this.clearBtnElipse.ElipseRadius = 5;
            this.clearBtnElipse.TargetControl = this.clearBtn;
            // 
            // openBtnElipse
            // 
            this.openBtnElipse.ElipseRadius = 5;
            this.openBtnElipse.TargetControl = this.openBtn;
            // 
            // saveBtnElipse
            // 
            this.saveBtnElipse.ElipseRadius = 5;
            this.saveBtnElipse.TargetControl = this.saveBtn;
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.minusBtn.Location = new System.Drawing.Point(667, -1);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(35, 35);
            this.minusBtn.TabIndex = 7;
            this.minusBtn.TabStop = false;
            this.minusBtn.Text = "—";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // injectBtn
            // 
            this.injectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.injectBtn.FlatAppearance.BorderSize = 0;
            this.injectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.injectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.injectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.injectBtn.Location = new System.Drawing.Point(539, 348);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(190, 35);
            this.injectBtn.TabIndex = 8;
            this.injectBtn.TabStop = false;
            this.injectBtn.Text = "Attach";
            this.injectBtn.UseVisualStyleBackColor = false;
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // injectBtnElipse
            // 
            this.injectBtnElipse.ElipseRadius = 5;
            this.injectBtnElipse.TargetControl = this.injectBtn;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(285, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(75, 19);
            this.title.TabIndex = 9;
            this.title.Text = "Phoenix Z";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.icon.ContextMenuStrip = this.options;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(19, 6);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(22, 22);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 10;
            this.icon.TabStop = false;
            // 
            // options
            // 
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.refreshScriptsToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(149, 48);
            this.options.Text = "Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "AlwaysOnTop";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // refreshScriptsToolStripMenuItem
            // 
            this.refreshScriptsToolStripMenuItem.Name = "refreshScriptsToolStripMenuItem";
            this.refreshScriptsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.refreshScriptsToolStripMenuItem.Text = "RefreshScripts";
            this.refreshScriptsToolStripMenuItem.Click += new System.EventHandler(this.refreshScriptsToolStripMenuItem_Click);
            // 
            // scriptsBox
            // 
            this.scriptsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.scriptsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptsBox.DisplayMember = "0";
            this.scriptsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptsBox.ForeColor = System.Drawing.SystemColors.Control;
            this.scriptsBox.FormattingEnabled = true;
            this.scriptsBox.ItemHeight = 15;
            this.scriptsBox.Items.AddRange(new object[] {
            "n/a"});
            this.scriptsBox.Location = new System.Drawing.Point(539, 40);
            this.scriptsBox.Name = "scriptsBox";
            this.scriptsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scriptsBox.Size = new System.Drawing.Size(190, 300);
            this.scriptsBox.Sorted = true;
            this.scriptsBox.TabIndex = 11;
            this.scriptsBox.TabStop = false;
            this.scriptsBox.ValueMember = "1";
            this.scriptsBox.SelectedIndexChanged += new System.EventHandler(this.scriptsBox_SelectedIndexChanged);
            // 
            // scriptBox
            // 
            this.scriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.scriptBox.AutoIndent = false;
            this.scriptBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.scriptBox.AutoScrollMinSize = new System.Drawing.Size(219, 36);
            this.scriptBox.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.scriptBox.BackBrush = null;
            this.scriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.scriptBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.scriptBox.CaretColor = System.Drawing.SystemColors.Control;
            this.scriptBox.CharHeight = 18;
            this.scriptBox.CharWidth = 9;
            this.scriptBox.CommentPrefix = "--";
            this.scriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.scriptBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.scriptBox.ForeColor = System.Drawing.SystemColors.Control;
            this.scriptBox.Hotkeys = resources.GetString("scriptBox.Hotkeys");
            this.scriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.scriptBox.IsReplaceMode = false;
            this.scriptBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.scriptBox.LeftBracket = '(';
            this.scriptBox.LeftBracket2 = '{';
            this.scriptBox.LeftPadding = 10;
            this.scriptBox.LineNumberColor = System.Drawing.SystemColors.Control;
            this.scriptBox.Location = new System.Drawing.Point(9, 48);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.scriptBox.RightBracket = ')';
            this.scriptBox.RightBracket2 = '}';
            this.scriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.scriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("scriptBox.ServiceColors")));
            this.scriptBox.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.scriptBox.ShowScrollBars = false;
            this.scriptBox.Size = new System.Drawing.Size(524, 294);
            this.scriptBox.TabIndex = 0;
            this.scriptBox.TabStop = false;
            this.scriptBox.Text = "--Phoenix Executor--\r\n   --by robiot--";
            this.scriptBox.TextAreaBorderColor = System.Drawing.Color.Transparent;
            this.scriptBox.Zoom = 100;
            // 
            // scriptBoxElipse
            // 
            this.scriptBoxElipse.ElipseRadius = 5;
            this.scriptBoxElipse.TargetControl = this.scriptBox;
            // 
            // titleDragControl
            // 
            this.titleDragControl.Fixed = true;
            this.titleDragControl.Horizontal = true;
            this.titleDragControl.TargetControl = this.title;
            this.titleDragControl.Vertical = true;
            // 
            // iconDragControl
            // 
            this.iconDragControl.Fixed = true;
            this.iconDragControl.Horizontal = true;
            this.iconDragControl.TargetControl = this.icon;
            this.iconDragControl.Vertical = true;
            // 
            // discordElipse
            // 
            this.discordElipse.ElipseRadius = 10;
            // 
            // killRblx
            // 
            this.killRblx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.killRblx.FlatAppearance.BorderSize = 0;
            this.killRblx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.killRblx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.killRblx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killRblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killRblx.ForeColor = System.Drawing.SystemColors.Control;
            this.killRblx.Location = new System.Drawing.Point(587, 2);
            this.killRblx.Name = "killRblx";
            this.killRblx.Size = new System.Drawing.Size(74, 31);
            this.killRblx.TabIndex = 13;
            this.killRblx.TabStop = false;
            this.killRblx.Text = "Kill Roblox";
            this.killRblx.UseVisualStyleBackColor = false;
            this.killRblx.Click += new System.EventHandler(this.killRblx_Click);
            // 
            // filloutPanel
            // 
            this.filloutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.filloutPanel.Location = new System.Drawing.Point(9, 40);
            this.filloutPanel.Name = "filloutPanel";
            this.filloutPanel.Size = new System.Drawing.Size(524, 25);
            this.filloutPanel.TabIndex = 16;
            // 
            // filloutPanelElipse
            // 
            this.filloutPanelElipse.ElipseRadius = 5;
            this.filloutPanelElipse.TargetControl = this.filloutPanel;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(740, 390);
            this.Controls.Add(this.killRblx);
            this.Controls.Add(this.scriptBox);
            this.Controls.Add(this.scriptsBox);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.title);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.filloutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Phoneix v1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scriptBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.FlowLayoutPanel upPanel;
        private ns1.BunifuDragControl uppPanelDragControl;
        private ns1.BunifuElipse mainElipse;
        private ns1.BunifuElipse executeBtnElipse;
        private ns1.BunifuElipse clearBtnElipse;
        private ns1.BunifuElipse openBtnElipse;
        private ns1.BunifuElipse saveBtnElipse;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button injectBtn;
        private ns1.BunifuElipse injectBtnElipse;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ListBox scriptsBox;
        private FastColoredTextBoxNS.FastColoredTextBox scriptBox;
        private ns1.BunifuElipse scriptBoxElipse;
        private ns1.BunifuDragControl titleDragControl;
        private ns1.BunifuDragControl iconDragControl;
        private ns1.BunifuElipse discordElipse;
        private System.Windows.Forms.Button killRblx;
        private System.Windows.Forms.ContextMenuStrip options;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshScriptsToolStripMenuItem;
        private System.Windows.Forms.Panel filloutPanel;
        private ns1.BunifuElipse filloutPanelElipse;
    }
}

