using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lab21
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
            Save.Enabled = false;
        }
        public string lan = "EN";
        string title = "Untitled ";

        private void New_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            switch (lan)
            {
                case "EN":
                    frm.msg = "Message";
                    frm.ask = "Do you want save changes in ";
                    frm.symbols = "Аmount of symbols  ";
                    frm.Amount.Text = "Аmount of symbols  ";
                    title = "Untitled ";
                    break;
                case "UA":
                    frm.msg = "Повідомлення";
                    frm.ask = "Хочете зберегти зміни в ";
                    frm.symbols = "Кількість символів  ";
                    frm.Amount.Text = "Кількість символів  ";
                    title = "Без назви ";
                    break;
            }
            frm.DocName = title + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private int openDocuments = 0;

        private void Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
                Save.Enabled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            Save.Enabled = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog.FileName;
                frm.Text = frm.DocName;
                frm.IsSaved = true;
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void img_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    blank frm = (blank)this.ActiveMdiChild;
                    Clipboard.SetImage(Image.FromFile(ofd.FileName));
                    frm.richTextBox1.Paste();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            switch (lan)
            {
                case "EN":
                    frm.MatchCase.Text = "Match &Case";
                    frm.MatchWhole.Text = "Match &whole\r\nword";
                    frm.btnCancel.Text = "&Cance";
                    frm.Text = "Find";
                    break;
                case "UA":
                    frm.MatchCase.Text = "Враховуючи\r\n&регістр";
                    frm.MatchWhole.Text = "За &цілим\r\nсловом";
                    frm.btnCancel.Text = "&Відміна";
                    frm.Text = "Пошук";
                    break;
            }
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            About frm = new About();
            switch (lan)
            {
                case "EN":
                    frm.label1.Text = "Notepad C# 2023\r\nAll rights reserved";
                    frm.msg = "Unable to open link that was clicked.";
                    break;
                case "UA":
                    frm.label1.Text = "Notepad C# 2023\r\nУсі права захищено";
                    frm.msg = "Неможливо відкрити посилання, яке було натиснуто.";
                    break;
            }
            frm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals(tbNew))
            {
                New_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbOpen))
            {
                Open_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbSave))
            {
                Save_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbCut))
            {
                Cut_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbCopy))
            {
                Copy_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbPaste))
            {
                Paste_Click(this, new EventArgs());
            }

        }

        private void UK_Click(object sender, EventArgs e)
        {
            lan = "UA";
            File.Text = "&Файл";
            New.Text = "Створити &файл";
            Open.Text = "&Відкрити";
            Save.Text = "&Зберегти";
            SaveAs.Text = "Зберегти &як";
            Exit.Text = "&Вихід";
            Edit.Text = "Редагувати";
            Cut.Text = "&Вирізати";
            Copy.Text = "&Копіювати";
            Paste.Text = "&Вставити";
            Delete.Text = "&Видалити";
            SelectAll.Text = "&Виділити все";
            Format.Text = "Ф&ормат";
            Font.Text = "Шрифт...";
            Color.Text = "Колір...";
            Window.Text = "В&ікно";
            Cascade.Text = "Каскад";
            TileHorizontal.Text = "Горизонт";
            TileVertical.Text = "Вертикаль";
            AboutProgramm.Text = "Про програму...";
            img.Text = "Зображення";
            Find.Text = "Пошук";
            tbNew.Text = "Створити &файл";
            tbOpen.Text = "&Відкрити";
            tbSave.Text = "&Зберегти";
            tbCut.Text = "&Вирізати";
            tbCopy.Text = "&Копіювати";
            tbPaste.Text = "&Вставити";
            lang.Text = "Мова";
            Left.Text = "По лівому краю";
            Center.Text = "По центру";
            Right.Text = "По правому краю";
        }

        private void EN_Click_1(object sender, EventArgs e)
        {
            lan = "EN";
            File.Text = "&File";
            New.Text = "&New";
            Open.Text = "&Open";
            Save.Text = "&Save";
            SaveAs.Text = "Save &As";
            Exit.Text = "&Exit";
            Edit.Text = "Edit";
            Cut.Text = "&Cut";
            Copy.Text = "&Copy";
            Paste.Text = "&Paste";
            Delete.Text = "&Delete";
            SelectAll.Text = "&Select All";
            Format.Text = "F&ormat";
            Font.Text = "Font...";
            Color.Text = "Color...";
            Window.Text = "&Window";
            Cascade.Text = "Cascade";
            TileHorizontal.Text = "Tile Horizontal";
            TileVertical.Text = "Tile Vertical";
            AboutProgramm.Text = "About Programm...";
            img.Text = "img";
            Find.Text = "&Find";
            tbNew.Text = "&New";
            tbOpen.Text = "&Open";
            tbSave.Text = "&Save";
            tbCut.Text = "&Cut";
            tbCopy.Text = "&Copy";
            tbPaste.Text = "& Paste";
            lang.Text = "Lang";
            Left.Text = "Left";
            Center.Text = "Center";
            Right.Text = "Right";
        }

        private void Left_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            frm.Show();
        }

        private void Center_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            frm.Show();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            frm.Show();
        }
    }
}
