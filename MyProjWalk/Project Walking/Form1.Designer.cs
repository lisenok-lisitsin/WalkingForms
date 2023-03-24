namespace Project_Walking
{
    partial class MainVoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainVoid));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxMain = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cacti = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 558);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // picboxMain
            // 
            this.picboxMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxMain.BackColor = System.Drawing.Color.Transparent;
            this.picboxMain.Image = ((System.Drawing.Image)(resources.GetObject("picboxMain.Image")));
            this.picboxMain.Location = new System.Drawing.Point(620, 520);
            this.picboxMain.Name = "picboxMain";
            this.picboxMain.Size = new System.Drawing.Size(32, 32);
            this.picboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxMain.TabIndex = 1;
            this.picboxMain.TabStop = false;
            this.picboxMain.LocationChanged += new System.EventHandler(this.picboxMain_LocationChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mk2sprite.png");
            this.imageList1.Images.SetKeyName(1, "mk2spriteWL2.png");
            this.imageList1.Images.SetKeyName(2, "mk2spriteWL.png");
            this.imageList1.Images.SetKeyName(3, "mk2spriteWR2.png");
            this.imageList1.Images.SetKeyName(4, "mk2spriteWR.png");
            this.imageList1.Images.SetKeyName(5, "mk2spriteWLU2.png");
            this.imageList1.Images.SetKeyName(6, "mk2spriteWLU.png");
            this.imageList1.Images.SetKeyName(7, "mk2spriteWLD2.png");
            this.imageList1.Images.SetKeyName(8, "mk2spriteWLD.png");
            this.imageList1.Images.SetKeyName(9, "mk2spriteUP2.png");
            this.imageList1.Images.SetKeyName(10, "mk2spriteUP.png");
            this.imageList1.Images.SetKeyName(11, "mk2spriteDOWN2.png");
            this.imageList1.Images.SetKeyName(12, "mk2spriteDOWN.png");
            // 
            // cacti
            // 
            this.cacti.BackColor = System.Drawing.Color.Transparent;
            this.cacti.Image = ((System.Drawing.Image)(resources.GetObject("cacti.Image")));
            this.cacti.Location = new System.Drawing.Point(1065, 219);
            this.cacti.Name = "cacti";
            this.cacti.Size = new System.Drawing.Size(32, 32);
            this.cacti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cacti.TabIndex = 2;
            this.cacti.TabStop = false;
            // 
            // MainVoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.picboxMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cacti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainVoid";
            this.Text = "Walking One";
            this.Load += new System.EventHandler(this.MainVoid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainVoid_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainVoid_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainVoid_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picboxMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox cacti;
    }
}

