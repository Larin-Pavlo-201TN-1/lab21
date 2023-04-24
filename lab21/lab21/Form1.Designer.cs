namespace lab21
{
    partial class frmmain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Window = new System.Windows.Forms.ToolStripMenuItem();
            this.Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.img = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.lang = new System.Windows.Forms.ToolStripSplitButton();
            this.UK = new System.Windows.Forms.ToolStripMenuItem();
            this.EN = new System.Windows.Forms.ToolStripMenuItem();
            this.Left = new System.Windows.Forms.ToolStripButton();
            this.Center = new System.Windows.Forms.ToolStripButton();
            this.Right = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Format,
            this.Window,
            this.Help,
            this.img,
            this.Find});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Window;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.SaveAs,
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 26);
            this.File.Text = "&File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.New.Size = new System.Drawing.Size(233, 26);
            this.New.Text = "&New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open.Size = new System.Drawing.Size(233, 26);
            this.Open.Text = "&Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(233, 26);
            this.Save.Text = "&Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAs.Size = new System.Drawing.Size(233, 26);
            this.SaveAs.Text = "Save &As";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Exit.Size = new System.Drawing.Size(233, 26);
            this.Exit.Text = "&Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut,
            this.Copy,
            this.Paste,
            this.Delete,
            this.SelectAll});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(49, 26);
            this.Edit.Text = "Edit";
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut.Size = new System.Drawing.Size(206, 26);
            this.Cut.Text = "&Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy.Size = new System.Drawing.Size(206, 26);
            this.Copy.Text = "&Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Paste.Size = new System.Drawing.Size(206, 26);
            this.Paste.Text = "&Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Delete.Size = new System.Drawing.Size(206, 26);
            this.Delete.Text = "&Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll.Size = new System.Drawing.Size(206, 26);
            this.SelectAll.Text = "&Select All";
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Font,
            this.Color});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(70, 26);
            this.Format.Text = "F&ormat";
            // 
            // Font
            // 
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(137, 26);
            this.Font.Text = "Font...";
            this.Font.Click += new System.EventHandler(this.Font_Click);
            // 
            // Color
            // 
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(137, 26);
            this.Color.Text = "Color...";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Window
            // 
            this.Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cascade,
            this.TileHorizontal,
            this.TileVertical});
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(78, 26);
            this.Window.Text = "&Window";
            // 
            // Cascade
            // 
            this.Cascade.Name = "Cascade";
            this.Cascade.Size = new System.Drawing.Size(190, 26);
            this.Cascade.Text = "Cascade";
            this.Cascade.Click += new System.EventHandler(this.Cascade_Click);
            // 
            // TileHorizontal
            // 
            this.TileHorizontal.Name = "TileHorizontal";
            this.TileHorizontal.Size = new System.Drawing.Size(190, 26);
            this.TileHorizontal.Text = "Tile Horizontal";
            this.TileHorizontal.Click += new System.EventHandler(this.TileHorizontal_Click);
            // 
            // TileVertical
            // 
            this.TileVertical.Name = "TileVertical";
            this.TileVertical.Size = new System.Drawing.Size(190, 26);
            this.TileVertical.Text = "Tile Vertical";
            this.TileVertical.Click += new System.EventHandler(this.TileVertical_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramm});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(30, 26);
            this.Help.Text = "?";
            // 
            // AboutProgramm
            // 
            this.AboutProgramm.Name = "AboutProgramm";
            this.AboutProgramm.Size = new System.Drawing.Size(216, 26);
            this.AboutProgramm.Text = "About Programm...";
            this.AboutProgramm.Click += new System.EventHandler(this.AboutProgramm_Click);
            // 
            // img
            // 
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(49, 26);
            this.img.Text = "img";
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // Find
            // 
            this.Find.Name = "Find";
            this.Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Find.Size = new System.Drawing.Size(51, 26);
            this.Find.Text = "&Find";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "RTF Files|*.rtf";
            this.saveFileDialog.OverwritePrompt = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.tbSave,
            this.tbCut,
            this.tbCopy,
            this.tbPaste,
            this.lang,
            this.Left,
            this.Center,
            this.Right});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Copy.png");
            this.imageList1.Images.SetKeyName(1, "Create New.png");
            this.imageList1.Images.SetKeyName(2, "Cut.png");
            this.imageList1.Images.SetKeyName(3, "Open.png");
            this.imageList1.Images.SetKeyName(4, "Paste.png");
            this.imageList1.Images.SetKeyName(5, "Save.png");
            // 
            // tbNew
            // 
            this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNew.Image = global::lab21.Properties.Resources.Create_New;
            this.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(29, 28);
            this.tbNew.Text = "Create New";
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = global::lab21.Properties.Resources.Open;
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(29, 28);
            this.tbOpen.Text = "Open";
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = global::lab21.Properties.Resources.Save;
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(29, 28);
            this.tbSave.Text = "Save";
            // 
            // tbCut
            // 
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Image = global::lab21.Properties.Resources.Cut;
            this.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new System.Drawing.Size(29, 28);
            this.tbCut.Text = "Cut";
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = global::lab21.Properties.Resources.Copy;
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(29, 28);
            this.tbCopy.Text = "Copy";
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Image = global::lab21.Properties.Resources.Paste;
            this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(29, 28);
            this.tbPaste.Text = "Paste";
            // 
            // lang
            // 
            this.lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UK,
            this.EN});
            this.lang.Image = global::lab21.Properties.Resources.lang;
            this.lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(39, 28);
            this.lang.Text = "Lang";
            // 
            // UK
            // 
            this.UK.Name = "UK";
            this.UK.Size = new System.Drawing.Size(111, 26);
            this.UK.Text = "UK";
            this.UK.Click += new System.EventHandler(this.UK_Click);
            // 
            // EN
            // 
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(111, 26);
            this.EN.Text = "EN";
            this.EN.Click += new System.EventHandler(this.EN_Click_1);
            // 
            // Left
            // 
            this.Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Left.Image = global::lab21.Properties.Resources.left;
            this.Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(29, 28);
            this.Left.Text = "Left";
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Center
            // 
            this.Center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Center.Image = global::lab21.Properties.Resources.center;
            this.Center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(29, 28);
            this.Center.Text = "Center";
            this.Center.Click += new System.EventHandler(this.Center_Click);
            // 
            // Right
            // 
            this.Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Right.Image = global::lab21.Properties.Resources.right;
            this.Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(29, 28);
            this.Right.Text = "Right";
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.Text = "Notepad C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Font;
        private System.Windows.Forms.ToolStripMenuItem Color;
        private System.Windows.Forms.ToolStripMenuItem Window;
        private System.Windows.Forms.ToolStripMenuItem Cascade;
        private System.Windows.Forms.ToolStripMenuItem TileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem TileVertical;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem img;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbNew;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSplitButton lang;
        private System.Windows.Forms.ToolStripMenuItem UK;
        private System.Windows.Forms.ToolStripMenuItem EN;
        private System.Windows.Forms.ToolStripButton Left;
        private System.Windows.Forms.ToolStripButton Center;
        private System.Windows.Forms.ToolStripButton Right;
    }
}

