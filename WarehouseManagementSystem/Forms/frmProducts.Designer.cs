namespace WarehouseManagementSystem
{
    partial class frmProducts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            textBox1 = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dgvProductList = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IRANSans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(897, 117);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(65, 27);
            label2.TabIndex = 2;
            label2.Text = "نام کالا";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("IRANSans", 10F);
            textBox1.Location = new Point(741, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 34);
            textBox1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5 });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(982, 30);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("IRANSans", 9F);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(135, 24);
            toolStripStatusLabel1.Text = "محل قرارگیری ساعت";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(13, 20);
            toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Font = new Font("IRANSans", 9F);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(135, 24);
            toolStripStatusLabel3.Text = "محل قرار گیری تاریخ";
            toolStripStatusLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(13, 20);
            toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Font = new Font("IRANSans", 9F);
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(192, 24);
            toolStripStatusLabel5.Text = "نام کاربر : محمدحسین صادقی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("IRANSans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(833, 201);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(129, 27);
            label3.TabIndex = 5;
            label3.Text = "دسته بندی کالا ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("IRANSans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(741, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 35);
            comboBox1.TabIndex = 6;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 45);
            dgvProductList.Margin = new Padding(3, 4, 3, 4);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RightToLeft = RightToLeft.Yes;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(708, 525);
            dgvProductList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANSans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(632, 14);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(88, 27);
            label1.TabIndex = 7;
            label1.Text = "لیست کالا";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("IRANSans", 10F, FontStyle.Bold);
            button1.Location = new Point(741, 291);
            button1.Name = "button1";
            button1.Size = new Size(221, 38);
            button1.TabIndex = 8;
            button1.Text = "افزودن";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("IRANSans", 10F, FontStyle.Bold);
            button2.Location = new Point(741, 350);
            button2.Name = "button2";
            button2.Size = new Size(221, 38);
            button2.TabIndex = 9;
            button2.Text = "ویرایش";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("IRANSans", 10F, FontStyle.Bold);
            button3.Location = new Point(741, 409);
            button3.Name = "button3";
            button3.Size = new Size(221, 38);
            button3.TabIndex = 10;
            button3.Text = "حذف";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 619);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvProductList);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(statusStrip1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Font = new Font("IRANSans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProducts";
            Text = "Form1";
            Load += frmProducts_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private Label label3;
        private ComboBox comboBox1;
        private DataGridView dgvProductList;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
