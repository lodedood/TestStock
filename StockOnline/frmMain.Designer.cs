namespace StockOnline
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.ButtonCellType buttonCellType2 = new FarPoint.Win.Spread.CellType.ButtonCellType();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Dell");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("ASUS");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("ThinkPad");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Lenovo");
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrow = new DevExpress.XtraEditors.SimpleButton();
            this.btnNoteBook = new DevExpress.XtraEditors.SimpleButton();
            this.timerAlert = new System.Windows.Forms.Timer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChkAlertLine = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreg = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sp1 = new FarPoint.Win.Spread.FpSpread();
            this.sp1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sp2 = new FarPoint.Win.Spread.FpSpread();
            this.sp2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListRoom6 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.ListRoom5 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListRoom4 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.ListRoom3 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListRoom2 = new System.Windows.Forms.ListView();
            this.ListRoom1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListItem = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sp3 = new FarPoint.Win.Spread.FpSpread();
            this.sp3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrintQR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchE = new System.Windows.Forms.TextBox();
            this.txtSearchS = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2_Sheet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp3_Sheet1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(399, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(240, 86);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "รับเข้า";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOut.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnOut.Appearance.Options.UseFont = true;
            this.btnOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.ImageOptions.Image")));
            this.btnOut.Location = new System.Drawing.Point(703, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(240, 86);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "จ่ายออก";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrow.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnBorrow.Appearance.Options.UseFont = true;
            this.btnBorrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.ImageOptions.Image")));
            this.btnBorrow.Location = new System.Drawing.Point(1011, 12);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(240, 86);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "ยืมของ";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnNoteBook
            // 
            this.btnNoteBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNoteBook.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnNoteBook.Appearance.Options.UseFont = true;
            this.btnNoteBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNoteBook.ImageOptions.Image")));
            this.btnNoteBook.Location = new System.Drawing.Point(399, 104);
            this.btnNoteBook.Name = "btnNoteBook";
            this.btnNoteBook.Size = new System.Drawing.Size(852, 86);
            this.btnNoteBook.TabIndex = 6;
            this.btnNoteBook.Text = "NoteBook กลาง";
            this.btnNoteBook.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timerAlert
            // 
            this.timerAlert.Enabled = true;
            this.timerAlert.Interval = 1000;
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.ChkAlertLine);
            this.groupBox4.Location = new System.Drawing.Point(1413, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 58);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // ChkAlertLine
            // 
            this.ChkAlertLine.AutoSize = true;
            this.ChkAlertLine.Checked = true;
            this.ChkAlertLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAlertLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ChkAlertLine.Location = new System.Drawing.Point(15, 19);
            this.ChkAlertLine.Name = "ChkAlertLine";
            this.ChkAlertLine.Size = new System.Drawing.Size(134, 24);
            this.ChkAlertLine.TabIndex = 7;
            this.ChkAlertLine.Text = "แจ้งเตือนใน Line";
            this.ChkAlertLine.UseVisualStyleBackColor = true;
            this.ChkAlertLine.CheckedChanged += new System.EventHandler(this.ChkAlertLine_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnreg);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.btnNoteBook);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 198);
            this.panel1.TabIndex = 9;
            // 
            // btnreg
            // 
            this.btnreg.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Appearance.Options.UseFont = true;
            this.btnreg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreg.ImageOptions.Image")));
            this.btnreg.Location = new System.Drawing.Point(45, 12);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(327, 86);
            this.btnreg.TabIndex = 7;
            this.btnreg.Text = "เพิ่มข้อมูลพนักงาน";
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1584, 663);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1578, 626);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sp1);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1570, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายการ รับเข้า / เบิกจ่าย";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sp1
            // 
            this.sp1.AccessibleDescription = "sp1, Sheet1, Row 0, Column 0, ";
            this.sp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            this.sp1.Location = new System.Drawing.Point(3, 3);
            this.sp1.Name = "sp1";
            this.sp1.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both;
            this.sp1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.sp1_Sheet1});
            this.sp1.Size = new System.Drawing.Size(1564, 576);
            this.sp1.TabIndex = 2;
            this.sp1.VerticalScrollBarWidth = 40;
            // 
            // sp1_Sheet1
            // 
            this.sp1_Sheet1.Reset();
            sp1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.sp1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            sp1_Sheet1.ColumnCount = 9;
            sp1_Sheet1.RowCount = 10;
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "วันที่";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "รหัส";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "ชื่อ";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "รับเข้า";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "จ่ายออก";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "คงเหลือ";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "ผู้รับ";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "ผู้จ่าย";
            this.sp1_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "หมายเหตุ";
            this.sp1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(0).Label = "วันที่";
            this.sp1_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(0).Width = 150F;
            this.sp1_Sheet1.Columns.Get(1).CellType = textCellType4;
            this.sp1_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(1).Label = "รหัส";
            this.sp1_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(1).Width = 150F;
            this.sp1_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.sp1_Sheet1.Columns.Get(2).Label = "ชื่อ";
            this.sp1_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(2).Width = 270F;
            this.sp1_Sheet1.Columns.Get(3).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(160)))));
            this.sp1_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(3).Label = "รับเข้า";
            this.sp1_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(3).Width = 150F;
            this.sp1_Sheet1.Columns.Get(4).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.sp1_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(4).Label = "จ่ายออก";
            this.sp1_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(4).Width = 150F;
            this.sp1_Sheet1.Columns.Get(5).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(194)))));
            this.sp1_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(5).Label = "คงเหลือ";
            this.sp1_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(5).Width = 150F;
            this.sp1_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(6).Label = "ผู้รับ";
            this.sp1_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(6).Width = 100F;
            this.sp1_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(7).Label = "ผู้จ่าย";
            this.sp1_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(7).Width = 100F;
            this.sp1_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(8).Label = "หมายเหตุ";
            this.sp1_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp1_Sheet1.Columns.Get(8).Width = 270F;
            this.sp1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.sp1_Sheet1.Rows.Default.Height = 30F;
            this.sp1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sp2);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1570, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "รายการยืมของ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sp2
            // 
            this.sp2.AccessibleDescription = "sp2, Sheet1, Row 0, Column 0, ";
            this.sp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp2.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            this.sp2.Location = new System.Drawing.Point(3, 3);
            this.sp2.Name = "sp2";
            this.sp2.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both;
            this.sp2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.sp2_Sheet1});
            this.sp2.Size = new System.Drawing.Size(1564, 576);
            this.sp2.TabIndex = 3;
            this.sp2.VerticalScrollBarWidth = 40;
            this.sp2.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.sp2_ButtonClicked);
            // 
            // sp2_Sheet1
            // 
            this.sp2_Sheet1.Reset();
            sp2_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.sp2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            sp2_Sheet1.ColumnCount = 10;
            sp2_Sheet1.RowCount = 10;
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "วันที่";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "รหัส";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "ชื่อ";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "จำนวน";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "ผู้ยืม";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "ผู้จ่าย";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "หมายเหตุ";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "อุปกรณ์เพิ่มเติม";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = " ";
            this.sp2_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "PK";
            this.sp2_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(0).Label = "วันที่";
            this.sp2_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(0).Width = 150F;
            this.sp2_Sheet1.Columns.Get(1).CellType = textCellType5;
            this.sp2_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(1).Label = "รหัส";
            this.sp2_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(1).Width = 150F;
            this.sp2_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.sp2_Sheet1.Columns.Get(2).Label = "ชื่อ";
            this.sp2_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(2).Width = 204F;
            this.sp2_Sheet1.Columns.Get(3).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(160)))));
            this.sp2_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(3).Label = "จำนวน";
            this.sp2_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(3).Width = 150F;
            this.sp2_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(4).Label = "ผู้ยืม";
            this.sp2_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(4).Width = 100F;
            this.sp2_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(5).Label = "ผู้จ่าย";
            this.sp2_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(5).Width = 100F;
            this.sp2_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(6).Label = "หมายเหตุ";
            this.sp2_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(6).Width = 330F;
            this.sp2_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(7).Label = "อุปกรณ์เพิ่มเติม";
            this.sp2_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp2_Sheet1.Columns.Get(7).Width = 300F;
            buttonCellType2.ButtonColor2 = System.Drawing.SystemColors.ButtonFace;
            buttonCellType2.Text = "คืนของ";
            this.sp2_Sheet1.Columns.Get(8).CellType = buttonCellType2;
            this.sp2_Sheet1.Columns.Get(8).Label = " ";
            this.sp2_Sheet1.Columns.Get(8).Width = 78F;
            this.sp2_Sheet1.Columns.Get(9).Label = "PK";
            this.sp2_Sheet1.Columns.Get(9).Visible = false;
            this.sp2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.sp2_Sheet1.Rows.Default.Height = 30F;
            this.sp2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnStatus);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1570, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "อุปกรณ์ส่วนกลาง";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnStatus
            // 
            this.pnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatus.Controls.Add(this.progressBar1);
            this.pnStatus.Location = new System.Drawing.Point(216, 476);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(1009, 47);
            this.pnStatus.TabIndex = 5;
            this.pnStatus.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1009, 47);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListRoom6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ListRoom5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ListRoom4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ListRoom3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ListRoom2);
            this.groupBox3.Controls.Add(this.ListRoom1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(252, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1313, 234);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "สถานที่";
            // 
            // ListRoom6
            // 
            this.ListRoom6.AllowDrop = true;
            this.ListRoom6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRoom6.Location = new System.Drawing.Point(1104, 29);
            this.ListRoom6.Name = "ListRoom6";
            this.ListRoom6.Size = new System.Drawing.Size(196, 151);
            this.ListRoom6.TabIndex = 16;
            this.ListRoom6.UseCompatibleStateImageBehavior = false;
            this.ListRoom6.View = System.Windows.Forms.View.List;
            this.ListRoom6.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListRoom6_ItemDrag);
            this.ListRoom6.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRoom6_DragDrop);
            this.ListRoom6.DragOver += new System.Windows.Forms.DragEventHandler(this.ListRoom6_DragOver);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1125, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "ห้องประชุมบุคคล";
            // 
            // ListRoom5
            // 
            this.ListRoom5.AllowDrop = true;
            this.ListRoom5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRoom5.Location = new System.Drawing.Point(884, 29);
            this.ListRoom5.Name = "ListRoom5";
            this.ListRoom5.Size = new System.Drawing.Size(196, 151);
            this.ListRoom5.TabIndex = 14;
            this.ListRoom5.UseCompatibleStateImageBehavior = false;
            this.ListRoom5.View = System.Windows.Forms.View.List;
            this.ListRoom5.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListRoom5_ItemDrag);
            this.ListRoom5.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRoom5_DragDrop);
            this.ListRoom5.DragOver += new System.Windows.Forms.DragEventHandler(this.ListRoom5_DragOver);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "ห้องประชุมฝ่ายไร่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "ห้องประชุมผู้บริหาร";
            // 
            // ListRoom4
            // 
            this.ListRoom4.AllowDrop = true;
            this.ListRoom4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRoom4.Location = new System.Drawing.Point(665, 29);
            this.ListRoom4.Name = "ListRoom4";
            this.ListRoom4.Size = new System.Drawing.Size(196, 151);
            this.ListRoom4.TabIndex = 10;
            this.ListRoom4.UseCompatibleStateImageBehavior = false;
            this.ListRoom4.View = System.Windows.Forms.View.List;
            this.ListRoom4.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListRoom4_ItemDrag);
            this.ListRoom4.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRoom4_DragDrop);
            this.ListRoom4.DragOver += new System.Windows.Forms.DragEventHandler(this.ListRoom5_DragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "ห้องรับแขก (บนออฟฟิต)";
            // 
            // ListRoom3
            // 
            this.ListRoom3.AllowDrop = true;
            this.ListRoom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRoom3.Location = new System.Drawing.Point(448, 29);
            this.ListRoom3.Name = "ListRoom3";
            this.ListRoom3.Size = new System.Drawing.Size(196, 151);
            this.ListRoom3.TabIndex = 8;
            this.ListRoom3.UseCompatibleStateImageBehavior = false;
            this.ListRoom3.View = System.Windows.Forms.View.List;
            this.ListRoom3.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListRoom3_ItemDrag);
            this.ListRoom3.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRoom3_DragDrop);
            this.ListRoom3.DragOver += new System.Windows.Forms.DragEventHandler(this.ListRoom3_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "ห้องประชุมวิศวะ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ห้องประชุมใหญ่";
            // 
            // ListRoom2
            // 
            this.ListRoom2.AllowDrop = true;
            this.ListRoom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRoom2.Location = new System.Drawing.Point(232, 29);
            this.ListRoom2.Name = "ListRoom2";
            this.ListRoom2.Size = new System.Drawing.Size(196, 151);
            this.ListRoom2.TabIndex = 6;
            this.ListRoom2.UseCompatibleStateImageBehavior = false;
            this.ListRoom2.View = System.Windows.Forms.View.List;
            this.ListRoom2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListRoom2_ItemDrag);
            this.ListRoom2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRoom2_DragDrop);
            this.ListRoom2.DragOver += new System.Windows.Forms.DragEventHandler(this.ListRoom2_DragOver);
            // 
            // ListRoom1
            // 
            this.ListRoom1.AllowDrop = true;
            this.ListRoom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRoom1.Location = new System.Drawing.Point(18, 29);
            this.ListRoom1.Name = "ListRoom1";
            this.ListRoom1.Size = new System.Drawing.Size(196, 151);
            this.ListRoom1.TabIndex = 1;
            this.ListRoom1.UseCompatibleStateImageBehavior = false;
            this.ListRoom1.View = System.Windows.Forms.View.List;
            this.ListRoom1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListRoom1_ItemDrag);
            this.ListRoom1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListRoom1_DragDrop);
            this.ListRoom1.DragOver += new System.Windows.Forms.DragEventHandler(this.ListRoom1_DragOver);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListItem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "อุปกรณ์";
            // 
            // ListItem
            // 
            this.ListItem.AllowDrop = true;
            this.ListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.ListItem.Location = new System.Drawing.Point(17, 29);
            this.ListItem.Name = "ListItem";
            this.ListItem.Size = new System.Drawing.Size(195, 188);
            this.ListItem.TabIndex = 0;
            this.ListItem.UseCompatibleStateImageBehavior = false;
            this.ListItem.View = System.Windows.Forms.View.SmallIcon;
            this.ListItem.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lv_ItemDrag);
            this.ListItem.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListItem_DragDrop);
            this.ListItem.DragOver += new System.Windows.Forms.DragEventHandler(this.ListItem_DragOver);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.sp3);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1570, 582);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ทรัพย์สิน";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // sp3
            // 
            this.sp3.AccessibleDescription = "sp3, Sheet1, Row 0, Column 0, ";
            this.sp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp3.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            this.sp3.Location = new System.Drawing.Point(3, 94);
            this.sp3.Name = "sp3";
            this.sp3.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both;
            this.sp3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.sp3_Sheet1});
            this.sp3.Size = new System.Drawing.Size(1564, 485);
            this.sp3.TabIndex = 5;
            this.sp3.VerticalScrollBarWidth = 40;
            // 
            // sp3_Sheet1
            // 
            this.sp3_Sheet1.Reset();
            sp3_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.sp3_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            sp3_Sheet1.ColumnCount = 4;
            sp3_Sheet1.RowCount = 10;
            this.sp3_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "รหัสทรัพย์สิน";
            this.sp3_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "รหัสหน่วยงาน";
            this.sp3_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "วันที่รับ";
            this.sp3_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ชื่อ";
            this.sp3_Sheet1.ColumnHeader.Rows.Get(0).Height = 37F;
            this.sp3_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(0).Label = "รหัสทรัพย์สิน";
            this.sp3_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(0).Width = 150F;
            this.sp3_Sheet1.Columns.Get(1).CellType = textCellType6;
            this.sp3_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(1).Label = "รหัสหน่วยงาน";
            this.sp3_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(1).Width = 150F;
            this.sp3_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(2).Label = "วันที่รับ";
            this.sp3_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(2).Width = 147F;
            this.sp3_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(3).Label = "ชื่อ";
            this.sp3_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sp3_Sheet1.Columns.Get(3).Width = 697F;
            this.sp3_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.sp3_Sheet1.Rows.Default.Height = 30F;
            this.sp3_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.btnPrintQR);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtSearchE);
            this.groupBox5.Controls.Add(this.txtSearchS);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1564, 91);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(897, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrintQR
            // 
            this.btnPrintQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintQR.Location = new System.Drawing.Point(1356, 22);
            this.btnPrintQR.Name = "btnPrintQR";
            this.btnPrintQR.Size = new System.Drawing.Size(202, 63);
            this.btnPrintQR.TabIndex = 5;
            this.btnPrintQR.Text = "พิมพ์ QR";
            this.btnPrintQR.UseVisualStyleBackColor = true;
            this.btnPrintQR.Click += new System.EventHandler(this.btnPrintQR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "รหัส";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(785, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "ถึง";
            // 
            // txtSearchE
            // 
            this.txtSearchE.Location = new System.Drawing.Point(465, 36);
            this.txtSearchE.Name = "txtSearchE";
            this.txtSearchE.Size = new System.Drawing.Size(312, 38);
            this.txtSearchE.TabIndex = 1;
            this.txtSearchE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchS
            // 
            this.txtSearchS.Location = new System.Drawing.Point(101, 36);
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.Size = new System.Drawing.Size(312, 38);
            this.txtSearchS.TabIndex = 0;
            this.txtSearchS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(121, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(191, 68);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "ปุ่ม Test";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockOnline";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2_Sheet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp3_Sheet1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton btnBorrow;
        private DevExpress.XtraEditors.SimpleButton btnNoteBook;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FarPoint.Win.Spread.FpSpread sp1;
        private FarPoint.Win.Spread.SheetView sp1_Sheet1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread sp2;
        private FarPoint.Win.Spread.SheetView sp2_Sheet1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView ListRoom5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListRoom4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListRoom3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListRoom2;
        private System.Windows.Forms.ListView ListRoom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchE;
        private System.Windows.Forms.TextBox txtSearchS;
        private FarPoint.Win.Spread.FpSpread sp3;
        private FarPoint.Win.Spread.SheetView sp3_Sheet1;
        private System.Windows.Forms.Button btnPrintQR;
        private System.Windows.Forms.CheckBox ChkAlertLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView ListRoom6;
        private DevExpress.XtraEditors.SimpleButton btnreg;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

