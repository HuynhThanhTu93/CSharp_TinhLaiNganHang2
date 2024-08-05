namespace CSharp_TinhLaiNganHang
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtGui = new TextBox();
            button1 = new Button();
            listKQ = new ListBox();
            label6 = new Label();
            numNam = new NumericUpDown();
            cbxLai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numNam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH LÃI NGÂN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 1;
            label2.Text = "Số tiền gửi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(161, 33);
            label3.TabIndex = 1;
            label3.Text = "Lãi xuất (%)";
            // 
            // txtGui
            // 
            txtGui.Location = new Point(167, 53);
            txtGui.Name = "txtGui";
            txtGui.Size = new Size(271, 40);
            txtGui.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(523, 60);
            button1.Name = "button1";
            button1.Size = new Size(142, 39);
            button1.TabIndex = 3;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listKQ
            // 
            listKQ.FormattingEnabled = true;
            listKQ.ItemHeight = 33;
            listKQ.Location = new Point(12, 232);
            listKQ.Name = "listKQ";
            listKQ.Size = new Size(722, 235);
            listKQ.TabIndex = 4;
            listKQ.SelectedIndexChanged += listKQ_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 149);
            label6.Name = "label6";
            label6.Size = new Size(70, 33);
            label6.TabIndex = 1;
            label6.Text = "Năm";
            // 
            // numNam
            // 
            numNam.Location = new Point(167, 147);
            numNam.Name = "numNam";
            numNam.Size = new Size(271, 40);
            numNam.TabIndex = 5;
            numNam.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxLai
            // 
            cbxLai.FormattingEnabled = true;
            cbxLai.Location = new Point(167, 99);
            cbxLai.Name = "cbxLai";
            cbxLai.Size = new Size(271, 41);
            cbxLai.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 485);
            Controls.Add(cbxLai);
            Controls.Add(numNam);
            Controls.Add(listKQ);
            Controls.Add(button1);
            Controls.Add(txtGui);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGui;
        private Button button1;
        private ListBox listKQ;
        private Label label6;
        private NumericUpDown numNam;
        private ComboBox cbxLai;
    }
}
