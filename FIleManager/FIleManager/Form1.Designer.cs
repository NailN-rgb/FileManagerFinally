namespace FIleManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileWayTextBox = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.FType = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainTree = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСФайламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileWayTextBox
            // 
            this.fileWayTextBox.Location = new System.Drawing.Point(358, 4);
            this.fileWayTextBox.Name = "fileWayTextBox";
            this.fileWayTextBox.Size = new System.Drawing.Size(681, 20);
            this.fileWayTextBox.TabIndex = 2;
            this.fileWayTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKey_UP);
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(9, 501);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(67, 13);
            this.FName.TabIndex = 4;
            this.FName.Text = "Имя Файла";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(82, 501);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(13, 13);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            this.fileNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FType
            // 
            this.FType.AutoSize = true;
            this.FType.Location = new System.Drawing.Point(894, 501);
            this.FType.Name = "FType";
            this.FType.Size = new System.Drawing.Size(64, 13);
            this.FType.TabIndex = 6;
            this.FType.Text = "Тип Файла";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(964, 501);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(13, 13);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "EXE_29677.png");
            this.icons.Images.SetKeyName(1, "midi-256_32_35908.png");
            this.icons.Images.SetKeyName(2, "office_gallery_image_picture_icon_159182.png");
            this.icons.Images.SetKeyName(3, "text-256_32_35893.png");
            this.icons.Images.SetKeyName(4, "typefolderblank_99336.png");
            this.icons.Images.SetKeyName(5, "vsd-256_32_35890.png");
            this.icons.Images.SetKeyName(6, "1486486316-arrow-film-movie-play-player-start-video_81236.png");
            this.icons.Images.SetKeyName(7, "Sistema_Default_35455.png");
            this.icons.Images.SetKeyName(8, "photo-photography-image-picture_108525.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 429);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 8;
            // 
            // mainTree
            // 
            this.mainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTree.Location = new System.Drawing.Point(0, 0);
            this.mainTree.Name = "mainTree";
            this.mainTree.ShowPlusMinus = false;
            this.mainTree.Size = new System.Drawing.Size(342, 429);
            this.mainTree.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.icons;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 429);
            this.listView1.SmallImageList = this.icons;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.DoubleClickListViewElement);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OpenSelectedElement);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(936, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Смена вида";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.работаСФайламиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.действияToolStripMenuItem.Text = "Действия...";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // работаСФайламиToolStripMenuItem
            // 
            this.работаСФайламиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.переместитьToolStripMenuItem,
            this.свойстваФайлаToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.работаСФайламиToolStripMenuItem.Name = "работаСФайламиToolStripMenuItem";
            this.работаСФайламиToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.работаСФайламиToolStripMenuItem.Text = "Работа с файлами...";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyWorkWithFilesClick);
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            this.переместитьToolStripMenuItem.Click += new System.EventHandler(this.RemoteWorkWithFilesClick);
            // 
            // свойстваФайлаToolStripMenuItem
            // 
            this.свойстваФайлаToolStripMenuItem.Name = "свойстваФайлаToolStripMenuItem";
            this.свойстваФайлаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.свойстваФайлаToolStripMenuItem.Text = "Свойства файла";
            this.свойстваФайлаToolStripMenuItem.Click += new System.EventHandler(this.FileInfoWorkWithFilesClick);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.видToolStripMenuItem.Text = "Вид...";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.FType);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.fileWayTextBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "FileManager 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fileWayTextBox;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label FType;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView mainTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСФайламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

