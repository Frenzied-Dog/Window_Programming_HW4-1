namespace hw4_1_10_13 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Nums = new ImageList(components);
            Btn0 = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            UnlockBtn = new Button();
            Label0 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            SuspendLayout();
            // 
            // Nums
            // 
            Nums.ColorDepth = ColorDepth.Depth32Bit;
            Nums.ImageStream = (ImageListStreamer)resources.GetObject("Nums.ImageStream");
            Nums.TransparentColor = Color.Transparent;
            Nums.Images.SetKeyName(0, "0.jpg");
            Nums.Images.SetKeyName(1, "1.jpg");
            Nums.Images.SetKeyName(2, "2.jpg");
            Nums.Images.SetKeyName(3, "3.jpg");
            Nums.Images.SetKeyName(4, "4.jpg");
            Nums.Images.SetKeyName(5, "5.jpg");
            Nums.Images.SetKeyName(6, "6.jpg");
            Nums.Images.SetKeyName(7, "7.jpg");
            Nums.Images.SetKeyName(8, "8.jpg");
            Nums.Images.SetKeyName(9, "9.jpg");
            // 
            // Btn0
            // 
            Btn0.ImageIndex = 0;
            Btn0.ImageList = Nums;
            Btn0.Location = new Point(70, 130);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(130, 200);
            Btn0.TabIndex = 0;
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // Btn1
            // 
            Btn1.ImageIndex = 0;
            Btn1.ImageList = Nums;
            Btn1.Location = new Point(246, 130);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(130, 200);
            Btn1.TabIndex = 1;
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.ImageIndex = 0;
            Btn2.ImageList = Nums;
            Btn2.Location = new Point(423, 130);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(130, 200);
            Btn2.TabIndex = 2;
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.ImageIndex = 0;
            Btn3.ImageList = Nums;
            Btn3.Location = new Point(600, 130);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(130, 200);
            Btn3.TabIndex = 3;
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // UnlockBtn
            // 
            UnlockBtn.Font = new Font("微軟正黑體", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UnlockBtn.Location = new Point(325, 380);
            UnlockBtn.Name = "UnlockBtn";
            UnlockBtn.Size = new Size(150, 60);
            UnlockBtn.TabIndex = 4;
            UnlockBtn.Text = "解鎖";
            UnlockBtn.UseVisualStyleBackColor = true;
            UnlockBtn.Click += UnlockBtn_Click;
            // 
            // Label0
            // 
            Label0.AutoSize = true;
            Label0.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            Label0.Location = new Point(110, 80);
            Label0.Name = "Label0";
            Label0.Size = new Size(0, 44);
            Label0.TabIndex = 5;
            Label0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(285, 80);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 44);
            Label1.TabIndex = 5;
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(465, 80);
            Label2.Name = "Label2";
            Label2.Size = new Size(0, 44);
            Label2.TabIndex = 5;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.Location = new Point(640, 80);
            Label3.Name = "Label3";
            Label3.Size = new Size(0, 44);
            Label3.TabIndex = 5;
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Label0);
            Controls.Add(UnlockBtn);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(Btn0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList Nums;
        private Button Btn0;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button UnlockBtn;
        private Label Label0;
        private Label Label1;
        private Label Label2;
        private Label Label3;
    }
}